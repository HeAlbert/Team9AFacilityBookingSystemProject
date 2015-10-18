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
    public partial class frmOccupancyReport : Form
    {
        private ReportControl myCaller;
        public frmOccupancyReport()
        {
            InitializeComponent();
        }
        public frmOccupancyReport(ReportControl reportControl)
            : this()
        {
            myCaller = reportControl;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SportsFacilityBookingDataSet ds = new SportsFacilityBookingDataSet();
            SportsFacilityBookingDataSetTableAdapters.AvaiablityFacilityTableAdapter ta = new SportsFacilityBookingDataSetTableAdapters.AvaiablityFacilityTableAdapter();
            OccupancyReport OccupancyCrp = new OccupancyReport();
            ta.Fill(ds.AvaiablityFacility);

            OccupancyCrp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = OccupancyCrp;
        }


    }
}
