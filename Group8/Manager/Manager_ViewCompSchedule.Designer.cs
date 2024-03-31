using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_ViewCompSchedule
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblCompT = new System.Windows.Forms.Label();
            this.comboBoxCompT = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblComT = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblPIC = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblinfoCompT = new System.Windows.Forms.Label();
            this.lblinfoLoc = new System.Windows.Forms.Label();
            this.lblinfoPIC = new System.Windows.Forms.Label();
            this.lblinfoDate = new System.Windows.Forms.Label();
            this.lblinfoTime = new System.Windows.Forms.Label();
            this.lblinfoCN = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(76, 66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Competition Schedule";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(796, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(95, 41);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(664, 11);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(128, 41);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblCompT
            // 
            this.lblCompT.AutoSize = true;
            this.lblCompT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCompT.Location = new System.Drawing.Point(78, 135);
            this.lblCompT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompT.Name = "lblCompT";
            this.lblCompT.Size = new System.Drawing.Size(155, 22);
            this.lblCompT.TabIndex = 6;
            this.lblCompT.Text = "Competition Title:";
            // 
            // comboBoxCompT
            // 
            this.comboBoxCompT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCompT.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.comboBoxCompT.FormattingEnabled = true;
            this.comboBoxCompT.Location = new System.Drawing.Point(82, 171);
            this.comboBoxCompT.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCompT.Name = "comboBoxCompT";
            this.comboBoxCompT.Size = new System.Drawing.Size(677, 25);
            this.comboBoxCompT.TabIndex = 7;
            this.comboBoxCompT.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompT_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(237, 121);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add New Competition";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblComT
            // 
            this.lblComT.AutoSize = true;
            this.lblComT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblComT.Location = new System.Drawing.Point(78, 223);
            this.lblComT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComT.Name = "lblComT";
            this.lblComT.Size = new System.Drawing.Size(155, 22);
            this.lblComT.TabIndex = 9;
            this.lblComT.Text = "Competition Title:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTime.Location = new System.Drawing.Point(78, 319);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time:";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCN.Location = new System.Drawing.Point(78, 405);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 12;
            this.lblCN.Text = "Contact Number:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoc.Location = new System.Drawing.Point(78, 448);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(85, 22);
            this.lblLoc.TabIndex = 16;
            this.lblLoc.Text = "Location:";
            // 
            // lblPIC
            // 
            this.lblPIC.AutoSize = true;
            this.lblPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPIC.Location = new System.Drawing.Point(78, 362);
            this.lblPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIC.Name = "lblPIC";
            this.lblPIC.Size = new System.Drawing.Size(151, 22);
            this.lblPIC.TabIndex = 17;
            this.lblPIC.Text = "Person In Charge:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDate.Location = new System.Drawing.Point(78, 269);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date:";
            // 
            // lblinfoCompT
            // 
            this.lblinfoCompT.AutoSize = true;
            this.lblinfoCompT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCompT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCompT.Location = new System.Drawing.Point(262, 223);
            this.lblinfoCompT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCompT.Name = "lblinfoCompT";
            this.lblinfoCompT.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCompT.TabIndex = 19;
            // 
            // lblinfoLoc
            // 
            this.lblinfoLoc.AutoSize = true;
            this.lblinfoLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoLoc.Location = new System.Drawing.Point(262, 448);
            this.lblinfoLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoLoc.Name = "lblinfoLoc";
            this.lblinfoLoc.Size = new System.Drawing.Size(2, 24);
            this.lblinfoLoc.TabIndex = 22;
            // 
            // lblinfoPIC
            // 
            this.lblinfoPIC.AutoSize = true;
            this.lblinfoPIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoPIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoPIC.Location = new System.Drawing.Point(262, 360);
            this.lblinfoPIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoPIC.Name = "lblinfoPIC";
            this.lblinfoPIC.Size = new System.Drawing.Size(2, 24);
            this.lblinfoPIC.TabIndex = 24;
            // 
            // lblinfoDate
            // 
            this.lblinfoDate.AutoSize = true;
            this.lblinfoDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoDate.Location = new System.Drawing.Point(262, 269);
            this.lblinfoDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoDate.Name = "lblinfoDate";
            this.lblinfoDate.Size = new System.Drawing.Size(2, 24);
            this.lblinfoDate.TabIndex = 25;
            // 
            // lblinfoTime
            // 
            this.lblinfoTime.AutoSize = true;
            this.lblinfoTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoTime.Location = new System.Drawing.Point(262, 317);
            this.lblinfoTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoTime.Name = "lblinfoTime";
            this.lblinfoTime.Size = new System.Drawing.Size(2, 24);
            this.lblinfoTime.TabIndex = 26;
            // 
            // lblinfoCN
            // 
            this.lblinfoCN.AutoSize = true;
            this.lblinfoCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoCN.Location = new System.Drawing.Point(262, 403);
            this.lblinfoCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoCN.Name = "lblinfoCN";
            this.lblinfoCN.Size = new System.Drawing.Size(2, 24);
            this.lblinfoCN.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(794, 486);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 38);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(195)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(693, 486);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 38);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Manager_ViewCompSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
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
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxCompT);
            this.Controls.Add(this.lblCompT);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_ViewCompSchedule";
            this.Text = "Competition Schedule";
            this.Load += new System.EventHandler(this.Manager_ViewCompSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnLogOut;
        private Button btnMainMenu;
        private Label lblCompT;
        private ComboBox comboBoxCompT;
        private Button btnAdd;
        private Label lblComT;
        private Label lblTime;
        private Label lblCN;
        private Label lblLoc;
        private Label lblPIC;
        private Label lblDate;
        private Label lblinfoCompT;
        private Label lblinfoLoc;
        private Label lblinfoPIC;
        private Label lblinfoDate;
        private Label lblinfoTime;
        private Label lblinfoCN;
        private Button btnDelete;
        private Button btnEdit;
    }
}