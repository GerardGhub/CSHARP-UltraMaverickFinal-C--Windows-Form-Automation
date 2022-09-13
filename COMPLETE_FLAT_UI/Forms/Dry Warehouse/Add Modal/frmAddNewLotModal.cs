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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAddNewLotModal : MaterialForm
    {
        frmLotManagement ths;
        readonly myclasses myClass = new myclasses();
        private DataSet dSet = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly Lot_Management LotManagementEntity = new Lot_Management();

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
            this.LotManagementEntity.Added_By = created_by;

            //Disabled Some TextBoxes
  
            this.mattotalsku.Enabled = false;
            this.mattotalsku.Text = "0";
     
        }

        private void cboMajorCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


      
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (matlotnumber.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
               this.matlotnumber.Focus();
                return;
            }
            if (matdescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matdescription.Focus();
                return;
            }
            if (cboMajorCategory.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboMajorCategory.Focus();
                return;
            }

            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection.sp_lot_management(
                0,
                matlotnumber.Text,
                matdescription.Text,
                lblMajorCatId.Text,
                this.LotManagementEntity.Added_By,
                "",
                this.LotManagementEntity.Added_By,
                "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();

                this.matlotnumber.Text = String.Empty;
                this.matlotnumber.Focus();
                return;
            }
            else
            {
              
                this.MetroSavingRequest();
            }
        }


        private void MetroSavingRequest()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add a data?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_lot_management(0,
                    matlotnumber.Text, 
                    matdescription.Text, 
                    lblMajorCatId.Text,
                    this.LotManagementEntity.Added_By, 
                    "", 
                    this.LotManagementEntity.Added_By, 
                    "", "add");
                this.GlobalStatePopup.CommittedSuccessFully();
                this.Close();
            }
            else
            {
                return;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewLotModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }



        private void matlotnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

         
            
        }

        private void matdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
