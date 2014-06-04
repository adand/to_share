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
        private DataTable dt = new DataTable();
        private string selectCommand;
        private string deleteCommand;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        SqlParameter parameter = new SqlParameter();

        public Class1()
        {
            InitializeComponent();

            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";

            string selectedID = "753";
            string selectCommand = "select * from dapanes where buildingID = @buildingID";
            string deleteCommand = "delete from dapanes where buildingID = @buildingID";

            //create the parameter
            parameter.ParameterName = "@buildingID";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 3;
            parameter.Value = selectedID;
            parameter.SourceVersion = DataRowVersion.Original;

            adapter = new SqlDataAdapter();

            //create the commands
            adapter.SelectCommand = new SqlCommand(selectCommand);
            adapter.DeleteCommand = new SqlCommand(deleteCommand);

            //create the parameters
            adapter.SelectCommand.Parameters.Add(parameter);
            adapter.DeleteCommand.Parameters.Add("@buildingID", SqlDbType.VarChar, 3, "buildingID").SourceVersion = DataRowVersion.Original;
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
                adapter.SelectCommand.Connection = connection;
                adapter.DeleteCommand.Connection = connection;
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
                adapter.SelectCommand.Connection = connection;
                adapter.DeleteCommand.Connection = connection;
                adapter.Update(dt);
            }
        }
    }
//}
