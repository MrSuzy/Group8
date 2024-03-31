using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_EditCompSche
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
            this.txtBoxLoc = new System.Windows.Forms.TextBox();
            this.txtBoxCN = new System.Windows.Forms.TextBox();
            this.txtBoxPIC = new System.Windows.Forms.TextBox();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPIC = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblComT = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLogOut1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblinfoCompT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxLoc
            // 
            this.txtBoxLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxLoc.Location = new System.Drawing.Point(328, 425);
            this.txtBoxLoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLoc.Name = "txtBoxLoc";
            this.txtBoxLoc.Size = new System.Drawing.Size(387, 30);
            this.txtBoxLoc.TabIndex = 58;
            // 
            // txtBoxCN
            // 
            this.txtBoxCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxCN.Location = new System.Drawing.Point(328, 375);
            this.txtBoxCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCN.Name = "txtBoxCN";
            this.txtBoxCN.Size = new System.Drawing.Size(165, 30);
            this.txtBoxCN.TabIndex = 57;
            // 
            // txtBoxPIC
            // 
            this.txtBoxPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxPIC.Location = new System.Drawing.Point(328, 320);
            this.txtBoxPIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPIC.Name = "txtBoxPIC";
            this.txtBoxPIC.Size = new System.Drawing.Size(165, 30);
            this.txtBoxPIC.TabIndex = 56;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxTime.Location = new System.Drawing.Point(328, 271);
            this.txtBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(165, 30);
            this.txtBoxTime.TabIndex = 55;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxDate.Location = new System.Drawing.Point(328, 214);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(165, 30);
            this.txtBoxDate.TabIndex = 54;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(784, 477);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(107, 47);
            this.btnDone.TabIndex = 52;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCN.Location = new System.Drawing.Point(75, 375);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 51;
            this.lblCN.Text = "Contact Number:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTime.Location = new System.Drawing.Point(75, 271);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 50;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDate.Location = new System.Drawing.Point(75, 213);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 48;
            this.lblDate.Text = "Date:";
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPIC.Location = new System.Drawing.Point(75, 320);
            this.lblPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(151, 22);
            this.lblPIC.TabIndex = 47;
            this.lblPIC.Text = "Person In Charge:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoc.Location = new System.Drawing.Point(75, 425);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(85, 22);
            this.lblLoc.TabIndex = 46;
            this.lblLoc.Text = "Location:";
            // 
            // lblComT
            // 
            this.lblComT.AutoSize = true;
            this.lblComT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblComT.Location = new System.Drawing.Point(75, 151);
            this.lblComT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComT.Name = "lblComT";
            this.lblComT.Size = new System.Drawing.Size(155, 22);
            this.lblComT.TabIndex = 42;
            this.lblComT.Text = "Competition Title:";
            this.lblComT.Click += new System.EventHandler(this.lblComT_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(678, 3);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(127, 50);
            this.btnMenu.TabIndex = 41;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLogOut1
            // 
            this.btnLogOut1.BackColor = System.Drawing.Color.White;
            this.btnLogOut1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut1.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut1.Location = new System.Drawing.Point(809, 3);
            this.btnLogOut1.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(82, 50);
            this.btnLogOut1.TabIndex = 40;
            this.btnLogOut1.Text = "Log Out";
            this.btnLogOut1.UseVisualStyleBackColor = false;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(73, 79);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 31);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Competition Schedule";
            // 
            // lblinfoCompT
            // 
            this.lblinfoCompT.AutoSize = true;
            this.lblinfoCompT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCompT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCompT.Location = new System.Drawing.Point(328, 151);
            this.lblinfoCompT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCompT.Name = "lblinfoCompT";
            this.lblinfoCompT.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCompT.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox1.Location = new System.Drawing.Point(328, 214);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 30);
            this.textBox1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox2.Location = new System.Drawing.Point(328, 271);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 30);
            this.textBox2.TabIndex = 55;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox3.Location = new System.Drawing.Point(328, 320);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 30);
            this.textBox3.TabIndex = 56;
            // 
            // Manager_EditCompSche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.lblinfoCompT);
            this.Controls.Add(this.txtBoxLoc);
            this.Controls.Add(this.txtBoxCN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtBoxPIC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPIC);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblComT);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLogOut1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_EditCompSche";
            this.Text = "Edit_Competition_Schedule";
            this.Load += new System.EventHandler(this.Manager_EditCompSche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBoxLoc;
        private TextBox txtBoxCN;
        private TextBox txtBoxPIC;
        private TextBox txtBoxTime;
        private TextBox txtBoxDate;
        private Button btnDone;
        private Label lblCN;
        private Label lblTime;
        private Label lblDate;
        private Label lblPIC;
        private Label lblLoc;
        private Label lblComT;
        private Button btnMenu;
        private Button btnLogOut1;
        private Label lblTitle;
        private Label lblinfoCompT;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}