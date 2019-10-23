using System.Data;

namespace PlanDelivery
{
    public class Simu
    {

        DataSet SimuDataSet { get; set; }
        /// <summary>
        /// External to this project
        /// </summary>
        DataTable PickupTable { get; set; }

        public Simu(DataSet simuDataSet)
        {
            SimuDataSet = simuDataSet;
        }

        public void Init()
        {
            PickupTable = SimuDataSet.Tables.Add("PickupPoint");
            PickupTable.Columns.Add("Id", typeof(int));
            PickupTable.Columns.Add("PickupName", typeof(string));

            DataRow rowp;
            rowp = PickupTable.NewRow();
            rowp["id"] = "1";
            rowp["PickupName"] = "Marche Ville";
            PickupTable.Rows.Add(rowp);
            rowp = PickupTable.NewRow();
            rowp["id"] = "2";
            rowp["PickupName"] = "Marche bio Garenne";
            PickupTable.Rows.Add(rowp);

        }

    }
}
