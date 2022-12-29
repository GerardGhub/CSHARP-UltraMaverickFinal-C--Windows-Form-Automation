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

namespace ULTRAMAVERICK.Application_Form.Report
{
    public partial class frmReceiptReports : MaterialForm
    {
        public frmReceiptReports()
        {
            InitializeComponent();
        }

        private void frmReceiptReports_Load(object sender, EventArgs e)
        {
            this.Text = "Miscellaneouse Receipt Reports";
        }
    }
}
