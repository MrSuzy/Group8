using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group8
{
    partial class Manager_UpdateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_UpdateProfile));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblinfouserID = new System.Windows.Forms.Label();
            this.lblinfoIC = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picStu = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblinfoName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(662, 11);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(120, 40);
            this.btnMainMenu.TabIndex = 9;
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
            this.btnLogOut.Location = new System.Drawing.Point(786, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(105, 40);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(93, 90);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 31);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Update Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblName.Location = new System.Drawing.Point(97, 172);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblUserID.Location = new System.Drawing.Point(96, 269);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(73, 22);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "UserID:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPassword.Location = new System.Drawing.Point(95, 420);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 22);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblIC.Location = new System.Drawing.Point(96, 219);
            this.lblIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(109, 22);
            this.lblIC.TabIndex = 16;
            this.lblIC.Text = "IC/Passport:";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCN.Location = new System.Drawing.Point(95, 373);
            this.lblCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(144, 22);
            this.lblCN.TabIndex = 17;
            this.lblCN.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEmail.Location = new System.Drawing.Point(96, 320);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblinfouserID
            // 
            this.lblinfouserID.AutoSize = true;
            this.lblinfouserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfouserID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfouserID.Location = new System.Drawing.Point(280, 269);
            this.lblinfouserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfouserID.Name = "lblinfouserID";
            this.lblinfouserID.Size = new System.Drawing.Size(2, 24);
            this.lblinfouserID.TabIndex = 33;
            // 
            // lblinfoIC
            // 
            this.lblinfoIC.AutoSize = true;
            this.lblinfoIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoIC.Location = new System.Drawing.Point(280, 219);
            this.lblinfoIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoIC.Name = "lblinfoIC";
            this.lblinfoIC.Size = new System.Drawing.Size(2, 24);
            this.lblinfoIC.TabIndex = 36;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(280, 420);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.TabIndex = 37;
            // 
            // txtCN
            // 
            this.txtCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCN.Location = new System.Drawing.Point(280, 367);
            this.txtCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(300, 30);
            this.txtCN.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(280, 320);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 30);
            this.txtEmail.TabIndex = 40;
            // 
            // picStu
            // 
            this.picStu.BackColor = System.Drawing.Color.White;
            this.picStu.Image = ((System.Drawing.Image)(resources.GetObject("picStu.Image")));
            this.picStu.Location = new System.Drawing.Point(662, 90);
            this.picStu.Margin = new System.Windows.Forms.Padding(2);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(152, 176);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 42;
            this.picStu.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(798, 483);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblinfoName
            // 
            this.lblinfoName.AutoSize = true;
            this.lblinfoName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinfoName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblinfoName.Location = new System.Drawing.Point(280, 172);
            this.lblinfoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoName.Name = "lblinfoName";
            this.lblinfoName.Size = new System.Drawing.Size(2, 24);
            this.lblinfoName.TabIndex = 55;
            // 
            // Manager_UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.lblinfoName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblinfoIC);
            this.Controls.Add(this.lblinfouserID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.lblIC);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager_UpdateProfile";
            this.Text = "Update_Profile";
            this.Load += new System.EventHandler(this.Manager_UpdateProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMainMenu;
        private Button btnLogOut;
        private Label lblTitle;
        private Label lblName;
        private Label lblUserID;
        private Label lblPassword;
        private Label lblIC;
        private Label lblCN;
        private Label lblEmail;
        private Label lblinfouserID;
        private Label lblinfoIC;
        private TextBox txtPassword;
        private TextBox txtCN;
        private TextBox txtEmail;
        private PictureBox picStu;
        private Button btnUpdate;
        private Label lblinfoName;
    }
}