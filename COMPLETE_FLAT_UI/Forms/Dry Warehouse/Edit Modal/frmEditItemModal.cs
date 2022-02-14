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
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{

    public partial class frmEditItemModal : MaterialForm
    {
        //Constructor bugok
        frmDryRawMaterials ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmEditItemModal(frmDryRawMaterials frm, string created_by,
            string item_code,
            string item_description,
            string item_class,
            string major_category,
            string sub_category,
            string primary_unit,
            string conversion,
            string item_type,
            string primary_key
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            this.item_code = item_code;
            this.item_description = item_description;
            this.item_class = item_class;
            this.major_category = major_category;
            this.sub_category = sub_category;
            this.primary_unit = primary_unit;
            this.conversion = conversion;
            this.item_type = item_type;
            this.primary_key = primary_key;

            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }


        public string created_by { get; set; }
        public string item_code { get; set; }
        public string item_description { get; set; }
        public string item_class { get; set; }
        public string major_category { get; set; }
        public string sub_category { get; set; }
        public string primary_unit { get; set; }
        public string conversion { get; set; }
        public string item_type { get; set; }
        public string primary_key { get; set; }
        public string sp_created_by { get; set; }
        public string sp_created_at { get; set; }

        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void frmEditItemModal_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.SendMessageInComboboxPHolder();

            this.loadItemClassDropdown();
            this.loadMajorCategoryDropdown();
            this.loadSubCategoryDropdown();
            this.loadItemTypeDropdown();
            this.loadPrimaryUnitDropdown();
            this.FirstLoadBindingOrb();
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
            this.sp_created_by = created_by;
            this.txtMatItemCode.Text = item_code;
            this.txtMatItemDesc.Text = item_description;
            this.cboItemClass.Text = item_class;
            this.cboMajorCategory.Text = major_category;
            this.cboSubCat.Text = sub_category;
            this.cboPrimaryUnit.Text = primary_unit;
            this.txtmatConversion.Text = conversion;
            this.cboItemType.Text = item_type;
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the Information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(Convert.ToInt32(primary_key),
                    this.txtMatItemCode.Text.Trim(),
                    this.txtMatItemDesc.Text.Trim(),
                    this.cboItemClass.Text.Trim(),
                    this.cboMajorCategory.Text.Trim(),
                    this.cboSubCat.Text.Trim(),
                    this.cboPrimaryUnit.Text.Trim(),
                    this.txtmatConversion.Text.Trim(),
                    this.cboItemType.Text.Trim(),
                    this.sp_created_at,
                    this.sp_created_by,
                    "", 
                    this.sp_created_by,
                    float.Parse(this.mattxtBufferStocks.Text.Trim()),
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
    }
}
