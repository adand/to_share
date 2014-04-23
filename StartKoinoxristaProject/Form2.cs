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
    public partial class Form2 : Form
    {
        private string BuildingID;
        private string Address;
        private string Area;

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\daniel\Source\Repos\to_share2\StartKoinoxristaProject\kinoxrista.mdf;Integrated Security=True");
            try
            {
                myConnection.Open();
            }
            catch (Exception eOpen)
            {
                Console.WriteLine(eOpen.ToString());
            }

            SqlCommand myCommand = new SqlCommand("insert into Buildings values(@BuildingID, @Address, @Area)");
            myCommand.Parameters.AddWithValue("@BuildingID", BuildingIDTextBox.Text);
            myCommand.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            myCommand.Parameters.AddWithValue("@Area", AreaTextBox.Text);

            myCommand.Connection = myConnection;

            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;

            DataSet myDataSet = new DataSet();
            DataTable myDataTable = new DataTable();
            myDataSet.Tables.Add(myDataTable);

            try
            {
                myDataAdapter.Fill(myDataTable);
                MessageBox.Show("Insertion was successful");
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Duplicate ID");
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }
            }

        }

            //Console.ReadLine();

            private static void DisplaySqlErrors(SqlException exception)
            {
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
                }
                Console.ReadLine();
            }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuildingIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // on click event handler for navigating back home 
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.Show();
            this.Hide();
        }
    }
}
