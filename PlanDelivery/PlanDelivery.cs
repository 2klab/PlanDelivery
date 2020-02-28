using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PlanDelivery
{
    //TableName=StorePickupPointSettings
    /**
     * Should be a table entry
     */
    public class PlanDeliveryByPickupSettings
    {
        public string BookingTableName { get; } = "Booking";
        public string TimeSlotTableName { get; } = "TimeSlot";
        public string VacationTableName { get; } = "Vacation";
        public string PickupIdName { get; } = "PickupId";
        public string IdName { get; } = "Id";
        public string HoursString { get; set; } = " ";
        //public static DateTime Truncate(this DateTime dateTime, TimeSpan timeSpan)
        static public DateTime Truncate(DateTime dateTime, TimeSpan timeSpan)
        {
            if (timeSpan == TimeSpan.Zero) return dateTime;
            if (dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue) return dateTime;
            return dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));
        }

        //public int CurrentDayOpenMorningAfternoon(int dayNo) { return DeliveryDayOpen[dayNo]; }


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
        [Category("Dates")]
        [Description("How many days booking can be done")]
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
        public List<Decimal> DefaultFees = new List<Decimal>(new Decimal[] { 3, 5, 7 });

        /// <summary>
        /// Fee depends on remaining slots
        /// </summary>
        public Boolean FeeDependsOnRemainingSlots { get; set; } = false;

        /// <summary>
        /// At what time the day starts
        /// </summary>
        public TimeSpan DeliveryStartsAt { get; set; } = TimeSpan.FromHours(9);

        /// <summary>
        /// At what time the day stops
        /// </summary>
        public TimeSpan DeliveryStopsAt { get; set; } = TimeSpan.FromHours(17);
        public TimeSpan MorningStartsAt { get; set; } = TimeSpan.FromHours(8.5);
        public TimeSpan MorningStopsAt { get; set; } = TimeSpan.FromHours(12.5);
        public TimeSpan AfternoonStartsAt { get; set; } = TimeSpan.FromHours(13);
        public TimeSpan AfternoonStopsAt { get; set; } = TimeSpan.FromHours(17);

        /// <summary>
        /// Not used
        /// </summary>
        //public int[,] WeeklyTimeSlots = new int[24, 7];//rows,cols

        /// <summary>
        /// How many delivery for this timeslot
        /// </summary>
        public int DefaultTimeSlotCapacity { get; set; } = 2;

        /// <summary>
        /// Duration of the time slot
        /// </summary>
        public int TimeSlotDurationInHours { get; set; } = 2;

        /// <summary>
        /// How long a timeslot can be booked
        /// </summary>
        public int TimeSlotBookingHourValidity { get; set; } = 2;

        /// <summary>
        /// Increment of the time slot
        /// </summary>
        public int TimeSlotIncrement { get; set; } = 1;

        //bof. vaut mieux une DataTable
        //idpickup, id, hour, day
        public static string[] DaysOfWeek = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        /// <summary>
        /// Days of the week where the pickup point is opened
        /// must be a table linked to the market
        /// </summary>
        //public string[] DeliveryDays { get; set; } = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public string[] DeliveryDayOpen { get; set; } = new string[] { "-", "-", "AmPm", "-", "-", "AmPm", "AmPm" };

        /// <summary>
        /// Delivery is possible if flying distance between customer and extended pickup is less than
        /// </summary>
        public float FlyDistMax { get; set; } = 500;
        //public DitanceBtwTwoAdressesSettingsID;
        //Non car adresse1=customer, adresse2=pickup location address
        //Il faut des fixed adresses pour les 2
    }

    public class PlanDelivery
    {
        public PlanDeliveryByPickupSettings Settings { get; set; }
            = new PlanDeliveryByPickupSettings();

        public DataSet NopDataSet = new DataSet("NopCommerce");
        public DataTable BookingTable { get; set; }
        public DataTable TimeSlotTable { get; set; }
        /// <summary>
        /// Full year vacation table
        /// </summary>
        public DataTable VacationTable { get { return NopDataSet.Tables[Settings.VacationTableName]; } }
        /// <summary>
        /// TODO: Delay between booking and delivery is too short
        /// 
        /// </summary>
        public void MakeBookingTable()
        {
            DateTime start = Settings.MinDate;
            if (NopDataSet.Tables.Contains(Settings.BookingTableName))
                NopDataSet.Tables.Remove(Settings.BookingTableName);
            BookingTable = NopDataSet.Tables.Add(Settings.BookingTableName);
            BookingTable.Columns.Add(Settings.PickupIdName, typeof(int));
            string colName = Settings.HoursString;
            BookingTable.Columns.Add(colName, typeof(string));

            for (int i = 0; i < Settings.DateRange + 1; i++)
            {
                DateTime date1 = start.AddDays(i);

                colName = date1.ToString("dddd") + Environment.NewLine + date1.ToShortDateString();
                //dt.Columns.Add(colName, typeof(float));
                BookingTable.Columns.Add(colName, typeof(string));
            }
            //Must take in account Summer lightning
            for (int h = Settings.DeliveryStartsAt.Hours; h < Settings.DeliveryStopsAt.Hours; h += Settings.TimeSlotIncrement)
            {
                DataRow row = BookingTable.NewRow();
                //string s = String.Format("{0:00}H00 - {1:00}H00", h, h + Settings.TimeSlotDuration);
                DateTime dto1 = new DateTime(2020, 2, 1, h, 0, 0);
                DateTime dto2 = new DateTime(2020, 2, 1, h + Settings.TimeSlotDurationInHours, 0, 0);
                string s = String.Format("{0:HH:mm} - {1:HH:mm}", dto1, dto2);
                row[Settings.HoursString] = s;
                for (int i = 1; i < BookingTable.Columns.Count; i++)
                {
                    int dow = (int)Settings.MinDate.DayOfWeek;
                    int dayNo = (i - 1 + dow) % 7;
                    string text;
                    //Tenir compte des vacations ici
                    //check vacation table
                    //Simple one, by week, simple click to assign a day off
                    if (Settings.DeliveryDayOpen[dayNo] == "-")
                        text = "-";
                    else
                        //this must be dependent on the number of slots available eg: 7-5-3 euros
                        //text = Settings.DefaultFees[0].ToString();// + "€";
                        row[i] = Settings.DefaultFees[0];
                }
                //check time slot is not full
                //check vacation

                //row[1]
                BookingTable.Rows.Add(row);
            }

        }

        /// <summary>
        /// One row per month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="dayStartsOn"></param>
        public void MakeFullYearVacationTableForAPickup(int pickupId, int year)
        {
            if (NopDataSet.Tables.Contains(Settings.VacationTableName))
                NopDataSet.Tables.Remove(Settings.VacationTableName);
            NopDataSet.Tables.Add(Settings.VacationTableName);
            DataColumn col;
            col = VacationTable.Columns.Add(Settings.PickupIdName, typeof(int));
            col.AllowDBNull = false;
            col = VacationTable.Columns.Add("Month", typeof(int));
            col.AllowDBNull = false;
            col = VacationTable.Columns.Add("Year", typeof(int));
            col.AllowDBNull = false;

            //0.Find the first day of the year
            int startDay = int.MaxValue;
            for (int month = 1; month <= 12; month++)
            {
                DateTime dateValue = new DateTime(year, month, 1);
                int weekDay = (int)dateValue.DayOfWeek;
                if (weekDay < startDay)
                    startDay = weekDay;
            }

            //1.Builds the columns
            for (int month = 1; month <= 12; month++)
            {
                for (int day = startDay; day < 37; day++)
                {
                    int weekDay = day % 7;
                    int week = (day - startDay) / 7;
                    string colname = PlanDeliveryByPickupSettings.DaysOfWeek[weekDay].Substring(0, 3) + week.ToString();
                    if (VacationTable.Columns.IndexOf(colname) == -1)
                    {
                        VacationTable.Columns.Add(colname, typeof(string));
                    }
                }
            }

            //2.Builds all the rows with working values
            for (int month = 1; month <= 12; month++)
            {
                DataRow row = VacationTable.NewRow();
                row[Settings.PickupIdName] = pickupId;
                row["Year"] = year;
                row["Month"] = month;
                DateTime dateStart = new DateTime(year, month, 1);
                for (int day = 1; day <= DateTime.DaysInMonth(year, month); day++)
                {
                    DateTime dateValue = new DateTime(year, month, day);
                    int weekDay = (int)dateValue.DayOfWeek;
                    int week = ((int)dateStart.DayOfWeek + day - 1 - startDay) / 7;
                    string colname = PlanDeliveryByPickupSettings.DaysOfWeek[weekDay].Substring(0, 3) + week.ToString();
                    string value;
                    value = day.ToString();
                    if (Settings.DeliveryDayOpen[weekDay] == "-")
                        value = String.Format("{0}", value, "");
                    else if (Settings.DeliveryDayOpen[weekDay] == "AmPm")
                        value = String.Format("{0}:{1}", value, "AmPm");
                    else if (Settings.DeliveryDayOpen[weekDay] == "Am")
                        value = String.Format("{0}:{1}", value, "Am");
                    else if (Settings.DeliveryDayOpen[weekDay] == "Pm")
                        value = String.Format("{0}:{1}", value, "Pm");
                    row[colname] = value;
                }
                VacationTable.Rows.Add(row);
            }
        }

        /*
            DateTime t = DateTime.Now;
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            myCal.GetWeekOfYear(t, myCWR, myFirstDOW);
*/

        public void SeedVacationTable(int pickupId, int year)
        {

        }

        public void MakeTimeSlotTableStrucForDisplay()
        {
            DataTable table = new DataTable();
            table.Columns.Add(Settings.PickupIdName, typeof(int));
            table.Columns.Add("Hour", typeof(TimeSpan));
            //table.Columns.Add("Description?", typeof(TimeSpan));
            //add 0,1,2,3,4,5,6 + start from date
            table.Columns.Add("Mon", typeof(int));
            table.Columns.Add("Tue", typeof(int));
            table.Columns.Add("Wed", typeof(int));
            table.Columns.Add("Thu", typeof(int));
            table.Columns.Add("Fri", typeof(int));
            table.Columns.Add("Sat", typeof(int));
            table.Columns.Add("Sun", typeof(int));
            //table.DataSet.Relations.Add...
        }

        public void InitSlotTable(int PickupId)
        {
            DataRow row;
            for (int h = Settings.DeliveryStartsAt.Hours; h < Settings.DeliveryStopsAt.Hours; h += Settings.TimeSlotDurationInHours)
            {
                row = TimeSlotTable.NewRow();
                row[Settings.PickupIdName] = PickupId;
                row["Hour"] = TimeSpan.FromHours(h);
                if (h >= Settings.DeliveryStartsAt.Hours && h <= Settings.DeliveryStopsAt.Hours)
                {/*
                    foreach (string d in Settings.DeliveryDays)
                    {
                        row[d] = Settings.DefaultTimeSlotCapacity;
                    }
                    */
                    //starting day
                    for (int day = 0; day < 7; day++)
                    {
                        int rd = (Settings.WeekStartsOn + day) % 7;
                        String s = rd.ToString("W");
                        row[s] = Settings.DefaultTimeSlotCapacity;
                    }
                }
                TimeSlotTable.Rows.Add(row);
            }
        }
        /// <summary>
        /// New weekly timeslots with copy
        /// To be done in V2
        /// </summary>
        /// <param name="PickupId"></param>
        public void MakeDefaultTimeSlots(int PickupId, int PickupIdCopyFrom = -1)
        {

        }

        public DataTable GetAllWFFromDB(bool thisTimeInExcel)
        {
            string req = @"
            select s.ici
            from nopfff s
            where 1=1
            and s.DELETE=0
            "
             + "\n order by 1";
            //DataTable dt1 = DBCmd.GetTable(req);
            DataTable dt1 = new DataTable();
            return dt1;
        }

    }
}