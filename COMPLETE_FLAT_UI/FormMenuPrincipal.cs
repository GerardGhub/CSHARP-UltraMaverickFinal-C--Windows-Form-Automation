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
using MaterialSkin;
using MaterialSkin.Controls;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMenuPrincipal : MaterialForm
    {
        //Constructor
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        DataSet dset_rights = new DataSet();
        int rights_id = 0;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            //Material Themes
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

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
                lblLastName.Visible = false;
                lblPosition.Visible = false;
       
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblPosition.Visible = true;
           
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
         
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

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 700); //Size of Windows
            //btnUsers.Enabled = true;
            lblFirstName.Text = userinfo.emp_name.ToString() + userinfo.emp_lastname.ToString();// First Name Session
            //lblLastName.Text = userinfo.emp_lastname.ToUpper(); // Last Name Session
            lblPosition.Text = userinfo.position.ToUpperInvariant(); // Position of User
            MostrarFormLogo();// loading logo
            //rights here
            rights_id = userinfo.user_rights_id;
            // Calling the Stored PROC 
            objStorProc = xClass.g_objStoredProc.GetCollections();

            //get_accessible_menu

            //Start of Parent Menu
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




            //Start of Child Menu
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
                        ;
                    }


      


            


                }
            }

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

            //FormListaClientes fm = new FormListaClientes();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            FormMembresia frm = new FormMembresia();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
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
            if (MessageBox.Show("Hi Punyeta?", "Alert to¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                // Start 3 blocks of validate
                frmLoginForm mainLogin = new frmLoginForm();
                this.Hide();
                mainLogin.Closed += (s, args) => this.Close();
                mainLogin.Show();
                //end of form validation

                //Application.Exit();
            }
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
            frmParentAvailableForms fm = new frmParentAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnChildMenu_Click(object sender, EventArgs e)
        {
            frmChildAvailableForms fm = new frmChildAvailableForms();
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
            frmDashBoardFormMenu asd = new frmDashBoardFormMenu();
            asd.ShowDialog();
        }

 

        private void toolClosePanelSelection_Click(object sender, EventArgs e)
        {
          
        }

        private void toolClosePanelSelection_Click_1(object sender, EventArgs e)
        {
            panelMenuSelection.Visible = false;
        }

        private void btnGrandChildForms_Click(object sender, EventArgs e)
        {
            frmGrandChildAvailableForms fm = new frmGrandChildAvailableForms();
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
            frmUserManagement fm = new frmUserManagement();
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
            frmGrandChildAvailableForms fm = new frmGrandChildAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolParentMenu_Click(object sender, EventArgs e)
        {
            frmParentAvailableForms fm = new frmParentAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolChildMenu_Click(object sender, EventArgs e)
        {
            frmChildAvailableForms fm = new frmChildAvailableForms();
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

            if (themeToggle.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblDateFinal.Text = DateTime.Now.ToLongDateString();
            lblTimeFinal.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form1());
        }

        

    }
}
