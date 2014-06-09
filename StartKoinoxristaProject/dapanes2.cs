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
    public class dapanes2 : Handle
    {
        private Label label5;
        private Label label4;
        private Label BuildingArea;
        private Label BuildingAddress;
        private BindingSource bindingSource1 = new BindingSource();
        private ComboBox areaComboBox;
        private ComboBox addressComboBox;
        private Button exitBtn;
        private Button editBtn;
        private Button cancelBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Label messageBoardLbl;
        private Label instantMessageBoardLbl;
        private Label issueMessageBoardLbl;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private ComboBox[] filterControlItems;
        private string selectedID;
        private string selectCommand;
        private DataGridView dataGridView1;
        private string deleteCommand;
    
        private void InitializeComponent()
        {
            this.issueMessageBoardLbl = new System.Windows.Forms.Label();
            this.instantMessageBoardLbl = new System.Windows.Forms.Label();
            this.messageBoardLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuildingArea = new System.Windows.Forms.Label();
            this.BuildingAddress = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // issueMessageBoardLbl
            // 
            this.issueMessageBoardLbl.AutoSize = true;
            this.issueMessageBoardLbl.Location = new System.Drawing.Point(58, 481);
            this.issueMessageBoardLbl.Name = "issueMessageBoardLbl";
            this.issueMessageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.issueMessageBoardLbl.TabIndex = 33;
            this.issueMessageBoardLbl.Text = "label1";
            // 
            // instantMessageBoardLbl
            // 
            this.instantMessageBoardLbl.AutoSize = true;
            this.instantMessageBoardLbl.Location = new System.Drawing.Point(56, 453);
            this.instantMessageBoardLbl.Name = "instantMessageBoardLbl";
            this.instantMessageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.instantMessageBoardLbl.TabIndex = 32;
            this.instantMessageBoardLbl.Text = "label1";
            // 
            // messageBoardLbl
            // 
            this.messageBoardLbl.AutoSize = true;
            this.messageBoardLbl.Location = new System.Drawing.Point(56, 426);
            this.messageBoardLbl.Name = "messageBoardLbl";
            this.messageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.messageBoardLbl.TabIndex = 31;
            this.messageBoardLbl.Text = "label1";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(288, 438);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(395, 438);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(524, 438);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(395, 190);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(524, 190);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addressComboBox
            // 
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(263, 69);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(121, 21);
            this.addressComboBox.TabIndex = 25;
            this.addressComboBox.SelectedIndexChanged += new System.EventHandler(this.addressComboBox_SelectedIndexChanged);
            // 
            // areaComboBox
            // 
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(56, 70);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(121, 21);
            this.areaComboBox.TabIndex = 24;
            this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Month:";
            // 
            // BuildingArea
            // 
            this.BuildingArea.AutoSize = true;
            this.BuildingArea.Location = new System.Drawing.Point(53, 53);
            this.BuildingArea.Name = "BuildingArea";
            this.BuildingArea.Size = new System.Drawing.Size(32, 13);
            this.BuildingArea.TabIndex = 17;
            this.BuildingArea.Text = "Area:";
            // 
            // BuildingAddress
            // 
            this.BuildingAddress.AutoSize = true;
            this.BuildingAddress.Location = new System.Drawing.Point(260, 53);
            this.BuildingAddress.Name = "BuildingAddress";
            this.BuildingAddress.Size = new System.Drawing.Size(48, 13);
            this.BuildingAddress.TabIndex = 16;
            this.BuildingAddress.Text = "Address:";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(263, 138);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 34;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged_1);
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(62, 138);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 35;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(56, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // dapanes2
            // 
            this.ClientSize = new System.Drawing.Size(742, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.issueMessageBoardLbl);
            this.Controls.Add(this.instantMessageBoardLbl);
            this.Controls.Add(this.messageBoardLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addressComboBox);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuildingArea);
            this.Controls.Add(this.BuildingAddress);
            this.Name = "dapanes2";
            this.Load += new System.EventHandler(this.dapanes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public dapanes2(string connectionString)
        {
            InitializeComponent();
            InitializeButtons();

            //Αντιστοίχισή του DataGridView της base class με το DataTable της base class.
            DataGridView1.DataSource = Table;

            ConnectionString = connectionString;
            filterControlItems = new ComboBox[] { areaComboBox, addressComboBox, monthComboBox, yearComboBox };
            foreach(ComboBox c in filterControlItems)
            {
                c.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public void InitializeButtons()
        {
            // initialize the object's buttons
            DataGridView1 = dataGridView1;
            AreaComboBox = areaComboBox;
            AddressComboBox = addressComboBox;
            EditBtn = editBtn;
            ExitBtn = exitBtn;
            SaveBtn = saveBtn;
            DeleteBtn = deleteBtn;
            CancelBtn = cancelBtn;
            MessageBoardLbl = messageBoardLbl;
            InstantMessageBoardLbl = instantMessageBoardLbl;
            IssueMessageBoardLbl = issueMessageBoardLbl;
        }

        private void dapanes2_Load(object sender, EventArgs e)
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

        private void AreaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AddressComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            selectedID = RetrieveIdBasedOnLocation();
            cancel(selectCommand, deleteCommand, selectedID, monthComboBox.SelectedItem.ToString(), yearComboBox.SelectedItem.ToString());
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string duplicateID_message = "...";
            string blankField_message = "...";
            string max_characters_message = "...";

            save(duplicateID_message, blankField_message, max_characters_message);
        }

        private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            whileEditingControls(false);
            whileNotEditingControls(true);
            editBtn.Hide();
            dataGridView1.Hide();
            string queryString = "select bAddress from buildings where bArea = @parameter order by bAddress";
            fillTheComboBox(queryString, areaComboBox.SelectedItem.ToString());
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
        }

        private void monthComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex != -1)
            {
                dataGridView1.Show();
                whileNotEditingControls(true);
                selectedID = RetrieveIdBasedOnLocation();

                /*string selectCommand = "select buildingID, theMonth as Month, theYear as Year, costCategory as 'Cost Category'," +
                "costDescription as 'Cost Description', cost from dapanes" +
                "where buildingID = @selectedID and theMonth = '@theMonth' and theYear = @theYear order by theYear, theMonth";*/

                selectCommand = "select buildingID, theMonth as Month, theYear as Year, costCategory as 'Cost Category'," +
                "costDescription as 'Cost Description', cost from dapanes where buildingID = @buildingID and theMonth = @month and theYear = @year";
                deleteCommand = "delete from dapanes where buildingID = @buildingID and themonth = @theMonth and theYear = @theYear and costCategory = @costCategory" + 
                    " and costDescription = @costDescription";

                Adapter = SetAdapterCommands(selectCommand, deleteCommand, selectedID, monthComboBox.SelectedItem.ToString(), yearComboBox.SelectedItem.ToString());

                GetData();

                //DataGridView1.Columns["buildingID"].Visible = false;
                resetLabelsText();
                whileEditingControls(false);

                whileNotEditingControls(true);
            }
            else
            {
                dataGridView1.Hide();
            }
        }

        public SqlDataAdapter SetAdapterCommands(string selectCommand, string deleteCommand, string selectedID, string theMonth, string theYear)
        {
            //create the parameters for selectCommand
            SqlParameter param_ID = new SqlParameter();
            param_ID.ParameterName = "@buildingID";
            param_ID.SqlDbType = SqlDbType.VarChar;
            param_ID.Size = 3;
            param_ID.Value = selectedID;

            SqlParameter param_month = new SqlParameter();
            param_month.ParameterName = "@month";
            param_month.SqlDbType = SqlDbType.NVarChar;
            param_month.Size = 15;
            param_month.Value = theMonth;

            SqlParameter param_year = new SqlParameter();
            param_year.ParameterName = "@year";
            param_year.SqlDbType = SqlDbType.Int;
            param_year.Value = theYear;

            //create the parameters for deleteCommand
            SqlParameter param_deleteID = new SqlParameter();
            param_deleteID.ParameterName = "@buildingID";
            param_deleteID.SqlDbType = SqlDbType.VarChar;
            param_deleteID.Size = 3;
            param_deleteID.SourceColumn = "buildingID";
            param_deleteID.SourceVersion = DataRowVersion.Original;

            SqlParameter param_deleteMonth = new SqlParameter();
            param_deleteMonth.ParameterName = "@theMonth";
            param_deleteMonth.SqlDbType = SqlDbType.NVarChar;
            param_deleteMonth.Size = 15;
            param_deleteMonth.SourceColumn = "theMonth";
            param_deleteMonth.SourceVersion = DataRowVersion.Original;

            SqlParameter param_deleteYear = new SqlParameter();
            param_deleteYear.ParameterName = "@theYear";
            param_deleteYear.SqlDbType = SqlDbType.Int;
            param_deleteYear.SourceColumn = "theYear";
            param_deleteYear.SourceVersion = DataRowVersion.Original;

            SqlParameter param_deleteCategory = new SqlParameter();
            param_deleteCategory.ParameterName = "@costCategory";
            param_deleteCategory.SqlDbType = SqlDbType.NVarChar;
            param_deleteCategory.Size = 20;
            param_deleteCategory.SourceColumn = "costCategory";
            param_deleteCategory.SourceVersion = DataRowVersion.Original;

            SqlParameter param_deleteDescription = new SqlParameter();
            param_deleteDescription.ParameterName = "@costDescription";
            param_deleteDescription.SqlDbType = SqlDbType.NVarChar;
            param_deleteDescription.Size = 40;
            param_deleteDescription.SourceColumn = "costDescription";
            param_deleteDescription.SourceVersion = DataRowVersion.Original;

            /*command.Parameters.Add(param_ID);
            command.Parameters.Add(param_Month);
            command.Parameters.Add(param_Year);*/

            SqlDataAdapter da = new SqlDataAdapter();

            //create the commands
            da.SelectCommand = new SqlCommand(selectCommand);
            //da.SelectCommand.Connection = connection;

            da.DeleteCommand = new SqlCommand(deleteCommand);
            //da.DeleteCommand.Connection = connection;

            //create the parameters
            da.SelectCommand.Parameters.Add(param_ID);
            da.SelectCommand.Parameters.Add(param_month);
            da.SelectCommand.Parameters.Add(param_year);

            da.DeleteCommand.Parameters.Add(param_deleteID);
            da.DeleteCommand.Parameters.Add(param_deleteMonth);
            da.DeleteCommand.Parameters.Add(param_deleteYear);
            da.DeleteCommand.Parameters.Add(param_deleteCategory);
            da.DeleteCommand.Parameters.Add(param_deleteDescription);

            return da;
        }

        private void yearComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            monthComboBox.SelectedIndex = -1;
        }
    }
//}
