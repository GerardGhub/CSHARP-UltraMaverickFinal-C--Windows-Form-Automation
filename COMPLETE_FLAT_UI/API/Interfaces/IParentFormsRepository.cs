using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Interfaces
{
    internal interface IParentFormsRepository
    {
        void GetStorePreparations(System.Windows.Forms.DataGridView DataGridViews);
        void GetStoreOrderForApproval(System.Windows.Forms.DataGridView DataGridViews);
        void GetStoreOrderApproved(System.Windows.Forms.DataGridView DataGridViews);
        void GetInternalOrderForScheduling(System.Windows.Forms.DataGridView DataGridViews);
        void GetInternalOrderApproved(System.Windows.Forms.DataGridView DataGridViews);
        void GetInternalPreparation(System.Windows.Forms.DataGridView DataGridViews);
        void GetDispatchingData(System.Windows.Forms.DataGridView DataGridViews);
        void GetReceivingDataDry(System.Windows.Forms.DataGridView DataGridViews);
        void GetReceivingDataDryReject(System.Windows.Forms.DataGridView DataGridViews);
    }
}
