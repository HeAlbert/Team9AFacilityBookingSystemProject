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
    public partial class frmTrendReport : Form
    {
        private ReportControl myCaller;
        public frmTrendReport()
        {
            InitializeComponent();
        }
        public frmTrendReport(ReportControl reportControl)
            : this()
        {
            myCaller = reportControl;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            SportsFacilityBookingDataSet ds = new SportsFacilityBookingDataSet();
            SportsFacilityBookingDataSetTableAdapters.BookingTableAdapter ta = new SportsFacilityBookingDataSetTableAdapters.BookingTableAdapter();
            TrendReport TrendReportCrp = new TrendReport();
            ta.Fill(ds.Booking);

            TrendReportCrp.SetDataSource(ds);
            crystalReportViewer2.ReportSource = TrendReportCrp;
        }


    }
}
