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

        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void frmEditItemModal_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            SendMessageInComboboxPHolder();

            loadItemClassDropdown();
            loadMajorCategoryDropdown();
            loadSubCategoryDropdown();
            loadItemTypeDropdown();
            loadPrimaryUnitDropdown();
            FirstLoadBindingOrb();
        }


        public void loadItemClassDropdown()
        {

            myClass.fillComboBoxDepartment(cboItemClass, "Item_Class_dropdown", dSet);


            lblItemClassID.Text = cboItemClass.SelectedValue.ToString();
        }
        public void loadMajorCategoryDropdown()
        {

            myClass.fillComboBoxDepartment(cboMajorCategory, "Major_Category_dropdown", dSet);


            lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadSubCategoryDropdown()
        {

            myClass.fillComboBoxDepartment(cboSubCat, "Sub_Category_dropdown", dSet);


            lblIDSubCat.Text = cboSubCat.SelectedValue.ToString();
        }


        public void loadItemTypeDropdown()
        {

            myClass.fillComboBoxDepartment(cboItemType, "Item_Type_dropdown", dSet);


            lblItemTypeID.Text = cboItemType.SelectedValue.ToString();
        }

        public void loadPrimaryUnitDropdown()
        {

            myClass.fillComboBoxDepartment(cboPrimaryUnit, "Primary_Unit_dropdown", dSet);


            lblPrimaryUnitID.Text = cboPrimaryUnit.SelectedValue.ToString();
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
            txtcreatedBy.Text = created_by;
            txtMatItemCode.Text = item_code;
            txtMatItemDesc.Text = item_description;
            cboItemClass.Text = item_class;
            cboMajorCategory.Text = major_category;
            cboSubCat.Text = sub_category;
            cboPrimaryUnit.Text = primary_unit;
            txtmatConversion.Text = conversion;
            cboItemType.Text = item_type;
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
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the  Raw Material Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(Convert.ToInt32(primary_key),
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
                    "", txtcreatedBy.Text.Trim(),
                    "edit");
                textBox1.Text = "data Already Save!";
                SaveSuccessfully();
                this.Close();
        

            }

            else
            {
                return;
            }

        }
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            SelectionChangedCommiotmentManual();
            if (txtMatItemCode.Text == String.Empty)
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

            if (lblItemClassID.Text == "NULL")
            {
                FillRequiredTextbox();
                cboItemClass.Focus();
                return;
            }

            if (lblMajorCatId.Text == "NULL")
            {
                FillRequiredTextbox();
                cboMajorCategory.Focus();
                return;
            }

            if (lblIDSubCat.Text == "NULL")
            {
                FillRequiredTextbox();
                cboSubCat.Focus();
                return;
            }

            if (lblItemTypeID.Text == "NULL")
            {
                FillRequiredTextbox();
                cboItemType.Focus();
                return;
            }

            if (lblPrimaryUnitID.Text == "NULL")
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


            MetroSave();


        }

        private void frmEditItemModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "Gerard Singian";
        }
    }
}
