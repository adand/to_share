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
    class Class2 : Form
    {
        private string connectionString;
        private Button loadBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button exitBtn;
        private DataGridView dataGridView1;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable dt;

        public Class2()
        {
            InitializeComponent();

            //define the connection string
            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";

            //create the connection
            SqlConnection connection = new SqlConnection(connectionString);

            //define the query for the select command
            string selectQuery = "select * from dapanes where theMonth = @theMonth and theYear = @theYear";

            //create the select command
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = selectQuery;
            selectCommand.Connection = connection;

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

            //create the DataAdapter
            SqlDataAdapter da = new SqlDataAdapter();

            //create the select command of the DataAdapter
            da.SelectCommand = selectCommand;

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            adapter = da;
        }

        private void InitializeComponent()
        {
            this.loadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(122, 58);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(250, 58);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(400, 57);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(539, 57);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 209);
            this.dataGridView1.TabIndex = 4;
            // 
            // Class2
            // 
            this.ClientSize = new System.Drawing.Size(861, 395);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadBtn);
            this.Name = "Class2";
            this.Text = "Class 2";
            this.Load += new System.EventHandler(this.Class2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Class2_Load(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {*/
                adapter.Update(dt);
            //}
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
//}
