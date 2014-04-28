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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingAddress = new System.Windows.Forms.Label();
            this.BuildingArea = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.showBuildingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Διεύθυνση:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Παρακαλώ εισάγετε τα στοιχεία της πολυκατοικίας για την οποία θα καταχωρήσετε δαπ" +
    "άνη";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Περιοχή:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(121, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 30);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Location = new System.Drawing.Point(40, 49);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.AddressComboBox.TabIndex = 6;
            this.AddressComboBox.SelectedIndexChanged += new System.EventHandler(this.AddressComboBox_SelectedIndexChanged);
            // 
            // BuildingAddress
            // 
            this.BuildingAddress.AutoSize = true;
            this.BuildingAddress.Location = new System.Drawing.Point(37, 33);
            this.BuildingAddress.Name = "BuildingAddress";
            this.BuildingAddress.Size = new System.Drawing.Size(63, 13);
            this.BuildingAddress.TabIndex = 7;
            this.BuildingAddress.Text = "Διεύθυνση:";
            this.BuildingAddress.Click += new System.EventHandler(this.label4_Click);
            // 
            // BuildingArea
            // 
            this.BuildingArea.AutoSize = true;
            this.BuildingArea.Location = new System.Drawing.Point(244, 33);
            this.BuildingArea.Name = "BuildingArea";
            this.BuildingArea.Size = new System.Drawing.Size(50, 13);
            this.BuildingArea.TabIndex = 8;
            this.BuildingArea.Text = "Περιοχή:";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(247, 49);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(121, 21);
            this.AreaComboBox.TabIndex = 9;
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
            // 
            // showBuildingButton
            // 
            this.showBuildingButton.Location = new System.Drawing.Point(40, 152);
            this.showBuildingButton.Name = "showBuildingButton";
            this.showBuildingButton.Size = new System.Drawing.Size(105, 39);
            this.showBuildingButton.TabIndex = 10;
            this.showBuildingButton.Text = "show buildings [1][2]";
            this.showBuildingButton.UseVisualStyleBackColor = true;
            this.showBuildingButton.Click += new System.EventHandler(this.showBuildingButton_Click);
            // 
            // Dapanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 322);
            this.Controls.Add(this.showBuildingButton);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.BuildingArea);
            this.Controls.Add(this.BuildingAddress);
            this.Controls.Add(this.AddressComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dapanes";
            this.Text = "Dapanes";
            this.Load += new System.EventHandler(this.Dapanes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox AddressComboBox;
        private System.Windows.Forms.Label BuildingAddress;
        private System.Windows.Forms.Label BuildingArea;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Button showBuildingButton;

    }
}