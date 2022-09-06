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
    public partial class FrmAddNewItemType : MaterialForm
    {
        frmItemType ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        Item_Type ItemTypeEntity = new Item_Type();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public FrmAddNewItemType(
            frmItemType frm,
            int Created_by,
            string ItemTypeDesc,
            string Mode,
            int PrimaryKey
            )
        {
            InitializeComponent();
            ths = frm;
            this.textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.ItemTypeEntity.It_Added_By = Created_by.ToString();
            this.ItemTypeEntity.Item_Type_Desc = ItemTypeDesc;
            this.ItemTypeEntity.Mode = Mode;
            this.ItemTypeEntity.Item_Type_Id = PrimaryKey;
            this.ItemTypeEntity.It_Updated_By = Created_by.ToString();
        }

        private void FrmAddNewItemType_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadTaskMode();
        }

        private void LoadTaskMode()
        {
            this.ItemTypeEntity.Mode = this.ItemTypeEntity.Mode;


            if (this.ItemTypeEntity.Mode == "ADD")
            {
                this.Text = "Add New Primary Unit";
                this.materialButton1.Text = "ADD";
                this.ItemTypeEntity.It_Added_By = this.ItemTypeEntity.It_Added_By;
                this.TxtMatItemType.Text = String.Empty;
                this.TxtMatItemType.Focus();
            }
            else
            {
                this.Text = "Update Primary Unit";
                this.materialButton1.Text = "UPDATE";
                this.ItemTypeEntity.It_Updated_By = this.ItemTypeEntity.It_Updated_By;
                this.ItemTypeEntity.Item_Type_Id = this.ItemTypeEntity.Item_Type_Id;
                this.TxtMatItemType.Text = this.ItemTypeEntity.Item_Type_Desc;
                this.ItemTypeEntity.Item_Type_Desc = this.ItemTypeEntity.Item_Type_Desc;
            }
   
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection =
            this.myClass.g_objStoredProc.GetCollections();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {


            if (this.ItemTypeEntity.Item_Type_Desc == this.TxtMatItemType.Text)
            {
                this.SaveFunctionality();
            }
            else
            {
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_Item_Type(0,
                    this.TxtMatItemType.Text,
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.TxtMatItemType.Text = String.Empty;
                    this.TxtMatItemType.Focus();
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
            if (this.ItemTypeEntity.Mode == "ADD")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the new data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_Item_Type(0,
                    this.TxtMatItemType.Text.Trim(),
                    this.ItemTypeEntity.It_Added_By,
                    this.ItemTypeEntity.It_Added_At,
                    this.ItemTypeEntity.It_Updated_At,
                    this.ItemTypeEntity.It_Updated_By,
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
                    this.dSet = g_objStoredProcCollection.sp_Item_Type(
                    this.ItemTypeEntity.Item_Type_Id,
                    this.TxtMatItemType.Text.Trim(),
                    this.ItemTypeEntity.It_Added_By,
                    this.ItemTypeEntity.It_Added_At,
                    this.ItemTypeEntity.It_Updated_At,
                    this.ItemTypeEntity.It_Updated_By,
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.TextBox1.Text = textBox1.Text;
        }

        private void TxtMatItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void FrmAddNewItemType_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }
    }
}
