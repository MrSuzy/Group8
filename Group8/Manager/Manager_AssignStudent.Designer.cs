using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_AssignStudent
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelGrp = new System.Windows.Forms.Panel();
            this.lblinfoGame = new System.Windows.Forms.Label();
            this.lblinfoPerformance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblinfoName = new System.Windows.Forms.Label();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStuDetail = new System.Windows.Forms.Label();
            this.comboBoxCompT = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblselectStu = new System.Windows.Forms.Label();
            this.listBoxStuName = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panelGrp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(31, 62);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Assign Students";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.White;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(666, 11);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(114, 33);
            this.btnMainMenu.TabIndex = 7;
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
            this.btnLogOut.Location = new System.Drawing.Point(784, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(107, 33);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelGrp
            // 
            this.panelGrp.BackColor = System.Drawing.Color.LightGray;
            this.panelGrp.Controls.Add(this.lblinfoGame);
            this.panelGrp.Controls.Add(this.lblinfoPerformance);
            this.panelGrp.Controls.Add(this.lblName);
            this.panelGrp.Controls.Add(this.lblinfoName);
            this.panelGrp.Controls.Add(this.lblPerformance);
            this.panelGrp.Controls.Add(this.lblGender);
            this.panelGrp.Controls.Add(this.lblStuDetail);
            this.panelGrp.Location = new System.Drawing.Point(259, 211);
            this.panelGrp.Margin = new System.Windows.Forms.Padding(2);
            this.panelGrp.Name = "panelGrp";
            this.panelGrp.Size = new System.Drawing.Size(283, 260);
            this.panelGrp.TabIndex = 11;
            // 
            // lblinfoGame
            // 
            this.lblinfoGame.AutoSize = true;
            this.lblinfoGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoGame.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoGame.Location = new System.Drawing.Point(87, 121);
            this.lblinfoGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoGame.Name = "lblinfoGame";
            this.lblinfoGame.Size = new System.Drawing.Size(2, 24);
            this.lblinfoGame.TabIndex = 35;
            // 
            // lblinfoPerformance
            // 
            this.lblinfoPerformance.AutoSize = true;
            this.lblinfoPerformance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoPerformance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoPerformance.Location = new System.Drawing.Point(13, 209);
            this.lblinfoPerformance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoPerformance.Name = "lblinfoPerformance";
            this.lblinfoPerformance.Size = new System.Drawing.Size(2, 24);
            this.lblinfoPerformance.TabIndex = 33;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblName.Location = new System.Drawing.Point(9, 62);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name:";
            // 
            // lblinfoName
            // 
            this.lblinfoName.AutoSize = true;
            this.lblinfoName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoName.Location = new System.Drawing.Point(87, 60);
            this.lblinfoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoName.Name = "lblinfoName";
            this.lblinfoName.Size = new System.Drawing.Size(2, 24);
            this.lblinfoName.TabIndex = 31;
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPerformance.Location = new System.Drawing.Point(8, 171);
            this.lblPerformance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(167, 22);
            this.lblPerformance.TabIndex = 28;
            this.lblPerformance.Text = "Performance Score:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblGender.Location = new System.Drawing.Point(9, 121);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 22);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Game:";
            // 
            // lblStuDetail
            // 
            this.lblStuDetail.AutoSize = true;
            this.lblStuDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblStuDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblStuDetail.Location = new System.Drawing.Point(2, 13);
            this.lblStuDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuDetail.Name = "lblStuDetail";
            this.lblStuDetail.Size = new System.Drawing.Size(160, 23);
            this.lblStuDetail.TabIndex = 11;
            this.lblStuDetail.Text = "Student\'s Details:";
            // 
            // comboBoxCompT
            // 
            this.comboBoxCompT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCompT.FormattingEnabled = true;
            this.comboBoxCompT.Location = new System.Drawing.Point(34, 151);
            this.comboBoxCompT.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCompT.Name = "comboBoxCompT";
            this.comboBoxCompT.Size = new System.Drawing.Size(825, 24);
            this.comboBoxCompT.TabIndex = 12;
            this.comboBoxCompT.SelectedIndexChanged += new System.EventHandler(this.comboBoxStulist_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSelect.Location = new System.Drawing.Point(33, 114);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(209, 22);
            this.lblSelect.TabIndex = 36;
            this.lblSelect.Text = "Select Competition Title:";
            // 
            // lblselectStu
            // 
            this.lblselectStu.AutoSize = true;
            this.lblselectStu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblselectStu.Location = new System.Drawing.Point(30, 201);
            this.lblselectStu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselectStu.Name = "lblselectStu";
            this.lblselectStu.Size = new System.Drawing.Size(191, 22);
            this.lblselectStu.TabIndex = 37;
            this.lblselectStu.Text = "Select Student\'s Name:";
            // 
            // listBoxStuName
            // 
            this.listBoxStuName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.listBoxStuName.FormattingEnabled = true;
            this.listBoxStuName.ItemHeight = 22;
            this.listBoxStuName.Location = new System.Drawing.Point(34, 225);
            this.listBoxStuName.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStuName.Name = "listBoxStuName";
            this.listBoxStuName.Size = new System.Drawing.Size(208, 246);
            this.listBoxStuName.TabIndex = 38;
            this.listBoxStuName.SelectedIndexChanged += new System.EventHandler(this.listBoxStuName_SelectedIndexChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(798, 490);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(93, 34);
            this.btnDone.TabIndex = 39;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblinfoCN);
            this.panel1.Controls.Add(this.lblinfoTime);
            this.panel1.Controls.Add(this.lblinfoDate);
            this.panel1.Controls.Add(this.lblinfoPIC);
            this.panel1.Controls.Add(this.lblinfoLoc);
            this.panel1.Controls.Add(this.lblinfoCompT);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPIC);
            this.panel1.Controls.Add(this.lblLoc);
            this.panel1.Controls.Add(this.lblCN);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblComT);
            this.panel1.Location = new System.Drawing.Point(546, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 260);
            this.panel1.TabIndex = 36;
            // 
            // lblinfoCN
            // 
            this.lblinfoCN.AutoSize = true;
            this.lblinfoCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCN.Location = new System.Drawing.Point(165, 171);
            this.lblinfoCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCN.Name = "lblinfoCN";
            this.lblinfoCN.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCN.TabIndex = 39;
            // 
            // lblinfoTime
            // 
            this.lblinfoTime.AutoSize = true;
            this.lblinfoTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoTime.Location = new System.Drawing.Point(165, 90);
            this.lblinfoTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoTime.Name = "lblinfoTime";
            this.lblinfoTime.Size = new System.Drawing.Size(2, 24);
            this.lblinfoTime.TabIndex = 38;
            // 
            // lblinfoDate
            // 
            this.lblinfoDate.AutoSize = true;
            this.lblinfoDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoDate.Location = new System.Drawing.Point(165, 51);
            this.lblinfoDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoDate.Name = "lblinfoDate";
            this.lblinfoDate.Size = new System.Drawing.Size(2, 24);
            this.lblinfoDate.TabIndex = 37;
            // 
            // lblinfoPIC
            // 
            this.lblinfoPIC.AutoSize = true;
            this.lblinfoPIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoPIC.Location = new System.Drawing.Point(165, 132);
            this.lblinfoPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoPIC.Name = "lblinfoPIC";
            this.lblinfoPIC.Size = new System.Drawing.Size(2, 24);
            this.lblinfoPIC.TabIndex = 36;
            // 
            // lblinfoLoc
            // 
            this.lblinfoLoc.AutoSize = true;
            this.lblinfoLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoLoc.Location = new System.Drawing.Point(165, 209);
            this.lblinfoLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoLoc.Name = "lblinfoLoc";
            this.lblinfoLoc.Size = new System.Drawing.Size(2, 24);
            this.lblinfoLoc.TabIndex = 35;
            // 
            // lblinfoCompT
            // 
            this.lblinfoCompT.AutoSize = true;
            this.lblinfoCompT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCompT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCompT.Location = new System.Drawing.Point(163, 14);
            this.lblinfoCompT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCompT.Name = "lblinfoCompT";
            this.lblinfoCompT.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCompT.TabIndex = 34;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDate.Location = new System.Drawing.Point(12, 53);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "Date:";
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPIC.Location = new System.Drawing.Point(14, 132);
            this.lblPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(151, 22);
            this.lblPIC.TabIndex = 32;
            this.lblPIC.Text = "Person In Charge:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoc.Location = new System.Drawing.Point(12, 211);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(85, 22);
            this.lblLoc.TabIndex = 31;
            this.lblLoc.Text = "Location:";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCN.Location = new System.Drawing.Point(12, 171);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 30;
            this.lblCN.Text = "Contact Number:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTime.Location = new System.Drawing.Point(12, 92);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "Time:";
            // 
            // lblComT
            // 
            this.lblComT.AutoSize = true;
            this.lblComT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblComT.Location = new System.Drawing.Point(12, 14);
            this.lblComT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComT.Name = "lblComT";
            this.lblComT.Size = new System.Drawing.Size(155, 22);
            this.lblComT.TabIndex = 28;
            this.lblComT.Text = "Competition Title:";
            // 
            // Manager_AssignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.listBoxStuName);
            this.Controls.Add(this.lblselectStu);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.comboBoxCompT);
            this.Controls.Add(this.panelGrp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_AssignStudent";
            this.Text = "Assign_Student_for_Competition";
            this.Load += new System.EventHandler(this.Manager_AssignStudent_Load);
            this.panelGrp.ResumeLayout(false);
            this.panelGrp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnMainMenu;
        private Button btnLogOut;
        private Panel panelGrp;
        private Label lblinfoGame;
        private Label lblinfoPerformance;
        private Label lblName;
        private Label lblinfoName;
        private Label lblPerformance;
        private Label lblGender;
        private Label lblStuDetail;
        private ComboBox comboBoxCompT;
        private Label lblSelect;
        private Label lblselectStu;
        private ListBox listBoxStuName;
        private Button btnDone;
        private Panel panel1;
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