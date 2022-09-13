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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Setup.Modal
{
    public partial class FrmOrderActivationRemarks : MaterialForm
    {

        readonly frmStoreOrderActivationRemarks ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly Store_Order_Activation_Remarks StoreOrderActivationRemarksEntity = new Store_Order_Activation_Remarks();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public FrmOrderActivationRemarks(
            frmStoreOrderActivationRemarks frm,
            int Created_by,
            string SoarDesc,
            string SoarType,
            string Mode,
            int SoarIdentity
            )
        {
            InitializeComponent();
            ths = frm;
            TextBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            this.StoreOrderActivationRemarksEntity.Soar_Added_By = Created_by.ToString();
            this.StoreOrderActivationRemarksEntity.Soar_Desc = SoarDesc;
            this.StoreOrderActivationRemarksEntity.Soar_type = SoarType;
            this.StoreOrderActivationRemarksEntity.Mode = Mode;
            this.StoreOrderActivationRemarksEntity.Soar_Id = SoarIdentity;
            this.StoreOrderActivationRemarksEntity.Soar_Updated_By = Created_by.ToString();
        }

        private void FrmOrderActivationRemarks_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadTaskMode();
        }
        private void LoadTaskMode()
        {
            this.StoreOrderActivationRemarksEntity.Mode = StoreOrderActivationRemarksEntity.Mode;


            if (StoreOrderActivationRemarksEntity.Mode == "ADD")
            {
                this.Text = "Add New Activation Remarks";
                this.MatBtnSave.Text = "ADD";
                this.StoreOrderActivationRemarksEntity.Soar_Added_By = this.StoreOrderActivationRemarksEntity.Soar_Added_By;

            }
            else
            {
                this.Text = "Update Activation Remarks";
                this.MatBtnSave.Text = "UPDATE";
                this.StoreOrderActivationRemarksEntity.Soar_Updated_By = this.StoreOrderActivationRemarksEntity.Soar_Updated_By;
                this.StoreOrderActivationRemarksEntity.Soar_Id = this.StoreOrderActivationRemarksEntity.Soar_Id;
                this.MatcmbType.Text = this.StoreOrderActivationRemarksEntity.Soar_type;
                this.TxtmatRemarks.Text = this.StoreOrderActivationRemarksEntity.Soar_Desc;
            }
            
        }




        private void ConnectionInit()
        {
            this.g_objStoredProcCollection =
            this.myClass.g_objStoredProc.GetCollections();
        }




        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.TxtmatRemarks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtmatRemarks.Focus();
                return;
            }
            else if (this.MatcmbType.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatcmbType.Focus();
                return;
            }


            if (this.StoreOrderActivationRemarksEntity.Soar_type == this.MatcmbType.Text
                && this.StoreOrderActivationRemarksEntity.Soar_Desc == this.TxtmatRemarks.Text)
            {
                this.SaveProcessClicker();
            }
            else
            {

                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_store_order_activation_remarks(0,
                    this.TxtmatRemarks.Text.Trim(),
                   this.MatcmbType.Text.Trim(), "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    this.TxtmatRemarks.Text = String.Empty;
                    this.MatcmbType.Text = String.Empty;
                    this.TxtmatRemarks.Focus();

                    return;
                }
                else
                {
                    this.SaveProcessClicker();
                }
            }

        }

        private void SaveProcessClicker()
        {

            if (this.StoreOrderActivationRemarksEntity.Mode == "ADD")
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = this.g_objStoredProcCollection
                        .sp_store_order_activation_remarks(0,
                        this.TxtmatRemarks.Text.Trim(),
                        this.MatcmbType.Text.Trim(),
                        this.StoreOrderActivationRemarksEntity.Soar_Added_By,
                        this.StoreOrderActivationRemarksEntity.Soar_Date_Added,
                        "",
                        "",
                        "add");
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();


                }
                else
                {
                    return;
                }


            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dSet.Clear();
                    dSet = this.g_objStoredProcCollection
                        .sp_store_order_activation_remarks(StoreOrderActivationRemarksEntity.Soar_Id,
                        this.TxtmatRemarks.Text.Trim(),
                        this.MatcmbType.Text.Trim(),
                        this.StoreOrderActivationRemarksEntity.Soar_Added_By,
                        this.StoreOrderActivationRemarksEntity.Soar_Date_Added,
                        this.StoreOrderActivationRemarksEntity.Soar_Updated_By,
                        "",
                        "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();


                }
                else
                {
                    return;
                }
            }
        }

        private void txtmatRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.TextBox1.Text = TextBox1.Text;
        }

        private void TxtmatRemarks_TextChanged(object sender, EventArgs e)
        {
            this.ValueChanger();
        }

        private void ValueChanger()
        {
            if (this.MatcmbType.Text == String.Empty)
            {
                this.MatBtnSave.Visible = false;
            }
            else if (this.TxtmatRemarks.Text == String.Empty)
            {
                this.MatBtnSave.Visible = false;
            }
            else
            {
                this.MatBtnSave.Visible = true;
            }
        }

        private void MatcmbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ValueChanger();
        }

        private void FrmOrderActivationRemarks_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.TextBox1.Text = "Gerard Singian";
        }
    }
}
