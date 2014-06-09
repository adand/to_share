using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*namespace StartKoinoxristaProject
{*/
    class Class1 : Form
    {
        string connectionString;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        SqlParameter parameter = new SqlParameter();

        public Class1()
        {
            InitializeComponent();
            /*
            string selectedID = "751";
            string deleteCommand = "delete from dapanes where buildingID = @buildingID"/* and theMonth = @theMonth and theYear = @theYear" + 
                " and costCategory = @costCategory and costDescription = @costDescription";
            */

            //define the connection string
            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";

            //create the connection
            SqlConnection connection = new SqlConnection(connectionString);

            //define the query for the select command
            string selectQuery = "select * from dapanes where theMonth = @theMonth and theYear = @theYear";

            //define the query for the update command
            string updateQuery = "update dapanes set buildingID = @buildingID, cost = @cost where buildingID = @oldBuildingID";

            //define the query for the delete command
            string deleteQuery = "delete from dapanes where buildingID = @oldBuildingID";

            //define the query for the insert command
            string insertQuery = "insert into dapanes values (@buildingID, @theMonth, @theYear, @costCategory, @costDescription, @cost)";

            //create the select command
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = selectQuery;
            selectCommand.Connection = connection;

            //create the update command
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = updateQuery;
            updateCommand.Connection = connection;

            //create the delete command
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.CommandText = deleteQuery;
            deleteCommand.Connection = connection;

            //create the insert command
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = insertQuery;
            insertCommand.Connection = connection;

            //create the parameter of the select command
            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@theMonth";
            parameter1.SqlDbType = SqlDbType.NVarChar;
            parameter1.Value = "Απρίλιος";

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@theYear";
            parameter2.SqlDbType = SqlDbType.Int;
            parameter2.Value = 2014;

            //add the parameter to the select command
            selectCommand.Parameters.Add(parameter1);
            selectCommand.Parameters.Add(parameter2);

            //create the parameter of the select command
            SqlParameter parameter3 = new SqlParameter();
            parameter3.ParameterName = "@buildingID";
            parameter3.SqlDbType = SqlDbType.VarChar;
            parameter3.SourceColumn = "buildingID";

            SqlParameter parameter4 = new SqlParameter();
            parameter4.ParameterName = "@cost";
            parameter4.SqlDbType = SqlDbType.SmallMoney;
            parameter4.SourceColumn = "cost";

            SqlParameter parameter5 = new SqlParameter();
            parameter5.ParameterName = "@oldBuildingID";
            parameter5.SqlDbType = SqlDbType.VarChar;
            parameter5.SourceColumn = "buildingID";
            parameter5.SourceVersion = DataRowVersion.Original;

            SqlParameter parameter6 = new SqlParameter();
            parameter6.ParameterName = "@oldBuildingID";
            parameter6.SqlDbType = SqlDbType.VarChar;
            parameter6.SourceColumn = "buildingID";
            parameter6.SourceVersion = DataRowVersion.Original;

            //add the parameter to the update command
            updateCommand.Parameters.Add(parameter3);
            updateCommand.Parameters.Add(parameter4);
            updateCommand.Parameters.Add(parameter5);

            //add the parameter to the delete command
            deleteCommand.Parameters.Add(parameter6);

            // add the parameters to the insert command
            insertCommand.Parameters.Add("@buildingID", SqlDbType.VarChar, 3, "buildingID");
            insertCommand.Parameters.Add("@theMonth", SqlDbType.NVarChar, 15, "theMonth");
            insertCommand.Parameters.Add("@theYear", SqlDbType.Int, 10, "theYear");
            insertCommand.Parameters.Add("@costCategory", SqlDbType.NVarChar, 20, "costCategory");
            insertCommand.Parameters.Add("@costDescription", SqlDbType.NVarChar, 40, "costDescription");
            insertCommand.Parameters.Add("@cost", SqlDbType.SmallMoney, 10, "cost");

            /*
            //create the parameter
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@buildingID";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 3;
            parameter.Value = selectedID;

            SqlParameter delparamID = new SqlParameter();
            delparamID.ParameterName = "@buildingID";
            delparamID.SqlDbType = SqlDbType.VarChar;
            delparamID.Size = 3;
            delparamID.SourceColumn = "buildingID";
            delparamID.SourceVersion = DataRowVersion.Original;

            SqlParameter delparamMonth = new SqlParameter();
            delparamID.ParameterName = "@theMonth";
            delparamID.SqlDbType = SqlDbType.NVarChar;
            delparamID.Size = 15;
            delparamID.SourceColumn = "theMonth";
            delparamID.SourceVersion = DataRowVersion.Original;

            SqlParameter delparamYear = new SqlParameter();
            delparamID.ParameterName = "@theYear";
            delparamID.SqlDbType = SqlDbType.VarChar;
            delparamID.Size = 3;
            delparamID.SourceColumn = "theYear";
            delparamID.SourceVersion = DataRowVersion.Original;

            SqlParameter delparamCategory = new SqlParameter();
            delparamID.ParameterName = "@costCategory";
            delparamID.SqlDbType = SqlDbType.NVarChar;
            delparamID.Size = 20;
            delparamID.SourceColumn = "costCategory";
            delparamID.SourceVersion = DataRowVersion.Original;

            SqlParameter delparamDescription = new SqlParameter();
            delparamID.ParameterName = "@costDescription";
            delparamID.SqlDbType = SqlDbType.NVarChar;
            delparamID.Size = 40;
            delparamID.SourceColumn = "costDescription";
            delparamID.SourceVersion = DataRowVersion.Original;
            */

            //create the DataAdapter
            adapter = new SqlDataAdapter();

            //create the select command of the DataAdapter
            adapter.SelectCommand = selectCommand;

            //create the update command of the DataAdapter
            adapter.UpdateCommand = updateCommand;

            //create the delete command of the DataAdapter
            adapter.DeleteCommand = deleteCommand;

            //create the insert command of the DataAdapter
            adapter.InsertCommand = insertCommand;

            /*
            //create the parameters
            adapter.SelectCommand.Parameters.Add(parameter);

            adapter.DeleteCommand.Parameters.Add(delparamID);
            adapter.DeleteCommand.Parameters.Add(delparamMonth);
            adapter.DeleteCommand.Parameters.Add(delparamYear);
            adapter.DeleteCommand.Parameters.Add(delparamCategory);
            adapter.DeleteCommand.Parameters.Add(delparamDescription);
             * */
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Class1
            // 
            this.ClientSize = new System.Drawing.Size(1047, 411);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Class1";
            this.Load += new System.EventHandler(this.Class1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Class1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter.Update(dt);
            }
        }
    }
//}
