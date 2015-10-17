namespace SFBSystemApplicatiopn
{
    partial class frmMaintainSportsFacility
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
            this.txtCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboFacilityStatus = new System.Windows.Forms.ComboBox();
            this.cboSportsType = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtSportsFacilityName = new System.Windows.Forms.TextBox();
            this.txtSportsFacilityID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(251, 474);
            this.txtCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(80, 25);
            this.txtCancel.TabIndex = 32;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 474);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboFacilityStatus
            // 
            this.cboFacilityStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFacilityStatus.FormattingEnabled = true;
            this.cboFacilityStatus.Location = new System.Drawing.Point(206, 433);
            this.cboFacilityStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFacilityStatus.Name = "cboFacilityStatus";
            this.cboFacilityStatus.Size = new System.Drawing.Size(184, 24);
            this.cboFacilityStatus.TabIndex = 30;
            // 
            // cboSportsType
            // 
            this.cboSportsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSportsType.Enabled = false;
            this.cboSportsType.FormattingEnabled = true;
            this.cboSportsType.Location = new System.Drawing.Point(205, 106);
            this.cboSportsType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSportsType.Name = "cboSportsType";
            this.cboSportsType.Size = new System.Drawing.Size(185, 24);
            this.cboSportsType.TabIndex = 31;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(206, 357);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(226, 68);
            this.txtRemarks.TabIndex = 26;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // txtSportsFacilityName
            // 
            this.txtSportsFacilityName.Enabled = false;
            this.txtSportsFacilityName.Location = new System.Drawing.Point(205, 138);
            this.txtSportsFacilityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSportsFacilityName.Name = "txtSportsFacilityName";
            this.txtSportsFacilityName.Size = new System.Drawing.Size(185, 22);
            this.txtSportsFacilityName.TabIndex = 27;
            // 
            // txtSportsFacilityID
            // 
            this.txtSportsFacilityID.Enabled = false;
            this.txtSportsFacilityID.Location = new System.Drawing.Point(204, 76);
            this.txtSportsFacilityID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSportsFacilityID.Name = "txtSportsFacilityID";
            this.txtSportsFacilityID.Size = new System.Drawing.Size(186, 22);
            this.txtSportsFacilityID.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sports Facility Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Remarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sports Facility Picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sports Facility Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sports Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sports Facility ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(155, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 16);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Maintain Sports Facility";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(205, 168);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(227, 181);
            this.btnUpload.TabIndex = 41;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // frmMaintainSportsFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 512);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboFacilityStatus);
            this.Controls.Add(this.cboSportsType);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtSportsFacilityName);
            this.Controls.Add(this.txtSportsFacilityID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmMaintainSportsFacility";
            this.Text = "MaintainSportsFacility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboFacilityStatus;
        private System.Windows.Forms.ComboBox cboSportsType;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtSportsFacilityName;
        private System.Windows.Forms.TextBox txtSportsFacilityID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpload;
    }
}