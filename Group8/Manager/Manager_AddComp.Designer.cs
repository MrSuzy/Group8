using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_AddComp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLogOut1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblComT = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtBoxComT = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxLoc = new System.Windows.Forms.TextBox();
            this.txtBoxCN = new System.Windows.Forms.TextBox();
            this.lblCN = new System.Windows.Forms.Label();
            this.txtBoxPIC = new System.Windows.Forms.TextBox();
            this.lblPIC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(62, 60);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Competition Schedule";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(665, 11);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(119, 38);
            this.btnMenu.TabIndex = 10;
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
            this.btnLogOut1.Location = new System.Drawing.Point(789, 11);
            this.btnLogOut1.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(101, 38);
            this.btnLogOut1.TabIndex = 9;
            this.btnLogOut1.Text = "Log Out";
            this.btnLogOut1.UseVisualStyleBackColor = false;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(63, 199);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(63, 440);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(85, 22);
            this.lblLoc.TabIndex = 23;
            this.lblLoc.Text = "Location:";
            // 
            // lblComT
            // 
            this.lblComT.AutoSize = true;
            this.lblComT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComT.Location = new System.Drawing.Point(63, 143);
            this.lblComT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComT.Name = "lblComT";
            this.lblComT.Size = new System.Drawing.Size(155, 22);
            this.lblComT.TabIndex = 19;
            this.lblComT.Text = "Competition Title:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(63, 261);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Time:";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(789, 488);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(93, 36);
            this.btnDone.TabIndex = 29;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtBoxComT
            // 
            this.txtBoxComT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxComT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxComT.Location = new System.Drawing.Point(288, 140);
            this.txtBoxComT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxComT.Name = "txtBoxComT";
            this.txtBoxComT.Size = new System.Drawing.Size(387, 30);
            this.txtBoxComT.TabIndex = 30;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDate.Location = new System.Drawing.Point(288, 196);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(165, 30);
            this.txtBoxDate.TabIndex = 31;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTime.Location = new System.Drawing.Point(288, 258);
            this.txtBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(165, 30);
            this.txtBoxTime.TabIndex = 32;
            // 
            // txtBoxLoc
            // 
            this.txtBoxLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoc.Location = new System.Drawing.Point(288, 437);
            this.txtBoxLoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLoc.Name = "txtBoxLoc";
            this.txtBoxLoc.Size = new System.Drawing.Size(387, 30);
            this.txtBoxLoc.TabIndex = 35;
            // 
            // txtBoxCN
            // 
            this.txtBoxCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCN.Location = new System.Drawing.Point(288, 378);
            this.txtBoxCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCN.Name = "txtBoxCN";
            this.txtBoxCN.Size = new System.Drawing.Size(165, 30);
            this.txtBoxCN.TabIndex = 34;
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCN.Location = new System.Drawing.Point(63, 381);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 28;
            this.lblCN.Text = "Contact Number:";
            // 
            // txtBoxPIC
            // 
            this.txtBoxPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPIC.Location = new System.Drawing.Point(288, 317);
            this.txtBoxPIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPIC.Name = "txtBoxPIC";
            this.txtBoxPIC.Size = new System.Drawing.Size(165, 30);
            this.txtBoxPIC.TabIndex = 33;
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIC.Location = new System.Drawing.Point(63, 320);
            this.lblPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(151, 22);
            this.lblPIC.TabIndex = 24;
            this.lblPIC.Text = "Person In Charge:";
            // 
            // Manager_AddComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.txtBoxLoc);
            this.Controls.Add(this.txtBoxCN);
            this.Controls.Add(this.txtBoxPIC);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxComT);
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
            this.Name = "Manager_AddComp";
            this.Text = "Add_or_Edit_Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Button btnMenu;
        private Button btnLogOut1;
        private Label lblDate;
        private Label lblLoc;
        private Label lblComT;
        private Label lblTime;
        private Button btnDone;
        private TextBox txtBoxComT;
        private TextBox txtBoxDate;
        private TextBox txtBoxTime;
        private TextBox txtBoxLoc;
        private TextBox txtBoxCN;
        private Label lblCN;
        private TextBox txtBoxPIC;
        private Label lblPIC;
    }
}