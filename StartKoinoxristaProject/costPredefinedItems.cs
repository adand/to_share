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
    public partial class costPredefinedItems : Form
    {
        public costPredefinedItems()
        {
            InitializeComponent();
        }

        private void costPredefinedItems_Load(object sender, EventArgs e)
        {
            int b = 7;
            Cost cost1 = new Cost();
            Cost cost2 = new Cost(b);
            MessageBox.Show(cost1.CostValue.ToString());
            MessageBox.Show(cost2.CostValue.ToString());
        }
    }
}
