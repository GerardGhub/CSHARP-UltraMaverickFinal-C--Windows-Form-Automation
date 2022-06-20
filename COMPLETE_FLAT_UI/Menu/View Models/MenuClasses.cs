using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.Menu.View_Models
{
    class MenuClasses
    {


        public Rectangle sizeGripRectangle;
        public string ImageParse { get; set; }
        public int sp_user_id { get; set; }
        public string total_receiving_dry_wh { get; set; }
        public string TotalStoreOrderCancelatWhChecker { get; set; }
        public string TotalStoreOrderDistinctLogisticChecker { get; set; }
        public double TotalCountNotificationDistinctType { get; set; }

        public string TotalLabTestReceivingViewing { get; set; }


    }
    class DashboardClasses
    {
        public string SpCategoryPreparation { get; set; }
        public string SpMoveOrder { get; set; }

        public string SpMoveOrderApproved { get; set; }
        public string SpMoveOrderSlipDispatch { get; set; }
        public string SPRowCountOfStoreDatagrid { get; set; }

    }
}
