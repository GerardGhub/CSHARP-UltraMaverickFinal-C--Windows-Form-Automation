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
    public partial class frmAddNewArea : MaterialForm
    {
      frmAreaManagement ths;
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmAddNewArea(frmAreaManagement frm, string created_by, string area_name, string mode, int identitys )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            this.sp_area_name = area_name;
            this.modes = mode;
            this.sp_area_id = identitys;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string created_by { get; set; }
        public string sp_area_name { get; set; }
        public string modes { get; set; }
        public int sp_area_id { get; set; }
        private void frmAddNewArea_Load(object sender, EventArgs e)
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
                this.Text = "Add New Area";
                this.materialButton1.Text = "ADD";
                this.created_by = created_by;
                this.mattxtStoreName.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Area";
                this.materialButton1.Text = "UPDATE";
                this.created_by = created_by;
              
                this.mattxtStoreName.Text = sp_area_name;
            }
            this.mattxtStoreName.Focus();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddNewArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

      

        public void AlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Data Already Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.mattxtStoreName.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtStoreName.Focus();
                return;
            }

        

            dSet.Clear();
            dSet = objStorProc.sp_tblArea(0,
                this.mattxtStoreName.Text, 
                this.created_by, "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.AlreadyExist();
                this.mattxtStoreName.Text = String.Empty;


                this.mattxtStoreName.Focus();
                return;
            }
            else
            {
                this.MetroSave();
            }


        }

     
    

        private void MetroSave()
        {
            if (modes == "add")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = objStorProc.sp_tblArea(0,


                        mattxtStoreName.Text.Trim(),
                        created_by,
                        "",
                        "",
                        "",
                        "add");



                    textBox1.Text = "data Already Save!";
                    this.GlobalStatePopup.CommittedSuccessFully();
                    frmAddNewArea_Load(new object(), new System.EventArgs());

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


                    dSet.Clear();
                    dSet = objStorProc.sp_tblArea(this.sp_area_id, 
                        this.mattxtStoreName.Text.Trim(),
                        this.created_by,
                        "",
                       this.created_by,
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

        private void mattxtStoreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void mattxtStoreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
