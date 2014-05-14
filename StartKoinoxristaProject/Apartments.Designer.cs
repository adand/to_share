namespace StartKoinoxristaProject
{
    partial class Apartments
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.messageBoardLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.instantMessageBoardLbl = new System.Windows.Forms.Label();
            this.issueMessageBoardLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(678, 61);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(678, 344);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // messageBoardLbl
            // 
            this.messageBoardLbl.AutoSize = true;
            this.messageBoardLbl.Location = new System.Drawing.Point(136, 341);
            this.messageBoardLbl.Name = "messageBoardLbl";
            this.messageBoardLbl.Size = new System.Drawing.Size(80, 13);
            this.messageBoardLbl.TabIndex = 3;
            this.messageBoardLbl.Text = "Message board";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(678, 344);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(597, 344);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // instantMessageBoardLbl
            // 
            this.instantMessageBoardLbl.AutoSize = true;
            this.instantMessageBoardLbl.Location = new System.Drawing.Point(131, 374);
            this.instantMessageBoardLbl.Name = "instantMessageBoardLbl";
            this.instantMessageBoardLbl.Size = new System.Drawing.Size(109, 13);
            this.instantMessageBoardLbl.TabIndex = 6;
            this.instantMessageBoardLbl.Text = "instantMessageBoard";
            // 
            // issueMessageBoardLbl
            // 
            this.issueMessageBoardLbl.AutoSize = true;
            this.issueMessageBoardLbl.Location = new System.Drawing.Point(131, 387);
            this.issueMessageBoardLbl.Name = "issueMessageBoardLbl";
            this.issueMessageBoardLbl.Size = new System.Drawing.Size(102, 13);
            this.issueMessageBoardLbl.TabIndex = 7;
            this.issueMessageBoardLbl.Text = "issueMessageBoard";
            this.issueMessageBoardLbl.Click += new System.EventHandler(this.issueMessageBoardLbl_Click);
            // 
            // Apartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 478);
            this.Controls.Add(this.issueMessageBoardLbl);
            this.Controls.Add(this.instantMessageBoardLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.messageBoardLbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Apartments";
            this.Text = "Apartments";
            this.Load += new System.EventHandler(this.Apartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label messageBoardLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label instantMessageBoardLbl;
        private System.Windows.Forms.Label issueMessageBoardLbl;

    }
}