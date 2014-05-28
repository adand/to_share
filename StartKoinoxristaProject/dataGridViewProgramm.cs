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
    public partial class dataGridViewProgramm : Form
    {
        private DataGridView dataGridView1 = new DataGridView();

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }

        public dataGridViewProgramm()
        {
            InitializeComponent();
        }

        private void dataGridViewProgramm_Load(object sender, EventArgs e)
        {

        }
    }
}
