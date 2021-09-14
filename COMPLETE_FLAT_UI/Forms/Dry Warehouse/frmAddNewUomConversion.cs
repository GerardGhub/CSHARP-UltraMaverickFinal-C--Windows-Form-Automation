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
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        public frmAddNewUomConversion(frmManageActivePrimaryUnit frm, string conversion_qty, string primary_unit, 
            string item_code, string item_description, string sp_active_pu_primary_id, string item_id,
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
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            LoadDataIntheUltimateOrbWeaver();
            lbluserid.Text = userinfo.user_id.ToString();
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

        public void ConversionAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Conversion Already Exist!";
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

            private void btnUpdateTool_Click(object sender, EventArgs e)
        {

            dSet.Clear();
            dSet = objStorProc.sp_PrimaryUnitManagement(0, txtMatConversion.Text, txtMatItemDesc.Text, "", "", "", "","","","","","", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                ConversionAlreadyExist();


                txtMatConversion.Text = String.Empty;
                txtMatConversion.Focus();
                return;
            }



            if (txtMatConversion.Text == String.Empty)
            {
                FillRequiredTextbox();
                txtMatConversion.Focus();
                return;
            }
            else
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add a new  primary unit conversion ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = objStorProc.sp_PrimaryUnitManagement(0,
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
                    SaveSuccessfully();


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
    }
}
