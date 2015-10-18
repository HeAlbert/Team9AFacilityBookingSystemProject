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
    public partial class frmMemberList : Form
    {
        private ReportControl myCaller;
        public frmMemberList()
        {
            InitializeComponent();
        }
        public frmMemberList(ReportControl reportControl):this()
        {
            myCaller = reportControl;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SportsFacilityBookingDataSet ds = new SportsFacilityBookingDataSet();
            SportsFacilityBookingDataSetTableAdapters.MemberTableAdapter ta = new SportsFacilityBookingDataSetTableAdapters.MemberTableAdapter();
            MemberList memberListCrp = new MemberList();
            ta.FillBy(ds.Member);

            memberListCrp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = memberListCrp;
        }
    }
}
