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
    public partial class frmBookingFacility : Form
    {
        private BookingControl mCaller;
        public frmBookingFacility()
        {
            InitializeComponent();
        }
        public frmBookingFacility(BookingControl bookingcontrol)
            : this()
        {
            mCaller = bookingcontrol;
        }
        private void frmBookingFacility_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking successfully!");
            this.Close();
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
