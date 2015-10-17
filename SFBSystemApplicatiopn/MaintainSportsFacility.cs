using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFBSystemApplicatiopn
{
    public partial class frmMaintainSportsFacility : Form
    {
        MaintainFacilityControl myCaller;

        public frmMaintainSportsFacility()
        {
            InitializeComponent();
        }
        public frmMaintainSportsFacility(MaintainFacilityControl maintain):this()
        {
            myCaller = maintain;
        }
        public void AcceptSpecFacilityInfo(SportFacility s,List<SportType> sl)
        {
            txtSportsFacilityID.Text = s.SportFacilityID.ToString();

            cboSportsType.DataSource = sl;
            cboSportsType.DisplayMember = "SportTypeName";
            cboSportsType.ValueMember = "SportTypeID";
            cboSportsType.SelectedValue = s.SportTypeID;
           
            txtSportsFacilityName.Text = s.SportFacilityName;
            try {
                btnUpload.BackgroundImage = myCaller.ByteToImage(s.Picture);
                txtRemarks.Text = s.Remarks;
            }
            catch(SystemException se)
            {
                
            }

            cboFacilityStatus.Items.Add("Broken");
            cboFacilityStatus.Items.Add("Normal");
            cboFacilityStatus.Items.Add("UnderMaintain");
            cboFacilityStatus.SelectedIndex = Convert.ToInt32(s.FacilityStatus);
            switch (cboFacilityStatus.SelectedText)
            {
                case "Broken":
                    cboFacilityStatus.SelectedValue = '0';
                    break;
                case "Normal":
                    cboFacilityStatus.SelectedValue = '1';
                    break;
                case "UnderMaintain":
                    cboFacilityStatus.SelectedValue = '2';
                    break;
            }
            cboFacilityStatus.SelectedValue = s.FacilityStatus;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 3. click save button will create a new SportFacility Object
            int id = Convert.ToInt32(txtSportsFacilityID.Text);
            // 4. at here we use myCaller.Ent  
            var d = from x in myCaller.Ent.SportFacilities where x.SportFacilityID == id select x;
            SportFacility sf = d.First();
            sf.SportFacilityID = Convert.ToInt32(txtSportsFacilityID.Text);
            sf.SportFacilityName = txtSportsFacilityName.Text;
            sf.SportTypeID = Convert.ToInt32(cboSportsType.SelectedValue.ToString());
            try
            {
                sf.Picture = myCaller.ImageToByte(btnUpload.BackgroundImage);
            }
            catch (SystemException se)
            {
            }
            sf.Remarks = txtRemarks.Text;
            sf.FacilityStatus = cboFacilityStatus.SelectedIndex.ToString();
            // 5. after set value to the SportFacility Object, will call the controller to save it
            myCaller.SelectSave();
        }

        private void cboFacilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            btnUpload.BackgroundImage = Image.FromFile(open.FileName);
        }
    }
}
