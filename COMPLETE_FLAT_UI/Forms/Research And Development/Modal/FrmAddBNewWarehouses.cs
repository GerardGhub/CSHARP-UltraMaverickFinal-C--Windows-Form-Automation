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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Research_And_Development.Modal
{
    public partial class FrmAddBNewWarehouses : MaterialForm
    {
        readonly frmWarehouses ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly Major_Category MajorCategoryEntity = new Major_Category();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public FrmAddBNewWarehouses(
             frmWarehouses frm,
            int Created_by,
            string MajorCategoryDesc,
            string Mode,
            int PrimaryKey,
            string WarehouseCode
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            this.MajorCategoryEntity.Mc_Added_By = Created_by.ToString();
            this.MajorCategoryEntity.Major_Category_Desc = MajorCategoryDesc;
            this.MajorCategoryEntity.Mode = Mode;
            this.MajorCategoryEntity.Major_Category_Id = PrimaryKey;
            this.MajorCategoryEntity.Mc_Updated_By = Created_by.ToString();
            this.MajorCategoryEntity.WarehouseCode = WarehouseCode;
        }

        private void FrmAddBNewWarehouses_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadTaskMode();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection =
            this.myClass.g_objStoredProc.GetCollections();
        }
        private void LoadTaskMode()
        {
            this.MajorCategoryEntity.Mode = MajorCategoryEntity.Mode;


            if (MajorCategoryEntity.Mode == "ADD")
            {
                this.Text = "Add New Warehouses";
                this.materialButton1.Text = "ADD";
                this.MajorCategoryEntity.Mc_Added_By = this.MajorCategoryEntity.Mc_Added_By;
                this.TxtMajorCategory.Text = String.Empty;
                this.TxtWarehouseCode.Enabled = true;
                this.TxtWarehouseCode.Focus();
            }
            else
            {
                this.Text = "Update Warehouses";
                this.materialButton1.Text = "SAVE";
                this.MajorCategoryEntity.Mc_Updated_By = this.MajorCategoryEntity.Mc_Updated_By;
                this.MajorCategoryEntity.Major_Category_Id = this.MajorCategoryEntity.Major_Category_Id;
                this.TxtMajorCategory.Text = MajorCategoryEntity.Major_Category_Desc;
                this.MajorCategoryEntity.Major_Category_Desc = this.MajorCategoryEntity.Major_Category_Desc;
                this.TxtWarehouseCode.Text = this.MajorCategoryEntity.WarehouseCode;
            }

        }

        private void FrmAddBNewWarehouses_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.TextBox1.Text = textBox1.Text;
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            string CurrentMode = "";
            if (this.TxtMajorCategory.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtMajorCategory.Focus();
                return;
            }

            if (this.TxtWarehouseCode.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtWarehouseCode.Focus();
                return;
            }


            if (this.MajorCategoryEntity.Mode == "ADD")
            {
                this.MajorCategoryEntity.Major_Category_Desc = String.Empty;
                CurrentMode = "getbywhcode";
            }
            else
            {
                CurrentMode = "getbyname";
            }

            if (this.MajorCategoryEntity.Major_Category_Desc == this.TxtMajorCategory.Text)
            {
          
                this.DoSaveFunctionality();
            }
            else
            {
                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                    .sp_Major_Category(0,
                    this.TxtMajorCategory.Text, 
                    this.TxtWarehouseCode.Text, 
                    "", 
                    "", 
                    "", 
                    this.TxtWarehouseCode.Text,
                    CurrentMode);

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();


                    this.TxtMajorCategory.Focus();
                    return;
                }
                else
                {
                    this.DoSaveFunctionality();
                }
            }

        }

        void DoSaveFunctionality()
        {

            if (this.MajorCategoryEntity.Mode == "ADD")
            {
                // CPU - Bound or IO-Bound operations
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                    .sp_Major_Category(0,
                    this.TxtMajorCategory.Text.Trim(),
                    this.MajorCategoryEntity.Mc_Added_By,
                    this.MajorCategoryEntity.Mc_Added_At,
                    this.MajorCategoryEntity.Mc_Updated_At,
                    this.MajorCategoryEntity.Mc_Updated_By,
                     this.TxtWarehouseCode.Text.Trim(),
                    "add");
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
                // CPU - Bound or IO-Bound operations
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                    .sp_Major_Category(
                    this.MajorCategoryEntity.Major_Category_Id,
                    this.TxtMajorCategory.Text.Trim(),
                    this.MajorCategoryEntity.Mc_Added_By,
                    this.MajorCategoryEntity.Mc_Added_At,
                    this.MajorCategoryEntity.Mc_Updated_At,
                    this.MajorCategoryEntity.Mc_Updated_By,
                    this.TxtWarehouseCode.Text.Trim(),
                    "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();
                }
                else
                {
                    return;
                }


            }


       }

        private void TxtMajorCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            myClass.TextBoxToUpperCase(e);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtWarehouseCode_TextChanged(object sender, EventArgs e)
        {        
            bool result = (this.TxtWarehouseCode.Text == String.Empty) ? this.TxtMajorCategory.Enabled = false : this.TxtMajorCategory.Enabled = true;
        }

        private void TxtWarehouseCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            myClass.TextBoxToUpperCase(e);
        }
    }
}
