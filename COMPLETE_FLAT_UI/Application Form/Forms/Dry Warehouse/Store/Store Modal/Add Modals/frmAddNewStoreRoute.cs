using COMPLETE_FLAT_UI.Models;
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
    public partial class FrmAddNewRoute : MaterialForm
    {
        FrmStoreRoute ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        TblRoute TblRouteEntity = new TblRoute();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public FrmAddNewRoute(
            FrmStoreRoute frm, 
            string created_by, 
            string area_name, 
            string mode, int identitys)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            this.created_by = created_by;
            this.TblRouteEntity.Route_Name = area_name;
            this.TblRouteEntity.Mode = mode;
            this.sp_route_id = identitys;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string created_by { get; set; }


        public int sp_route_id { get; set; }
        private void FrmAddNewRoute_Load(object sender, EventArgs e)
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
            this.TblRouteEntity.Mode = TblRouteEntity.Mode;


            if (TblRouteEntity.Mode == "ADD")
            {
                this.Text = "Add New Route";
                this.materialButton1.Text = "ADD";
                this.created_by = created_by;
                this.matTxtRouteName.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Route";
                this.materialButton1.Text = "SAVE";
                this.created_by = created_by;

                this.matTxtRouteName.Text = TblRouteEntity.Route_Name;
            }
            this.matTxtRouteName.Focus();

        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void FrmAddNewRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }






        private void MetroSave()
        {
            if (TblRouteEntity.Mode == "ADD")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                        .sp_tblRoute(
                    0,
                    this.matTxtRouteName.Text.Trim(),
                    userinfo.user_id.ToString(),
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
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection
                        .sp_tblRoute(this.sp_route_id, 
                        this.matTxtRouteName.Text.Trim(),
                        this.created_by,
                        "",
                       this.created_by,
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

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            if (this.matTxtRouteName.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matTxtRouteName.Focus();
                return;
            }


            if (this.TblRouteEntity.Route_Name == this.matTxtRouteName.Text && this.TblRouteEntity.Mode != "ADD")
            {
                this.MetroSave();

            }
            else 
            {
                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                    .sp_tblRoute(0,
                    this.matTxtRouteName.Text,
                    this.created_by,
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.matTxtRouteName.Text = String.Empty;


                    this.matTxtRouteName.Focus();
                    return;
                }
                else
                {
                    this.MetroSave();
                }
            }
        }

        private void MatTxtRouteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
