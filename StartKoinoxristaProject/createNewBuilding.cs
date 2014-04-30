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
using System.IO;

namespace StartKoinoxristaProject
{
    public partial class createNewBuildingForm : Form
    {
        //private string BuildingID;
        //private string Address;
        //private string Area;

        string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
       

        public createNewBuildingForm()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = "insert into Buildings values(@BuildingID, @Address, @Area)";

            // Create an object of the database accessor class. This class is inside the program.cs file
            AccessTheDatabase AddBuildings = new AccessTheDatabase();

            // Call the method that will begin the process of database access
            AddBuildings.AccessingProcess(BuildingIDTextBox.Text, AddressTextBox.Text, AreaTextBox.Text, query);

            if (BuildingIDTextBox.Text != "" && AreaTextBox.Text != "" && AddressTextBox.Text != "") //avoid empty fields 
            {
                try
                {
                    // Fill DataTable by using DataAdapter
                    AddBuildings.get_myDataAdapter().Fill(AddBuildings.get_myDataTable());
                    MessageBox.Show("Insertion was successful");    // Successful insertion to database
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // case of primary key constraint violation
                    {
                        MessageBox.Show("Duplicate ID");
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed: " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error); // show exeption error, ok button and error icon 
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields ");

            }

            // Create an object of the database accessor class. This class is inside the program.cs file
            AccessTheDatabase AddApartments = new AccessTheDatabase();

            // Call the method that will begin the process of database access
            AddApartments.AccessingProcess(BuildingIDTextBox.Text, AddressTextBox.Text, AreaTextBox.Text, query);

            /* need to be fixed
             * 
            //insert apartments
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
               
                try
                {
                    
                    SqlCommand instcomd = new SqlCommand("insert into Apartments values (@BuildingID,@ApartmentID,@FullName,@GeneralMM,@ElevatorMM,@Manager)");
                    instcomd.Parameters.AddWithValue("@BuildingID", BuildingIDTextBox.Text);
                    instcomd.Parameters.AddWithValue("@ApartmentID", row.Cells[0].Value.ToString());
                    instcomd.Parameters.AddWithValue("@FullName", row.Cells[1].Value.ToString());
                    instcomd.Parameters.AddWithValue("@GeneralMM", row.Cells[2].Value.ToString());
                    instcomd.Parameters.AddWithValue("@ElevatorMM", row.Cells[3].Value.ToString());
                    instcomd.Parameters.AddWithValue("@Manager", row.Cells[4].Value.ToString());


                    instcomd.Connection = AddBuildings.get_connection();
                   
                    instcomd.ExecuteNonQuery();
                }
                catch(SqlException ext) {

                    MessageBox.Show("Error :"+ext.Message);

                }
            }
             * 
            */

            
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

        private void Form2_Load(object sender, EventArgs e)
        {
            apartmentDetailsDataGridView.Hide();
            clearBuildingsTableButton.Hide();
            SaveButton.Hide();
        }

        private void ClearBuildingsTable_Click(object sender, EventArgs e)
        {
            string query = "delete from Buildings";
            AccessTheDatabase ClearBuildings = new AccessTheDatabase();
            ClearBuildings.AccessingProcess(query);

            try
            {
                // Fill DataTable by using DataAdapter
                ClearBuildings.get_myDataAdapter().Fill(ClearBuildings.get_myDataTable());
                MessageBox.Show("Deletion was successful");    // Successful deletion on database
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Deletion Failed: " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error); // show exeption error, ok button and error icon 
            }

            
            /*SqlDataAdapter myDataAdapter;

            // Create an object of the database accessor class. This class is inside the program.cs file
            AccessTheDatabase writeKinoxrista = new AccessTheDatabase();

            // Call the communication method of the database by using the object that has been declared above
            writeKinoxrista.CommunicateWithDatabase();

            SqlCommand myCommand = new SqlCommand("delete from Buildings");
             * */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            BuildingIDTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            AreaTextBox.Enabled = false;
            continueButton.Hide();
            apartmentDetailsDataGridView.Show();
            SaveButton.Show();
        }

       // insert values on apartments table does not work yes 
    }
}
