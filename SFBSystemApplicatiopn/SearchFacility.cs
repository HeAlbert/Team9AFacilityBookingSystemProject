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
    public partial class frmSearchFacility : Form
    {
        private MaintainFacilityControl myCaller;
        public frmSearchFacility()
        {
            InitializeComponent();
        }
        public frmSearchFacility(MaintainFacilityControl maintain):this()
        {
            myCaller = maintain;
        }
           

        public void AcceptSportTypeInfo(List<SportType> s )
        {
            cboFacilityType.DataSource = s;
            cboFacilityType.DisplayMember = "SportTypeName";
            cboFacilityType.ValueMember = "SportTypeID";
        }
        public void AcceptFacilityInfo(List<SportFacility> s)
        {
            cboFacilityName.DataSource = s;
            cboFacilityName.DisplayMember = "SportFacilityName";
            cboFacilityName.ValueMember = "SportFacilityID";
            
        }

        private void cboFacilityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cboFacilityType.SelectedValue.ToString();

            if (i.Length > 4) { }
            else
                myCaller.GetFacilityInfo(i);
        }

        private void frmSearchFacility_Load(object sender, EventArgs e)
        {
            myCaller.GetSportTypeInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(cboFacilityName.SelectedValue);
            myCaller.selctmaintainFacility();
            myCaller.GetSpecFacilityInfo(i);
        }
    }
}
