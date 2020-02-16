﻿using System;
using System.Data;
using System.Globalization;

namespace PlanDelivery
{
    //TableName=StorePickupPointSettings
    public class PlanDeliveryByPickupSettings
    {
        public string HoursString = " ";
        //public static DateTime Truncate(this DateTime dateTime, TimeSpan timeSpan)
        static public DateTime Truncate(DateTime dateTime, TimeSpan timeSpan)
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
        //public int[,] WeeklyTimeSlots = new int[24, 7];//rows,cols

        /// <summary>
        /// How many delivery for this timeslot
        /// </summary>
        public int DefaultTimeSlotCapacity { get; set; } = 3;

        /// <summary>
        /// Duration of the time slot
        /// </summary>
        public int TimeSlotDuration { get; set; } = 2;

        /// <summary>
        /// Increment of the time slot
        /// </summary>
        public int TimeSlotIncrement { get; set; } = 1;

        //bof. vaut mieux une DataTable
        //idpickup, id, hour, day
        static string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        /// <summary>
        /// Days of the week where the pickup point is opened
        /// </summary>
        //public string[] DeliveryDays { get; set; } = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public int[] DeliveryDayOpen { get; set; } = new int[] { 1, 0, 1, 0, 1, 1, 1 };

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

        public DataTable VacationTable { get; set; }
        public DataTable BookingTable { get; set; }
        public DataTable TimeSlotTable { get; set; }
        public void MakeBookingTable()
        {
            DateTime start = Settings.MinDate;
            BookingTable = new DataTable("BookingTable");

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
                string s = String.Format("{0:00}H00 - {1:00}H00", h, h + Settings.TimeSlotDuration);
                row[Settings.HoursString] = s;
                for (int i = 1; i < BookingTable.Columns.Count; i++)
                {
                    int dow = (int)Settings.MinDate.DayOfWeek;
                    int dayNo = (i - 1 + dow) % 7;
                    string text;
                    //Tenir compte des vacations ici
                    //check vacation table
                    //Simple one, by week, simple click to assign a day off
                    if (Settings.DeliveryDayOpen[dayNo] == 0)
                        text = "-";
                    else
                        text = Settings.DefaultFee + "€";
                    row[i] = text;
                }
                //check time slot is not full
                //check vacation

                //row[1]
                BookingTable.Rows.Add(row);
            }

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


        /// <summary>
        /// Table should be transposed: rows become columns
        /// so that it is wide oriented
        /// </summary>
        /// <param name="year"></param>
        public void BuildVacationTable(int year)
        {
            DataColumn col;
            VacationTable = new DataTable();
            col = VacationTable.Columns.Add("PickupId", typeof(int));
            col.AllowDBNull = false;
            col = VacationTable.Columns.Add("Id", typeof(int));
            col.AutoIncrement = true;
            VacationTable.Columns.Add("WeekNo", typeof(int));
            foreach (string sDay in new string[]
            { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" })
                VacationTable.Columns.Add(sDay, typeof(int));
            VacationTable.Columns.Add("Description", typeof(string));

            DateTime t = DateTime.Now;

            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            myCal.GetWeekOfYear(t, myCWR, myFirstDOW);
        }


        public DataTable GetVacationTableAsDates()
        {
            return new DataTable();
        }

        //get row depending on the date
        public void SeedVacationTable(int year)
        {
            if (VacationTable == null)
                BuildVacationTable(DateTime.Now.Year);

            for (int d = 1; d < 2; d++)
            {
                DateTime date = new DateTime(year, 08, d);
                DataRow row = VacationTable.NewRow();
                row["PickupId"] = 24;
                foreach (string sDay in new string[]
                { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" })
                    row[sDay] = 1;
                row["Description"] = "Summer vacation";
                VacationTable.Rows.Add(row);
            }
            //Add French Public holidays

        }

        public void MakeTimeSlotTableStrucForDisplay()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PickupId", typeof(int));
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
            for (int h = Settings.DeliveryStartsAt.Hours; h < Settings.DeliveryStopsAt.Hours; h += Settings.TimeSlotDuration)
            {
                row = TimeSlotTable.NewRow();
                row["PickupId"] = PickupId;
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
        public void GenerateDefaultTimeSlots(int PickupId, int PickupIdCopyFrom = -1)
        {

        }


    }
}