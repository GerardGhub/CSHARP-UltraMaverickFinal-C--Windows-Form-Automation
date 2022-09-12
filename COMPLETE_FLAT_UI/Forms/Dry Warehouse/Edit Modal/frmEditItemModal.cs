using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{

    public partial class frmEditItemModal : MaterialForm
    {
        //Constructor bugok
        frmDryMiscellaneouseIssue ths;
        readonly Raw_Materials_Dry RawMaterialsDryEntity = new Raw_Materials_Dry();
        private DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmEditItemModal(frmDryMiscellaneouseIssue frm, string created_by,
            string item_code,
            string item_description,
            string item_class,
            string major_category,
            string sub_category,
            string primary_unit,
            string conversion,
            string item_type,
            int primary_key,
            double buffer_stock,
            int expiration_days_prompting
            )
        {
            InitializeComponent();
            ths = frm;
            this.textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.RawMaterialsDryEntity.Created_By = created_by;
            this.RawMaterialsDryEntity.Item_Code = item_code;
            this.RawMaterialsDryEntity.Item_Description = item_description;
            this.RawMaterialsDryEntity.Item_Class = item_class;
            this.RawMaterialsDryEntity.Major_Category = major_category;
            this.RawMaterialsDryEntity.Sub_Category = sub_category;
            this.RawMaterialsDryEntity.Primary_Unit = primary_unit;
            this.RawMaterialsDryEntity.Conversion = conversion;
            this.RawMaterialsDryEntity.Item_Type = item_type;
            this.RawMaterialsDryEntity.Item_Id = primary_key;
            this.RawMaterialsDryEntity.Buffer_Stock = buffer_stock;
            this.RawMaterialsDryEntity.Expiration_Prompting = expiration_days_prompting;
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }


       

        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void frmEditItemModal_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.SendMessageInComboboxPHolder();

            this.loadItemClassDropdown();
            this.loadMajorCategoryDropdown();
            this.loadSubCategoryDropdown();
            this.loadItemTypeDropdown();
            this.loadPrimaryUnitDropdown();
            this.FirstLoadBindingOrb();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections


        }

        public void loadItemClassDropdown()
        {

            myClass.fillComboBoxDepartment(cboItemClass, "Item_Class_dropdown", dSet);


            this.lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }
        public void loadMajorCategoryDropdown()
        {

            myClass.fillComboBoxDepartment(cboMajorCategory, "Major_Category_dropdown", dSet);


            this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadSubCategoryDropdown()
        {

            myClass.fillComboBoxDepartment(cboSubCat, "Sub_Category_dropdown", dSet);


            this.lblIDSubCat.Text = cboSubCat.SelectedValue.ToString();
        }


        public void loadItemTypeDropdown()
        {

            myClass.fillComboBoxDepartment(cboItemType, "Item_Type_dropdown", dSet);


            this.lblItemTypeID.Text = cboItemType.SelectedValue.ToString();
        }

        public void loadPrimaryUnitDropdown()
        {

            myClass.fillComboBoxDepartment(cboPrimaryUnit, "Primary_Unit_dropdown", dSet);


            this.lblPrimaryUnitID.Text = cboPrimaryUnit.SelectedValue.ToString();
        }

        private void SendMessageInComboboxPHolder()
        {
            SendMessage(this.cboSubCat.Handle, CB_SETCUEBANNER, 0, "Sub Category");
            SendMessage(this.cboMajorCategory.Handle, CB_SETCUEBANNER, 0, "Major Category");
            SendMessage(this.cboPrimaryUnit.Handle, CB_SETCUEBANNER, 0, "Primary Unit");
            SendMessage(this.cboItemType.Handle, CB_SETCUEBANNER, 0, "Item Type");
            SendMessage(this.cboItemClass.Handle, CB_SETCUEBANNER, 0, "Item Class");
        }




        private void FirstLoadBindingOrb()
        {
            this.RawMaterialsDryEntity.Created_By = RawMaterialsDryEntity.Created_By;
            this.txtMatItemCode.Text = RawMaterialsDryEntity.Item_Code;
            this.txtMatItemDesc.Text = RawMaterialsDryEntity.Item_Description;
            this.cboItemClass.Text = RawMaterialsDryEntity.Item_Class;
            this.cboMajorCategory.Text = RawMaterialsDryEntity.Major_Category;
            this.cboSubCat.Text = RawMaterialsDryEntity.Sub_Category;
            this.cboPrimaryUnit.Text = RawMaterialsDryEntity.Primary_Unit;
            this.txtmatConversion.Text = RawMaterialsDryEntity.Conversion;
            this.cboItemType.Text = RawMaterialsDryEntity.Item_Type;
            this.mattxtBufferStocks.Text = RawMaterialsDryEntity.Buffer_Stock.ToString();
            this.txtExpirationDaysPrompting.Text = RawMaterialsDryEntity.Expiration_Prompting.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void cboItemClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }

        private void cboMajorCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void cboSubCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblIDSubCat.Text = cboSubCat.SelectedValue.ToString();
        }

        private void cboItemType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblItemTypeID.Text = cboItemType.SelectedValue.ToString();
        }
   
        private void cboPrimaryUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            lblPrimaryUnitID.Text = cboPrimaryUnit.SelectedValue.ToString();
            lblItemTypeID.Text = cboItemType.SelectedValue.ToString();
            lblIDSubCat.Text = cboSubCat.SelectedValue.ToString();
            lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
            lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }
        private void SelectionChangedCommiotmentManual()
        {
            lblPrimaryUnitID.Text = cboPrimaryUnit.SelectedValue.ToString();
        }

      
        private void MetroSave()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(Convert.ToInt32(RawMaterialsDryEntity.Item_Id),
                    this.txtMatItemCode.Text.Trim(),
                    this.txtMatItemDesc.Text.Trim(),
                    this.cboItemClass.Text.Trim(),
                    this.cboMajorCategory.Text.Trim(),
                    this.cboSubCat.Text.Trim(),
                    this.cboPrimaryUnit.Text.Trim(),
                    this.txtmatConversion.Text.Trim(),
                    this.cboItemType.Text.Trim(),
                    this.RawMaterialsDryEntity.Created_At,
                    this.RawMaterialsDryEntity.Created_By,
                    "", 
                    this.RawMaterialsDryEntity.Created_By,
                    float.Parse(this.mattxtBufferStocks.Text.Trim()),
                    this.txtExpirationDaysPrompting.Text.Trim(),
                    "edit");
                this.textBox1.Text = "data Already Save!";
                this.GlobalStatePopup.CommittedSuccessFully();
                this.Close();
        

            }

            else
            {
                return;
            }

        }
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            this.SelectionChangedCommiotmentManual();
            if (this.txtMatItemCode.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtMatItemCode.Focus();
                return;
            }

            if (this.txtMatItemDesc.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtMatItemDesc.Focus();
                return;
            }

            if (this.lblItemClassID.Text == "NULL")
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboItemClass.Focus();
                return;
            }

            if (this.lblMajorCatId.Text == "NULL")
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboMajorCategory.Focus();
                return;
            }

            if (this.lblIDSubCat.Text == "NULL")
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboSubCat.Focus();
                return;
            }

            if (this.lblItemTypeID.Text == "NULL")
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboItemType.Focus();
                return;
            }

            if (this.lblPrimaryUnitID.Text == "NULL")
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboPrimaryUnit.Focus();
                return;
            }
            if (this.txtmatConversion.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtmatConversion.Focus();
                return;
            }

            if (this.mattxtBufferStocks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtBufferStocks.Focus();
                return;
            }

            this.MetroSave();


        }

        private void frmEditItemModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void mattxtBufferStocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(mattxtBufferStocks.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void mattxtBufferStocks_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPrimaryUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cboPrimaryUnit.Text == "KILOGRAM")
            {
                this.txtmatConversion.Text = "1";
                this.txtmatConversion.Enabled = false;
            }
            else
            {
                this.txtmatConversion.Text = String.Empty;
                this.txtmatConversion.Enabled = true;
                this.txtmatConversion.Focus();
            }

        }

        private void txtExpirationDaysPrompting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
            e.Handled = true;
            }

        

        }

        private void txtmatConversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
            e.Handled = true;
            }

    
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
