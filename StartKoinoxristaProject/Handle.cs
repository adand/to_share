using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

/*namespace StartKoinoxristaProject
{*/
    public class Handle : Form
    {
        private string connectionString;
        private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds;
        private Control editBtn;
        private Control exitBtn;
        private Control saveBtn;
        private Control deleteBtn;
        private Control cancelBtn;
        private Label messageBoardLbl;
        private Label instantMessageBoardLbl;
        private Label issueMessageBoardLbl;
        private ComboBox filterComboBox;
        private ComboBox filteredComboBox;

        public Handle()
        {
            
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
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

        public ComboBox FilterComboBox
        {
            get { return filterComboBox; }
            set { filterComboBox = value; }
        }

        public ComboBox FilteredComboBox
        {
            get { return filteredComboBox; }
            set { filteredComboBox = value; }
        }

        /*public void set_dataGridView(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }*/
        
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
            whileNotEditingControls(false);
            whileEditingControls(true);
            messageBoardLbl.Text = "Edit in progress ...";
        }

        public void save(string duplicateID_message, string blankField_message, string max_characters_message)
        {
            string message = "Are you sure you want to update the database with changes?";
            string caption = "Update confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable dt = (DataTable)bindingSource1.DataSource;
                    int r = da.Update((DataTable)bindingSource1.DataSource);
                    whileEditingControls(false);
                    MessageBox.Show("Saved! " + r + " row(s) affected.");
                    GetData(da.SelectCommand.CommandText);
                    whileNotEditingControls(true);
                }
                catch (SqlException sqlEx)
                {
                    instantMessageBoardLbl.Text = "Insertion stopped on the red icon. Resolve rule's violation to insert the rest of the records.";
                    string messageIntro = "Rule affected: ";
                    switch (sqlEx.Number)
                    {
                        case 2627:
                            {
                                issueMessageBoardLbl.Text = messageIntro + duplicateID_message;
                                break;
                            }
                        case 515:
                            {
                                issueMessageBoardLbl.Text = messageIntro + blankField_message;
                                break;
                            }
                        case 8152:
                            {
                                issueMessageBoardLbl.Text = messageIntro + max_characters_message;
                                break;
                            }
                        default:
                            {
                                MessageBox.Show(sqlEx.Message);
                                break;
                            }
                    }
                    instantMessageBoardLbl.ForeColor = Color.Red;
                    instantMessageBoardLbl.Show();
                    issueMessageBoardLbl.Show();
                }
            }
            else if (result == DialogResult.No)
            {
                messageBoardLbl.ResetText();
                MessageBox.Show("Not Saved!");
                try
                {
                    GetData(da.SelectCommand.CommandText);
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch
                {
                    messageBoardLbl.Text = "Reloading from database failed";
                }
            }
        }

        public void fillTheComboBox(string queryString, string columnTitle)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();
            using (connection)
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filterComboBox.Items.Add(reader[columnTitle]);
                    }
                }
            }
        }

        public void fillTheComboBox(string queryString, string columnTitle, string filterItem)
        {
            filteredComboBox.ResetText();
            filteredComboBox.Items.Clear();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = queryString;
            command.Connection = connection;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@parameter";
            parameter.SqlDbType = SqlDbType.NVarChar;
            parameter.Value = filterItem;

            command.Parameters.Add(parameter);

            connection.Open();
            using (connection)
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filteredComboBox.Items.Add(reader[columnTitle]);
                    }
                }
            }
        }

        public void delete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        public void cancel()
        {
            string message = "Are you sure you want to Abort?";
            string caption = "Confirm Cancellation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    GetData(da.SelectCommand.CommandText);
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void GetData(string selectCommand)
        {
            da = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            da.Fill(dt);

            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = dt;
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Handle
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Handle";
            this.Load += new System.EventHandler(this.Handle_Load);
            this.ResumeLayout(false);

        }

        private void Handle_Load(object sender, EventArgs e)
        {

        }
    }
//}
