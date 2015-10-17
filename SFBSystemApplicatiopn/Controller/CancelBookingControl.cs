using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFBSystemApplicatiopn
{
    public class CancelBookingControl
    {
        private frmCancelABooking frmcancelabooking;

        public void selectCancelBooking()
        {
            frmcancelabooking = new frmCancelABooking(this);
            frmcancelabooking.Show();
        }
    }
}
