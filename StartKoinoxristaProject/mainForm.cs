using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

/*namespace StartKoinoxristaProject
{*/
    public class mainForm : Form
    {
        private Button buildingsBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button exitBtn;

        public mainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.buildingsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(375, 228);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
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
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(545, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
            Buildings c1 = new Buildings("select buildingID as 'Building ID', bAddress as Address, bArea as Area from buildings order by buildingID");
            c1.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apart a1 = new Apart("");
            a1.Show();
        }
    }
//}
