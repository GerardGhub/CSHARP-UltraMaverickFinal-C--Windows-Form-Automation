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

namespace COMPLETE_FLAT_UI
{
    public partial class frmLoginForm : Form
    {
        FormMenuPrincipal mainMenu;
        DataSet dSet = new DataSet();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginProcedural();

            if (dSet.Tables[0].Rows.Count > 0)
            {
                userinfo.set_user_parameters(dSet);
                myglobal.user_password = txtPassword.Text;

                player.SoundLocation = @"C:\MaverickReports\Fedora_Voice\Fresh-morning-Welcome-po-sa-Fe1608971554.wav";
                player.Play();

                string winpath = Environment.GetEnvironmentVariable("windir");
                string path = System.IO.Path.GetDirectoryName(
                              System.Windows.Forms.Application.ExecutablePath);

                //Program Files(x86)\DiniTools\WeighConsole.exe"

                //System.Diagnostics.Process.Start(@"C:\Program Files (x86)\DiniTools\WeighConsole.exe");//deploy


                mainMenu = new FormMenuPrincipal();
                mainMenu.Show();



                this.Close();

            }
            else
            {
                player.SoundLocation = @"C:\MaverickReports\windows_error_msg.wav";
                player.Play();
                //MessageBox.Show("Sorry! You are not allowed to use this system!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotAllowToUsedTheSystem();
           
            }
        }

        public void NotAllowToUsedTheSystem()
        {
        
            MetroFramework.MetroMessageBox.Show(this, "Sorry! You are not allowed to use this system! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Application.Exit();
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            
            txtUsername.Focus();


        }

        public void StartupFocus()
        {

        }
        public void LoginProcedural()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                FilltextboxErrorNotifier();
                txtUsername.Focus();
                return;

            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                FilltextboxErrorNotifier();
                txtPassword.Focus();
                return;

            }
        }


        public void FilltextboxErrorNotifier()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);

            popup.ContentText = "Warning , Fill up the Empty Fields";

            popup.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);

            popup.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.ContentPadding = new Padding(0);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            //popup.Size = new Size(920, 270);
            //popup.ImageSize = new Size(175, 220);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }




    }
}
