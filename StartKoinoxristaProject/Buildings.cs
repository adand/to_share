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
    public class Buildings : Handle
    {
        private DataGridView dataGridView2;
        private Button exitBtn;
        private Button editBtn;
        private Button cancelBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Label messageBoardLbl;
        private Label instantMessageBoardLbl;
        private Label issueMessageBoardLbl;
        private DataGridView dataGridView1 = new DataGridView();

        public Buildings()
        {
            InitializeComponent();
        }

        public Buildings(string queryString)
        {
            InitializeComponent();
            DataGridView1 = dataGridView2;
            GetData(queryString);

            InitializeButtons();
            whileEditingControls(false);
        }

        public void InitializeButtons()
        {
            // initialize the object's buttons
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.messageBoardLbl = new System.Windows.Forms.Label();
            this.instantMessageBoardLbl = new System.Windows.Forms.Label();
            this.issueMessageBoardLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(133, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(509, 236);
            this.dataGridView2.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(567, 39);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(486, 39);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(567, 310);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(486, 310);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(405, 310);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // messageBoardLbl
            // 
            this.messageBoardLbl.AutoSize = true;
            this.messageBoardLbl.Location = new System.Drawing.Point(130, 307);
            this.messageBoardLbl.Name = "messageBoardLbl";
            this.messageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.messageBoardLbl.TabIndex = 8;
            this.messageBoardLbl.Text = "label1";
            // 
            // instantMessageBoardLbl
            // 
            this.instantMessageBoardLbl.AutoSize = true;
            this.instantMessageBoardLbl.Location = new System.Drawing.Point(130, 335);
            this.instantMessageBoardLbl.Name = "instantMessageBoardLbl";
            this.instantMessageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.instantMessageBoardLbl.TabIndex = 9;
            this.instantMessageBoardLbl.Text = "label2";
            // 
            // issueMessageBoardLbl
            // 
            this.issueMessageBoardLbl.AutoSize = true;
            this.issueMessageBoardLbl.Location = new System.Drawing.Point(130, 367);
            this.issueMessageBoardLbl.Name = "issueMessageBoardLbl";
            this.issueMessageBoardLbl.Size = new System.Drawing.Size(35, 13);
            this.issueMessageBoardLbl.TabIndex = 10;
            this.issueMessageBoardLbl.Text = "label3";
            // 
            // Buildings
            // 
            this.ClientSize = new System.Drawing.Size(789, 451);
            this.Controls.Add(this.issueMessageBoardLbl);
            this.Controls.Add(this.instantMessageBoardLbl);
            this.Controls.Add(this.messageBoardLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Buildings";
            this.Load += new System.EventHandler(this.Buildings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Buildings_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string duplicateID_message = "Building ID should be unique";
            string blankField_message = "None of the fields allowed to be blank!";
            string max_characters_message = "The maximum number of characters for Building ID is 3. Address, Area can contain at most 20 characters each.";

            save(duplicateID_message, blankField_message, max_characters_message);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            delete();
        }


    }
//}
