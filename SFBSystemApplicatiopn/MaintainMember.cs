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
    public partial class frmMaintainMember : Form
    {
        private MaintianMemberControl myCaller;
        public frmMaintainMember()
        {
            InitializeComponent();
        }
        public frmMaintainMember(MaintianMemberControl maintainmembercontrol)
            : this()
        {
            myCaller = maintainmembercontrol;
        }
        private void frmMaintainMember_Load(object sender, EventArgs e)
        {
        }

       
    }
}
