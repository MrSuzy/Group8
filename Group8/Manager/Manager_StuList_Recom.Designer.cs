using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_StuList_Recom
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
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.panelGrp = new System.Windows.Forms.Panel();
            this.lblinfoGame = new System.Windows.Forms.Label();
            this.lblStuDetail = new System.Windows.Forms.Label();
            this.lblinfoPerformance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblinfoName = new System.Windows.Forms.Label();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.panelGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(696, 6);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(103, 42);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(803, 6);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(88, 42);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(42, 68);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 31);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Student Recommended from Coach";
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.ItemHeight = 22;
            this.listBoxStudent.Location = new System.Drawing.Point(48, 147);
            this.listBoxStudent.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(261, 334);
            this.listBoxStudent.TabIndex = 9;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // panelGrp
            // 
            this.panelGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.panelGrp.Controls.Add(this.lblinfoGame);
            this.panelGrp.Controls.Add(this.lblStuDetail);
            this.panelGrp.Controls.Add(this.lblinfoPerformance);
            this.panelGrp.Controls.Add(this.lblName);
            this.panelGrp.Controls.Add(this.lblinfoName);
            this.panelGrp.Controls.Add(this.lblPerformance);
            this.panelGrp.Controls.Add(this.lblGame);
            this.panelGrp.Location = new System.Drawing.Point(329, 147);
            this.panelGrp.Margin = new System.Windows.Forms.Padding(2);
            this.panelGrp.Name = "panelGrp";
            this.panelGrp.Size = new System.Drawing.Size(500, 334);
            this.panelGrp.TabIndex = 10;
            // 
            // lblinfoGame
            // 
            this.lblinfoGame.AutoSize = true;
            this.lblinfoGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoGame.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoGame.Location = new System.Drawing.Point(155, 167);
            this.lblinfoGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoGame.Name = "lblinfoGame";
            this.lblinfoGame.Size = new System.Drawing.Size(2, 24);
            this.lblinfoGame.TabIndex = 35;
            // 
            // lblStuDetail
            // 
            this.lblStuDetail.AutoSize = true;
            this.lblStuDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblStuDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblStuDetail.Location = new System.Drawing.Point(25, 44);
            this.lblStuDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuDetail.Name = "lblStuDetail";
            this.lblStuDetail.Size = new System.Drawing.Size(160, 23);
            this.lblStuDetail.TabIndex = 11;
            this.lblStuDetail.Text = "Student\'s Details:";
            // 
            // lblinfoPerformance
            // 
            this.lblinfoPerformance.AutoSize = true;
            this.lblinfoPerformance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoPerformance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoPerformance.Location = new System.Drawing.Point(155, 238);
            this.lblinfoPerformance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoPerformance.Name = "lblinfoPerformance";
            this.lblinfoPerformance.Size = new System.Drawing.Size(2, 24);
            this.lblinfoPerformance.TabIndex = 33;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblName.Location = new System.Drawing.Point(25, 100);
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
            this.lblinfoName.Location = new System.Drawing.Point(155, 98);
            this.lblinfoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoName.Name = "lblinfoName";
            this.lblinfoName.Size = new System.Drawing.Size(2, 24);
            this.lblinfoName.TabIndex = 31;
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPerformance.Location = new System.Drawing.Point(25, 240);
            this.lblPerformance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(116, 22);
            this.lblPerformance.TabIndex = 28;
            this.lblPerformance.Text = "Performance:";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblGame.Location = new System.Drawing.Point(25, 169);
            this.lblGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(62, 22);
            this.lblGame.TabIndex = 30;
            this.lblGame.Text = "Game:";
            // 
            // Manager_StuList_Recom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.panelGrp);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_StuList_Recom";
            this.Text = "Student_Recommendation";
            this.Load += new System.EventHandler(this.Manager_StuList_Recom_Load);
            this.panelGrp.ResumeLayout(false);
            this.panelGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMainMenu;
        private Button btnLogOut;
        private Label lblTitle;
        private ListBox listBoxStudent;
        private Panel panelGrp;
        private Label lblStuDetail;
        private Label lblinfoGame;
        private Label lblinfoPerformance;
        private Label lblName;
        private Label lblinfoName;
        private Label lblPerformance;
        private Label lblGame;
    }
}