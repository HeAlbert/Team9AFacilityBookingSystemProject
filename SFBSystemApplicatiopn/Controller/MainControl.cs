using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFBSystemApplicatiopn
{
    public class MainControl
    {
        private MaintianMemberControl maintainmembercontrol;
        private NewMemberControl newmembercontrol;
        private CreateNewSportFacilityControl newSportsFacilitycontrol;
        private MaintainFacilityControl maintainFacilityControl;
        private EnquiryFacilityControl enquiryFacilityControl;
        private BookingControl bookingControl;
        private CancelBookingControl cancelBookingControl;
        
        
        public void MainMenu()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu(this));
        }

        public void selectNewMember()
        {
            newmembercontrol = new NewMemberControl();
            newmembercontrol.SelectNewMember();
        }
        public void selectSearchMember()
        {            
            maintainmembercontrol=new MaintianMemberControl();
            maintainmembercontrol.selectSearchMember();
          
        }
        public void selectMaintainMember()
        {
            maintainmembercontrol = new MaintianMemberControl();
            maintainmembercontrol.selectUpdate();

        }

        public void selectNewSportsFacility()
        {
            newSportsFacilitycontrol = new CreateNewSportFacilityControl();
            newSportsFacilitycontrol.selectCreateNewSportsFacility();
        }

        public void selectMaintainFacility()
        {
            maintainFacilityControl = new MaintainFacilityControl();
            maintainFacilityControl.selectsearchFacility();
        }
        
        public void selectEnquiryFacility()
        {
            enquiryFacilityControl = new EnquiryFacilityControl();
            enquiryFacilityControl.selectEnquiryFacility();
        }

        public void selectCancelBooking()
        {
            cancelBookingControl = new CancelBookingControl();
            cancelBookingControl.selectCancelBooking();

        }
        public void selectNewBooking()
        {
            bookingControl = new BookingControl();
            bookingControl.selectNewBooking();
        }
         
    }
}
