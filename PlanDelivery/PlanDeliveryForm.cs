using System;
using System.Data;
using System.Windows.Forms;

namespace PlanDelivery
{
    public partial class PlanDeliveryForm : Form
    {
        public PlanDeliveryForm()
        {
            InitializeComponent();
        }

        PlanDelivery plan;

        static DataSet SimuDS = new DataSet("Simu");
        Simu NopSimu = new Simu(SimuDS);

        private void Form1_Load(object sender, EventArgs e)
        {
            plan = new PlanDelivery();
            plan.MakeBookingTable();
            plan.SeedVacationTable(2019);
            plan.GenerateDefaultTimeSlots(24);

            dataGridTimeslot.DataSource = plan.TimeSlotTable;

            dataGridViewBooking.DataSource = plan.BookingTable;
            dataGridViewVacation.DataSource = plan.VacationTable;

            propertyGrid1.SelectedObject = plan.Settings;

            comboBoxPickupPoint.DataSource = NopSimu.PickupTable;
            comboBoxPickupPoint.DisplayMember = "PickupName";

            monthCalendarHoliday.MinDate = plan.Settings.MinDate;
            monthCalendarHoliday.MaxDate = plan.Settings.MaxDate;
        }

        private void comboBoxPickupPoint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            plan.InitSlotTable(12);
            dataGridTimeslot.DataSource = plan.TimeSlotTable;
        }

        private void dataGridViewBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex
            Console.WriteLine("Cell clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //slot--
            //add order

        }
    }
}
