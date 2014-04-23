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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void grdAuthorTitles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\daniel\Source\Repos\to_share2\StartKoinoxristaProject\kinoxrista.mdf;Integrated Security=True");
            SqlCommand myCommand = new SqlCommand("select * from Buildings");
            myCommand.Connection = myConnection;
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;

            DataSet myDataSet = new DataSet();
            DataTable myDataTable = new DataTable();
            myDataSet.Tables.Add(myDataTable);

            myDataAdapter.Fill(myDataTable);

            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myDataTable;

            DataGrid1.DataSource = myBindingSource;
            myDataAdapter.Update(myDataTable);
        }
    }
}
