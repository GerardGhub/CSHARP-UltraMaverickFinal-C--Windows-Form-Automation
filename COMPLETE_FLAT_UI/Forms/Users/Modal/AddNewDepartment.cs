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
    public partial class AddNewDepartment : MaterialForm
    {
        frmDepartment ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        Department Dept = new Department();
        TblCustomersRepository TblCustomersRepositorys = new TblCustomersRepository();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public AddNewDepartment(frmDepartment frm, int UserId, string Mode, int DepartmentId, string DepartmentName)
        {
            InitializeComponent();
            ths = frm;
            this.Dept.Created_By = UserId.ToString();
            this.Dept.Mode = Mode;
            this.Dept.Department_Id = DepartmentId;
            this.Dept.Department_Name = DepartmentName;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

        }


        public void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
        }
        private void AddNewDepartment_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            if (this.Dept.Mode == "Add")
            {

            }
            else
            {
                this.TxtDepartment.Text = Dept.Department_Name;
                this.Dept.Department_Id = Dept.Department_Id;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void AddNewDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {


            if (this.Dept.Mode == "Add")
            {
                dSet = g_objStoredProcCollection
                    .sp_department(
                    this.Dept.Department_Id,
                    this.TxtDepartment.Text,
                    "getbyname");



                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    return;
                }
             
                
                

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (this.TxtDepartment.Text.Trim() == "")
                    {


                        this.GlobalStatePopup.FillRequiredFields();
                        TxtDepartment.BackColor = Color.Yellow;
                        TxtDepartment.Focus();
                        return;
                    }



                    else
                    {
                           



                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_department(0,
                        this.TxtDepartment.Text.Trim(),
                        this.Dept.Created_By,
                        this.Dept.Created_At,
                        this.Dept.Updated_At,
                        user_info.firstname,
                        this.Dept.Created_By,
                       "LocationID",
                        "add");
                        this.GlobalStatePopup.SuccessFullySave();

                        this.textBox1.Text = "FormClosed";
                        this.Close();
                    }



                }
                else
                {

                    return;
                }


            }

            else
            {

                if(this.Dept.Department_Name == this.TxtDepartment.Text.Trim())
                {

           
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_department(
                    this.Dept.Department_Id,
                    this.TxtDepartment.Text,
                    "getbyname");



                    if (dSet.Tables[0].Rows.Count > 0)
                    {
                        this.GlobalStatePopup.DataAlreadyExist();
                        return;
                    }
                }


                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (this.TxtDepartment.Text.Trim() == "")
                    {


                        this.GlobalStatePopup.FillRequiredFields();
                        TxtDepartment.BackColor = Color.Yellow;
                        TxtDepartment.Focus();
                        return;
                    }



                    else
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_department(
                            this.Dept.Department_Id,
                            this.TxtDepartment.Text.Trim(),
                            this.Dept.Created_By,
                            "",
                            "",
                            this.Dept.Created_By,
                            this.Dept.Created_By,
                            "",
                            "edit");
                        this.GlobalStatePopup.SuccessFullySave();

                        this.textBox1.Text = "FormClosed";
                        this.Close();
                    }



                }
                else
                {

                    return;
                }
            }
            //close

        }
    }
}
