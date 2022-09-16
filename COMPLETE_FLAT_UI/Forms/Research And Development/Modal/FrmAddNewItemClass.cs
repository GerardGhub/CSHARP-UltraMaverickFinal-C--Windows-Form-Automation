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
    public partial class FrmAddNewItemClass : MaterialForm
    {
        readonly FrmItemClass ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly Item_Class Item_ClassEntity = new Item_Class();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public FrmAddNewItemClass(
            FrmItemClass frm,
            int Created_by,
            string ItemClassDesc,
            string Mode, 
            int PrimaryKey
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            this.Item_ClassEntity.Item_Added_By = Created_by.ToString();
            this.Item_ClassEntity.Item_Class_Desc = ItemClassDesc;
            this.Item_ClassEntity.Mode = Mode;
            this.Item_ClassEntity.Item_Class_Id = PrimaryKey;
            this.Item_ClassEntity.Item_Updated_By = Created_by.ToString();
        }

        private void FrmAddNewItemClass_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadTaskMode();
        }

        private void LoadTaskMode()
        {
            this.Item_ClassEntity.Mode = Item_ClassEntity.Mode;


            if (Item_ClassEntity.Mode == "ADD")
            {
                this.Text = "Add New Item Class";
                this.materialButton1.Text = "ADD";
                this.Item_ClassEntity.Item_Added_By = this.Item_ClassEntity.Item_Added_By;
                this.TxtMatItemClass.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Item Class";
                this.materialButton1.Text = "UPDATE";
                this.Item_ClassEntity.Item_Updated_By = this.Item_ClassEntity.Item_Updated_By;
                this.Item_ClassEntity.Item_Class_Id = this.Item_ClassEntity.Item_Class_Id;
                this.TxtMatItemClass.Text = Item_ClassEntity.Item_Class_Desc;
                this.Item_ClassEntity.Item_Class_Desc = this.Item_ClassEntity.Item_Class_Desc;
            }
            this.TxtMatItemClass.Focus();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = 
            this.myClass.g_objStoredProc.GetCollections();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void FrmAddNewItemClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.TxtMatItemClass.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtMatItemClass.Focus();
                return;
            }


            if (Item_ClassEntity.Mode == "ADD")
            {
                this.Item_ClassEntity.Item_Class_Desc = String.Empty;
            }


            if (this.Item_ClassEntity.Item_Class_Desc == this.TxtMatItemClass.Text)
            {
                this.SaveFunctionality();
            }
            else
            {
                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                    .sp_Item_Class(0,
                    this.TxtMatItemClass.Text,
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.TxtMatItemClass.Text = string.Empty;
                    this.TxtMatItemClass.Focus();
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
            if (this.Item_ClassEntity.Mode == "ADD")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the new data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                        .sp_Item_Class(0,
                    this.TxtMatItemClass.Text.Trim(),
                    this.Item_ClassEntity.Item_Added_By,
                    this.Item_ClassEntity.Item_Added_At,
                    this.Item_ClassEntity.Item_Updated_At,
                    this.Item_ClassEntity.Item_Updated_By,
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

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the new data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                        .sp_Item_Class(this.Item_ClassEntity.Item_Class_Id,
                    this.TxtMatItemClass.Text.Trim(),
                    this.Item_ClassEntity.Item_Added_By,
                    this.Item_ClassEntity.Item_Added_At,
                    this.Item_ClassEntity.Item_Updated_At,
                    this.Item_ClassEntity.Item_Updated_By,
                    "edit");
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();


                }

                else
                {
                    return;
                }

            }
        }

        private void TxtMatItemClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
