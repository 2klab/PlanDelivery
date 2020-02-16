using System;
using System.Data;

namespace PlanDelivery
{
    public class Simu
    {

        DataSet SimuDataSet { get; set; }
        /// <summary>
        /// External to this project
        /// </summary>
        public DataTable PickupTable { get; set; }
        public DataTable OrderTable { get; set; }
        public DataTable ClientTable { get; set; }
        public DataTable Client_OrderTable { get; set; }


        public Simu(DataSet simuDataSet)
        {
            SimuDataSet = simuDataSet;
            InitAndSeed();
        }

        public void InitAndSeed()
        {
            DataColumn col;
            PickupTable = SimuDataSet.Tables.Add("PickupPoint");
            col = PickupTable.Columns.Add("Id", typeof(int));
            col.AutoIncrement = true;
            PickupTable.Columns.Add("PickupName", typeof(string));

            DataRow rowp;
            rowp = PickupTable.NewRow();
            rowp["PickupName"] = "Marche Ville";
            PickupTable.Rows.Add(rowp);
            rowp = PickupTable.NewRow();
            rowp["PickupName"] = "Marche bio Garenne";
            PickupTable.Rows.Add(rowp);

            OrderTable = SimuDataSet.Tables.Add("Order");
            col = OrderTable.Columns.Add("Id", typeof(int));
            col.AutoIncrement = true;
            col = OrderTable.Columns.Add("PickupId", typeof(int));
            col.AllowDBNull = false;
            OrderTable.Columns.Add("DeliveryAddress", typeof(string));
            OrderTable.Columns.Add("DeliveryStart", typeof(TimeSpan));
            OrderTable.Columns.Add("DeliveryStop", typeof(TimeSpan));
        }

    }
}
