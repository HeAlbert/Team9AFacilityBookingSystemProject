using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFBSystemApplicatiopn
{
    public class MaintianMemberControl
    {
        private frmSearchMember searchMember;
        private frmMaintainMember maintainMember;
        private frmMemberList memberList;

        public void selectSearchMember()
        {
            searchMember = new frmSearchMember(this);
            searchMember.Show();            
        }

        public void selectUpdate()
        {
            maintainMember = new frmMaintainMember(this);
            maintainMember.Show();
        }

        public void SelectPrint()
        {
            memberList = new frmMemberList();
            memberList.ShowDialog();
            
        }
    }
}
