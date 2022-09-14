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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmUpdateLotData : MaterialForm
    {
        frmLotManagement ths;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        Lot_Management Lots = new Lot_Management();
        IStoredProcedures g_objStoredProcCollection = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public frmUpdateLotData(
            frmLotManagement frm,
            string Created_by,
            string Lot_number,
            string Description,
            string Category,
            int Primary_id,
            string TotalSku)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.Lots.Added_By = Created_by;
            this.Lots.Lot_Number = Lot_number;
            this.Lots.Description = Description;
            this.Lots.Category = Category;
            this.primary_id = Primary_id;
            this.SpTotalSku = TotalSku;
   
        }




        public int primary_id { get; set; }
        public string SpTotalSku { get; set; }
        private void frmUpdateLotData_Load(object sender, EventArgs e)
        {
            this.FirstLoadBindingExpilict();


                this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        private void FirstLoadBindingExpilict()
        {
            this.Lots.Added_By = this.Lots.Added_By;
            this.matlotnumber.Text = this.Lots.Lot_Number;
            this.matdescription.Text = this.Lots.Description;
            this.cboMajorCategory.Text = this.Lots.Category;
            this.mattotalsku.Text  = SpTotalSku;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmUpdateLotData_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";

        }

 

    
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (matdescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matdescription.Focus();
                return;
            }


            //Start

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_lot_management(primary_id,
               this.matlotnumber.Text, matdescription.Text, lblMajorCatId.Text, this.Lots.Added_By, "", this.Lots.Added_By, "", "edit");
                this.GlobalStatePopup.UpdatedSuccessfully();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void matdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
