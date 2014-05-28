﻿using System;
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
        private DataGridView dataGridView2 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private Control editBtn;
        private Control exitBtn;
        private Control saveBtn;
        private Control deleteBtn;
        private Control cancelBtn;
        private Label messageBoardLbl;
        private Label instantMessageBoardLbl;
        private Label issueMessageBoardLbl;
            
        public handleTheForm()
        {
            InitializeComponent();            
            ds = new DataSet();
            dt = new DataTable();
        }

        public BindingSource BindingSource1
        {
            get { return bindingSource1; }
            set { bindingSource1 = value; }
        }

        public Control EditBtn
        {
            get { return editBtn;}
            set { editBtn = value;}
        }

        public Control ExitBtn
        {
            get { return exitBtn;}
            set { exitBtn = value;}
        }

        public Control SaveBtn
        {
            get { return saveBtn;}
            set { saveBtn = value;}
        }

        public Control DeleteBtn
        {
            get { return deleteBtn;}
            set { deleteBtn = value;}
        }

        public Control CancelBtn
        {
            get { return cancelBtn;}
            set { cancelBtn = value;}
        }

        public Label MessageBoardLbl
        {
            get { return messageBoardLbl;}
            set { messageBoardLbl = value;}
        }

        public Label InstantMessageBoardLbl
        {
            get { return instantMessageBoardLbl;}
            set { instantMessageBoardLbl = value;}
        }

        public Label IssueMessageBoardLbl
        {
            get { return issueMessageBoardLbl;}
            set { issueMessageBoardLbl = value;}
        }

        /*public void set_dataGridView(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }*/

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }

        public DataGridView DataGridView2
        {
            get { return dataGridView2; }
            set { dataGridView2 = value; }
        }

        public void setDataSource()
        {
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Hide();
        }
        
        private void handleTheForm_Load(object sender, EventArgs e)
        {
            
        }

        public void exit()
        {
            this.Close();
            mainForm myMainForm = new mainForm();
            myMainForm.Show();
        }

        public void edit()
        {

        }

        public void cancel()
        {
            string message = "Are you sure you want to Abort?";
            string caption = "Confirm Cancellation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            saveBtn.Hide();
            /*if (result == DialogResult.Yes)
            {
                try
                {
                    messageBoardLbl.ResetText();
                    GetData(da.SelectCommand.CommandText);
                    whileEditingControls(false);
                    // whileNotEditingControls(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
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
                    dataGridView1.ReadOnly = false;
                    
                }
                else
                {
                    whileEditingControls[i].Hide();
                    dataGridView1.ReadOnly = true;
                    resetLabelsText();
                }
            }
        }

        public void whileNotEditingControls(bool displayStatus)
        {
            Control[] whileNotEditingControls = { editBtn, exitBtn };
            for (int i = 0; i < whileNotEditingControls.Length; i++)
            {
                if (displayStatus)
                {
                    whileNotEditingControls[i].Show();
                }
                else
                {
                    whileNotEditingControls[i].Hide();
                }
            }
        }

        public void resetLabelsText()
        {
            Label[] labels = { messageBoardLbl, instantMessageBoardLbl, issueMessageBoardLbl };
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].ResetText();
            }
        }
    }
}
