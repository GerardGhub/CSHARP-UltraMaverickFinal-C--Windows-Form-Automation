using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class frmDryWhMiscellaneousReceipts : MaterialForm
    {
        public frmDryWhMiscellaneousReceipts()
        {
            InitializeComponent();
        }

        private void frmDryWhMiscellaneousReceipts_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FrmAddNewMiscellaneousReceipt AddReceipt = new FrmAddNewMiscellaneousReceipt();
            AddReceipt.ShowDialog();
        }
    }
}
