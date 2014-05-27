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
    public partial class mainForm : Form
    {
        private string queryString;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // define the query string that will be used in buildings form
            string queryString = "select buildingID as Building_ID, bAddress as Address, bArea as Area from Buildings order by buildingID";

            // this will call an overloaded constructor method
            Buildings blds1 = new Buildings(queryString);

            // this will call the function toReplaceBuildings_Load
            blds1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dapanes dap1 = new Dapanes();
            dap1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            costPredefinedItems a = new costPredefinedItems();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apartments newApartment = new Apartments();
            newApartment.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class test
    {
        private int t = 4;

        public int gett()
        {
            return t;
        }
    }

}
