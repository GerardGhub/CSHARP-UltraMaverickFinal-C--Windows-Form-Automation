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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Allocation_Process
{
    public partial class frmCancelAllocationOrder : MaterialForm
    {
        frmAllocationModule ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;

        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int validate = 0;
        public frmCancelAllocationOrder(frmAllocationModule frm, string buttonActions)
        {
            InitializeComponent();
            ths = frm;
            SpButtonActions = buttonActions;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }
        public string SpButtonActions { get; set; }

        private void frmCancelAllocationOrder_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.ClearTextboxesState();
            this.SpButtonActions = SpButtonActions;
        }

        private void ClearTextboxesState()
        {
            this.textBox1.Text = String.Empty;
            this.cboReason.Items.Clear();
        }
        public void loadRemarksDropdownForCancel()
        {

            this.myClass.fillComboBoxDepartment(this.cboReason,
            "internal_order_activation_remarks_activated_minor_typecancel", dSet);

        }

        public void loadRemarksDropdownForReturn()
        {

            this.myClass.fillComboBoxDepartment(this.cboReason,
            "internal_order_activation_remarks_activated_minor_typereturn", dSet);

        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox2Cancel.Text = textBox1.Text;
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (this.cboReason.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboReason.Focus();
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Cancel the consolidated order? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.validate = 1;
                this.textBox1.Text = this.cboReason.Text;
           if (this.textBox1.Text == this.cboReason.Text)
                {
                    ths.textBox2Cancel.Text = String.Empty;
                }
                this.textBox1.Text = this.cboReason.Text;

                this.Close();
            }
            else
            {
 
                ths.textBox2Cancel.Text = String.Empty;

                return;
            }
        }

        private void cboReason_Click(object sender, EventArgs e)
        {
            if (this.SpButtonActions == "RETURN")
            {
                this.loadRemarksDropdownForReturn();
            }
            else
            {
                this.loadRemarksDropdownForCancel();
            }
        }

        private void frmCancelAllocationOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cboReason.Text == String.Empty)
            {
                ths.textBox2Cancel.Text = String.Empty;
            }
        }
    }
}
