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
    public partial class toReplaceBuildings : Form
    {
        BindingSource bindingSource1 = new BindingSource();
        SqlDataAdapter da;

        public toReplaceBuildings()
        {
            InitializeComponent();
        }

        private void toReplaceBuildings_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Buildings order by buildingID");
            messageBoardLbl.ResetText();
            saveBtn.Hide();
            cancelBtn.Hide();
        }

        public void GetData(string selectCommand)
        {
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";
            da = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
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
                    messageBoardLbl.ResetText();
                    da.Update((DataTable)bindingSource1.DataSource);
                    MessageBox.Show("Saved");
                    saveBtn.Hide();
                    cancelBtn.Hide();
                    GetData(da.SelectCommand.CommandText);
                    editBtn.Show();
                    dataGridView1.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
    }
}
