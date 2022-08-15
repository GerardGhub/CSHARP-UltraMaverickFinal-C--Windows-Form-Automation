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
            this.MatBtnNew.Enabled = false;
            FrmAddNewMiscellaneousReceipt AddReceipt = new FrmAddNewMiscellaneousReceipt(this);
            AddReceipt.ShowDialog();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.textBox1.Text != String.Empty)
            {
                this.MatBtnNew.Enabled = true;
            }
        }
    }
}
