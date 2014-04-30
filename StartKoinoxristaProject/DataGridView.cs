using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StartKoinoxristaProject
{
    public partial class DataGridView : Form
    {
        SqlDataAdapter adap;
        SqlCommandBuilder cmdb1;
        DataSet ds;

        public DataGridView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveApartments_Click(object sender, EventArgs e)
        {
            try
            {
                cmdb1 = new SqlCommandBuilder(adap);
                adap.Update(ds);
                MessageBox.Show("Information updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\adand\Projects\ABM\to_share\StartKoinoxristaProject\kinoxrista.mdf;Integrated Security=True";
                con.Open();
                adap = new SqlDataAdapter("select * from Apartments", con); 
                ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
