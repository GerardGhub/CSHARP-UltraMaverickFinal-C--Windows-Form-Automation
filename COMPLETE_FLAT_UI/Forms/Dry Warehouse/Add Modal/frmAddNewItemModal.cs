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

            lblPrimaryUnitID.Text = cboPrimaryUnit.SelectedValue.ToString();

            if (cboPrimaryUnit.Text == "Kilogram")
            {
                txtmatConversion.Enabled = false;
                txtmatConversion.Text = "1";
            }

            else if (cboSubCat.Text == "Packaging")
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
        public void FillRequiredTextbox()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "FILL UP THE REQUIRED FIELDS";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


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
            if(txtMatItemCode.Text == String.Empty)
            {
                FillRequiredTextbox();
                txtMatItemCode.Focus();
                return;
            }

            if (txtMatItemDesc.Text == String.Empty)
            {
                FillRequiredTextbox();
                txtMatItemDesc.Focus();
                return;
            }

            if (cboItemClass.Text == String.Empty)
            {
                FillRequiredTextbox();
                this.cboItemClass.Focus();
                return;
            }

            if (cboMajorCategory.Text == String.Empty)
            {
                FillRequiredTextbox();
                cboMajorCategory.Focus();
                return;
            }

            if (cboSubCat.Text == String.Empty)
            {
                FillRequiredTextbox();
                cboSubCat.Focus();
                return;
            }

            if (cboItemType.Text == String.Empty)
            {
                FillRequiredTextbox();
                cboItemType.Focus();
                return;
            }

            if (cboPrimaryUnit.Text == String.Empty)
            {
                FillRequiredTextbox();
                cboPrimaryUnit.Focus();
                return;
            }
            if (txtmatConversion.Text == String.Empty)
            {
                FillRequiredTextbox();
                txtmatConversion.Focus();
                return;
            }





            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                txtMatItemCode.Text, txtMatItemDesc.Text, "", "", "","","","","","","","",0, "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                RawMatsAlreadyExist();



                txtMatItemCode.Focus();
                return;
            }
            else
            {
                this.MetroSave();
            }


        }

        public void SaveSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Save";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        private void MetroSave()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add a new  raw material ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(0,
                    txtMatItemCode.Text.Trim(),
                    txtMatItemDesc.Text.Trim(),
                    cboItemClass.Text.Trim(),
                    cboMajorCategory.Text.Trim(),
                    cboSubCat.Text.Trim(),
                    cboPrimaryUnit.Text.Trim(),
                    txtmatConversion.Text.Trim(),
                    cboItemType.Text.Trim(),
                    txtcreatedAt.Text.Trim(),
                    txtcreatedBy.Text.Trim(),
                    "","",0,
                    "add");

                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(0,
                    txtMatItemCode.Text.Trim(),
                    txtMatItemDesc.Text.Trim(),
                    cboItemClass.Text.Trim(),
                    cboMajorCategory.Text.Trim(),
                    cboSubCat.Text.Trim(),
                    lblPrimaryUnitID.Text.Trim(),
                    txtmatConversion.Text.Trim(),
                    cboItemType.Text.Trim(),
                    txtcreatedAt.Text.Trim(),
                    txtcreatedBy.Text.Trim(),
                    "", "",0,
                    "addRMLogs");

                textBox1.Text = "data Already Save!";
                SaveSuccessfully();
                frmAddNewItemModal_Load(new object(), new System.EventArgs());

            }
            
            else
            {
                return;
            }

        }


        public void RawMatsAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Raw Material Already Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


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
    }
}
