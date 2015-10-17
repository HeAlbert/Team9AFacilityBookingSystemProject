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
    public partial class frmMainMenu : Form
    {
        private MainControl mCaller;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public frmMainMenu(MainControl maincontrol):this()
        {
            mCaller = maincontrol;
        }

        private void msiNewMember_Click(object sender, EventArgs e)
        {
            mCaller.selectNewMember();
        }

        private void maintainMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mCaller.selectSearchMember();           
        }               

        private void msiNewFacility_Click(object sender, EventArgs e)
        {
            mCaller.selectNewSportsFacility();
        }

        private void msiMaintainFacility_Click(object sender, EventArgs e)
        {
            mCaller.selectMaintainFacility();
        }

        private void enquiryFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mCaller.selectEnquiryFacility();
        }

        private void msiCancelBooking_Click(object sender, EventArgs e)
        {
            mCaller.selectCancelBooking();
        }

        private void msiNewBooking_Click(object sender, EventArgs e)
        {
            mCaller.selectNewBooking();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

    }
}
