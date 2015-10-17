namespace SFBSystemApplicatiopn
{
    partial class frmCreateNewSportsFacility
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.cboSportsType = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtSportsFacilityName = new System.Windows.Forms.TextBox();
            this.txtSportsFacilityID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(202, 183);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(218, 201);
            this.btnUpload.TabIndex = 40;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cboSportsType
            // 
            this.cboSportsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSportsType.FormattingEnabled = true;
            this.cboSportsType.Location = new System.Drawing.Point(201, 121);
            this.cboSportsType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSportsType.Name = "cboSportsType";
            this.cboSportsType.Size = new System.Drawing.Size(217, 24);
            this.cboSportsType.TabIndex = 39;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(203, 392);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(217, 68);
            this.txtRemarks.TabIndex = 36;
            // 
            // txtSportsFacilityName
            // 
            this.txtSportsFacilityName.Location = new System.Drawing.Point(202, 153);
            this.txtSportsFacilityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSportsFacilityName.Name = "txtSportsFacilityName";
            this.txtSportsFacilityName.Size = new System.Drawing.Size(217, 22);
            this.txtSportsFacilityName.TabIndex = 37;
            // 
            // txtSportsFacilityID
            // 
            this.txtSportsFacilityID.Location = new System.Drawing.Point(201, 91);
            this.txtSportsFacilityID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSportsFacilityID.Name = "txtSportsFacilityID";
            this.txtSportsFacilityID.ReadOnly = true;
            this.txtSportsFacilityID.Size = new System.Drawing.Size(217, 22);
            this.txtSportsFacilityID.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Remarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sports Facility Picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sports Facility Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sports Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sports Facility ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 480);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(340, 480);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(144, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 16);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Register New Sports Facility";
            // 
            // frmCreateNewSportsFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 512);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.cboSportsType);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtSportsFacilityName);
            this.Controls.Add(this.txtSportsFacilityID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmCreateNewSportsFacility";
            this.Text = "CreateNewSportsFacility";
            this.Load += new System.EventHandler(this.frmCreateNewSportsFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox cboSportsType;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtSportsFacilityName;
        private System.Windows.Forms.TextBox txtSportsFacilityID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
    }
}