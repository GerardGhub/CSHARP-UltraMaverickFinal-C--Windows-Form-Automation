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
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmUpdateLotData : MaterialForm
    {
        frmLotManagement ths;
        //myclasses xClass = new myclasses();
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        public frmUpdateLotData(frmLotManagement frm, string created_by, string sp_lot_number, string sp_description, string sp_category, int primary_id)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            this.sp_lot_number = sp_lot_number;
            this.sp_description = sp_description;
            this.sp_category = sp_category;
            this.primary_id = primary_id;
   
        }

        public string created_by { get; set; }
        public string sp_lot_number { get; set; }
        public string sp_description { get; set; }
        public string sp_category { get; set; }
        public int primary_id { get; set; }
        private void frmUpdateLotData_Load(object sender, EventArgs e)
        {
            this.FirstLoadBindingOrb();
            
                this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
                this.objStorProc = myClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

        }

        private void FirstLoadBindingOrb()
        {
            this.txtcreatedBy.Text = created_by;
            this.matlotnumber.Text = sp_lot_number;
            this.matdescription.Text = sp_description;
            this.cboMajorCategory.Text = sp_category;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmUpdateLotData_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "Gerard Singian";

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

        public void UpadatedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Updated Successfully";
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
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (matdescription.Text == String.Empty)
            {
                this.FillRequiredTextbox();
                this.matdescription.Focus();
                return;
            }
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the information?  ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                this.dSet.Clear();
                this.dSet = objStorProc.sp_lot_management(primary_id,
                    matlotnumber.Text, matdescription.Text, lblMajorCatId.Text, matcreatedby.Text, "", matcreatedby.Text, "", "edit");
                this.UpadatedSuccessfully();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
