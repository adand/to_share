namespace StartKoinoxristaProject
{
    partial class Dapanes
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
            this.continueButton = new System.Windows.Forms.Button();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingAddress = new System.Windows.Forms.Label();
            this.BuildingArea = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.costCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.costCategoryLabel = new System.Windows.Forms.Label();
            this.costDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoxristaDataSet = new StartKoinoxristaProject.kinoxristaDataSet();
            this.costDescriptionLabel = new System.Windows.Forms.Label();
            this.costValueTextBox = new System.Windows.Forms.TextBox();
            this.costValueLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.alreadyInsertedCostDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.buildingsTableAdapter = new StartKoinoxristaProject.kinoxristaDataSetTableAdapters.BuildingsTableAdapter();
            this.buildingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alreadyInsertedCostDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(293, 167);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 5;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.DisplayMember = "test";
            this.AddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Location = new System.Drawing.Point(247, 49);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.AddressComboBox.TabIndex = 6;
            this.AddressComboBox.SelectedIndexChanged += new System.EventHandler(this.AddressComboBox_SelectedIndexChanged);
            // 
            // BuildingAddress
            // 
            this.BuildingAddress.AutoSize = true;
            this.BuildingAddress.Location = new System.Drawing.Point(244, 33);
            this.BuildingAddress.Name = "BuildingAddress";
            this.BuildingAddress.Size = new System.Drawing.Size(48, 13);
            this.BuildingAddress.TabIndex = 7;
            this.BuildingAddress.Text = "Address:";
            this.BuildingAddress.Click += new System.EventHandler(this.label4_Click);
            // 
            // BuildingArea
            // 
            this.BuildingArea.AutoSize = true;
            this.BuildingArea.Location = new System.Drawing.Point(37, 33);
            this.BuildingArea.Name = "BuildingArea";
            this.BuildingArea.Size = new System.Drawing.Size(32, 13);
            this.BuildingArea.TabIndex = 8;
            this.BuildingArea.Text = "Area:";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(40, 49);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(121, 21);
            this.AreaComboBox.TabIndex = 9;
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(40, 111);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 11;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // YearComboBox
            // 
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(247, 111);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 21);
            this.YearComboBox.TabIndex = 12;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Year:";
            // 
            // costCategoryComboBox
            // 
            this.costCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costCategoryComboBox.FormattingEnabled = true;
            this.costCategoryComboBox.Location = new System.Drawing.Point(515, 49);
            this.costCategoryComboBox.Name = "costCategoryComboBox";
            this.costCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.costCategoryComboBox.TabIndex = 15;
            this.costCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.costCategoryComboBox_SelectedIndexChanged);
            // 
            // costCategoryLabel
            // 
            this.costCategoryLabel.AutoSize = true;
            this.costCategoryLabel.Location = new System.Drawing.Point(512, 33);
            this.costCategoryLabel.Name = "costCategoryLabel";
            this.costCategoryLabel.Size = new System.Drawing.Size(76, 13);
            this.costCategoryLabel.TabIndex = 16;
            this.costCategoryLabel.Text = "Cost Category:";
            this.costCategoryLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // costDescriptionComboBox
            // 
            this.costDescriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.buildingsBindingSource, "BuildingID", true));
            this.costDescriptionComboBox.DisplayMember = "test";
            this.costDescriptionComboBox.FormattingEnabled = true;
            this.costDescriptionComboBox.Location = new System.Drawing.Point(700, 48);
            this.costDescriptionComboBox.Name = "costDescriptionComboBox";
            this.costDescriptionComboBox.Size = new System.Drawing.Size(303, 21);
            this.costDescriptionComboBox.TabIndex = 17;
            this.costDescriptionComboBox.Text = "Select a category from the list or type your own description";
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.kinoxristaDataSet;
            // 
            // kinoxristaDataSet
            // 
            this.kinoxristaDataSet.DataSetName = "kinoxristaDataSet";
            this.kinoxristaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costDescriptionLabel
            // 
            this.costDescriptionLabel.AutoSize = true;
            this.costDescriptionLabel.Location = new System.Drawing.Point(697, 32);
            this.costDescriptionLabel.Name = "costDescriptionLabel";
            this.costDescriptionLabel.Size = new System.Drawing.Size(87, 13);
            this.costDescriptionLabel.TabIndex = 18;
            this.costDescriptionLabel.Text = "Cost Description:";
            // 
            // costValueTextBox
            // 
            this.costValueTextBox.Location = new System.Drawing.Point(903, 90);
            this.costValueTextBox.Name = "costValueTextBox";
            this.costValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.costValueTextBox.TabIndex = 19;
            // 
            // costValueLabel
            // 
            this.costValueLabel.AutoSize = true;
            this.costValueLabel.Location = new System.Drawing.Point(866, 97);
            this.costValueLabel.Name = "costValueLabel";
            this.costValueLabel.Size = new System.Drawing.Size(31, 13);
            this.costValueLabel.TabIndex = 20;
            this.costValueLabel.Text = "Cost:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(515, 193);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(373, 13);
            this.messageLabel.TabIndex = 21;
            this.messageLabel.Text = "Ήδη καταχωρημένες δαπάνες πολυκατοικίας γι\' αυτή τη χρονική περίοδο";
            // 
            // alreadyInsertedCostDataGridView
            // 
            this.alreadyInsertedCostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alreadyInsertedCostDataGridView.Location = new System.Drawing.Point(518, 209);
            this.alreadyInsertedCostDataGridView.Name = "alreadyInsertedCostDataGridView";
            this.alreadyInsertedCostDataGridView.Size = new System.Drawing.Size(453, 150);
            this.alreadyInsertedCostDataGridView.TabIndex = 22;
            this.alreadyInsertedCostDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(928, 126);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsBindingSource1
            // 
            this.buildingsBindingSource1.DataMember = "Buildings";
            this.buildingsBindingSource1.DataSource = this.kinoxristaDataSet;
            // 
            // Dapanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 371);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.alreadyInsertedCostDataGridView);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.costValueLabel);
            this.Controls.Add(this.costValueTextBox);
            this.Controls.Add(this.costDescriptionLabel);
            this.Controls.Add(this.costDescriptionComboBox);
            this.Controls.Add(this.costCategoryLabel);
            this.Controls.Add(this.costCategoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.BuildingArea);
            this.Controls.Add(this.BuildingAddress);
            this.Controls.Add(this.AddressComboBox);
            this.Controls.Add(this.continueButton);
            this.Name = "Dapanes";
            this.Text = "Dapanes";
            this.Load += new System.EventHandler(this.Dapanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alreadyInsertedCostDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.ComboBox AddressComboBox;
        private System.Windows.Forms.Label BuildingAddress;
        private System.Windows.Forms.Label BuildingArea;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox costCategoryComboBox;
        private System.Windows.Forms.Label costCategoryLabel;
        private System.Windows.Forms.ComboBox costDescriptionComboBox;
        private System.Windows.Forms.Label costDescriptionLabel;
        private System.Windows.Forms.TextBox costValueTextBox;
        private System.Windows.Forms.Label costValueLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.DataGridView alreadyInsertedCostDataGridView;
        private System.Windows.Forms.Button saveButton;
        private kinoxristaDataSet kinoxristaDataSet;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private kinoxristaDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.BindingSource buildingsBindingSource1;

    }
}