using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

/*namespace StartKoinoxristaProject
{*/
    public class Build : Handle
    {
        private SqlDataAdapter da;
        private DataSet ds;
        private DataGridView dataGridView1 = new DataGridView();
        private Button editBtn = new Button();
        private Button exitBtn = new Button();
        private Button saveBtn = new Button();
        private Button deleteBtn = new Button();
        private Button cancelBtn = new Button();
        private Label messageBoardLbl = new Label();
        private Label instantMessageBoardLbl = new Label();
        private Label issueMessageBoardLbl = new Label();


        //default constructor
        public Build()
        {
            /*
            // initialize the objects that are on the form
            InitializeComponent();
            MessageBox.Show("inside default constructor");
             * */
        }

        // overloaded constructor method
        public Build(string queryString)
        {
            /*
            // initialize the objects that are on the form
            InitializeComponent();
             * */

            this.Controls.Add(dataGridView1);

            // get the value of the property
            BindingSource bindingSource1 = BindingSource1;

            // define the data source for the dataGridView
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = GetData(queryString);

            // bind dataGridView1 of the parent form with dataTable
            setDataSource();

            //DataGridView2 = dataGridView1;

            // initialize the object's buttons
            EditBtn = editBtn;
            ExitBtn = exitBtn;
            SaveBtn = saveBtn;
            DeleteBtn = deleteBtn;
            CancelBtn = cancelBtn;
            MessageBoardLbl = messageBoardLbl;
            InstantMessageBoardLbl = instantMessageBoardLbl;
            IssueMessageBoardLbl = issueMessageBoardLbl;
        }

        private void buildings_Load(object sender, EventArgs e)
        {
            // hide the edit-buttons
            whileEditingControls(false);


            /*MessageBox.Show("form loader");
            dataGridView1.DataSource = bindingSource1;
            string queryString = "select buildingID as Building_ID, bAddress as Address, bArea as Area from Buildings order by buildingID";
            whileEditingControls(false);*/
        }

        /*public void GetData(string selectCommand)
        {
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";
            da = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            da.Fill(dt);
            bindingSource1.DataSource = dt;
        }*/

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            GetData(da.SelectCommand.CommandText);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            edit();
            whileNotEditingControls(false);
            whileEditingControls(true);
            messageBoardLbl.Text = "Edit in progress ...";
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.Rows.Count - 1];
        }

        /*public void whileEditingControls(bool displayStatus)
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
        }*/

        /*public void whileNotEditingControls(bool displayStatus)
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
        }*/

        /*public void resetLabelsText()
        {
            Label[] labels = { messageBoardLbl, instantMessageBoardLbl, issueMessageBoardLbl };
            for (int i = 0; i < labels.Length; i++ )
            {
                labels[i].ResetText();
            }
        }*/

        private void saveBtn_Click(object sender, EventArgs e)
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
                    int r = 0;
                    /*
                    int r = da.Update((DataTable)bindingSource1.DataSource);
                     * */
                    whileEditingControls(false);
                    MessageBox.Show("Saved! " + r + " row(s) affected.");
                    GetData(da.SelectCommand.CommandText);
                    whileNotEditingControls(true);
                }
                catch (SqlException sqlEx)
                {
                    instantMessageBoardLbl.Text = "Insertion stopped on the red icon. Resolve rule's violation to insert the rest of the records.";
                    string messageIntro = "Rule affected:\n";
                    switch (sqlEx.Number)
                    {
                        case 2627:
                        {
                            issueMessageBoardLbl.Text = messageIntro + "Building ID must be unique. Also, the combination of Address, Area must be unique too.";
                            break;
                        }
                        case 515:
                        {
                            issueMessageBoardLbl.Text = messageIntro + "None of the fields allowed to be blank!";
                            break;
                        }
                        case 8152:
                        {
                            issueMessageBoardLbl.Text = messageIntro + "The maximum number of characters for Building ID is 3. Address, Area can contain at most 20 characters each.";
                            break;
                        }
                        default:
                        {
                            MessageBox.Show(sqlEx.Message + ": " + sqlEx.Number.ToString());
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
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void issueMessageBoardLbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
//}
