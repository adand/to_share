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
    public partial class testing_with_DataGridViewComboBoxColumn : Form
    {
        DataTable dt = new DataTable();
        private DataGridViewComboBoxColumn cbc;
        public testing_with_DataGridViewComboBoxColumn()
        {
            InitializeComponent();
        }

        private void testing_with_DataGridViewComboBoxColumn_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Add("Vehicles", "Type of vehicle");
            cbc = new DataGridViewComboBoxColumn();
            dataGridView1.Columns.Add(cbc);
            string queryString = "select * from dapanes";
            DataTable dt = populate(queryString);
            dataGridView1.AutoGenerateColumns = false;
            cbc.DataSource = dt;
            cbc.DataPropertyName = "costCategory";
            cbc.Name = "Cost Category";
        }   

        public DataTable populate(string queryString)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                connection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
