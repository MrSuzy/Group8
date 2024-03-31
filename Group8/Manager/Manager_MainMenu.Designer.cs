using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace Group8
{
    partial class Manager_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelName = new System.Windows.Forms.Panel();
            this.lblClubName = new System.Windows.Forms.Label();
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnUpPro = new System.Windows.Forms.Button();
            this.btnCompRes = new System.Windows.Forms.Button();
            this.btnStuL = new System.Windows.Forms.Button();
            this.btnAss = new System.Windows.Forms.Button();
            this.btnRecom = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.CldMenu = new System.Windows.Forms.MonthCalendar();
            this.panelName.SuspendLayout();
            this.grpBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelName.Controls.Add(this.lblClubName);
            this.panelName.Location = new System.Drawing.Point(101, 46);
            this.panelName.Margin = new System.Windows.Forms.Padding(2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(671, 99);
            this.panelName.TabIndex = 0;
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblClubName.Location = new System.Drawing.Point(63, 32);
            this.lblClubName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(523, 31);
            this.lblClubName.TabIndex = 0;
            this.lblClubName.Text = "Asia Pacific University (APU) eSports Club";
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.BackColor = System.Drawing.Color.Silver;
            this.grpBoxMenu.Controls.Add(this.btnUpPro);
            this.grpBoxMenu.Controls.Add(this.btnCompRes);
            this.grpBoxMenu.Controls.Add(this.btnStuL);
            this.grpBoxMenu.Controls.Add(this.btnAss);
            this.grpBoxMenu.Controls.Add(this.btnRecom);
            this.grpBoxMenu.Controls.Add(this.btnComp);
            this.grpBoxMenu.Location = new System.Drawing.Point(139, 200);
            this.grpBoxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxMenu.Size = new System.Drawing.Size(286, 288);
            this.grpBoxMenu.TabIndex = 2;
            this.grpBoxMenu.TabStop = false;
            // 
            // btnUpPro
            // 
            this.btnUpPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnUpPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpPro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpPro.ForeColor = System.Drawing.Color.Black;
            this.btnUpPro.Location = new System.Drawing.Point(50, 225);
            this.btnUpPro.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpPro.Name = "btnUpPro";
            this.btnUpPro.Size = new System.Drawing.Size(188, 36);
            this.btnUpPro.TabIndex = 5;
            this.btnUpPro.Text = "Update Profile";
            this.btnUpPro.UseVisualStyleBackColor = false;
            this.btnUpPro.Click += new System.EventHandler(this.btnUpPro_Click_1);
            // 
            // btnCompRes
            // 
            this.btnCompRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnCompRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompRes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompRes.ForeColor = System.Drawing.Color.Black;
            this.btnCompRes.Location = new System.Drawing.Point(50, 185);
            this.btnCompRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompRes.Name = "btnCompRes";
            this.btnCompRes.Size = new System.Drawing.Size(188, 36);
            this.btnCompRes.TabIndex = 4;
            this.btnCompRes.Text = "Competition Result";
            this.btnCompRes.UseVisualStyleBackColor = false;
            this.btnCompRes.Click += new System.EventHandler(this.btnCompRes_Click_1);
            // 
            // btnStuL
            // 
            this.btnStuL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnStuL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStuL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnStuL.ForeColor = System.Drawing.Color.Black;
            this.btnStuL.Location = new System.Drawing.Point(50, 145);
            this.btnStuL.Margin = new System.Windows.Forms.Padding(2);
            this.btnStuL.Name = "btnStuL";
            this.btnStuL.Size = new System.Drawing.Size(188, 36);
            this.btnStuL.TabIndex = 3;
            this.btnStuL.Text = "Student List";
            this.btnStuL.UseVisualStyleBackColor = false;
            this.btnStuL.Click += new System.EventHandler(this.btnStuL_Click_1);
            // 
            // btnAss
            // 
            this.btnAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnAss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAss.ForeColor = System.Drawing.Color.Black;
            this.btnAss.Location = new System.Drawing.Point(50, 105);
            this.btnAss.Margin = new System.Windows.Forms.Padding(2);
            this.btnAss.Name = "btnAss";
            this.btnAss.Size = new System.Drawing.Size(188, 36);
            this.btnAss.TabIndex = 2;
            this.btnAss.Text = "Assignment";
            this.btnAss.UseVisualStyleBackColor = false;
            this.btnAss.Click += new System.EventHandler(this.btnAss_Click_1);
            // 
            // btnRecom
            // 
            this.btnRecom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnRecom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRecom.ForeColor = System.Drawing.Color.Black;
            this.btnRecom.Location = new System.Drawing.Point(50, 65);
            this.btnRecom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecom.Name = "btnRecom";
            this.btnRecom.Size = new System.Drawing.Size(188, 36);
            this.btnRecom.TabIndex = 1;
            this.btnRecom.Text = "Recommendation";
            this.btnRecom.UseVisualStyleBackColor = false;
            this.btnRecom.Click += new System.EventHandler(this.btnRecom_Click);
            // 
            // btnComp
            // 
            this.btnComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnComp.ForeColor = System.Drawing.Color.Black;
            this.btnComp.Location = new System.Drawing.Point(50, 25);
            this.btnComp.Margin = new System.Windows.Forms.Padding(2);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(188, 36);
            this.btnComp.TabIndex = 0;
            this.btnComp.Text = "Competition Schedule";
            this.btnComp.UseVisualStyleBackColor = false;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(681, 163);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 34);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // CldMenu
            // 
            this.CldMenu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.CldMenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CldMenu.Location = new System.Drawing.Point(482, 234);
            this.CldMenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.CldMenu.Name = "CldMenu";
            this.CldMenu.TabIndex = 4;
            this.CldMenu.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // Manager_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.CldMenu);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpBoxMenu);
            this.Controls.Add(this.panelName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_MainMenu";
            this.Text = "Main Menu";
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.grpBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelName;
        private Label lblClubName;
        private GroupBox grpBoxMenu;
        private Button btnComp;
        private Button btnUpPro;
        private Button btnCompRes;
        private Button btnStuL;
        private Button btnAss;
        private Button btnRecom;
        private Button btnLogOut;
        private MonthCalendar CldMenu;
    }
}
