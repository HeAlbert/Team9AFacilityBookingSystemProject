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
    public partial class frmSearchMember : Form
    {
        private MaintianMemberControl mCaller; 
        public frmSearchMember()
        {
            InitializeComponent();
        }

        public frmSearchMember(MaintianMemberControl maintainmembercontrol) : this()
        {
            mCaller = maintainmembercontrol;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mCaller.selectUpdate();
        }

        private void frmSearchMember_Load(object sender, EventArgs e)
        {
            
        }
    }
}
