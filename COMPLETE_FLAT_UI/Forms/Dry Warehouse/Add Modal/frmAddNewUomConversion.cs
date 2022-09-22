using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAddNewUomConversion : MaterialForm
    {
        frmManageActivePrimaryUnit ths;

        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public frmAddNewUomConversion(
            frmManageActivePrimaryUnit frm,
            string conversion_qty, 
            string primary_unit, 
            string item_code, 
            string item_description, 
            string sp_active_pu_primary_id, 
            string item_id,
            string sp_item_primary_unit)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.conversion_qty = conversion_qty;
            this.primary_unit = primary_unit;
            this.item_code = item_code;
            this.item_description = item_description;
            this.sp_active_pu_primary_id = sp_active_pu_primary_id;
            this.item_id = item_id;
            this.sp_item_primary_unit = sp_item_primary_unit;
        }
        public string conversion_qty { get; set; }
        public string primary_unit { get; set; }
        public string item_code { get; set; }
        public string item_description { get; set; }
        public string sp_active_pu_primary_id { get; set; }
        public string item_id { get; set; }
        public string sp_item_primary_unit { get; set; }

        private void frmAddNewUomConversion_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadDataIntheUltimateOrbWeaver();
            this.lbluserid.Text = userinfo.user_id.ToString();
       
        }

        public void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void LoadDataIntheUltimateOrbWeaver()
        {
            txtMatItemCode.Text = item_code;
            txtMatItemDesc.Text = item_description;
            txtMatPrimaryUnit.Text = sp_item_primary_unit;
            //txtMatConversion.Text = conversion_qty;
            
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewUomConversion_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "Gerard Singian";
        }



            private void btnUpdateTool_Click(object sender, EventArgs e)
        {

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_PrimaryUnitManagement(0, txtMatConversion.Text, txtMatItemDesc.Text, "", "", "", "","","","","","", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();


                txtMatConversion.Text = String.Empty;
                txtMatConversion.Focus();
                return;
            }



            if (this.txtMatConversion.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtMatConversion.Focus();
                return;
            }
            else
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_PrimaryUnitManagement(0,
                         sp_active_pu_primary_id,
                        txtMatPrimaryUnit.Text.Trim(),
                        txtMatConversion.Text.Trim(),
                        item_id,
                        txtMatItemCode.Text.Trim(),
                        txtMatItemDesc.Text.Trim(),
                        "",
                        lbluserid.Text.Trim(),
                        "",
                        "",
                        "0",
                        "add");
                    textBox1.Text = "data Already Save!";
                    DispossalofTextboxEmpty();
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();


                }

                else
                {
                    return;
                }
            }
        }

        private void DispossalofTextboxEmpty()
        {
            txtMatConversion.Text = String.Empty;
        }
 
        private void txtMatConversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtMatConversion.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtMatConversion_TextChanged(object sender, EventArgs e)
        {
            if(this.txtMatConversion.Text == String.Empty)
            {
                this.BtnSaveTool.Visible = false;
            }
            else
            {
                this.BtnSaveTool.Visible = true;
            }
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {

        }
    }
}
