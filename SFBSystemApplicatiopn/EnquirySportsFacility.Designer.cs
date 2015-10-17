namespace SFBSystemApplicatiopn
{
    partial class frmEnquirySportsFacility
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
            this.gbAvailableTiming = new System.Windows.Forms.GroupBox();
            this.cboTimeSlots = new System.Windows.Forms.ComboBox();
            this.cboTimeShift = new System.Windows.Forms.ComboBox();
            this.rdoTimeShift = new System.Windows.Forms.RadioButton();
            this.rdoTimeSlots = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSportsTypeName = new System.Windows.Forms.ComboBox();
            this.dgvSportsFacility = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbAvailableTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAvailableTiming
            // 
            this.gbAvailableTiming.Controls.Add(this.cboTimeSlots);
            this.gbAvailableTiming.Controls.Add(this.cboTimeShift);
            this.gbAvailableTiming.Controls.Add(this.rdoTimeShift);
            this.gbAvailableTiming.Controls.Add(this.rdoTimeSlots);
            this.gbAvailableTiming.Location = new System.Drawing.Point(12, 110);
            this.gbAvailableTiming.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAvailableTiming.Name = "gbAvailableTiming";
            this.gbAvailableTiming.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAvailableTiming.Size = new System.Drawing.Size(317, 112);
            this.gbAvailableTiming.TabIndex = 9;
            this.gbAvailableTiming.TabStop = false;
            this.gbAvailableTiming.Text = "Available Timing";
            // 
            // cboTimeSlots
            // 
            this.cboTimeSlots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeSlots.FormattingEnabled = true;
            this.cboTimeSlots.Location = new System.Drawing.Point(150, 61);
            this.cboTimeSlots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTimeSlots.Name = "cboTimeSlots";
            this.cboTimeSlots.Size = new System.Drawing.Size(146, 24);
            this.cboTimeSlots.TabIndex = 4;
            // 
            // cboTimeShift
            // 
            this.cboTimeShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeShift.FormattingEnabled = true;
            this.cboTimeShift.Location = new System.Drawing.Point(150, 27);
            this.cboTimeShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTimeShift.Name = "cboTimeShift";
            this.cboTimeShift.Size = new System.Drawing.Size(146, 24);
            this.cboTimeShift.TabIndex = 4;
            // 
            // rdoTimeShift
            // 
            this.rdoTimeShift.AutoSize = true;
            this.rdoTimeShift.Location = new System.Drawing.Point(27, 63);
            this.rdoTimeShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTimeShift.Name = "rdoTimeShift";
            this.rdoTimeShift.Size = new System.Drawing.Size(88, 20);
            this.rdoTimeShift.TabIndex = 0;
            this.rdoTimeShift.TabStop = true;
            this.rdoTimeShift.Text = "Time Slots";
            this.rdoTimeShift.UseVisualStyleBackColor = true;
            // 
            // rdoTimeSlots
            // 
            this.rdoTimeSlots.AutoSize = true;
            this.rdoTimeSlots.Location = new System.Drawing.Point(27, 29);
            this.rdoTimeSlots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTimeSlots.Name = "rdoTimeSlots";
            this.rdoTimeSlots.Size = new System.Drawing.Size(84, 20);
            this.rdoTimeSlots.TabIndex = 0;
            this.rdoTimeSlots.TabStop = true;
            this.rdoTimeSlots.Text = "Time Shift";
            this.rdoTimeSlots.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sports Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enquiry Sports Facility";
            // 
            // cboSportsTypeName
            // 
            this.cboSportsTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSportsTypeName.FormattingEnabled = true;
            this.cboSportsTypeName.Location = new System.Drawing.Point(143, 65);
            this.cboSportsTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSportsTypeName.Name = "cboSportsTypeName";
            this.cboSportsTypeName.Size = new System.Drawing.Size(186, 24);
            this.cboSportsTypeName.TabIndex = 10;
            // 
            // dgvSportsFacility
            // 
            this.dgvSportsFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportsFacility.Location = new System.Drawing.Point(12, 240);
            this.dgvSportsFacility.Name = "dgvSportsFacility";
            this.dgvSportsFacility.Size = new System.Drawing.Size(440, 281);
            this.dgvSportsFacility.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 197);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmEnquirySportsFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 533);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSportsFacility);
            this.Controls.Add(this.gbAvailableTiming);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSportsTypeName);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmEnquirySportsFacility";
            this.Text = "EnquirySportsFacility";
            this.Load += new System.EventHandler(this.frmEnquirySportsFacility_Load);
            this.gbAvailableTiming.ResumeLayout(false);
            this.gbAvailableTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportsFacility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAvailableTiming;
        private System.Windows.Forms.ComboBox cboTimeSlots;
        private System.Windows.Forms.ComboBox cboTimeShift;
        private System.Windows.Forms.RadioButton rdoTimeShift;
        private System.Windows.Forms.RadioButton rdoTimeSlots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSportsTypeName;
        private System.Windows.Forms.DataGridView dgvSportsFacility;
        private System.Windows.Forms.Button btnSearch;
    }
}