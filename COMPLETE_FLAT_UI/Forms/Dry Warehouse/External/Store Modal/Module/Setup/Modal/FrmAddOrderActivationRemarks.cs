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
            this.AvgOrderTrendEntity.Added_By = Created_by.ToString();
            this.AvgOrderTrendEntity.Avg_Desc = AverageDesc;
            this.AvgOrderTrendEntity.Avg_Days = AverageDays;
            this.AvgOrderTrendEntity.Mode = Mode;
            this.AvgOrderTrendEntity.Avg_Id = AverageIdentity;
            this.AvgOrderTrendEntity.Updated_By = Created_by.ToString();
        }

        private void FrmOrderActivationRemarks_Load(object sender, EventArgs e)
        {

        }

        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtmatRemarks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtmatRemarks.Focus();
                return;
            }
            else if (this.matcmbType.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matcmbType.Focus();
                return;
            }

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_store_order_activation_remarks(0,
                this.txtmatRemarks.Text.Trim(),
               this.matcmbType.Text.Trim(), "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();

                this.txtmatRemarks.Text = String.Empty;
                this.matcmbType.Text = String.Empty;
                this.txtmatRemarks.Focus();
       
                return;
            }
            else
            {
                this.SaveProcessClicker();
            }
        }

        private void SaveProcessClicker()
        {

        }

        private void txtmatRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = TextBox1.Text;
        }
    }
}
