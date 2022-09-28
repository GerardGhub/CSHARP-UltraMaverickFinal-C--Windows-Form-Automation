using COMPLETE_FLAT_UI.Models;
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
using MaterialSkin;
using MaterialSkin.Controls;

namespace COMPLETE_FLAT_UI
{
    public partial class frmLoginForm : MaterialForm
    {

        DataSet dSet = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        readonly myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        readonly myglobal pointer_module = new myglobal();
        public frmLoginForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
     

            if (txtMaterialUsername.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                txtMaterialUsername.Focus();
                return;

            }

            if (txtMaterialPassword.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                txtMaterialPassword.Focus();
                return;

            }
            dSet.Clear();
            dSet = objStorProc.sp_userfile(0, txtMaterialUsername.Text.Trim(), txtMaterialPassword.Text.Trim(), "", "dispossal");





            //User Stored Procedure Validate name & Password
            dSet.Clear();
            dSet = objStorProc.sp_userfile(0, 
                txtMaterialUsername.Text.Trim(),
                txtMaterialPassword.Text.Trim(), 
                "", "validate");



            if (dSet.Tables[0].Rows.Count > 0)
            {
                userinfo.set_user_parameters(dSet);
                myglobal.user_password = txtMaterialPassword.Text;

                player.SoundLocation = @"C:\MaverickReports\Fedora_Voice\Fresh-morning-Welcome-po-sa-Fe1608971554.wav";
                player.Play();

                string winpath = Environment.GetEnvironmentVariable("windir");
                string path = System.IO.Path.GetDirectoryName(
                              System.Windows.Forms.Application.ExecutablePath);

                //Program Files(x86)\DiniTools\WeighConsole.exe"

                //System.Diagnostics.Process.Start(@"C:\Program Files (x86)\DiniTools\WeighConsole.exe");//deploy

           

                this.Hide();
                FormMenuPrincipal sistema = new FormMenuPrincipal();
                sistema.ShowDialog();
                this.Close();

                //end of form validation
            }
            else
            {
                player.SoundLocation = @"C:\MaverickReports\Fedora_Voice\windows_error_msg.wav";
                player.Play();
                NotAllowToUsedTheSystem();
           
            }
        }

        public void NotAllowToUsedTheSystem()
        {
        
            MetroFramework.MetroMessageBox.Show(this, "Sorry! You are not allowed to use this system invalid credentials! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Application.Exit();
            txtMaterialUsername.Text = String.Empty;
            txtMaterialPassword.Text = String.Empty;

            txtMaterialUsername.Focus();


        }





        private void frmLoginForm_Load(object sender, EventArgs e)
        {

            //ThemeManager.ColorScheme = new ColorScheme(Primary.Black700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);

            objStorProc = xClass.g_objStoredProc.GetCollections();
            txtMaterialUsername.Select();
            this.RoundPictureAss();
      
        }

        private void RoundPictureAss()
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox1.Region = rg;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtMaterialPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void MaterialLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin_Click( sender,  e);
        }

        private void txtMaterialUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            xClass.TextBoxToUpperCase(e);
        }

        private void txtMaterialPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            xClass.TextBoxToUpperCase(e);
        }

        private void txtMaterialPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
