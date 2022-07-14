﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.External.Preparation
{
    public partial class frmCancelExternalApprovedOrder : MaterialForm
    {
        frmStoreOrderforApproval ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int validate = 0;
        public frmCancelExternalApprovedOrder(frmStoreOrderforApproval frm, string buttonActions)
        {
            InitializeComponent();
            ths = frm;
            SpButtonActions = buttonActions;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }
        public string SpButtonActions { get; set; }
        private void frmCancelExternalApprovedOrder_Load(object sender, EventArgs e)
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


            //this.lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }

        public void loadRemarksDropdownForReturn()
        {

            this.myClass.fillComboBoxDepartment(this.cboReason,
            "internal_order_activation_remarks_activated_minor_typereturn", dSet);


            //this.lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
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
    }
}
