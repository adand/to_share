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

/*namespace StartKoinoxristaProject
{*/
public class costPredefinedItems : Form
{
    private DataGridView dataGridView1 = new DataGridView();

    public costPredefinedItems()
    {
        this.dataGridView1.Dock = DockStyle.Fill;
        this.Controls.Add(dataGridView1);
        this.Text = "Demo";
    }

    private void costPredefinedItems_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
//}
