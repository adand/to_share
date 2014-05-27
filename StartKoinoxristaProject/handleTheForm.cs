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
    public partial class handleTheForm : Form
    {
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        private Control saveBtn;
        private Control deleteBtn;
        private Control cancelBtn;
        private Control messageBoardLbl;
        private Control instantMessageBoardLbl;
        private Control issueMessageBoardLbl;

        public handleTheForm()
        {
            InitializeComponent();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource();
            ds = new DataSet();
            dt = new DataTable();
            saveBtn = new Control();
            deleteBtn = new Control();
            cancelBtn = new Control();
            messageBoardLbl = new Control();
            instantMessageBoardLbl = new Control();
            issueMessageBoardLbl = new Control();
        }

        public BindingSource BindingSource1
        {
            get { return bindingSource1; }
            set { bindingSource1 = value; }
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1;}
            set { dataGridView1 = value;}
        }

        private void handleTheForm_Load(object sender, EventArgs e)
        {

        }

        public DataTable GetData(string selectCommand)
        {
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";
            da = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            ds.Tables.Add(dt);
            da.Fill(dt);
            return dt;
        }

        public void whileEditingControls(bool displayStatus)
        {
            Control[] whileEditingControls = { saveBtn, deleteBtn, cancelBtn, messageBoardLbl, instantMessageBoardLbl, issueMessageBoardLbl };
            for (int i = 0; i < whileEditingControls.Length; i++)
            {
                if (displayStatus)
                {
                    whileEditingControls[i].Show();
                    //dataGridView1.ReadOnly = false;
                    
                }
                else
                {
                    whileEditingControls[i].Hide();
                    /*dataGridView1.ReadOnly = true;
                    resetLabelsText();*/
                }
            }
        }
    }
}
