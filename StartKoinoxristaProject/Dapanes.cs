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

namespace StartKoinoxristaProject
{
    public partial class Dapanes : Form
    {
        public Dapanes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool invalidEntry = false;

            if (AddressComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid Address. Try again.");
                invalidEntry = true;
            }

            if (AreaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid Area. Try again.");
                invalidEntry = true;
            }

            if (monthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid Month. Try again.");
                invalidEntry = true;
            }

            if (YearComboBox.SelectedItem == null)
            {
                MessageBox.Show("Invalid Year. Try again.");
                invalidEntry = true;
            }

            if (invalidEntry == false)
            {
                continueButton.Hide();

                AddressComboBox.Enabled = false;
                AreaComboBox.Enabled = false;
                monthComboBox.Enabled = false;
                YearComboBox.Enabled = false;

                costCategoryComboBox.Show();
                costCategoryLabel.Show();
                costDescriptionComboBox.Show();
                costDescriptionLabel.Show();
                costValueTextBox.Show();
                costValueLabel.Show();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dapanes_Load(object sender, EventArgs e)
        {
            costCategoryComboBox.Hide();
            costCategoryLabel.Hide();
            costDescriptionComboBox.Hide();
            costDescriptionLabel.Hide();
            costValueTextBox.Hide();
            costValueLabel.Hide();
           
            decimal a = 3.5m;
            double b = 7000232165.34;
            double c = 3.21;
            NumberFormatInfo nfi = new CultureInfo("el-GR", false).NumberFormat;
            nfi.NumberGroupSeparator = ".";
            costCategoryComboBox.Items.Add(a);
            costCategoryComboBox.Items.Add(b.ToString("N", nfi));
            costCategoryComboBox.Items.Add(c);

            string query;
            query = "select * from Buildings";
            AccessTheDatabase ShowBuilding = new AccessTheDatabase();
            ShowBuilding.AccessingProcess(query);
            ShowBuilding.get_myDataAdapter().Fill(ShowBuilding.get_myDataTable());

            DataTable dt = ShowBuilding.get_myDataTable();
            /*string addr = dt.Rows[0].ItemArray[1].ToString();
            MessageBox.Show(addr);*/

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddressComboBox.Items.Add(dt.Rows[i]["Address"]);
                AreaComboBox.Items.Add(dt.Rows[i]["Area"]);
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
    }
}
