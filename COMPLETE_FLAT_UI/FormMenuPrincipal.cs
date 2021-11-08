using COMPLETE_FLAT_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Forms.Users;
using ULTRAMAVERICK.Models;
//using MaterialSkin;
//using MaterialSkin.Controls;
using ULTRAMAVERICK.Properties;
using ULTRAMAVERICK.Forms.Research_And_Development;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Forms.Dry_Warehouse;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Import;
using System.IO;
using ULTRAMAVERICK.Report;
using CrystalDecisions.CrystalReports.Engine;
using ULTRAMAVERICK.Barcode_Reprinting;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMenuPrincipal : Form
    {


        ReportDocument rpt = new ReportDocument();
        string Rpt_Path = "";
        //Constructor
        public Byte[] imageByte = null;
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        DataSet dset_rights = new DataSet();
        int rights_id = 0;
        bool ready = false;
        myclasses myClass = new myclasses();
        DataSet dsImage = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            ////Material Themes
            ////var materialSkinManager = MaterialSkinManager.Instance;
            ////materialSkinManager.AddFormToManage(this);
            ////materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        //MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public string ImageParse { get; set; }
        public int sp_user_id { get; set; }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
       
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
                lblFirstName.Visible = false;
               
                lblPosition.Visible = false;
                pbImage.Visible = false;
                ClearDashboardtext();


            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
                lblFirstName.Visible = true;
            
                lblPosition.Visible = true;
                pbImage.Visible = true;
                DashboardEpicComebackofText();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
         
        }

    private void DashboardEpicComebackofText()
        {
            btnDashBoard.Text = "Dashboard";
            btnUsers.Text = "Users";
            btnPreparationDepartment.Text = "Preparation Dept";
            btnDryWarehouse.Text = "Dry Warehouse";
            btnResearchAndDevelopment.Text = "Research & Dev";
            btnProductionPlanner.Text = "Planner";
            btnLogout.Text = "Logout";
        }

        private void ClearDashboardtext()
        {
            btnDashBoard.Text = String.Empty;
            btnUsers.Text = String.Empty;
            btnPreparationDepartment.Text = String.Empty;
            btnDryWarehouse.Text = String.Empty;
            btnResearchAndDevelopment.Text = String.Empty;
            btnProductionPlanner.Text = String.Empty;
            btnLogout.Text = String.Empty;
        }
        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;
            
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormLogo());
            //FormLogo logo = new FormLogo();
            //logo.ShowDialog();


        }


        private void BadgeNotification()
        {
            //Header
            Adorner.AddBadgeTo(btnNotificationsBell, "123");
            //end Header
            //Major Menu Notifications
            if (userinfo.receiving_status == "On")
            {
                //Adorner.AddBadgeTo(btnUsers, "123");
                //Adorner.AddBadgeTo(btnDryWarehouse, "123");
                //Adorner.AddBadgeTo(btnProductionPlanner, "123");
                //Adorner.AddBadgeTo(btnPreparationDepartment, "123");
                //Adorner.AddBadgeTo(btnResearchAndDevelopment, "123");
            }
        }
        public string user_section_controlBox { get; set; }

        private void RoundPictureAss()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbImage.Width - 3, pbImage.Height - 3);
            Region rg = new Region(gp);
            pbImage.Region = rg;
        }

        private void loadDefaultImage()
        {
            try
            {
                ready = false;
                pbImage.Image = null;
                pbImage.Refresh();
                pbImage.BackgroundImage = new Bitmap(ULTRAMAVERICK.Properties.Resources.Buddy);
                // Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\Buddy.png");
                imageByte = new byte[Convert.ToInt32(null)];
        
            }
            catch (Exception)
            {

            }
        }

        private void loadImage()
        {
            sp_user_id = userinfo.user_id;

            dsImage = g_objStoredProcCollection.sp_employee_new(sp_user_id, "", "getImage");
            //              imageByte = (Byte[])(dsImage.Tables[0].Rows[0]["image_employee"]);
            try
            {

                imageByte = (Byte[])(dsImage.Tables[0].Rows[0]["image_employee"]);
                if (imageByte.Length == 0)
                {
                    loadDefaultImage();
                }
                else
                {
                    try
                    {

                        pbImage.Image = Image.FromStream(new MemoryStream(imageByte));
             
                    }
                    catch (Exception exception)
                    {
                        this.Show();
                        loadDefaultImage();
                        MessageBox.Show("Error  :  Image of" + lblFirstName.Text + "  Failed To Load. \n\n" + exception.Message, "HR Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception) { loadDefaultImage(); }
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {            // Calling the Stored PROC 

            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            //this.Size = new Size(1300, 700); //Size of Windows
            BadgeNotification();
            RoundPictureAss();
            //btnUsers.Enabled = true;
            lblFirstName.Text = userinfo.emp_name.ToString() + userinfo.emp_lastname.ToString();// First Name Session
            //lblLastName.Text = userinfo.emp_lastname.ToUpper(); // Last Name Session
            lblPosition.Text = userinfo.position.ToUpperInvariant(); // Position of User
            MostrarFormLogo();// loading logo
                              //rights here
         ImageParse = userinfo.image_employee;
            if(ImageParse == String.Empty)
            {
                loadDefaultImage();
            }
            else
            {
                loadImage();
            }
            rights_id = userinfo.user_rights_id;

            user_section_controlBox = userinfo.user_section;
          
            if (user_section_controlBox == "Office")
            {
                ControlBox = true;
            }
            else
            {
                ControlBox = false;
            }

            //get_accessible_menu

            //Start of Major Menu
            dset_rights.Clear();
            dset_rights = objStorProc.sp_getFilterTables("get_accessible_menu_parents", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
                {
                    string parent_form_name = dset_rights.Tables[0].Rows[x][1].ToString();


              
                    if (parent_form_name == "User")
                    {
                        btnUsers.Enabled = true;
                    }
                    else if (parent_form_name == "bt")
                    {
                        btnDashBoard.Enabled = true;
                      /*  MostrarFormLogo()*/;
                    }


                    else if (parent_form_name == "Dry Warehouse")
                    {
                        btnDryWarehouse.Enabled = true;
                    }
                    else if (parent_form_name == "Production Planner")
                    {
                        btnProductionPlanner.Enabled = true;
                    }
                    else if (parent_form_name == "Preparation Department")
                    {
                        btnPreparationDepartment.Enabled = true;
                    }
                    else if (parent_form_name == "Research & Development")
                    {
                        btnResearchAndDevelopment.Enabled = true;
                    }

                }
            }

            //END




            //Start of Sub Menu
            SubMenu();

            //END
            dset_rights.Clear();
            dset_rights = objStorProc.sp_getFilterTables("get_accessible_menu_grandChild", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
                {
                    string form_name = dset_rights.Tables[0].Rows[x][1].ToString();


                    //User Manager
                    if (form_name == "frmUserManagement.cs")
                    {
                        toolUserManagement.Enabled = true;
                    }

                    else if (form_name == "frmUserRight.cs")
                    {
                        toolUserRights.Enabled = true;

                    }

                    else if (form_name == "frmDepartment.cs")
                    {
                        toolDepartment.Enabled = true;

                    }

                    else if (form_name == "frmDepartmentUnit.cs")
                    {
                        toolDepartmentUnit.Enabled = true;

                    }

                    else if (form_name == "frmTypeofApprover.cs")
                    {
                        toolTypeofApprover.Enabled = true;

                    }


                    else if (form_name == "frmPosition.cs")
                    {
                        toolPosition.Enabled = true;

                    }

                    else if (form_name == "frmLocation.cs")
                    {
                        toolDropdownLocation.Enabled = true;
                    }
                    //End User Manager

                    //Start Menu
                    else if (form_name == "frmParentAvailableForms.cs")
                    {
                        toolParentMenu.Enabled = true;


                    }

                    else if (form_name == "frmChildAvailableForms.cs")
                    {
                        toolChildMenu.Enabled = true;


                    }

                    else if (form_name == "frmGrandChildAvailableForms.cs")
                    {
                        toolGrandChildMenu.Enabled = true;


                    }

                    //Import Dry

                    else if (form_name == "frmImportRawMatsExcel.cs")
                    {
                        dryRawMaterialsToolStripMenuItem.Enabled = true;
                    }
                    else if (form_name == "frmImportPoSummary.cs")
                    {
                        poSummaryToolStripMenuItem.Enabled = true;
                    }

                    // Raw Materials

                    else if (form_name == "frmItemClass.cs")
                    {
                        toolStripModuleItemClass.Enabled = true;
                    }
                    else if (form_name == "frmMajorCategory.cs")
                    {
                        toolStripModuleMajorCategory.Enabled = true;
                    }
                    else if (form_name == "frmSubCategory.cs")
                    {
                        toolStripModuleSubCategory.Enabled = true;
                    }
                    else if (form_name == "frmPrimaryUnit.cs")
                    {
                        toolStripModulePrimaryUnit.Enabled = true;
                    }
                    else if (form_name == "frmItemType.cs")
                    {
                        toolStripModuleItemType.Enabled = true;
                    }
                    else if (form_name == "frmDryRawMaterials")
                    {
                        toolModuleRawMaterialsDry.Enabled = true;
                    }
                    else if (form_name == "frmManageActivePrimaryUnit.cs")
                    {
                        toolModulePrimaryUnitMgmt.Enabled = true;
                    }


                }
            }






        }
        private void SubMenu()
        {
            dset_rights.Clear();
            dset_rights = objStorProc.sp_getFilterTables("get_accessible_menu", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
                {
                    string form_name = dset_rights.Tables[0].Rows[x][1].ToString();



                    if (form_name == "toolDropdownMenu")
                    {
                        toolDropdownMenu.Visible = true;
                    }
                    else if (form_name == "toolDropdownUser")
                    {
                        toolDropdownUser.Visible = true;
                        /*  MostrarFormLogo()*/

                    }
                    //Raw Mats //Dry
                    else if (form_name == "toolStripRawMaterials")
                    {
                        toolStripRawMaterials.Visible = true;
                    }
                    //Import Dry
                    else if (form_name == "toolImportDry")
                    {
                        toolImportDry.Visible = true;
                    }
              


                }
            }
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        //METODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR ----------------------------------------------------------
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            panelMenuSelection.Visible = true;

            SubMenu();

            //Research And Development
            toolStripRawMaterials.Visible = false;
            toolImportDry.Visible = false;
            this.timeSubMenuIn.Start();


            //FormListaClientes fm = new FormListaClientes();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            //FormMembresia frm = new FormMembresia();
            //frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(frm);
            panelMenuSelection.Visible = true;
       
            toolStripRawMaterials.Visible = false;
            SubMenu();
            toolDropdownMenu.Visible = false;
            toolDropdownUser.Visible = false;
            //Research And Development
            toolStripRawMaterials.Visible = false;

            this.timeSubMenuIn.Start();

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximize.Visible = false;
            btnNormal1.Visible = true;
        }

        private void btnNormal1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal1.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
        }

   

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            frmUserRight fm = new frmUserRight();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnMinimizeFinal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizedFinal_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
             btnMaximizedFinal.Visible = false;
            btnNormalFinal.Visible = true;
        }

        private void btnNormalFinal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormalFinal.Visible = false;
            btnMaximizedFinal.Visible = true;
        }

        private void btnCloseFinal_Click(object sender, EventArgs e)
        {
            UpdateUserPasswordModal uptsetting = new UpdateUserPasswordModal();
            uptsetting.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUserManagement fm = new frmUserManagement();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPosition fm = new frmPosition();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment fm = new frmDepartment();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnParentMenu_Click(object sender, EventArgs e)
        {
            frmMajorAvailableForms fm = new frmMajorAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnChildMenu_Click(object sender, EventArgs e)
        {
            frmSubMenusAvailableForms fm = new frmSubMenusAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnTypeofApprove_Click(object sender, EventArgs e)
        {
            frmTypeofApprover fm = new frmTypeofApprover();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //frmDashBoardFormMenu asd = new frmDashBoardFormMenu();
            //asd.ShowDialog();


            frmDashBoardFormMenu addNew = new frmDashBoardFormMenu(this);
            addNew.ShowDialog();
        }

 

        private void toolClosePanelSelection_Click(object sender, EventArgs e)
        {
          
        }

        private void toolClosePanelSelection_Click_1(object sender, EventArgs e)
        {

            ////this.timerSubMenuOut.Start();

            //timerSubMenuOut_Tick(sender, e);


            panelMenuSelection.Visible = false;
        }
    

        private void btnGrandChildForms_Click(object sender, EventArgs e)
        {
            frmModulesAvailableForms fm = new frmModulesAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment fm = new frmDepartment();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolUserManagement_Click(object sender, EventArgs e)
        {
            frmUserManagement2 fm = new frmUserManagement2();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolUserRights_Click(object sender, EventArgs e)
        {
            frmUserRight fm = new frmUserRight();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDepartmentUnit_Click(object sender, EventArgs e)
        {
            frmDepartmentUnit fm = new frmDepartmentUnit();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolTypeofApprover_Click(object sender, EventArgs e)
        {
            frmTypeofApprover fm = new frmTypeofApprover();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolPosition_Click(object sender, EventArgs e)
        {
            frmPosition fm = new frmPosition();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolGrandChildMenu_Click(object sender, EventArgs e)
        {
            frmModulesAvailableForms fm = new frmModulesAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolParentMenu_Click(object sender, EventArgs e)
        {
            frmMajorAvailableForms fm = new frmMajorAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolChildMenu_Click(object sender, EventArgs e)
        {
            frmSubMenusAvailableForms fm = new frmSubMenusAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnApproverTagging_Click(object sender, EventArgs e)
        {
            frmTaggingofApprover fm = new frmTaggingofApprover();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        } 

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
            //PanelHeader.BackColor = MaterialSkinManager.Themes.DARK;

            //if (themeToggle.Checked)
            //{
            //    ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            //}
            //else
            //{
            //    ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //}
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            panelMenuSelection.Visible = false;
        }

        private void toolDropdownUser_Click(object sender, EventArgs e)
        {

        }

        private void toolStripRawMaterials_Click(object sender, EventArgs e)
        {

        }

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblDateFinal.Text = DateTime.Now.ToLongDateString();
            lblTimeFinal.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void toolStripModuleItemClass_Click_1(object sender, EventArgs e)
        {
            frmItemClass fm = new frmItemClass();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModuleMajorCategory_Click(object sender, EventArgs e)
        {
            frmMajorCategory fm = new frmMajorCategory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModuleSubCategory_Click(object sender, EventArgs e)
        {
            frmSubCategory fm = new frmSubCategory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModulePrimaryUnit_Click(object sender, EventArgs e)
        {
            frmPrimaryUnit fm = new frmPrimaryUnit();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModuleItemType_Click(object sender, EventArgs e)
        {
            frmItemType fm = new frmItemType();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDropdownLocation_Click(object sender, EventArgs e)
        {
            frmLocation fm = new frmLocation();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolModuleRawMaterialsDry_Click(object sender, EventArgs e)
        {
            frmDryRawMaterials fm = new frmDryRawMaterials();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
        public string sidecolor { get; set; }
        private void txtMatSideBarColor_TextChanged(object sender, EventArgs e)
        {

            if (txtMatSideBarColor.Text == "Light Gray")
            {
                panelMenu.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnDashBoard.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnUsers.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnDryWarehouse.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnProductionPlanner.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnPreparationDepartment.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnResearchAndDevelopment.BackColor = ColorTranslator.FromHtml("#D6D6D6");
            }
            else if (txtMatSideBarColor.Text == "Matte Black")
            {
                panelMenu.BackColor = ColorTranslator.FromHtml("#4F4F51");
                //Button
                btnDashBoard.ForeColor = Color.White;
                btnUsers.ForeColor = Color.White;
                btnDryWarehouse.ForeColor = Color.White;
                btnProductionPlanner.ForeColor = Color.White;
                btnPreparationDepartment.ForeColor = Color.White;
                btnResearchAndDevelopment.ForeColor = Color.White;

                panelMenu.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnDashBoard.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnUsers.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnDryWarehouse.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnProductionPlanner.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnPreparationDepartment.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnResearchAndDevelopment.BackColor = ColorTranslator.FromHtml("#4F4F51");
            }
            else
            {

            }

            //panelMenu.BackColor = System.Drawing.Color.MidnightBlue;



        }

        private void toolModulePrimaryUnitMgmt_Click(object sender, EventArgs e)
        {
            frmManageActivePrimaryUnit fm = new frmManageActivePrimaryUnit();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolImportDry_Click(object sender, EventArgs e)
        {
           //frmImportRawMatsExcel fm = new frmImportRawMatsExcel();
           // fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
           // AbrirFormEnPanel(fm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          frmUserManagement2 fm = new frmUserManagement2();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void dryRawMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportRawMatsExcel fm = new frmImportRawMatsExcel();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void poSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportPoSummary fm = new frmImportPoSummary();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timerSubMenuOut_Tick(object sender, EventArgs e)
        {
            if (panelMenuSelection.Width <= 0)
                this.timeSubMenuIn.Stop();
            else
                panelMenuSelection.Width = panelMenuSelection.Width - 5;
        }

        private void timeSubMenuIn_Tick(object sender, EventArgs e)
        {
            if (panelMenuSelection.Width >= 230)
                this.timerSubMenuOut.Stop();
            else
                panelMenuSelection.Width = panelMenuSelection.Width + 5;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Logout " + lblFirstName.Text + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //this.Close();

                //frmLoginForm Login = new frmLoginForm();
                //Login.ShowDialog();

                //this.Hide();
                //frmLoginForm sistema = new frmLoginForm();
                //sistema.ShowDialog();

                Application.Exit();
            }
            else
            {

                return;
            }

      
        }

        private void listOfReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListofReceiving fm = new frmListofReceiving();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void lotManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLotManagement fm = new frmLotManagement();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void rMBarcodeModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myglobal.REPORT_NAME = "MicroBook";
            //rpt.Load(Rpt_Path + "\\MicroBook.rpt");

            frmReport fm = new frmReport();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void rMReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDryReceivingModule fm = new frmDryReceivingModule();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBarcodeReprinting fm = new frmBarcodeReprinting();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDryWHInventory fm = new frmDryWHInventory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Form1());
            panelMenuSelection.Visible = true;
            SubMenu();
            toolImportDry.Visible = false;
            //User major Menu
            toolDropdownUser.Visible = false;
            toolDropdownMenu.Visible = false;
        }


        private void toolStripModuleItemClass_Click(object sender, EventArgs e)
        {
            //frmItemClass fm = new frmItemClass();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }



    }
}
