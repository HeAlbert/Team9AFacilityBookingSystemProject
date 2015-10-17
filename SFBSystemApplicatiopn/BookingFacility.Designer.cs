namespace SFBSystemApplicatiopn
{
    partial class frmBookingFacility
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpUseDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSportFacilityName = new System.Windows.Forms.ComboBox();
            this.cboSportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAvailableTiming = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboTimeSlot2 = new System.Windows.Forms.ComboBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.cboTimeSlot1 = new System.Windows.Forms.ComboBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAvailableTiming.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Facility";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(86, 89);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(117, 20);
            this.txtMemberID.TabIndex = 25;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(86, 63);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(117, 20);
            this.txtBookingID.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 24;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Member ID :";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(13, 66);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(66, 13);
            this.lblBookingID.TabIndex = 23;
            this.lblBookingID.Text = "Booking ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpUseDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpBookingDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(238, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(204, 71);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            // 
            // dtpUseDate
            // 
            this.dtpUseDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUseDate.Location = new System.Drawing.Point(93, 42);
            this.dtpUseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpUseDate.Name = "dtpUseDate";
            this.dtpUseDate.Size = new System.Drawing.Size(99, 20);
            this.dtpUseDate.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Booking Date :";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(93, 20);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(99, 20);
            this.dtpBookingDate.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Use Date :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboSportFacilityName);
            this.groupBox2.Controls.Add(this.cboSportType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gbAvailableTiming);
            this.groupBox2.Location = new System.Drawing.Point(10, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(432, 135);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sports Facility";
            // 
            // cboSportFacilityName
            // 
            this.cboSportFacilityName.FormattingEnabled = true;
            this.cboSportFacilityName.Location = new System.Drawing.Point(93, 50);
            this.cboSportFacilityName.Name = "cboSportFacilityName";
            this.cboSportFacilityName.Size = new System.Drawing.Size(126, 21);
            this.cboSportFacilityName.TabIndex = 4;
            // 
            // cboSportType
            // 
            this.cboSportType.FormattingEnabled = true;
            this.cboSportType.Location = new System.Drawing.Point(93, 26);
            this.cboSportType.Name = "cboSportType";
            this.cboSportType.Size = new System.Drawing.Size(126, 21);
            this.cboSportType.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sports Type";
            // 
            // gbAvailableTiming
            // 
            this.gbAvailableTiming.Controls.Add(this.comboBox1);
            this.gbAvailableTiming.Controls.Add(this.cboTimeSlot2);
            this.gbAvailableTiming.Controls.Add(this.btnAdd2);
            this.gbAvailableTiming.Controls.Add(this.cboTimeSlot1);
            this.gbAvailableTiming.Controls.Add(this.btnAdd1);
            this.gbAvailableTiming.Location = new System.Drawing.Point(231, 18);
            this.gbAvailableTiming.Name = "gbAvailableTiming";
            this.gbAvailableTiming.Size = new System.Drawing.Size(183, 104);
            this.gbAvailableTiming.TabIndex = 10;
            this.gbAvailableTiming.TabStop = false;
            this.gbAvailableTiming.Text = "Time Slots";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // cboTimeSlot2
            // 
            this.cboTimeSlot2.FormattingEnabled = true;
            this.cboTimeSlot2.Location = new System.Drawing.Point(57, 45);
            this.cboTimeSlot2.Name = "cboTimeSlot2";
            this.cboTimeSlot2.Size = new System.Drawing.Size(115, 21);
            this.cboTimeSlot2.TabIndex = 4;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(17, 72);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(26, 18);
            this.btnAdd2.TabIndex = 24;
            this.btnAdd2.Text = "+";
            this.btnAdd2.UseVisualStyleBackColor = true;
            // 
            // cboTimeSlot1
            // 
            this.cboTimeSlot1.FormattingEnabled = true;
            this.cboTimeSlot1.Location = new System.Drawing.Point(57, 19);
            this.cboTimeSlot1.Name = "cboTimeSlot1";
            this.cboTimeSlot1.Size = new System.Drawing.Size(115, 21);
            this.cboTimeSlot1.TabIndex = 4;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(17, 46);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(26, 18);
            this.btnAdd1.TabIndex = 24;
            this.btnAdd1.Text = "+";
            this.btnAdd1.UseVisualStyleBackColor = true;
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(288, 292);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(69, 20);
            this.txtCancel.TabIndex = 31;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(376, 292);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(69, 20);
            this.btnConfirm.TabIndex = 32;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmBookingFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 375);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBookingFacility";
            this.Text = "Booking Facility";
            this.Load += new System.EventHandler(this.frmBookingFacility_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAvailableTiming.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpUseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbAvailableTiming;
        private System.Windows.Forms.ComboBox cboTimeSlot2;
        private System.Windows.Forms.ComboBox cboTimeSlot1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSportFacilityName;
        private System.Windows.Forms.ComboBox cboSportType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}