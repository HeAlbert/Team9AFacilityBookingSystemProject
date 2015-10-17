using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Objects;

namespace SFBSystemApplicatiopn
{
    public class NewMemberControl
    {
        private frmCreateNewMember createNewMember;        

        public void SelectNewMember()
        {
            createNewMember = new frmCreateNewMember();
            createNewMember.Show();            
        }

        public void selectSave()
        {
            SportsFacilityBookingEntities1 ent = new SportsFacilityBookingEntities1();
            
        }
        
    }
}
