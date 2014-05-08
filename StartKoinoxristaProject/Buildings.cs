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
    public partial class Buildings : Form
    {
        BindingSource bindingSource1 = new BindingSource();
        SqlDataAdapter da;
        DataSet ds;

        public Buildings()
        {
            InitializeComponent();
        }

        private void toReplaceBuildings_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select buildingID as Building_ID, bAddress as Address, bArea as Area from Buildings order by buildingID");
            messageBoardLbl.ResetText();
            instantMessageBoardLbl.Hide();
            issueMessageBoardLbl.Hide();
            saveBtn.Hide();
            cancelBtn.Hide();
        }

        public void GetData(string selectCommand)
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
            dataGridView1.ReadOnly = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            GetData(da.SelectCommand.CommandText);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            editBtn.Hide();
            saveBtn.Show();
            cancelBtn.Show();
            messageBoardLbl.Text = "Edit in progress ...";
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.Rows.Count - 1];
        }

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
                    int r = da.Update((DataTable)bindingSource1.DataSource);
                    MessageBox.Show("Added: " + ds.HasChanges(DataRowState.Added) + " rows");
                    messageBoardLbl.ResetText();
                    instantMessageBoardLbl.Text = "Saved! " + r + " row(s) affected.";
                    instantMessageBoardLbl.Show();
                    issueMessageBoardLbl.Hide();
                    saveBtn.Hide();
                    cancelBtn.Hide();
                    GetData(da.SelectCommand.CommandText);
                    editBtn.Show();
                    dataGridView1.ReadOnly = true;
                }
                catch (SqlException sqlEx)
                {
                    instantMessageBoardLbl.Text = "Insertion stopped on the red icon. Resolve rule's violation to insert the rest of the records.";
                    string messageIntro = "Rule affected: ";
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
                    }
                    instantMessageBoardLbl.ForeColor = Color.Red;
                    instantMessageBoardLbl.Show();
                    issueMessageBoardLbl.Show();
                }
            }
            else if (result == DialogResult.No)
            {
                messageBoardLbl.ResetText();
                MessageBox.Show("Not Saved");
                try
                {
                    GetData(da.SelectCommand.CommandText);
                    saveBtn.Hide();
                    cancelBtn.Hide();
                    editBtn.Show();
                }
                catch
                {
                    messageBoardLbl.Text = "Reloading from database failed";
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
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
                    messageBoardLbl.ResetText();
                    GetData(da.SelectCommand.CommandText);
                    saveBtn.Hide();
                    cancelBtn.Hide();
                    editBtn.Show();
                    dataGridView1.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void issueMessageBoardLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
