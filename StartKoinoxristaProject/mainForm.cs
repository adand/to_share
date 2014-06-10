using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

/*namespace StartKoinoxristaProject
{*/
    public class mainForm : Form
    {
        private string connectionString;
        private Button buildingsBtn;
        private Button button2;
        private Button costCategoriesBtn;
        private Button dapanesBtn;
        private Label label1;
        private Label label2;
        private Button exitBtn;

        public mainForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\databases\abmDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.buildingsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.costCategoriesBtn = new System.Windows.Forms.Button();
            this.dapanesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(295, 318);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // buildingsBtn
            // 
            this.buildingsBtn.Location = new System.Drawing.Point(58, 79);
            this.buildingsBtn.Name = "buildingsBtn";
            this.buildingsBtn.Size = new System.Drawing.Size(155, 41);
            this.buildingsBtn.TabIndex = 1;
            this.buildingsBtn.Text = "Προσθήκη / επεξεργασία πολυκατοικίας";
            this.buildingsBtn.UseVisualStyleBackColor = true;
            this.buildingsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Προσθήκη / επεξεργασία διαμερίσματος";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // costCategoriesBtn
            // 
            this.costCategoriesBtn.Location = new System.Drawing.Point(58, 216);
            this.costCategoriesBtn.Name = "costCategoriesBtn";
            this.costCategoriesBtn.Size = new System.Drawing.Size(141, 46);
            this.costCategoriesBtn.TabIndex = 3;
            this.costCategoriesBtn.Text = "Προσθήκη / επεξεργασία κατηγοριών δαπάνης";
            this.costCategoriesBtn.UseVisualStyleBackColor = true;
            this.costCategoriesBtn.Click += new System.EventHandler(this.costCategoriesBtn_Click);
            // 
            // dapanesBtn
            // 
            this.dapanesBtn.Location = new System.Drawing.Point(250, 216);
            this.dapanesBtn.Name = "dapanesBtn";
            this.dapanesBtn.Size = new System.Drawing.Size(141, 46);
            this.dapanesBtn.TabIndex = 4;
            this.dapanesBtn.Text = "Προσθήκη / επεξεργασία δαπάνης";
            this.dapanesBtn.UseVisualStyleBackColor = true;
            this.dapanesBtn.Click += new System.EventHandler(this.dapanesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Εγκαταστάσεις";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Δαπάνες";
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(589, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dapanesBtn);
            this.Controls.Add(this.costCategoriesBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buildingsBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buildings c1 = new Buildings(connectionString);
            c1.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apart a1 = new Apart(connectionString);
            string queryString = "select distinct bArea from buildings order by bArea";
            a1.fillTheComboBox(queryString);

            a1.DataGridView1.Hide();
            a1.whileEditingControls(false);
            a1.EditBtn.Hide();
            a1.Show();
        }

        private void costCategoriesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            string queryString = "select costCategory as 'Cost Category', costDescription as 'Cost Description' from costPredefinedItems";
            costPredefinedItems c1 = new costPredefinedItems(queryString, connectionString);
            
            c1.whileEditingControls(false);
            c1.Show();
        }

        private void dapanesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dapanes2 d1 = new dapanes2(connectionString);
            string queryString = "select distinct bArea from buildings order by bArea";
            d1.fillTheComboBox(queryString);

            d1.DataGridView1.Hide();
            d1.whileEditingControls(false);
            d1.EditBtn.Hide();
            d1.Show();
        }
    }
//}
