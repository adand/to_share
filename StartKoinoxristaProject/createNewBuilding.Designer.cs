namespace StartKoinoxristaProject
{
    partial class createNewBuildingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BuildingIDTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.kinoxristaDataSet = new StartKoinoxristaProject.kinoxristaDataSet();
            this.kinoxristaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Manager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ElevatorMM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneralMM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.clearBuildingsTableButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.buildingDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildingIDTextBox
            // 
            this.BuildingIDTextBox.Location = new System.Drawing.Point(16, 38);
            this.BuildingIDTextBox.Name = "BuildingIDTextBox";
            this.BuildingIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.BuildingIDTextBox.TabIndex = 0;
            this.BuildingIDTextBox.TextChanged += new System.EventHandler(this.BuildingIDTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(219, 38);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(128, 20);
            this.AddressTextBox.TabIndex = 1;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(417, 38);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(112, 20);
            this.AreaTextBox.TabIndex = 2;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.AreaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Building ID: (1-3 characters)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address: (1-20 characters)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area: (1-15 characters)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(530, 341);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // buildingDetailsGroupBox
            // 
            this.buildingDetailsGroupBox.Controls.Add(this.label2);
            this.buildingDetailsGroupBox.Controls.Add(this.BuildingIDTextBox);
            this.buildingDetailsGroupBox.Controls.Add(this.label3);
            this.buildingDetailsGroupBox.Controls.Add(this.AddressTextBox);
            this.buildingDetailsGroupBox.Controls.Add(this.AreaTextBox);
            this.buildingDetailsGroupBox.Controls.Add(this.label1);
            this.buildingDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingDetailsGroupBox.Location = new System.Drawing.Point(44, 26);
            this.buildingDetailsGroupBox.Name = "buildingDetailsGroupBox";
            this.buildingDetailsGroupBox.Size = new System.Drawing.Size(561, 74);
            this.buildingDetailsGroupBox.TabIndex = 8;
            this.buildingDetailsGroupBox.TabStop = false;
            this.buildingDetailsGroupBox.Text = "Building";
            // 
            // kinoxristaDataSet
            // 
            this.kinoxristaDataSet.DataSetName = "kinoxristaDataSet";
            this.kinoxristaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kinoxristaDataSetBindingSource
            // 
            this.kinoxristaDataSetBindingSource.DataSource = this.kinoxristaDataSet;
            this.kinoxristaDataSetBindingSource.Position = 0;
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Manager";
            this.Manager.Name = "Manager";
            // 
            // ElevatorMM
            // 
            this.ElevatorMM.HeaderText = "ElevatorMM";
            this.ElevatorMM.Name = "ElevatorMM";
            // 
            // GeneralMM
            // 
            this.GeneralMM.HeaderText = "GeneralMM";
            this.GeneralMM.Name = "GeneralMM";
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Full_Name";
            this.Full_Name.Name = "Full_Name";
            // 
            // ApartmentID
            // 
            this.ApartmentID.HeaderText = "ApartmentID";
            this.ApartmentID.Name = "ApartmentID";
            // 
            // apartmentDetailsDataGridView
            // 
            this.apartmentDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartmentDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApartmentID,
            this.Full_Name,
            this.GeneralMM,
            this.ElevatorMM,
            this.Manager});
            this.apartmentDetailsDataGridView.Location = new System.Drawing.Point(44, 135);
            this.apartmentDetailsDataGridView.Name = "apartmentDetailsDataGridView";
            this.apartmentDetailsDataGridView.Size = new System.Drawing.Size(561, 189);
            this.apartmentDetailsDataGridView.TabIndex = 9;
            this.apartmentDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clearBuildingsTableButton
            // 
            this.clearBuildingsTableButton.Location = new System.Drawing.Point(44, 341);
            this.clearBuildingsTableButton.Name = "clearBuildingsTableButton";
            this.clearBuildingsTableButton.Size = new System.Drawing.Size(227, 23);
            this.clearBuildingsTableButton.TabIndex = 10;
            this.clearBuildingsTableButton.Text = "clear the database table Bulidings";
            this.clearBuildingsTableButton.UseVisualStyleBackColor = true;
            this.clearBuildingsTableButton.Click += new System.EventHandler(this.ClearBuildingsTable_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(530, 106);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // createNewBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 376);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.clearBuildingsTableButton);
            this.Controls.Add(this.apartmentDetailsDataGridView);
            this.Controls.Add(this.buildingDetailsGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "createNewBuildingForm";
            this.Text = "Create New Building";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.buildingDetailsGroupBox.ResumeLayout(false);
            this.buildingDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BuildingIDTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox buildingDetailsGroupBox;
        private System.Windows.Forms.BindingSource kinoxristaDataSetBindingSource;
        private kinoxristaDataSet kinoxristaDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevatorMM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralMM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentID;
        private System.Windows.Forms.DataGridView apartmentDetailsDataGridView;
        private System.Windows.Forms.Button clearBuildingsTableButton;
        private System.Windows.Forms.Button continueButton;

    }
}