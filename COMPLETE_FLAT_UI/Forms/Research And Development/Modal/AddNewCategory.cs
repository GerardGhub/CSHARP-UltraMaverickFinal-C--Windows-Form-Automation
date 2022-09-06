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
    public partial class AddNewCategory : MaterialForm
    {
        readonly frmSubCategory ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly Sub_Category SubCategoryEntity = new Sub_Category();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public AddNewCategory(
            frmSubCategory frm,
            int Created_by,
            string SubCategoryDesc,
            string Mode,
            int PrimaryKey,
            string Expirable
            )
        {
            InitializeComponent();
            ths = frm;
            this.textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.SubCategoryEntity.Sc_Added_By = Created_by.ToString();
            this.SubCategoryEntity.Sub_Category_Desc = SubCategoryDesc;
            this.SubCategoryEntity.Mode = Mode;
            this.SubCategoryEntity.Sub_Category_Id = PrimaryKey;
            this.SubCategoryEntity.Sc_Updated_By = Created_by.ToString();
            this.SubCategoryEntity.Is_Expirable = Expirable;

        }

        private void AddNewCategory_Load(object sender, EventArgs e)
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
            this.SubCategoryEntity.Mode = SubCategoryEntity.Mode;


            if (this.SubCategoryEntity.Mode == "ADD")
            {
                this.Text = "Add New Warehouses";
                this.materialButton1.Text = "ADD";
                this.SubCategoryEntity.Sc_Added_By = this.SubCategoryEntity.Sc_Added_By;
                this.TxtSubCategory.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Warehouses";
                this.materialButton1.Text = "UPDATE";
                this.SubCategoryEntity.Sc_Updated_By = this.SubCategoryEntity.Sc_Updated_By;
                this.SubCategoryEntity.Sub_Category_Id = this.SubCategoryEntity.Sub_Category_Id;
                this.TxtSubCategory.Text = SubCategoryEntity.Sub_Category_Desc;
                this.SubCategoryEntity.Sub_Category_Desc = SubCategoryEntity.Sub_Category_Desc;
                this.SubCategoryEntity.Is_Expirable = this.SubCategoryEntity.Is_Expirable;

                if (this.SubCategoryEntity.Is_Expirable == "1")
                {
                    this.matRadioExpirable.Checked = true;
                    this.matRadioNotExpirable.Checked = false;
                }
                else if (this.SubCategoryEntity.Is_Expirable == "0")
                {
                    matRadioExpirable.Checked = false;
                    matRadioNotExpirable.Checked = true;
                }
            }
            this.TxtSubCategory.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.TextBox1.Text = textBox1.Text;

  
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.TxtSubCategory.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtSubCategory.Focus();
                return;
            }
            if(this.matRadioExpirable.Checked == false && this.matRadioNotExpirable.Checked == false)
            {
                this.GlobalStatePopup.FillRequiredFields();
                return;
            }

            if (this.SubCategoryEntity.Sub_Category_Desc == this.TxtSubCategory.Text)
            {
                this.SaveFunctionality();
            }
            else
            {

                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                    .sp_Sub_Category(0,
                    this.TxtSubCategory.Text,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {

                    this.GlobalStatePopup.DataAlreadyExist();
                    this.TxtSubCategory.Text = String.Empty;
                    this.TxtSubCategory.Focus();
                    return;
                }
                else
                {
                    this.SaveFunctionality();
                }
            }
    }

        private void SaveFunctionality()
        {

            if (this.SubCategoryEntity.Mode == "ADD")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection
                   .sp_Sub_Category(0,
                    this.TxtSubCategory.Text.Trim(),

                    this.SubCategoryEntity.Sc_Added_By,
                    this.SubCategoryEntity.Sc_Added_At,
                    this.SubCategoryEntity.Sc_Updated_At,
                    this.SubCategoryEntity.Sc_Updated_By,
                    this.SubCategoryEntity.Is_Expirable,
                    "add");
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();



                }
                else
                {
                    return;
                }
                //End
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection
                   .sp_Sub_Category(this.SubCategoryEntity.Sub_Category_Id,
                    this.TxtSubCategory.Text.Trim(),

                    this.SubCategoryEntity.Sc_Added_By,
                    this.SubCategoryEntity.Sc_Added_At,
                    this.SubCategoryEntity.Sc_Updated_At,
                    this.SubCategoryEntity.Sc_Updated_By,
                    this.SubCategoryEntity.Is_Expirable,
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

        private void matRadioExpirable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioExpirable.Checked == true)
            {
                this.SubCategoryEntity.Is_Expirable = "1";
            }
            else if (this.matRadioNotExpirable.Checked == true)
            {
                this.SubCategoryEntity.Is_Expirable = "0";
            }
        }

        private void matRadioNotExpirable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioExpirable.Checked == true)
            {
                this.SubCategoryEntity.Is_Expirable = "1";
            }
            else if (this.matRadioNotExpirable.Checked == true)
            {
                this.SubCategoryEntity.Is_Expirable = "0";
            }
        }

        private void TxtSubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void AddNewCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }
    }
}
