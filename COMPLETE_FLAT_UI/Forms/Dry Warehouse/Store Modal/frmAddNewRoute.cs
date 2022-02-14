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
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmAddNewRoute : MaterialForm
    {
        frmStoreRoute ths;
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public frmAddNewRoute(frmStoreRoute frm, string created_by, string area_name, string mode, int identitys)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            this.sp_route_name = area_name;
            this.modes = mode;
            this.sp_route_id = identitys;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string created_by { get; set; }
        public string sp_route_name { get; set; }
        public string modes { get; set; }
        public int sp_route_id { get; set; }
        private void frmAddNewRoute_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.CallingMainFormWindowBinder();
        }
        private void CallingMainFormWindowBinder()
        {
            this.modes = modes;


            if (modes == "add")
            {
                this.Text = "Add New Route";
                this.materialButton1.Text = "ADD";
                this.created_by = created_by;
                this.matTxtRouteName.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Route";
                this.materialButton1.Text = "UPDATE";
                this.created_by = created_by;

                this.matTxtRouteName.Text = sp_route_name;
            }
            this.matTxtRouteName.Focus();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }






        private void MetroSave()
        {
            if (modes == "add")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = objStorProc.sp_tblRoute(0,


                        this.matTxtRouteName.Text.Trim(),
                        this.created_by,
                        "",
                        "",
                        "",
                        "add");



                    this.textBox1.Text = "data Already Save!";
                    this.GlobalStatePopup.CommittedSuccessFully();
                    this.frmAddNewRoute_Load(new object(), new System.EventArgs());

                }

                else
                {
                    return;
                }

            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the data ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = objStorProc.sp_tblRoute(sp_route_id, matTxtRouteName.Text.Trim(),
                        created_by,
                        "",
                       created_by,
                        "",
                        "edit");



                    textBox1.Text = "data Already Save!";
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();
                }

                else
                {
                    return;
                }
            }



        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.matTxtRouteName.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matTxtRouteName.Focus();
                return;
            }



            dSet.Clear();
            dSet = objStorProc.sp_tblRoute(0,
                matTxtRouteName.Text, created_by, "", "", "", "getbyname");

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

        private void matTxtRouteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
