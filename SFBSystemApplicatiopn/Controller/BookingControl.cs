using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFBSystemApplicatiopn
{
    public class BookingControl
    {
        private frmBookingFacility frmbookingfacility;
       
        public void selectNewBooking()
        {
            frmbookingfacility = new frmBookingFacility(this);
            frmbookingfacility.Show();
        }

        
        
    }
}
