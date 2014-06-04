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
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable dt = new DataTable();
        private string selectCommand;
        private string deleteCommand;
        SqlParameter parameter = new SqlParameter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";
            using(connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string selectedID = "753";
                selectCommand = "select * from dapanes where buildingID = @buildingID";
                deleteCommand = "delete from dapanes where buildingID = @buildingID";

                /*
                // create the command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = selectCommand;
                */

                //create the parameter
                parameter.ParameterName = "@buildingID";
                parameter.SqlDbType = SqlDbType.VarChar;
                parameter.Size = 3;
                parameter.Value = selectedID;

                /*
                //add the parameter into the command
                command.Parameters.Add(parameter);

                 * */

                //create the commands
                adapter.SelectCommand = new SqlCommand(selectCommand);
                adapter.SelectCommand.Connection = connection;

                adapter.DeleteCommand = new SqlCommand(deleteCommand);
                adapter.DeleteCommand.Connection = connection;

                //create the parameters
                adapter.SelectCommand.Parameters.Add(parameter);
                adapter.DeleteCommand.Parameters.Add("@buildingID", SqlDbType.VarChar, 3, "buildingID").SourceVersion = DataRowVersion.Original;

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                connection.Open();
                adapter.Update(dt);
            }
        }
    }
}
