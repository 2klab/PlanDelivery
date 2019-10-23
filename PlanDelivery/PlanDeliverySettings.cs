using System;
using System.Data;
using System.Globalization;

namespace PlanDelivery
{
    public class PlanDeliveryByPickupSettings
    {
        public string HoursString = " ";
        //public static DateTime Truncate(this DateTime dateTime, TimeSpan timeSpan)
        public DateTime Truncate(DateTime dateTime, TimeSpan timeSpan)
        {
            if (timeSpan == TimeSpan.Zero) return dateTime;
            if (dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue) return dateTime;
            return dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));
        }

        public DateTime MinDate
        {
            get
            {
                DateTime current = DateTime.Now;
                DateTime start = current;
                start = Truncate(start, TimeSpan.FromHours(1));
                if (current.Hour >= SameDayDeliveryIfTimeBefore.Hours)
                {
                    start = start.AddDays(1);
                }
                if (current.Hour >= NextDayDeliveryIfTimeBefore.Hours)
                    start = start.AddDays(1);
                return start;
            }
        }
        public DateTime MaxDate
        {
            get
            {
                DateTime end = MinDate.AddDays(DateRange);
                return end;
            }
        }
        /// <summary>
        /// The pickup point identifier
        /// </summary>
        int PickupId;
        /// <summary>
        ///  Slot Duration, Order Lead Time in Days, 
        ///  Hour Duration and Slot Capacity.
        public int DateRange { get; set; } = 14;
        public TimeSpan SameDayDeliveryIfTimeBefore { get; set; } = TimeSpan.FromHours(12);
        public TimeSpan NextDayDeliveryIfTimeBefore { get; set; } = TimeSpan.FromHours(20);

        /// <summary>
        /// Monday or Sunday
        /// </summary>
        public int WeekStartsOn { get; set; } = 1;//1=Monday

        /// <summary>
        /// Default pickup fee
        /// </summary>
        public Double DefaultFee { get; set; } = 1.5;

        /// <summary>
        /// At what time the day starts
        /// </summary>
        public TimeSpan DeliveryStartsAt { get; set; } = TimeSpan.FromHours(9);

        /// <summary>
        /// At what time the day stops
        /// </summary>
        public TimeSpan DeliveryStopsAt { get; set; } = TimeSpan.FromHours(13);

        /// <summary>
        /// Not used
        /// </summary>
        public int[,] WeeklyTimeSlots = new int[24, 7];//rows,cols

        /// <summary>
        /// How many delivery for this timeslot
        /// </summary>
        public int DefaultTimeSlotCapacity { get; set; } = 3;

        /// <summary>
        /// Duration of the time slot
        /// </summary>
        public int TimeSlotDuration { get; set; } = 2;

        //bof. vaut mieux une DataTable
        //idpickup, id, hour, day
        static string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        /// <summary>
        /// Days of the week where the pickup point is opened
        /// </summary>
        public string[] DeliveryDays { get; set; } = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        public DataTable GetSlotsTableStruc()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PickupId", typeof(int));
            table.Columns.Add("Hour", typeof(TimeSpan));
            //table.Columns.Add("Description?", typeof(TimeSpan));
            table.Columns.Add("Mon", typeof(int));
            table.Columns.Add("Tue", typeof(int));
            table.Columns.Add("Wed", typeof(int));
            table.Columns.Add("Thu", typeof(int));
            table.Columns.Add("Fri", typeof(int));
            table.Columns.Add("Sat", typeof(int));
            table.Columns.Add("Sun", typeof(int));
            //table.DataSet.Relations.Add...
            return table;
        }

        public void InitSlotTable(DataTable SlotsTable)//,pickupId
        {
            //From PickupId
            DataRow row;
            for (int h = DeliveryStartsAt.Hours; h < DeliveryStopsAt.Hours; h += TimeSlotDuration)
            {
                row = SlotsTable.NewRow();
                row["PickupId"] = PickupId;
                row["Hour"] = TimeSpan.FromHours(h);
                if (h >= DeliveryStartsAt.Hours && h <= DeliveryStopsAt.Hours)
                {
                    foreach (string d in DeliveryDays)
                    {
                        row[d] = DefaultTimeSlotCapacity;
                    }
                }
                SlotsTable.Rows.Add(row);
            }
        }
        /// <summary>
        /// New weekly timeslots with copy
        /// </summary>
        /// <param name="PickupId"></param>
        public void GenerateDefaultTimeSlots(int PickupId, int PickupIdCopyFrom = -1)
        {
        }

    }

    public class PlanDeliveryVacation
    {
 
    }

    public class PlanDelivery
    {
        PlanDeliveryByPickupSettings settings = new PlanDeliveryByPickupSettings();

        public DataTable VacationTable;

        public DataTable BookingTable;
        public void MakeBookingTable()
        {
            DateTime start = settings.MinDate;
            BookingTable = new DataTable("BookingTable");

            string colName = settings.HoursString;
            BookingTable.Columns.Add(colName, typeof(string));
            for (int i = 0; i < settings.DateRange + 1; i++)
            {
                DateTime date1 = start.AddDays(i);

                colName = date1.ToShortDateString();
                //dt.Columns.Add(colName, typeof(float));
                BookingTable.Columns.Add(colName, typeof(string));
            }
            //Must take in account Summer lightning
            for (int h = settings.DeliveryStartsAt.Hours; h < settings.DeliveryStopsAt.Hours; h += settings.TimeSlotDuration)
            {
                DataRow row = BookingTable.NewRow();
                string s = String.Format("{0:00}H00 - {1:00}H00", h, h + settings.TimeSlotDuration);
                row[settings.HoursString] = s;
                for (int i = 1; i < BookingTable.Columns.Count; i++)
                {
                    row[i] = settings.DefaultFee+"€";
                    //if ... row[i] = "-"
                    //TimeSlots[i]--;
                }
                //check time slot is not full
                //check vacation

                //row[1]
                BookingTable.Rows.Add(row);
            }

        }

        /// <summary>
        /// Table should be transposed: rows become columns
        /// so that it is wide oriented
        /// </summary>
        /// <param name="year"></param>
        public void BuildVacationTable(int year)
        {
            VacationTable = new DataTable();
            VacationTable.Columns.Add("Id", typeof(int));
            VacationTable.Columns.Add("PickupId", typeof(int));
            //table.Columns.Add("Year", typeof(int));
            //table.Columns.Add("Month", typeof(int));
            VacationTable.Columns.Add("WeekNo", typeof(int));
            foreach (string sMonth in new string[]
            { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" })
                VacationTable.Columns.Add(sMonth, typeof(int));

            //table.Columns.Add("Date", typeof(DateTime));
            //table.Columns.Add("IsHoliday", typeof(bool));
            DateTime t = DateTime.Now;

            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            myCal.GetWeekOfYear(t, myCWR, myFirstDOW);
        }

        public void BuildVacationTableV1()
        {
            DataColumn col;
            VacationTable = new DataTable();
            VacationTable.Columns.Add("PickupId", typeof(int));
            col = VacationTable.Columns.Add("Id", typeof(int));
            col.AutoIncrement = true;
            VacationTable.Columns.Add("Date", typeof(DateTime));
            VacationTable.Columns.Add("Type", typeof(int));
        }

        private void BuildVacationTableV2()
        {
            VacationTable = new DataTable();
            VacationTable.Columns.Add("PickupId", typeof(int));
            VacationTable.Columns.Add("Day", typeof(TimeSpan));//0-366
            //table.Columns.Add("Description?", typeof(TimeSpan));
            VacationTable.Columns.Add("IsVacation", typeof(int));

            VacationTable = new DataTable();
            VacationTable.Columns.Add("Id", typeof(int));
            VacationTable.Columns.Add("Date", typeof(DateTime));
            VacationTable.Columns.Add("Description", typeof(string));
            DataRow rowc = VacationTable.NewRow();
            rowc["id"] = 1;
            rowc["Date"] = new DateTime(2019, 11, 11);
            rowc["Description"] = "Holiday";

        }

        public void SeedVacationTable(int year)
        {
            if (VacationTable == null)
                BuildVacationTable(DateTime.Now.Year);
            for (int d = 1; d < 31; d++)
            {
                DateTime date = new DateTime(year, 08, d);
                DataRow row = VacationTable.NewRow();
                row["Date"] = date;
                VacationTable.Rows.Add(row);
            }
            //Add French Public holidays

        }

    }
}