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

        //Δήλωση ενός DataGridView object χωρίς όμως να δείχνει σε κάποια θέση μνήμης.
        //Η κάθε κλάση που κληρονομεί από αυτή την κλάση δημιουργεί ένα DataGridView object και αφού το βάζει να δείχνει σε κάποια θέση μνήμης,
        // θέτει τον "δείκτη" του object της base class να δείχνει στην θέση μνήμης που δείχνει το object της derived class.
        private DataGridView dataGridView1 = new DataGridView();

        private BindingSource bindingSource1 = new BindingSource();

        private SqlDataAdapter adapter = new SqlDataAdapter();

        private DataTable table = new DataTable();

        //private DataSet ds;
        private Control editBtn;
        private Control exitBtn;
        private Control saveBtn;
        private Control deleteBtn;
        private Control cancelBtn;
        private Label messageBoardLbl;
        private Label instantMessageBoardLbl;
        private Label issueMessageBoardLbl;
        private ComboBox areaComboBox;
        private ComboBox addressComboBox;

        public Handle()
        {
            
        }

        public SqlDataAdapter Adapter
        {
            get { return adapter; }
            set { adapter = value; }
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

        public ComboBox AreaComboBox
        {
            get { return areaComboBox; }
            set { areaComboBox = value; }
        }

        public ComboBox AddressComboBox
        {
            get { return addressComboBox; }
            set { addressComboBox = value; }
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
                    int r = adapter.Update(dt);
                    whileEditingControls(false);
                    MessageBox.Show("Saved! " + r + " row(s) affected.");
                    GetData(adapter.SelectCommand.CommandText);
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
                    GetData(adapter.SelectCommand.CommandText);
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch
                {
                    messageBoardLbl.Text = "Reloading from database failed";
                }
            }
        }

        //@selectedID the Building ID
        public void save(string selectedID, string duplicateID_message, string blankField_message, string max_characters_message)
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
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState.ToString() != "Deleted")
                        {
                            if (row[0].ToString().Length == 0)
                            {
                                row[0] = selectedID;
                            }
                        }
                    }

                    int r = adapter.Update(dt);

                    whileEditingControls(false);
                    MessageBox.Show("Saved! " + r + " row(s) affected.");
                    GetData(adapter.SelectCommand);
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
                    GetData2();
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch
                {
                    messageBoardLbl.Text = "Reloading from database failed";
                }
            }
        }

        //@selectedID the Building ID
        public void save(string[] columnAutomaticValues, string duplicateID_message, string blankField_message, string max_characters_message)
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
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState.ToString() != "Deleted")
                        {
                            for (int i = 0; i < columnAutomaticValues.Length; i++)
                            {
                                if (row[i].ToString().Length == 0)
                                {
                                    row[i] = columnAutomaticValues[i];
                                }
                            }
                        }
                    }

                    int r = adapter.Update(dt);

                    whileEditingControls(false);
                    MessageBox.Show("Saved! " + r + " row(s) affected.");
                    GetData(adapter.SelectCommand);
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
                    GetData2();
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch
                {
                    messageBoardLbl.Text = "Reloading from database failed";
                }
            }
        }

        public void fillTheComboBox(string queryString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            using (connection)
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        areaComboBox.Items.Add(reader[0]);
                    }
                }
            }
        }

        public void fillTheComboBox(string queryString, string filterItem)
        {
            addressComboBox.ResetText();
            addressComboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = queryString;
                command.Connection = connection;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@parameter";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Value = filterItem;

                command.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        addressComboBox.Items.Add(reader[0]);
                    }
                }
            }
        }

        public string RetrieveIdBasedOnLocation()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select buildingID from buildings where bArea = @Area and bAddress = @Address";

                SqlParameter param_area = new SqlParameter();
                param_area.ParameterName = "@Area";
                param_area.SqlDbType = SqlDbType.NVarChar;
                param_area.Value = areaComboBox.SelectedItem.ToString();

                SqlParameter param_address = new SqlParameter();
                param_address.ParameterName = "@Address";
                param_address.SqlDbType = SqlDbType.NVarChar;
                param_address.Value = addressComboBox.SelectedItem.ToString();

                command.Parameters.Add(param_area);
                command.Parameters.Add(param_address);

                connection.Open();
                return command.ExecuteScalar().ToString();
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
                    GetData(adapter.SelectCommand.CommandText);
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void cancel2()
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
                    GetData2();
                    whileEditingControls(false);
                    whileNotEditingControls(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void cancel(string selectCommand, string deleteCommand, string selectedID, string month, string year)
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
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        GetData2();
                        whileEditingControls(false);
                        whileNotEditingControls(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void GetData(SqlCommand selectCommand)
        {
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = selectCommand;
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bindingSource1.DataSource = dt;
        }

        //Γίνεται ανάκτηση από τη βάση δεδομένων με τη χρήση DataAdapter Commands οι οποίες καθορίζονται αυτόματα από ένα SqlCommandBuilder αντικείμενο.
        //Ο DataAdapter που χρησιμοποιείται έχει τοπική εμβέλεια.
        //@selectCommand the command that SqlCommandBuilder needs in order to produce automatically the other Commands.
        public void GetData(string selectCommand)
        {
            adapter = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bindingSource1.DataSource = dt;
        }

        public void GetData(SqlDataAdapter da)
        {
            adapter = da;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bindingSource1.DataSource = dt;
        }

        public void GetData2()
        {
            dataGridView1.DataSource = bindingSource1;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            bindingSource1.DataSource = dt;
        }
        
        /*public SqlDataAdapter CreateSqlDataAdapter(string selectCommand, string selectedID, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            
            // create the commands
            adapter.SelectCommand = new SqlCommand(selectCommand);

            //create the parameters
            adapter.SelectCommand.Parameters.Add("@buildingID", SqlDbType.VarChar, 3, "buildingID");
        }*/

        public void whileEditingControls(bool displayStatus)
        {
            Control[] whileEditingControls = { saveBtn, deleteBtn, cancelBtn, messageBoardLbl, instantMessageBoardLbl, issueMessageBoardLbl };
            if (displayStatus)
            {
                dataGridView1.ReadOnly = false;

                foreach(Control c in whileEditingControls)
                {
                    c.Show();
                }

                //find which column is the first visible column and set the cursor of the DataGridView to point there.
                int firstVisibleColumnIndex = 0;

                for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; columnIndex++)
                {
                    if (dataGridView1.Columns[columnIndex].Visible == true)
                    {
                        firstVisibleColumnIndex = columnIndex;
                        break;
                    }
                }
                dataGridView1.CurrentCell = dataGridView1[firstVisibleColumnIndex, dataGridView1.Rows.Count - 1];
            }
            else
            {
                foreach (Control c in whileEditingControls)
                {
                    c.Hide();
                }
                dataGridView1.ReadOnly = true;
                resetLabelsText();
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
