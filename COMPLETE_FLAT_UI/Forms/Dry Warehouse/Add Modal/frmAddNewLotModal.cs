using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAddNewLotModal : MaterialForm
    {
        frmLotManagement ths;
        //myclasses xClass = new myclasses();
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;


        private readonly String defaultImage = Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\Employee.png";

        public frmAddNewLotModal(frmLotManagement frm, string created_by)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
         
        }
        public string created_by { get; set; }

        private void frmAddNewLotModal_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = myClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.CallingMainFormWindowBinder();
            this.loadMajorCategoryDropdown();
        }


        public void loadMajorCategoryDropdown()
        {

            this.myClass.fillComboBoxDepartment(cboMajorCategory, "Major_Category_dropdown", dSet);


            this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }
        private void CallingMainFormWindowBinder()
        {
            this.matcreatedby.Text = created_by;

            //Disabled Some TextBoxes
            this.matcreatedby.Enabled = false;
            this.mattotalsku.Enabled = false;
            this.mattotalsku.Text = "0";
     
        }

        private void cboMajorCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }
        public void AlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Lot Number Already Exist!";
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
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (matlotnumber.Text == String.Empty)
            {
                this.FillRequiredTextbox();
               this.matlotnumber.Focus();
                return;
            }
            if (matdescription.Text == String.Empty)
            {
                this.FillRequiredTextbox();
              this.matdescription.Focus();
                return;
            }
            if (cboMajorCategory.Text == String.Empty)
            {
                this.FillRequiredTextbox();
               this.cboMajorCategory.Focus();
                return;
            }

            this.dSet.Clear();
            this.dSet = objStorProc.sp_lot_management(0,
                matlotnumber.Text, matdescription.Text, lblMajorCatId.Text, matcreatedby.Text, "", matcreatedby.Text, "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
               this.AlreadyExist();

                this.matlotnumber.Text = String.Empty;
                this.matlotnumber.Focus();
                return;
            }
            else
            {
                //metroSave_Click(sender, e);
                this.MetroSavingRequest();
            }
        }


        private void MetroSavingRequest()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add a new lot?  ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                this.dSet.Clear();
                this.dSet = objStorProc.sp_lot_management(0,
                    matlotnumber.Text, matdescription.Text, lblMajorCatId.Text, matcreatedby.Text, "", matcreatedby.Text, "", "add");
                this.SaveSuccessfully();
                this.Close();
            }
            else
            {
                return;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewLotModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.selectEmployeeImage();
        }
        private void selectEmployeeImage()
        {
            //odbEmployeeImage.Filter = "JPEG Images (.JPG)|*.jpg|GIF Images (.GIF)|*.gif|BITMAPS (.BMP)|*.bmp|PNG Images (.PNG)|*.png";
            //odbEmployeeImage.Multiselect = false;
            //ready = true;
            //if (odbEmployeeImage.ShowDialog() != DialogResult.Cancel)
            //{
            //    try
            //    {
            //        pbImage.Image = null;
            //        pbImage.Refresh();
            //        pbImage.Image = Image.FromFile(odbEmployeeImage.FileName);
            //        ready = true;
            //        if (readImageByte(odbEmployeeImage.FileName))
            //        {
            //            btnRemove.Enabled = true;
            //        }
            //    }
            //    catch (Exception exception)
            //    {
            //        ready = false;
            //        MessageBox.Show("Error  : Image Failed To Load \n\n\n" + exception.Message, "HR Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void matlotnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

         
            
        }
    }
}
