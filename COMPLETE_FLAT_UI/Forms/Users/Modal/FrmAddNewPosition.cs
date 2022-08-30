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
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Users.Modal
{
    public partial class FrmAddNewPosition : MaterialForm
    {
        frmPosition ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        Position PositionEntity = new Position();
        string mode = "";
        TblCustomersRepository TblCustomersRepositorys = new TblCustomersRepository();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public FrmAddNewPosition(frmPosition frm, int UserId, string Mode)
        {
            InitializeComponent();
            ths = frm;
            this.PositionEntity.Created_By = UserId.ToString();
            this.PositionEntity.Mode = Mode;
        }

        private void FrmAddNewPosition_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadDepartment();
        }

        public void LoadDepartment()
        {
            this.myClass.fillComboBoxDepartment(CboDepartment, "department_dropdown", dSet);
            this.PositionEntity.Department_Id = CboDepartment.SelectedValue.ToString();
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = this.myClass.g_objStoredProc.GetCollections();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void FrmAddNewPosition_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {


            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(0,
                    this.TxtPosition.Text.Trim(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.TxtPosition.Focus();
                    return;
                }
                else
                {
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_position(0,
                    this.TxtPosition.Text.Trim(),
                    this.PositionEntity.Department_Id,
                    this.PositionEntity.Created_By,
                    this.PositionEntity.Created_At,
                    this.PositionEntity.Modified_Date,
                    this.PositionEntity.Modified_By,
                    this.PositionEntity.Created_By,
                    "add");
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();

                }

            }


            else
            {

                return;
            }

        }

        private void TxtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
