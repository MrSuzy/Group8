using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_StudList_Comp
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCompT = new System.Windows.Forms.Label();
            this.comboBoxCompT = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.listBoxSpecificStu = new System.Windows.Forms.ListBox();
            this.lblinfoCN = new System.Windows.Forms.Label();
            this.lblinfoTime = new System.Windows.Forms.Label();
            this.lblinfoDate = new System.Windows.Forms.Label();
            this.lblinfoPIC = new System.Windows.Forms.Label();
            this.lblinfoLoc = new System.Windows.Forms.Label();
            this.lblinfoCompT = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPIC = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblComT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.White;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(670, 11);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(106, 42);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(780, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 42);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 61);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 31);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Student List";
            // 
            // lblCompT
            // 
            this.lblCompT.AutoSize = true;
            this.lblCompT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCompT.Location = new System.Drawing.Point(82, 122);
            this.lblCompT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompT.Name = "lblCompT";
            this.lblCompT.Size = new System.Drawing.Size(155, 22);
            this.lblCompT.TabIndex = 11;
            this.lblCompT.Text = "Competition Title:";
            // 
            // comboBoxCompT
            // 
            this.comboBoxCompT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCompT.FormattingEnabled = true;
            this.comboBoxCompT.Location = new System.Drawing.Point(86, 146);
            this.comboBoxCompT.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCompT.Name = "comboBoxCompT";
            this.comboBoxCompT.Size = new System.Drawing.Size(302, 24);
            this.comboBoxCompT.TabIndex = 12;
            this.comboBoxCompT.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompT_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(86, 470);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 45);
            this.btnView.TabIndex = 40;
            this.btnView.Text = "View List";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // listBoxSpecificStu
            // 
            this.listBoxSpecificStu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.listBoxSpecificStu.FormattingEnabled = true;
            this.listBoxSpecificStu.ItemHeight = 22;
            this.listBoxSpecificStu.Location = new System.Drawing.Point(482, 146);
            this.listBoxSpecificStu.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSpecificStu.Name = "listBoxSpecificStu";
            this.listBoxSpecificStu.Size = new System.Drawing.Size(294, 312);
            this.listBoxSpecificStu.TabIndex = 41;
            // 
            // lblinfoCN
            // 
            this.lblinfoCN.AutoSize = true;
            this.lblinfoCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCN.Location = new System.Drawing.Point(256, 370);
            this.lblinfoCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCN.Name = "lblinfoCN";
            this.lblinfoCN.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCN.TabIndex = 53;
            // 
            // lblinfoTime
            // 
            this.lblinfoTime.AutoSize = true;
            this.lblinfoTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoTime.Location = new System.Drawing.Point(256, 288);
            this.lblinfoTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoTime.Name = "lblinfoTime";
            this.lblinfoTime.Size = new System.Drawing.Size(2, 24);
            this.lblinfoTime.TabIndex = 52;
            // 
            // lblinfoDate
            // 
            this.lblinfoDate.AutoSize = true;
            this.lblinfoDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoDate.Location = new System.Drawing.Point(256, 246);
            this.lblinfoDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoDate.Name = "lblinfoDate";
            this.lblinfoDate.Size = new System.Drawing.Size(2, 24);
            this.lblinfoDate.TabIndex = 51;
            // 
            // lblinfoPIC
            // 
            this.lblinfoPIC.AutoSize = true;
            this.lblinfoPIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoPIC.Location = new System.Drawing.Point(256, 328);
            this.lblinfoPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoPIC.Name = "lblinfoPIC";
            this.lblinfoPIC.Size = new System.Drawing.Size(2, 24);
            this.lblinfoPIC.TabIndex = 50;
            // 
            // lblinfoLoc
            // 
            this.lblinfoLoc.AutoSize = true;
            this.lblinfoLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoLoc.Location = new System.Drawing.Point(256, 415);
            this.lblinfoLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoLoc.Name = "lblinfoLoc";
            this.lblinfoLoc.Size = new System.Drawing.Size(2, 24);
            this.lblinfoLoc.TabIndex = 49;
            // 
            // lblinfoCompT
            // 
            this.lblinfoCompT.AutoSize = true;
            this.lblinfoCompT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCompT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCompT.Location = new System.Drawing.Point(256, 201);
            this.lblinfoCompT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCompT.Name = "lblinfoCompT";
            this.lblinfoCompT.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCompT.TabIndex = 48;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDate.Location = new System.Drawing.Point(82, 248);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 47;
            this.lblDate.Text = "Date:";
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPIC.Location = new System.Drawing.Point(82, 330);
            this.lblPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(151, 22);
            this.lblPIC.TabIndex = 46;
            this.lblPIC.Text = "Person In Charge:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoc.Location = new System.Drawing.Point(82, 415);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(85, 22);
            this.lblLoc.TabIndex = 45;
            this.lblLoc.Text = "Location:";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCN.Location = new System.Drawing.Point(82, 372);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 44;
            this.lblCN.Text = "Contact Number:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTime.Location = new System.Drawing.Point(82, 290);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 43;
            this.lblTime.Text = "Time:";
            // 
            // lblComT
            // 
            this.lblComT.AutoSize = true;
            this.lblComT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblComT.Location = new System.Drawing.Point(82, 201);
            this.lblComT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComT.Name = "lblComT";
            this.lblComT.Size = new System.Drawing.Size(155, 22);
            this.lblComT.TabIndex = 42;
            this.lblComT.Text = "Competition Title:";
            // 
            // Manager_StudList_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.lblinfoCN);
            this.Controls.Add(this.lblinfoTime);
            this.Controls.Add(this.lblinfoDate);
            this.Controls.Add(this.lblinfoPIC);
            this.Controls.Add(this.lblinfoLoc);
            this.Controls.Add(this.lblinfoCompT);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPIC);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblComT);
            this.Controls.Add(this.listBoxSpecificStu);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.comboBoxCompT);
            this.Controls.Add(this.lblCompT);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_StudList_Comp";
            this.Text = "Student_for_Specific_Competition";
            this.Load += new System.EventHandler(this.Manager_StudList_Comp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMainMenu;
        private Button btnLogOut;
        private Label lblTitle;
        private Label lblCompT;
        private ComboBox comboBoxCompT;
        private Button btnView;
        private ListBox listBoxSpecificStu;
        private Label lblinfoCN;
        private Label lblinfoTime;
        private Label lblinfoDate;
        private Label lblinfoPIC;
        private Label lblinfoLoc;
        private Label lblinfoCompT;
        private Label lblDate;
        private Label lblPIC;
        private Label lblLoc;
        private Label lblCN;
        private Label lblTime;
        private Label lblComT;
    }
}