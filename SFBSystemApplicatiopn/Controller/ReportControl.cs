using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFBSystemApplicatiopn
{
    public class ReportControl
    {
        private frmMemberList memberList;
        private frmTrendReport trendReport;
        private frmOccupancyReport OccupancyReport;
        public void selectMemberList()
        {
            memberList = new frmMemberList(this);
            memberList.Show();
        }
        public void selectTrendReport()
        {
            trendReport = new frmTrendReport(this);
            trendReport.Show();
        }
        public void selectOccupancyReport()
        {
            OccupancyReport = new frmOccupancyReport(this);
            OccupancyReport.Show();
        }

    }
}
