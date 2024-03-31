namespace Group8
{
    partial class MonthlyIncomeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyIncomeReport));
            this.btnView = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblSalaryDetails = new System.Windows.Forms.Label();
            this.lblClubFeesDetails = new System.Windows.Forms.Label();
            this.lblTotalFeesDetails = new System.Windows.Forms.Label();
            this.lblMemberDetails = new System.Windows.Forms.Label();
            this.lblFeesDetails = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblClubFees = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblCoachID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCoachID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(86, 336);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 36);
            this.btnView.TabIndex = 46;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(86, 385);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 36);
            this.btnMenu.TabIndex = 45;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.InitialImage")));
            this.picBoxLogo.Location = new System.Drawing.Point(760, 23);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(96, 90);
            this.picBoxLogo.TabIndex = 44;
            this.picBoxLogo.TabStop = false;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblSalaryDetails);
            this.gbData.Controls.Add(this.lblClubFeesDetails);
            this.gbData.Controls.Add(this.lblTotalFeesDetails);
            this.gbData.Controls.Add(this.lblMemberDetails);
            this.gbData.Controls.Add(this.lblFeesDetails);
            this.gbData.Controls.Add(this.lblSalary);
            this.gbData.Controls.Add(this.lblClubFees);
            this.gbData.Controls.Add(this.lblEx);
            this.gbData.Controls.Add(this.lblTotalFees);
            this.gbData.Controls.Add(this.lblMembers);
            this.gbData.Controls.Add(this.lblFees);
            this.gbData.Location = new System.Drawing.Point(289, 133);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(567, 379);
            this.gbData.TabIndex = 43;
            this.gbData.TabStop = false;
            this.gbData.Text = "Monthly Earnings";
            // 
            // lblSalaryDetails
            // 
            this.lblSalaryDetails.AutoSize = true;
            this.lblSalaryDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryDetails.Location = new System.Drawing.Point(467, 320);
            this.lblSalaryDetails.Name = "lblSalaryDetails";
            this.lblSalaryDetails.Size = new System.Drawing.Size(0, 22);
            this.lblSalaryDetails.TabIndex = 46;
            // 
            // lblClubFeesDetails
            // 
            this.lblClubFeesDetails.AutoSize = true;
            this.lblClubFeesDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubFeesDetails.Location = new System.Drawing.Point(467, 201);
            this.lblClubFeesDetails.Name = "lblClubFeesDetails";
            this.lblClubFeesDetails.Size = new System.Drawing.Size(0, 22);
            this.lblClubFeesDetails.TabIndex = 44;
            // 
            // lblTotalFeesDetails
            // 
            this.lblTotalFeesDetails.AutoSize = true;
            this.lblTotalFeesDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesDetails.Location = new System.Drawing.Point(467, 103);
            this.lblTotalFeesDetails.Name = "lblTotalFeesDetails";
            this.lblTotalFeesDetails.Size = new System.Drawing.Size(0, 22);
            this.lblTotalFeesDetails.TabIndex = 43;
            // 
            // lblMemberDetails
            // 
            this.lblMemberDetails.AutoSize = true;
            this.lblMemberDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberDetails.Location = new System.Drawing.Point(467, 64);
            this.lblMemberDetails.Name = "lblMemberDetails";
            this.lblMemberDetails.Size = new System.Drawing.Size(0, 22);
            this.lblMemberDetails.TabIndex = 42;
            // 
            // lblFeesDetails
            // 
            this.lblFeesDetails.AutoSize = true;
            this.lblFeesDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesDetails.Location = new System.Drawing.Point(467, 27);
            this.lblFeesDetails.Name = "lblFeesDetails";
            this.lblFeesDetails.Size = new System.Drawing.Size(30, 22);
            this.lblFeesDetails.TabIndex = 41;
            this.lblFeesDetails.Text = "50";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(6, 320);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(67, 22);
            this.lblSalary.TabIndex = 40;
            this.lblSalary.Text = "Salary:";
            // 
            // lblClubFees
            // 
            this.lblClubFees.AutoSize = true;
            this.lblClubFees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubFees.Location = new System.Drawing.Point(53, 201);
            this.lblClubFees.Name = "lblClubFees";
            this.lblClubFees.Size = new System.Drawing.Size(96, 22);
            this.lblClubFees.TabIndex = 38;
            this.lblClubFees.Text = "Club Fees:";
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx.Location = new System.Drawing.Point(6, 158);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(90, 22);
            this.lblEx.TabIndex = 37;
            this.lblEx.Text = "Expenses:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(53, 103);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(57, 22);
            this.lblTotalFees.TabIndex = 36;
            this.lblTotalFees.Text = "Total:";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(53, 64);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(179, 22);
            this.lblMembers.TabIndex = 35;
            this.lblMembers.Text = "Number of Members:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(6, 27);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(150, 22);
            this.lblFees.TabIndex = 34;
            this.lblFees.Text = "Fees (per month):";
            // 
            // cbMonth
            // 
            this.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cbMonth.Location = new System.Drawing.Point(52, 234);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(196, 24);
            this.cbMonth.TabIndex = 42;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(48, 209);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(66, 22);
            this.lblMonth.TabIndex = 40;
            this.lblMonth.Text = "Month:";
            // 
            // lblCoachID
            // 
            this.lblCoachID.AutoSize = true;
            this.lblCoachID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachID.Location = new System.Drawing.Point(48, 133);
            this.lblCoachID.Name = "lblCoachID";
            this.lblCoachID.Size = new System.Drawing.Size(86, 22);
            this.lblCoachID.TabIndex = 39;
            this.lblCoachID.Text = "CoachID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(47, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 25);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Monthly Income Report";
            // 
            // txtCoachID
            // 
            this.txtCoachID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoachID.Location = new System.Drawing.Point(52, 159);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.Size = new System.Drawing.Size(196, 22);
            this.txtCoachID.TabIndex = 47;
            // 
            // MonthlyIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.txtCoachID);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblCoachID);
            this.Controls.Add(this.lblTitle);
            this.Name = "MonthlyIncomeReport";
            this.Text = "MonthlyIncomeReport";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblSalaryDetails;
        private System.Windows.Forms.Label lblClubFeesDetails;
        private System.Windows.Forms.Label lblTotalFeesDetails;
        private System.Windows.Forms.Label lblMemberDetails;
        private System.Windows.Forms.Label lblFeesDetails;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblClubFees;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblCoachID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCoachID;
    }
}