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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals
{
    public partial class frmAddNewRegion : MaterialForm
    {
        frmRegion ths;
        DataSet dSet = new DataSet();
        readonly TblRegion TblRegionEntity = new TblRegion();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmAddNewRegion(frmRegion frm, 
            string created_by, 
            string RegionDescription, 
            string mode, 
            int identitys)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.TblRegionEntity.Added_By = created_by;
            this.TblRegionEntity.Region_Description = RegionDescription;
            this.TblRegionEntity.Mode = mode;
            this.TblRegionEntity.Region_Id = identitys;
        }




  

        private void frmAddNewRegion_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.CallingMainFormWindowBinder();
        }
        private void ConnectionInit()
        {
           this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void CallingMainFormWindowBinder()
        {
            this.TblRegionEntity.Mode = this.TblRegionEntity.Mode;


            if (TblRegionEntity.Mode == "ADD")
            {
                this.Text = "Add New Region";
                this.matbtnSave.Text = "ADD";
                this.TblRegionEntity.Added_By = this.TblRegionEntity.Added_By;
            }
            else
            {
                this.Text = "Update Region";
                this.matbtnSave.Text = "UPDATE";
                this.TblRegionEntity.Added_By = this.TblRegionEntity.Added_By;
                this.matTxtRegion.Text = this.TblRegionEntity.Region_Description;
            }
            this.matTxtRegion.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }


        private void MetroSave()
        {
            if (this.TblRegionEntity.Mode == "ADD")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblRegion(0,
                    this.matTxtRegion.Text.Trim(),
                    "1",
                    this.TblRegionEntity.Added_By,
                    "",
                    "",
                    "",
                    "add");



                    this.textBox1.Text = "data Already Save!";
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();

                }

                else
                {
                    return;
                }

            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the data ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                    .sp_tblRegion(TblRegionEntity.Region_Id, 
                    this.matTxtRegion.Text.Trim(),
                    "1",
                    this.TblRegionEntity.Added_By,
                    "",
                    this.TblRegionEntity.Added_By,
                    "",
                    "edit");

                    this.textBox1.Text = "data Already Save!";
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();
                }

                else
                {
                    return;
                }
            }



        }




        private void matbtnSave_Click(object sender, EventArgs e)
        {
            if (this.matTxtRegion.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matTxtRegion.Focus();
                return;
            }

            if (this.TblRegionEntity.Mode == "ADD")
            {
                this.TblRegionEntity.Region_Description = String.Empty;
            }

            if (this.matTxtRegion.Text == this.TblRegionEntity.Region_Description)
            {
                this.MetroSave();
            }
            else
            {
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tblRegion(0,
                    this.matTxtRegion.Text,
                    "1",
                    this.TblRegionEntity.Added_By,
                    "",
                    "",
                    "",
                    "getbyname");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.matTxtRegion.Text = String.Empty;
                    this.matTxtRegion.Focus();
                    return;
                }
                else
                {
                    this.MetroSave();
                }
            }

        }

        private void frmAddNewRegion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void matTxtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
