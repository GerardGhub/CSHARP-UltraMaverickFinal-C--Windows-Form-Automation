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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreApprovedOrderUpdatePreparationDate : MaterialForm
    {
        frmNewStoreOrderApproved ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        public frmStoreApprovedOrderUpdatePreparationDate(frmNewStoreOrderApproved frm)
        {
            InitializeComponent();
            ths = frm;
            textBox2.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void frmStoreApprovedOrderUpdatePreparationDate_Load(object sender, EventArgs e)
        {
            this.InitiliazeDatePickerMinDate();
        }
        private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox2.Text = textBox2.Text;
        }

        private void frmStoreApprovedOrderUpdatePreparationDate_FormClosing(object sender, FormClosingEventArgs e)
        {
    

            this.textBox2.Text = this.bunifuPrepaDate.Text;
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Update the Preparation Date ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
