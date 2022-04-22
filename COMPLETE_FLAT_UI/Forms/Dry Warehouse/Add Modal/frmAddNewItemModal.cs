using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAddNewItemModal : MaterialForm
    {
        frmDryRawMaterials ths;
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public frmAddNewItemModal(frmDryRawMaterials frm, string created_by)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public string created_by { get; set; }
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private void frmAddNewItemModal_Load(object sender, EventArgs e)
        {
            
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
                objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

                this.txtMatItemCode.Focus();
            this.CallingMainFormWindowBinder();
            this.loadItemClassDropdown();
            this.loadMajorCategoryDropdown();
            this.loadSubCategoryDropdown();
            this.loadItemTypeDropdown();
            this.loadPrimaryUnitDropdown();
            this.CleartextBoxes();
        }
        private void CleartextBoxes()
        {
         
            this.textBox1.Text = String.Empty;
            this.cboPrimaryUnit.Text = String.Empty;
            this.txtmatConversion.Text = String.Empty;
            this.cboMajorCategory.Text = String.Empty;
            this.cboSubCat.Text = String.Empty;
            this.cboItemType.Text = String.Empty;
            this.cboItemClass.Text = String.Empty;
            this.txtMatItemCode.Text = String.Empty;
            this.txtMatItemDesc.Text = String.Empty;
                
        }

        public void loadItemClassDropdown()
        {
          
            myClass.fillComboBoxDepartment(cboItemClass, "Item_Class_dropdown", dSet);
          

            lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
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


        private void CallingMainFormWindowBinder()
        {
            this.txtcreatedBy.Text = created_by;
          
         
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewItemModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void cboItemClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }

        private void cboMajorCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {

            this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void cboSubCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblIDSubCat.Text = cboSubCat.SelectedValue.ToString();
            if(cboSubCat.Text =="Packaging")
            {
                txtmatConversion.Text = "0";
                txtmatConversion.Enabled = false;
            }
            else if (cboSubCat.Text == "Cleaning")
            {
                txtmatConversion.Text = "0";
                txtmatConversion.Enabled = false;
            }
            else
            {
                txtmatConversion.Text = String.Empty;
                txtmatConversion.Enabled = true;
                txtmatConversion.Focus();
            }
        }

        private void cboItemType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblItemTypeID.Text = cboItemType.SelectedValue.ToString();

            if(cboItemType.Text =="Product")
            {
                txtmatConversion.Enabled = false;
                txtmatConversion.Text = "0";
            }
            else if(cboItemType.Text =="Ingredients")
            {
                txtmatConversion.Enabled = true;
                txtmatConversion.Text = String.Empty;
                txtmatConversion.Focus();
            
            }
            else
            {

            }
        }

        private void cboPrimaryUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {

            this.lblPrimaryUnitID.Text = this.cboPrimaryUnit.SelectedValue.ToString();

         
        }
 
        private void txtmatConversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
                {
                    if (Regex.IsMatch(
                     txtmatConversion.Text,
                     "^\\d*\\.\\d{1}$")) e.Handled = true;
                }
                else e.Handled = e.KeyChar != (char)Keys.Back;
            
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if(this.txtMatItemCode.Text == String.Empty)
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

            if (this.cboItemClass.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboItemClass.Focus();
                return;
            }

            if (cboMajorCategory.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboMajorCategory.Focus();
                return;
            }

            if (this.cboSubCat.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboSubCat.Focus();
                return;
            }

            if (this.cboItemType.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboItemType.Focus();
                return;
            }

            if (this.cboPrimaryUnit.Text == String.Empty)
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





            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                this.txtMatItemCode.Text, 
                this.txtMatItemDesc.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                0,
                "",
                "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();



                this.txtMatItemCode.Focus();
                return;
            }
            else
            {
                this.MetroSave();
            }


        }


        private void MetroSave()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new  raw material ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(0,
                    this.txtMatItemCode.Text.Trim(),
                    this.txtMatItemDesc.Text.Trim(),
                    this.cboItemClass.Text.Trim(),
                    this.cboMajorCategory.Text.Trim(),
                    this.cboSubCat.Text.Trim(),
                    this.cboPrimaryUnit.Text.Trim(),
                    this.txtmatConversion.Text.Trim(),
                    this.cboItemType.Text.Trim(),
                    this.txtcreatedAt.Text.Trim(),
                    this.txtcreatedBy.Text.Trim(),
                    "","", Convert.ToInt32(this.mattxtBufferStocks.Text),
                    "",
                    "add");

                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(0,
                    this.txtMatItemCode.Text.Trim(),
                    this.txtMatItemDesc.Text.Trim(),
                    this.cboItemClass.Text.Trim(),
                    this.cboMajorCategory.Text.Trim(),
                    this.cboSubCat.Text.Trim(),
                    this.lblPrimaryUnitID.Text.Trim(),
                    this.txtmatConversion.Text.Trim(),
                    this.cboItemType.Text.Trim(),
                    this.txtcreatedAt.Text.Trim(),
                    this.txtcreatedBy.Text.Trim(),
                    "", "", Convert.ToInt32(this.mattxtBufferStocks.Text),
                    "",
                    "addRMLogs");

                this.textBox1.Text = "data Already Save!";
                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmAddNewItemModal_Load(new object(), new System.EventArgs());

            }
            
            else
            {
                return;
            }

        }





        private void txtMatItemCode_Validated(object sender, EventArgs e)
        {
     
        }

        private void txtMatItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;

            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtMatItemDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;

            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cboItemClass_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboPrimaryUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cboPrimaryUnit.Text == "KILOGRAM")
            {
                this.txtmatConversion.Enabled = false;
                this.txtmatConversion.Text = "1";
            }

            else if (this.cboSubCat.Text == "PACKAGING")
            {
                this.txtmatConversion.Text = "0";
                this.txtmatConversion.Enabled = false;
            }
            else if (this.cboSubCat.Text == "CLEANING")
            {
                this.txtmatConversion.Text = "0";
                this.txtmatConversion.Enabled = false;
            }

            else
            {
                this.txtmatConversion.Text = String.Empty;
                this.txtmatConversion.Enabled = true;
                this.txtmatConversion.Focus();
            }
        }
    }
}
