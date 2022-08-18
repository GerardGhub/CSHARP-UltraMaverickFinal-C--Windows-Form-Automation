using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Interfaces
{
    interface ITblCustomersRepository
    {

        void GetCustomer(System.Windows.Forms.DataGridView DataGridViews);

        void GetCustomerDeactivated(System.Windows.Forms.DataGridView DataGridViews);

        void GetCustomerSearchMajor(int TotalRecords);
    }
}
