namespace Group8
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblRoleDetails = new System.Windows.Forms.Label();
            this.lblUIDDetails = new System.Windows.Forms.Label();
            this.lblICDetails = new System.Windows.Forms.Label();
            this.lblNameDetails = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblRoleDetails);
            this.gbData.Controls.Add(this.lblUIDDetails);
            this.gbData.Controls.Add(this.lblICDetails);
            this.gbData.Controls.Add(this.lblNameDetails);
            this.gbData.Controls.Add(this.btnCancel);
            this.gbData.Controls.Add(this.cbLevel);
            this.gbData.Controls.Add(this.lblLevel);
            this.gbData.Controls.Add(this.lblRole);
            this.gbData.Controls.Add(this.txtPass);
            this.gbData.Controls.Add(this.txtEmail);
            this.gbData.Controls.Add(this.txtContact);
            this.gbData.Controls.Add(this.lblPass);
            this.gbData.Controls.Add(this.lblUID);
            this.gbData.Controls.Add(this.lblEmail);
            this.gbData.Controls.Add(this.lblContact);
            this.gbData.Controls.Add(this.lblIC);
            this.gbData.Controls.Add(this.lblName);
            this.gbData.Controls.Add(this.btnUpdate);
            this.gbData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(91, 193);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(742, 303);
            this.gbData.TabIndex = 37;
            this.gbData.TabStop = false;
            // 
            // lblRoleDetails
            // 
            this.lblRoleDetails.AutoSize = true;
            this.lblRoleDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleDetails.Location = new System.Drawing.Point(512, 34);
            this.lblRoleDetails.Name = "lblRoleDetails";
            this.lblRoleDetails.Size = new System.Drawing.Size(0, 22);
            this.lblRoleDetails.TabIndex = 25;
            // 
            // lblUIDDetails
            // 
            this.lblUIDDetails.AutoSize = true;
            this.lblUIDDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUIDDetails.Location = new System.Drawing.Point(171, 203);
            this.lblUIDDetails.Name = "lblUIDDetails";
            this.lblUIDDetails.Size = new System.Drawing.Size(0, 22);
            this.lblUIDDetails.TabIndex = 24;
            // 
            // lblICDetails
            // 
            this.lblICDetails.AutoSize = true;
            this.lblICDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICDetails.Location = new System.Drawing.Point(171, 74);
            this.lblICDetails.Name = "lblICDetails";
            this.lblICDetails.Size = new System.Drawing.Size(0, 22);
            this.lblICDetails.TabIndex = 23;
            // 
            // lblNameDetails
            // 
            this.lblNameDetails.AutoSize = true;
            this.lblNameDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDetails.Location = new System.Drawing.Point(171, 34);
            this.lblNameDetails.Name = "lblNameDetails";
            this.lblNameDetails.Size = new System.Drawing.Size(0, 22);
            this.lblNameDetails.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(506, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbLevel
            // 
            this.cbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "N/A",
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cbLevel.Location = new System.Drawing.Point(514, 66);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(196, 27);
            this.cbLevel.TabIndex = 17;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(424, 71);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(61, 22);
            this.lblLevel.TabIndex = 14;
            this.lblLevel.Text = "Level:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(424, 34);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 22);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Role:";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Location = new System.Drawing.Point(175, 244);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 27);
            this.txtPass.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(175, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Location = new System.Drawing.Point(175, 108);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(178, 27);
            this.txtContact.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(6, 249);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(94, 22);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password:";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.Location = new System.Drawing.Point(6, 203);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(73, 22);
            this.lblUID.TabIndex = 4;
            this.lblUID.Text = "UserID:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(6, 113);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(144, 22);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIC.Location = new System.Drawing.Point(6, 74);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(35, 22);
            this.lblIC.TabIndex = 1;
            this.lblIC.Text = "IC:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(506, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 36);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.InitialImage")));
            this.picBoxLogo.Location = new System.Drawing.Point(760, 39);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(96, 90);
            this.picBoxLogo.TabIndex = 36;
            this.picBoxLogo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(607, 89);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 36);
            this.btnMenu.TabIndex = 35;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(47, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 25);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "User Management";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTitle);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblRoleDetails;
        private System.Windows.Forms.Label lblUIDDetails;
        private System.Windows.Forms.Label lblICDetails;
        private System.Windows.Forms.Label lblNameDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitle;
    }
}