using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartKoinoxristaProject
{
    public partial class queryWithStringFormat : Form
    {
        public queryWithStringFormat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imp = comboBox1.SelectedItem.ToString();

            string queryOnBuildings;
            queryOnBuildings = string.Format("select BuildingID from Buildings where Address = '{0}'", imp);
            AccessTheDatabase ShowBuilding = new AccessTheDatabase();
            ShowBuilding.AccessingProcess(queryOnBuildings);
            ShowBuilding.get_myDataAdapter().Fill(ShowBuilding.get_myDataTable());

            DataTable dtOfBuildings = ShowBuilding.get_myDataTable();
            /*string addr = dt.Rows[0].ItemArray[1].ToString();
            MessageBox.Show(addr);*/

            for (int i = 0; i < dtOfBuildings.Rows.Count; i++)
            {
                /*
                 * I'm going to do it after the user has select the area
                 * AddressComboBox.Items.Add(dtOfBuildings.Rows[i]["Address"]);
                 */
                listBox1.Items.Add(dtOfBuildings.Rows[i]["BuildingID"]);
            }
        }
    }
}
