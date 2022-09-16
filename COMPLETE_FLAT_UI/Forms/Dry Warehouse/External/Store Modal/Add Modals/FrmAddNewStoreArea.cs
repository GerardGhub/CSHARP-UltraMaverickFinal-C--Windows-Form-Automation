using MaterialSkin;
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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmAddNewArea : MaterialForm
    {
       frmAreaManagement ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        TblArea TblAreaEntity = new TblArea();
        IStoredProcedures g_objStoredProcCollection = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmAddNewArea(
            frmAreaManagement frm, 
            string Created_by, 
            string Area_name, 
            string Mode, 
            int Identitys )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.TblAreaEntity.Added_By = Created_by;
            this.TblAreaEntity.Area_Name = Area_name;
            this.TblAreaEntity.Mode = Mode;
            this.TblAreaEntity.Aread_Id = Identitys;
            this.TblAreaEntity.Modified_By = Created_by;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
     



        private void frmAddNewArea_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.CallingMainFormWindowBinder();        
        }

        public void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void CallingMainFormWindowBinder()
        {
            this.TblAreaEntity.Mode = TblAreaEntity.Mode;
         
         
            if (this.TblAreaEntity.Mode == "ADD")
            {
                this.Text = "Add New Area";
                this.materialButton1.Text = "ADD";
                this.TblAreaEntity.Added_By = TblAreaEntity.Added_By;

            }
            else
            {
                this.Text = "Update Area";
                this.materialButton1.Text = "UPDATE";
                this.TblAreaEntity.Modified_By = TblAreaEntity.Modified_By;

                this.MattxtStoreArea.Text = this.TblAreaEntity.Area_Name;
            }
            this.MattxtStoreArea.Focus();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

      




        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.MattxtStoreArea.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MattxtStoreArea.Focus();
                return;
            }


            if (this.TblAreaEntity.Mode == "ADD")
            {
                this.TblAreaEntity.Area_Name = String.Empty;
            }

            if (this.MattxtStoreArea.Text == this.TblAreaEntity.Area_Name)
            {
                this.MetroSave();
            }
            else
            {
       

                dSet.Clear();
                dSet = g_objStoredProcCollection
                    .sp_tblArea(0,
                    this.MattxtStoreArea.Text,
                    this.TblAreaEntity.Added_By,
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.MattxtStoreArea.Text = String.Empty;


                    this.MattxtStoreArea.Focus();
                    return;
                }
                else
                {
                    this.MetroSave();
                }
            }


        }

     
    

        private void MetroSave()
        {
            if (TblAreaEntity.Mode == "ADD")
                {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                        .sp_tblArea(0,
                        this.MattxtStoreArea.Text.Trim(),
                        this.TblAreaEntity.Added_By,
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
                this.dSet = g_objStoredProcCollection
                .sp_tblArea(this.TblAreaEntity.Aread_Id, 
                this.MattxtStoreArea.Text.Trim(),
                this.TblAreaEntity.Added_By,
                "",
                this.TblAreaEntity.Added_By,
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

        private void mattxtStoreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void mattxtStoreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
