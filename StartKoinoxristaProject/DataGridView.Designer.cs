namespace StartKoinoxristaProject
{
    partial class DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneralMM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevatorMM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveApartments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApartmentID,
            this.FullName,
            this.GeneralMM,
            this.ElevatorMM,
            this.Manager});
            this.dataGridView1.Location = new System.Drawing.Point(51, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ApartmentID
            // 
            this.ApartmentID.HeaderText = "ApartmentID";
            this.ApartmentID.Name = "ApartmentID";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // GeneralMM
            // 
            this.GeneralMM.HeaderText = "GeneralMM";
            this.GeneralMM.Name = "GeneralMM";
            // 
            // ElevatorMM
            // 
            this.ElevatorMM.HeaderText = "ElevatorMM";
            this.ElevatorMM.Name = "ElevatorMM";
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Manager";
            this.Manager.Name = "Manager";
            // 
            // SaveApartments
            // 
            this.SaveApartments.Location = new System.Drawing.Point(519, 244);
            this.SaveApartments.Name = "SaveApartments";
            this.SaveApartments.Size = new System.Drawing.Size(75, 23);
            this.SaveApartments.TabIndex = 1;
            this.SaveApartments.Text = "Save";
            this.SaveApartments.UseVisualStyleBackColor = true;
            this.SaveApartments.Click += new System.EventHandler(this.SaveApartments_Click);
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 343);
            this.Controls.Add(this.SaveApartments);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridView";
            this.Text = "DataGridView";
            this.Load += new System.EventHandler(this.DataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralMM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevatorMM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.Button SaveApartments;
    }
}