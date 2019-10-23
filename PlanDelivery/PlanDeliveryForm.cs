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

        PlanDeliveryByPickupSettings PlanDeliveryByPickupSettings = new PlanDeliveryByPickupSettings();

        static DataSet SimuDS = new DataSet("Simu");
        Simu NopSimu = new Simu(SimuDS);

        private void Form1_Load(object sender, EventArgs e)
        {

            propertyGrid1.SelectedObject = PlanDeliveryByPickupSettings;
            comboBoxPickupPoint.DataSource = NopSimu.PickupTable;
            comboBoxPickupPoint.DisplayMember = "PickupName";
            dataGridSlots.DataSource = NopSimu.SlotTable;

            monthCalendarHoliday.MinDate = PlanDeliveryByPickupSettings.MinDate;
            monthCalendarHoliday.MaxDate = PlanDeliveryByPickupSettings.MaxDate;

            PlanDelivery plan = new PlanDelivery();
            plan.MakeBookingTable();
            plan.SeedVacationTable(2019);
            dataGridViewBooking.DataSource = plan.BookingTable;
            dataGridViewVacation.DataSource = plan.VacationTable;
        }

        private void comboBoxPickupPoint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SlotTable = PlanDeliveryByPickupSettings.GetSlotsTableStruc();
            PlanDeliveryByPickupSettings.InitSlotTable(SlotTable);
            dataGridSlots.DataSource = SlotTable;
        }
    }
}
