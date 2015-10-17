using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFBSystemApplicatiopn
{
    public class EnquiryFacilityControl
    {
        private frmEnquirySportsFacility enquiryFacility;

        public void selectEnquiryFacility()
        {
            enquiryFacility = new frmEnquirySportsFacility();
            enquiryFacility.Show();
        }
    }
}
