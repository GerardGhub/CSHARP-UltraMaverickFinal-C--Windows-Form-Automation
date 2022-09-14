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
    public partial class AddPrimaryUnit : MaterialForm
    {
        frmPrimaryUnit ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        Primary_Unit PrimaryUnitEntity = new Primary_Unit();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public AddPrimaryUnit(
            frmPrimaryUnit frm,
            int Created_by,
            string PrimaryUnitDesc,
            string Mode,
            int PrimaryKey
            )
        {
            InitializeComponent();
            ths = frm;
            this.textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.PrimaryUnitEntity.Pm_Added_By = Created_by.ToString();
            this.PrimaryUnitEntity.Unit_Desc = PrimaryUnitDesc;
            this.PrimaryUnitEntity.Mode = Mode;
            this.PrimaryUnitEntity.Unit_Id = PrimaryKey;
            this.PrimaryUnitEntity.Pm_Updated_By = Created_by.ToString();
        }

        private void AddPrimaryUnit_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadTaskMode();
        }

        private void LoadTaskMode()
        {
            this.PrimaryUnitEntity.Mode = PrimaryUnitEntity.Mode;


            if (PrimaryUnitEntity.Mode == "ADD")
            {
                this.Text = "Add New Primary Unit";
                this.materialButton1.Text = "ADD";
                this.PrimaryUnitEntity.Pm_Added_By = this.PrimaryUnitEntity.Pm_Added_By;
                this.TxtMatPrimaryUnit.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Primary Unit";
                this.materialButton1.Text = "UPDATE";
                this.PrimaryUnitEntity.Pm_Updated_By = this.PrimaryUnitEntity.Pm_Updated_By;
                this.PrimaryUnitEntity.Unit_Id = this.PrimaryUnitEntity.Unit_Id;
                this.TxtMatPrimaryUnit.Text = PrimaryUnitEntity.Unit_Desc;
                this.PrimaryUnitEntity.Unit_Desc = this.PrimaryUnitEntity.Unit_Desc;
            }
            this.TxtMatPrimaryUnit.Focus();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection =
            this.myClass.g_objStoredProc.GetCollections();
        }


        private void AddPrimaryUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.TxtMatPrimaryUnit.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtMatPrimaryUnit.Focus();
                return;
            }

            if (this.PrimaryUnitEntity.Mode == "ADD")
            {
                this.PrimaryUnitEntity.Unit_Desc = String.Empty;
            }



            if (this.PrimaryUnitEntity.Unit_Desc == this.TxtMatPrimaryUnit.Text)
            {
                this.SaveFunctionality();
            }
            else
            {

                dSet.Clear();
                dSet = g_objStoredProcCollection
                    .sp_Primary_Unit(0,
                    this.TxtMatPrimaryUnit.Text,
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.TxtMatPrimaryUnit.Text = String.Empty;
                    this.TxtMatPrimaryUnit.Focus();
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
            if (this.PrimaryUnitEntity.Mode == "ADD")
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the new data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                        this.dSet.Clear();
                        this.dSet = this.g_objStoredProcCollection
                        .sp_Primary_Unit(0,
                        this.TxtMatPrimaryUnit.Text.Trim(),
                        this.PrimaryUnitEntity.Pm_Added_By,
                        this.PrimaryUnitEntity.Pm_Added_At,
                        this.PrimaryUnitEntity.Pm_Updated_At,
                        this.PrimaryUnitEntity.Pm_Updated_By,
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
                    .sp_Primary_Unit(
                    this.PrimaryUnitEntity.Unit_Id,
                    this.TxtMatPrimaryUnit.Text.Trim(),
                    this.PrimaryUnitEntity.Pm_Added_By,
                    this.PrimaryUnitEntity.Pm_Added_At,
                    this.PrimaryUnitEntity.Pm_Updated_At,
                    this.PrimaryUnitEntity.Pm_Updated_By,
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

        private void TxtMatPrimaryUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
