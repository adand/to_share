using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace StartKoinoxristaProject
{
    public partial class Dapanes : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();


        public Dapanes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dapanes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoxristaDataSet1.Apartments' table. You can move, or remove it, as needed.
            this.apartmentsTableAdapter.Fill(this.kinoxristaDataSet1.Apartments);
            // TODO: This line of code loads data into the 'kinoxristaDataSet.Buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.kinoxristaDataSet.Buildings);

            costCategoryComboBox.Hide();
            costCategoryLabel.Hide();
            costDescriptionComboBox.Hide();
            costDescriptionLabel.Hide();
            costValueTextBox.Hide();
            costValueLabel.Hide();
            saveButton.Hide();
            messageLabel.Hide();
            alreadyInsertedCostDataGridView.Hide();
           
            /*decimal a = 3.5m;
            double b = 7000232165.34;
            double c = 3.21;
            NumberFormatInfo nfi = new CultureInfo("el-GR", false).NumberFormat;
            nfi.NumberGroupSeparator = ".";
            costCategoryComboBox.Items.Add(a);
            costCategoryComboBox.Items.Add(b.ToString("N", nfi));
            costCategoryComboBox.Items.Add(c);*/

            // Begin reading database table Building in order to fill the comboboxes Address and Area

            string queryOnBuildings;
            queryOnBuildings = "select distinct Area from Buildings";
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
                AreaComboBox.Items.Add(dtOfBuildings.Rows[i]["Area"]);
            }

            string[] monthNames = { "Ιανουάριος", "Φεβρουάριος", "Μάρτιος", "Απρίλιος", "Μάιος", "Ιούνιος", "Ιούλιος", "Αύγουστος", "Σεπτέμβριος", "Οκτώβριος",
                                  "Νοέμβριος", "Δεκέμβριος" };
            monthComboBox.Items.AddRange(monthNames);

            for (int i=2010; i<2050; i++)
            {
                YearComboBox.Items.Add(i);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showBuildingButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryOnBuildings;
            queryOnBuildings = string.Format("select Address from Buildings where Area = '{0}'", AreaComboBox.SelectedItem);
            AccessTheDatabase ShowBuilding = new AccessTheDatabase();
            ShowBuilding.AccessingProcess(queryOnBuildings);
            ShowBuilding.get_myDataAdapter().Fill(ShowBuilding.get_myDataTable());

            DataTable dtOfBuildings = ShowBuilding.get_myDataTable();
            /*string addr = dt.Rows[0].ItemArray[1].ToString();
            MessageBox.Show(addr);*/

            AddressComboBox.Items.Clear();
            for (int i = 0; i < dtOfBuildings.Rows.Count; i++)
            {
                 AddressComboBox.Items.Add(dtOfBuildings.Rows[i]["Address"]);
                // AreaComboBox.Items.Add(dtOfBuildings.Rows[i]["Area"]);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void costCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            costDescriptionComboBox.Enabled = true;
            costDescriptionComboBox.Items.Clear();
            costDescriptionComboBox.ResetText();

            string connectionString =
                    @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\kinoxrista.mdf;Integrated Security=True;Connect Timeout=30";

            string queryString2 =
                    "SELECT distinct costDescription from costPreDefinedItems where costCategory = @costCategoryComboBox";

            using (SqlConnection connection =
                    new SqlConnection(connectionString))
            {
                SqlCommand command2 = new SqlCommand(queryString2, connection);
                command2.Parameters.AddWithValue("@costCategoryComboBox", costCategoryComboBox.SelectedItem);

                try
                {
                    connection.Open();

                    SqlDataReader reader2 = command2.ExecuteReader();

                    while (reader2.Read())
                    {
                        costDescriptionComboBox.Items.Add(reader2[0]);
                    }
                    reader2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "r2");
                }
            }

        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString =
                    @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                alreadyInsertedCostDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void continueButton_Click(object sender, EventArgs e)
        {

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            alreadyInsertedCostDataGridView.DataSource = bindingSource1;
            GetData("select * from dapanes");
            
            bool invalidChoice = false;

            if ((AddressComboBox.SelectedItem == null) || (AreaComboBox.SelectedItem == null) || (monthComboBox.SelectedItem == null) ||
                (YearComboBox.SelectedItem == null))
            {
                invalidChoice = true;
            }

            if (invalidChoice == true)
            {
                continueButton.Hide();

                AddressComboBox.Enabled = false;
                AreaComboBox.Enabled = false;
                monthComboBox.Enabled = false;
                YearComboBox.Enabled = false;

                costCategoryComboBox.Show();
                costCategoryLabel.Show();
                
                costDescriptionComboBox.Show();
                costDescriptionComboBox.Enabled = false;

                costDescriptionLabel.Show();
                costValueTextBox.Show();
                costValueLabel.Show();
                saveButton.Show();
                messageLabel.Show();
                alreadyInsertedCostDataGridView.Show();

                string connectionString =
                    @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\kinoxrista.mdf;Integrated Security=True;Connect Timeout=30";

                // Provide the query string with a parameter placeholder. 
                string queryString1 =
                    "SELECT distinct costCategory from costPreDefinedItems";

                // Create and open the connection in a using block. This 
                // ensures that all resources will be closed and disposed 
                // when the code exits. 
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command1 = new SqlCommand(queryString1, connection);

                    // Open the connection in a try/catch block.  
                    // Create and execute the DataReader, writing the result 
                    // set to the console window. 
                    try
                    {
                        connection.Open();

                        SqlDataReader reader1 = command1.ExecuteReader();
                        
                        while (reader1.Read())
                        {
                            costCategoryComboBox.Items.Add(reader1[0]);
                        }
                        reader1.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "r1");
                    }
                }

            }
            else
            {
                MessageBox.Show("You must fill all fields!");
            }

            /*
             * 
             * // Create an instance of the ListBox.
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(200, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form. 
            this.Controls.Add(listBox1);
            // Set the ListBox to display items in multiple columns.
            // listBox1.MultiColumn = false;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox. 
            for (int x = 1; x <= 50; x++)
            {
                listBox1.Items.Add("Item " + x.ToString());
            }
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();

            // Select three items from the ListBox.
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(3, true);
            listBox1.SetSelected(5, true);

            // Display the second selected item in the ListBox to the console.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedItems[1].ToString());
            // Display the index of the first selected item in the ListBox.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndices[0].ToString());  
             * 
             */
        }

        private void buildingIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
