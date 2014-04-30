namespace StartKoinoxristaProject
{
    partial class costPredefinedItems
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
            this.saveCostPredefinedItemsButton = new System.Windows.Forms.Button();
            this.costPredefinedItemsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.costPredefinedItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // saveCostPredefinedItemsButton
            // 
            this.saveCostPredefinedItemsButton.Location = new System.Drawing.Point(337, 241);
            this.saveCostPredefinedItemsButton.Name = "saveCostPredefinedItemsButton";
            this.saveCostPredefinedItemsButton.Size = new System.Drawing.Size(71, 23);
            this.saveCostPredefinedItemsButton.TabIndex = 5;
            this.saveCostPredefinedItemsButton.Text = "Save";
            this.saveCostPredefinedItemsButton.UseVisualStyleBackColor = true;
            // 
            // costPredefinedItemsDataGridView
            // 
            this.costPredefinedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costPredefinedItemsDataGridView.Location = new System.Drawing.Point(39, 55);
            this.costPredefinedItemsDataGridView.Name = "costPredefinedItemsDataGridView";
            this.costPredefinedItemsDataGridView.Size = new System.Drawing.Size(369, 150);
            this.costPredefinedItemsDataGridView.TabIndex = 6;
            // 
            // costPredefinedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 299);
            this.Controls.Add(this.costPredefinedItemsDataGridView);
            this.Controls.Add(this.saveCostPredefinedItemsButton);
            this.Controls.Add(this.label1);
            this.Name = "costPredefinedItems";
            this.Text = "Create New Cost Category / Cost Description";
            this.Load += new System.EventHandler(this.costPredefinedItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costPredefinedItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveCostPredefinedItemsButton;
        private System.Windows.Forms.DataGridView costPredefinedItemsDataGridView;
    }
}