using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

/*namespace StartKoinoxristaProject
{*/
    class Apart : Handle
    {
        private System.Windows.Forms.DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private System.Windows.Forms.Button exitBtn = new Button();
        private System.Windows.Forms.Button editBtn = new Button();
        private System.Windows.Forms.Button saveBtn = new Button();
        private System.Windows.Forms.Button deleteBtn = new Button();
        private System.Windows.Forms.Button cancelBtn = new Button();
        private System.Windows.Forms.Label messageBoardLbl = new Label();
        private System.Windows.Forms.Label instantMessageBoardLbl = new Label();
        private System.Windows.Forms.Label issueMessageBoardLbl = new Label();
        private System.Windows.Forms.Label label4 = new Label();
        private System.Windows.Forms.Label label5 = new Label();
        private System.Windows.Forms.ComboBox filterComboBox = new ComboBox();
        private System.Windows.Forms.ComboBox filteredComboBox = new ComboBox();
        private System.Windows.Forms.Label areaLbl = new Label();
        private System.Windows.Forms.Label addressLbl = new Label();
        private ComboBox[] filterControlItems;

        public Apart()
        {
            InitializeComponent();
            InitializeButtons();
            dataGridView1.DataSource = bindingSource1;
        }

        public Apart(string connectionString)
        {
            InitializeComponent();
            InitializeButtons();
            dataGridView1.DataSource = bindingSource1;

            ConnectionString = connectionString;
            filterControlItems = new ComboBox[] {filterComboBox, filteredComboBox};
            foreach(ComboBox c in filterControlItems)
            {
                c.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public void InitializeButtons()
        {
            // initialize the object's buttons
            DataGridView1 = dataGridView1;
            FilterComboBox = filterComboBox;
            FilteredComboBox = filteredComboBox;
            EditBtn = editBtn;
            ExitBtn = exitBtn;
            SaveBtn = saveBtn;
            DeleteBtn = deleteBtn;
            CancelBtn = cancelBtn;
            MessageBoardLbl = messageBoardLbl;
            InstantMessageBoardLbl = instantMessageBoardLbl;
            IssueMessageBoardLbl = issueMessageBoardLbl;
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.messageBoardLbl = new System.Windows.Forms.Label();
            this.instantMessageBoardLbl = new System.Windows.Forms.Label();
            this.issueMessageBoardLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filteredComboBox = new System.Windows.Forms.ComboBox();
            this.areaLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(565, 45);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(469, 46);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(306, 319);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(411, 319);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(510, 319);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // messageBoardLbl
            // 
            this.messageBoardLbl.AutoSize = true;
            this.messageBoardLbl.Location = new System.Drawing.Point(113, 319);
            this.messageBoardLbl.Name = "messageBoardLbl";
            this.messageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.messageBoardLbl.TabIndex = 6;
            this.messageBoardLbl.Text = "label1";
            // 
            // instantMessageBoardLbl
            // 
            this.instantMessageBoardLbl.AutoSize = true;
            this.instantMessageBoardLbl.Location = new System.Drawing.Point(113, 344);
            this.instantMessageBoardLbl.Name = "instantMessageBoardLbl";
            this.instantMessageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.instantMessageBoardLbl.TabIndex = 7;
            this.instantMessageBoardLbl.Text = "label2";
            // 
            // issueMessageBoardLbl
            // 
            this.issueMessageBoardLbl.AutoSize = true;
            this.issueMessageBoardLbl.Location = new System.Drawing.Point(113, 368);
            this.issueMessageBoardLbl.Name = "issueMessageBoardLbl";
            this.issueMessageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.issueMessageBoardLbl.TabIndex = 8;
            this.issueMessageBoardLbl.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(116, 46);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 11;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filteredComboBox
            // 
            this.filteredComboBox.FormattingEnabled = true;
            this.filteredComboBox.Location = new System.Drawing.Point(286, 46);
            this.filteredComboBox.Name = "filteredComboBox";
            this.filteredComboBox.Size = new System.Drawing.Size(121, 21);
            this.filteredComboBox.TabIndex = 12;
            this.filteredComboBox.SelectedIndexChanged += new System.EventHandler(this.filteredComboBox_SelectedIndexChanged);
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(116, 27);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(32, 13);
            this.areaLbl.TabIndex = 13;
            this.areaLbl.Text = "Area:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(286, 27);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(48, 13);
            this.addressLbl.TabIndex = 14;
            this.addressLbl.Text = "Address:";
            // 
            // Apart
            // 
            this.ClientSize = new System.Drawing.Size(729, 457);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.filteredComboBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.issueMessageBoardLbl);
            this.Controls.Add(this.instantMessageBoardLbl);
            this.Controls.Add(this.messageBoardLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Apart";
            this.Load += new System.EventHandler(this.Apart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            editBtn.Hide();
            string queryString = "select bAddress from buildings where bArea = @parameter order by bAddress";
            string columnTitle = "bAddress";
            fillTheComboBox(queryString, columnTitle, filterComboBox.SelectedItem.ToString());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void filteredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Show();
            whileNotEditingControls(true);
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select buildingID from buildings where bArea = @Area and bAddress = @Address";

                SqlParameter param_area = new SqlParameter();
                param_area.ParameterName = "@Area";
                param_area.SqlDbType = SqlDbType.NVarChar;
                param_area.Value = filterComboBox.SelectedItem.ToString();

                SqlParameter param_address = new SqlParameter();
                param_address.ParameterName = "@Address";
                param_address.SqlDbType = SqlDbType.NVarChar;
                param_address.Value = filteredComboBox.SelectedItem.ToString();

                command.Parameters.Add(param_area);
                command.Parameters.Add(param_address);

                connection.Open();
                string selectedID = command.ExecuteScalar().ToString();

                dataGridView1.DataSource = bindingSource1;
                GetData(string.Format("select buildingID, owner as Owner, apartmentID as 'Apartment ID', generalProportion as 'General Proportion (‰)', " +
                "elevatorProportion as 'Elevator Proportion (‰)' from Apartments where buildingID = '{0}' order by apartmentID", selectedID));
                dataGridView1.Columns["buildingID"].Visible = false;
                resetLabelsText();
                whileEditingControls(false);

                whileNotEditingControls(true);
            }
        }

        private void Apart_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            edit();
            enableFilterControls(false);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancel();
            enableFilterControls(true);
        }

        private void enableFilterControls(bool enableStatus)
        {
            foreach(Control c in filterControlItems)
            {
                if (enableStatus)
                {
                    c.Enabled = true;
                }
                else
                {
                    c.Enabled = false;
                }
            }
        }
    }
//}
