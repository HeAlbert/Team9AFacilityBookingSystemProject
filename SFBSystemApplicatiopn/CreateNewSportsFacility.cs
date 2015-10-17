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
    public partial class frmCreateNewSportsFacility : Form
    {
        private CreateNewSportFacilityControl myCaller;
        public frmCreateNewSportsFacility()
        {
            InitializeComponent();
        }

        public frmCreateNewSportsFacility(CreateNewSportFacilityControl control):this()
        {
            myCaller = control;
        }
      


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SportFacility s = new SportFacility();
            s.SportTypeID = (int)cboSportsType.SelectedValue;
            s.SportFacilityName = txtSportsFacilityName.Text;
            s.Picture = myCaller.ImageToByte((btnUpload.BackgroundImage));
            s.FacilityStatus = "1";
            s.Remarks = txtRemarks.Text;
            myCaller.SelectSave(s);
        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            btnUpload.BackgroundImage = Image.FromFile(open.FileName);
        }
        public void AcceptSportsFacilityInfo(List<SportType> ST)
        {
           
            cboSportsType.DataSource = ST;
            cboSportsType.DisplayMember = "SportTypeName";
            cboSportsType.ValueMember = "SportTypeID";
        }

        private void frmCreateNewSportsFacility_Load(object sender, EventArgs e)
        {
            myCaller.CreateNewSportFacility(); 
        }
    }
}
