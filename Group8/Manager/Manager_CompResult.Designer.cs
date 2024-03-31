using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_CompResult
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLogOut1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblinfoDate = new System.Windows.Forms.Label();
            this.lblinfoPIC = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPIC = new System.Windows.Forms.Label();
            this.lblComT = new System.Windows.Forms.Label();
            this.lblinfoCN = new System.Windows.Forms.Label();
            this.lblinfoTime = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblChampion = new System.Windows.Forms.Label();
            this.comboBoxCompT = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxGrp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(680, 6);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(115, 46);
            this.btnMenu.TabIndex = 12;
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
            this.btnLogOut1.Location = new System.Drawing.Point(799, 6);
            this.btnLogOut1.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(92, 46);
            this.btnLogOut1.TabIndex = 11;
            this.btnLogOut1.Text = "Log Out";
            this.btnLogOut1.UseVisualStyleBackColor = false;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(77, 82);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 31);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Competition Result";
            // 
            // lblinfoDate
            // 
            this.lblinfoDate.AutoSize = true;
            this.lblinfoDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoDate.Location = new System.Drawing.Point(286, 219);
            this.lblinfoDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoDate.Name = "lblinfoDate";
            this.lblinfoDate.Size = new System.Drawing.Size(2, 24);
            this.lblinfoDate.TabIndex = 31;
            // 
            // lblinfoPIC
            // 
            this.lblinfoPIC.AutoSize = true;
            this.lblinfoPIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoPIC.Location = new System.Drawing.Point(286, 324);
            this.lblinfoPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoPIC.Name = "lblinfoPIC";
            this.lblinfoPIC.Size = new System.Drawing.Size(2, 24);
            this.lblinfoPIC.TabIndex = 30;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDate.Location = new System.Drawing.Point(79, 215);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date:";
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPIC.Location = new System.Drawing.Point(76, 321);
            this.lblPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(151, 22);
            this.lblPIC.TabIndex = 27;
            this.lblPIC.Text = "Person In Charge:";
            // 
            // lblComT
            // 
            this.lblComT.AutoSize = true;
            this.lblComT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblComT.Location = new System.Drawing.Point(79, 159);
            this.lblComT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComT.Name = "lblComT";
            this.lblComT.Size = new System.Drawing.Size(155, 22);
            this.lblComT.TabIndex = 26;
            this.lblComT.Text = "Competition Title:";
            // 
            // lblinfoCN
            // 
            this.lblinfoCN.AutoSize = true;
            this.lblinfoCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCN.Location = new System.Drawing.Point(286, 379);
            this.lblinfoCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCN.Name = "lblinfoCN";
            this.lblinfoCN.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCN.TabIndex = 36;
            // 
            // lblinfoTime
            // 
            this.lblinfoTime.AutoSize = true;
            this.lblinfoTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoTime.Location = new System.Drawing.Point(286, 272);
            this.lblinfoTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoTime.Name = "lblinfoTime";
            this.lblinfoTime.Size = new System.Drawing.Size(2, 24);
            this.lblinfoTime.TabIndex = 35;
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCN.Location = new System.Drawing.Point(76, 375);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 34;
            this.lblCN.Text = "Contact Number:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTime.Location = new System.Drawing.Point(76, 268);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "Time:";
            // 
            // lblChampion
            // 
            this.lblChampion.AutoSize = true;
            this.lblChampion.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblChampion.Location = new System.Drawing.Point(76, 429);
            this.lblChampion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChampion.Name = "lblChampion";
            this.lblChampion.Size = new System.Drawing.Size(104, 22);
            this.lblChampion.TabIndex = 43;
            this.lblChampion.Text = "Champions:";
            // 
            // comboBoxCompT
            // 
            this.comboBoxCompT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCompT.FormattingEnabled = true;
            this.comboBoxCompT.Location = new System.Drawing.Point(286, 160);
            this.comboBoxCompT.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCompT.Name = "comboBoxCompT";
            this.comboBoxCompT.Size = new System.Drawing.Size(388, 24);
            this.comboBoxCompT.TabIndex = 44;
            this.comboBoxCompT.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompT_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(790, 478);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 46);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxGrp
            // 
            this.comboBoxGrp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGrp.FormattingEnabled = true;
            this.comboBoxGrp.Location = new System.Drawing.Point(286, 427);
            this.comboBoxGrp.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGrp.Name = "comboBoxGrp";
            this.comboBoxGrp.Size = new System.Drawing.Size(142, 24);
            this.comboBoxGrp.TabIndex = 54;
            this.comboBoxGrp.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrp_SelectedIndexChanged);
            // 
            // Manager_CompResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.comboBoxGrp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxCompT);
            this.Controls.Add(this.lblChampion);
            this.Controls.Add(this.lblinfoCN);
            this.Controls.Add(this.lblinfoTime);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblinfoDate);
            this.Controls.Add(this.lblinfoPIC);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPIC);
            this.Controls.Add(this.lblComT);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLogOut1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_CompResult";
            this.Text = "Competition_Result";
            this.Load += new System.EventHandler(this.Manager_CompResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMenu;
        private Button btnLogOut1;
        private Label lblTitle;
        private Label lblinfoDate;
        private Label lblinfoPIC;
        private Label lblDate;
        private Label lblPIC;
        private Label lblComT;
        private Label lblinfoCN;
        private Label lblinfoTime;
        private Label lblCN;
        private Label lblTime;
        private Label label2;
        private Label lblChampion;
        private ComboBox comboBoxCompT;
        private Button btnUpdate;
        private ComboBox comboBoxGrp;
    }
}