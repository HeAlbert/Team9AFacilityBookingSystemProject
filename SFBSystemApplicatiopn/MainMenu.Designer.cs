namespace SFBSystemApplicatiopn
{
    partial class frmMainMenu
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msiMember = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.maintainMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiFacility = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNewFacility = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.msiMaintainFacility = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.enquiryFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNewBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.msiCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMaintainMember = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.occupancyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiMember,
            this.msiFacility,
            this.bookingToolStripMenuItem,
            this.msiMaintainMember});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.msMainMenu.Size = new System.Drawing.Size(464, 26);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "MainMenu";
            // 
            // msiMember
            // 
            this.msiMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNewMember,
            this.toolStripMenuItem1,
            this.maintainMemberToolStripMenuItem});
            this.msiMember.Name = "msiMember";
            this.msiMember.Size = new System.Drawing.Size(67, 20);
            this.msiMember.Text = "&Member";
            // 
            // msiNewMember
            // 
            this.msiNewMember.Name = "msiNewMember";
            this.msiNewMember.Size = new System.Drawing.Size(176, 22);
            this.msiNewMember.Text = "&New Member";
            this.msiNewMember.Click += new System.EventHandler(this.msiNewMember_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // maintainMemberToolStripMenuItem
            // 
            this.maintainMemberToolStripMenuItem.Name = "maintainMemberToolStripMenuItem";
            this.maintainMemberToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.maintainMemberToolStripMenuItem.Text = "&Maintain Member";
            this.maintainMemberToolStripMenuItem.Click += new System.EventHandler(this.maintainMemberToolStripMenuItem_Click);
            // 
            // msiFacility
            // 
            this.msiFacility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNewFacility,
            this.toolStripMenuItem2,
            this.msiMaintainFacility,
            this.toolStripMenuItem5,
            this.enquiryFacilityToolStripMenuItem});
            this.msiFacility.Name = "msiFacility";
            this.msiFacility.Size = new System.Drawing.Size(62, 20);
            this.msiFacility.Text = "&Facility";
            // 
            // msiNewFacility
            // 
            this.msiNewFacility.Name = "msiNewFacility";
            this.msiNewFacility.Size = new System.Drawing.Size(171, 22);
            this.msiNewFacility.Text = "&New Facility";
            this.msiNewFacility.Click += new System.EventHandler(this.msiNewFacility_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // msiMaintainFacility
            // 
            this.msiMaintainFacility.Name = "msiMaintainFacility";
            this.msiMaintainFacility.Size = new System.Drawing.Size(171, 22);
            this.msiMaintainFacility.Text = "&Maintain Facility";
            this.msiMaintainFacility.Click += new System.EventHandler(this.msiMaintainFacility_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(168, 6);
            // 
            // enquiryFacilityToolStripMenuItem
            // 
            this.enquiryFacilityToolStripMenuItem.Name = "enquiryFacilityToolStripMenuItem";
            this.enquiryFacilityToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.enquiryFacilityToolStripMenuItem.Text = "&Enquiry Facility";
            this.enquiryFacilityToolStripMenuItem.Click += new System.EventHandler(this.enquiryFacilityToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNewBooking,
            this.toolStripMenuItem3,
            this.msiCancelBooking});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bookingToolStripMenuItem.Text = "&Booking";
            // 
            // msiNewBooking
            // 
            this.msiNewBooking.Name = "msiNewBooking";
            this.msiNewBooking.Size = new System.Drawing.Size(167, 22);
            this.msiNewBooking.Text = "&New Booking";
            this.msiNewBooking.Click += new System.EventHandler(this.msiNewBooking_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // msiCancelBooking
            // 
            this.msiCancelBooking.Name = "msiCancelBooking";
            this.msiCancelBooking.Size = new System.Drawing.Size(167, 22);
            this.msiCancelBooking.Text = "&Cancel Booking";
            this.msiCancelBooking.Click += new System.EventHandler(this.msiCancelBooking_Click);
            // 
            // msiMaintainMember
            // 
            this.msiMaintainMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberListToolStripMenuItem,
            this.toolStripMenuItem4,
            this.occupancyReportToolStripMenuItem,
            this.trendReportToolStripMenuItem});
            this.msiMaintainMember.Name = "msiMaintainMember";
            this.msiMaintainMember.Size = new System.Drawing.Size(58, 20);
            this.msiMaintainMember.Text = "&Report";
            this.msiMaintainMember.Click += new System.EventHandler(this.msiMaintainMember_Click);
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.memberListToolStripMenuItem.Text = "&Member List";
            this.memberListToolStripMenuItem.Click += new System.EventHandler(this.memberListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // occupancyReportToolStripMenuItem
            // 
            this.occupancyReportToolStripMenuItem.Name = "occupancyReportToolStripMenuItem";
            this.occupancyReportToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.occupancyReportToolStripMenuItem.Text = "Occupancy Report";
            this.occupancyReportToolStripMenuItem.Click += new System.EventHandler(this.occupancyReportToolStripMenuItem_Click);
            // 
            // trendReportToolStripMenuItem
            // 
            this.trendReportToolStripMenuItem.Name = "trendReportToolStripMenuItem";
            this.trendReportToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.trendReportToolStripMenuItem.Text = "Trend Report";
            this.trendReportToolStripMenuItem.Click += new System.EventHandler(this.trendReportToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 512);
            this.Controls.Add(this.msMainMenu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msiMember;
        private System.Windows.Forms.ToolStripMenuItem msiNewMember;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maintainMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiFacility;
        private System.Windows.Forms.ToolStripMenuItem msiNewFacility;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem msiMaintainFacility;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiNewBooking;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem msiCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem msiMaintainMember;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem enquiryFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem occupancyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendReportToolStripMenuItem;
    }
}