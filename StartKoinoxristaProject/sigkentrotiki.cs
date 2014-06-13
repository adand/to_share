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
    public class sigkentrotiki : Handle
    {
        private Button exitBtn;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private ComboBox addressComboBox;
        private ComboBox areaComboBox;
        private Label label5;
        private Label label4;
        private Label BuildingArea;
        private Label BuildingAddress;
        private DataGridView dataGridView1;
        private string selectedID;
        private Button debtRegistrationBtn;
        private DataGridView dataGridView2;
        private ComboBox[] filterControlItems;

        public sigkentrotiki(string connectionString)
        {
            InitializeComponent();
            InitializeButtons();

            ConnectionString = connectionString;

            DataGridView1.DataSource = BindingSource1;

            filterControlItems = new ComboBox[] { areaComboBox, addressComboBox, monthComboBox, yearComboBox };
            foreach (ComboBox c in filterControlItems)
            {
                c.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuildingArea = new System.Windows.Forms.Label();
            this.BuildingAddress = new System.Windows.Forms.Label();
            this.debtRegistrationBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(896, 104);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(194, 125);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 43;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(395, 125);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 42;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // addressComboBox
            // 
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(395, 56);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(121, 21);
            this.addressComboBox.TabIndex = 41;
            this.addressComboBox.SelectedIndexChanged += new System.EventHandler(this.addressComboBox_SelectedIndexChanged);
            // 
            // areaComboBox
            // 
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(188, 57);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(121, 21);
            this.areaComboBox.TabIndex = 40;
            this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Month:";
            // 
            // BuildingArea
            // 
            this.BuildingArea.AutoSize = true;
            this.BuildingArea.Location = new System.Drawing.Point(185, 40);
            this.BuildingArea.Name = "BuildingArea";
            this.BuildingArea.Size = new System.Drawing.Size(32, 13);
            this.BuildingArea.TabIndex = 37;
            this.BuildingArea.Text = "Area:";
            // 
            // BuildingAddress
            // 
            this.BuildingAddress.AutoSize = true;
            this.BuildingAddress.Location = new System.Drawing.Point(392, 40);
            this.BuildingAddress.Name = "BuildingAddress";
            this.BuildingAddress.Size = new System.Drawing.Size(48, 13);
            this.BuildingAddress.TabIndex = 36;
            this.BuildingAddress.Text = "Address:";
            // 
            // debtRegistrationBtn
            // 
            this.debtRegistrationBtn.Location = new System.Drawing.Point(741, 104);
            this.debtRegistrationBtn.Name = "debtRegistrationBtn";
            this.debtRegistrationBtn.Size = new System.Drawing.Size(108, 23);
            this.debtRegistrationBtn.TabIndex = 44;
            this.debtRegistrationBtn.Text = "debt registration";
            this.debtRegistrationBtn.UseVisualStyleBackColor = true;
            this.debtRegistrationBtn.Click += new System.EventHandler(this.debtRegistrationBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(741, 164);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(310, 279);
            this.dataGridView2.TabIndex = 45;
            // 
            // sigkentrotiki
            // 
            this.ClientSize = new System.Drawing.Size(1219, 486);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.debtRegistrationBtn);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.addressComboBox);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuildingArea);
            this.Controls.Add(this.BuildingAddress);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sigkentrotiki";
            this.Load += new System.EventHandler(this.sigkentrotiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void InitializeButtons()
        {
            // initialize the object's buttons
            DataGridView1 = dataGridView1;
            AreaComboBox = areaComboBox;
            AddressComboBox = addressComboBox;
            ExitBtn = exitBtn;
        }

        private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            string queryString = "select bAddress from buildings where bArea = @parameter order by bAddress";
            fillTheComboBox(queryString, areaComboBox.SelectedItem.ToString());
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
        }

        private void addressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.SelectedIndex = -1;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex != -1)
            {
                dataGridView1.Show();
                selectedID = RetrieveIdBasedOnLocation();

                string selectQuery = 
                    "select apartmentID as 'Apartment ID', " +
                        "generalProportion as 'General Proportion', " + 
                        "(select sum(cost) * ( A1.generalProportion / 1000 ) " +
                        "from dapanes A2 " + 
                        "where theMonth = @theMonth and theYear = @theYear and A2.buildingID = A1.buildingID and costCategory = N'Γενικά κοινόχρηστα') Cost1, " +
                        "elevatorProportion as 'Elevator Proportion', " +
                        "(select sum(cost) * ( A1.elevatorProportion / 1000 ) " +
                        "from dapanes A3 " +
                        "where theMonth = @theMonth and theYear = @theYear and A3.buildingID = A1.buildingID and costCategory = N'Ασανσέρ') Cost2 " +
                    "from Apartments A1 " + 
                    "where A1.buildingID = @buildingID";

                SqlConnection connection = new SqlConnection(ConnectionString);

                SqlCommand selectCommand = new SqlCommand();
                selectCommand.CommandText = selectQuery;
                selectCommand.Connection = connection;

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@buildingID";
                parameter1.SqlDbType = SqlDbType.VarChar;
                parameter1.SourceColumn = "buildingID";
                parameter1.Value = selectedID;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@theMonth";
                parameter2.SqlDbType = SqlDbType.NVarChar;
                parameter2.SourceColumn = "theMonth";
                parameter2.Value = monthComboBox.SelectedItem.ToString();

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@theYear";
                parameter3.SqlDbType = SqlDbType.VarChar;
                parameter3.SourceColumn = "theYear";
                parameter3.Value = yearComboBox.SelectedItem.ToString();

                selectCommand.Parameters.Add(parameter1);
                selectCommand.Parameters.Add(parameter2);
                selectCommand.Parameters.Add(parameter3);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = selectCommand;

                //GetData(da);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                /*var query =
                    from table in dt.AsEnumerable()
                    select new
                    {
                        apID = table.Field<string>("Apartment ID")
                    };*/

                DataView view = new DataView(dt);

                string[] columnNames = {"Apartment ID", "Cost1"};

                DataTable dt2 = view.ToTable(false, columnNames);
                dt2.Columns.Add("Month");

                foreach(DataRow row in dt2.Rows)
                {
                    row[2] = "true";
                }

                MessageBox.Show(dt2.Columns.Count.ToString());
                dataGridView2.DataSource = dt2;

                /*
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = selectCommand;

                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                Adapter = da;

                GetData2();
                 * */
            }
            else
            {
                dataGridView1.Hide();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void sigkentrotiki_Load(object sender, EventArgs e)
        {
            string[] monthNames = { "Ιανουάριος", "Φεβρουάριος", "Μάρτιος", "Απρίλιος", "Μάιος", "Ιούνιος", "Ιούλιος", "Αύγουστος", "Σεπτέμβριος", "Οκτώβριος",
                                  "Νοέμβριος", "Δεκέμβριος" };
            monthComboBox.Items.AddRange(monthNames);

            for (int i = 2010; i < 2050; i++)
            {
                yearComboBox.Items.Add(i);
            }
            dataGridView1.Hide();
        }

        private void debtRegistrationBtn_Click(object sender, EventArgs e)
        {

        }
    }
//}
