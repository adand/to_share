namespace StartKoinoxristaProject
{
    partial class Form3
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
            this.kinoxristaDataSet = new StartKoinoxristaProject.kinoxristaDataSet();
            this.kinoxristaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
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
            // DataGrid1
            // 
            this.DataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Location = new System.Drawing.Point(60, 21);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(656, 228);
            this.DataGrid1.TabIndex = 0;
            this.DataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAuthorTitles_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGrid1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bound DataSet";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoxristaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kinoxristaDataSet kinoxristaDataSet;
        private System.Windows.Forms.BindingSource kinoxristaDataSetBindingSource;
        private System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.Button button1;

    }
}