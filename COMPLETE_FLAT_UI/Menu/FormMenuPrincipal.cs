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
using System.Drawing.Drawing2D;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation;
using ULTRAMAVERICK.BaseWPFControls;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Dispatching;
using ULTRAMAVERICK.Forms.Lab_Test;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Miscellaneous;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order;
using ULTRAMAVERICK.Menu.View_Models;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMenuPrincipal : Form
    {


        ReportDocument rpt = new ReportDocument();
   
        //Constructor
        public Byte[] imageByte = null;
        myclasses xClass = new myclasses();

        IStoredProcedures objStorProc = null;
        DataSet dset_rights = new DataSet();
        DataSet dSet = new DataSet();
        int rights_id = 0;
        myclasses myClass = new myclasses();
        readonly MenuClasses Menu = new MenuClasses();
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

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (this.Menu.sizeGripRectangle.Contains(hitPoint))
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

            this.Menu.sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(this.Menu.sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, this.Menu.sizeGripRectangle);

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, this.Menu.sizeGripRectangle);
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
      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
    
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 185)
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
            btnDashBoard1.Text = "Dashboard";
            btnUsers1.Text = "Users";
            btnPreparationDepartment1.Text = "Preparation Dept";
            btnDryWarehouse1.Text = "Dry Warehouse";
            btnResearchAndDevelopment1.Text = "Research & Dev";
            btnProductionPlanner1.Text = "Planner";
            btnSetUp.Text = "Set-Up";
        }

        private void ClearDashboardtext()
        {
            btnDashBoard1.Text = String.Empty;
            btnUsers1.Text = String.Empty;
            btnPreparationDepartment1.Text = String.Empty;
            btnDryWarehouse1.Text = String.Empty;
            btnResearchAndDevelopment1.Text = String.Empty;
            btnProductionPlanner1.Text = String.Empty;
            btnSetUp.Text = String.Empty;
        }
        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 185)
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

        private  void HeaderBadge() //Header Badge
        {
            if(this.Menu.TotalStoreOrderCancelatWhChecker != "0")
            {
                this.Menu.TotalStoreOrderCancelatWhChecker = "1";
            }
            this.Menu.TotalCountNotificationDistinctType = 
            Convert.ToDouble(this.Menu.TotalStoreOrderCancelatWhChecker) +
            Convert.ToDouble(this.Menu.TotalStoreOrderDistinctLogisticChecker) +
            Convert.ToDouble(this.Menu.TotalLabTestReceivingViewing);
        }

        private void BadgeNotification()
        {
            if (this.Menu.TotalStoreOrderCancelatWhChecker != "0")
            {
                this.HeaderBadge();
            }
            else if (this.Menu.TotalStoreOrderDistinctLogisticChecker != "0")
            {
                this.HeaderBadge();
            }
            else if (this.Menu.TotalLabTestReceivingViewing != "0")
            {
                this.HeaderBadge();
            }
            else
            {
             
            }


            //Header
            Adorner.AddBadgeTo(btnNotificationsBell, 
            this.Menu.TotalCountNotificationDistinctType.ToString());
            //end Header
            //Major Menu Notifications
            if (userinfo.receiving_status == "On")
            {
                //Adorner.AddBadgeTo(btnUsers, "123");
                //Adorner.AddBadgeTo(btnDryWarehouse, "123");
                //Adorner.AddBadgeTo(btnProductionPlanner, "123");
                //Adorner.AddBadgeTo(btnPreparationDepartment, "123");
                //Adorner.AddBadgeTo(btnResearchAndDevelopment, "123");
                //Adorner.AddBadgeToToolStrip(listOfReceivingToolStripMenuItem, total_receiving_dry_wh);
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

                this.pbImage.Image = null;
                this.pbImage.Refresh();
                this.pbImage.BackgroundImage = new Bitmap(ULTRAMAVERICK.Properties.Resources.Buddy);
                this.imageByte = new byte[Convert.ToInt32(null)];
        
            }
            catch (Exception)
            {

            }
        }

        private void loadImage()
        {
            this.Menu.sp_user_id = userinfo.user_id;

            this.dsImage = g_objStoredProcCollection.sp_employee_new(this.Menu.sp_user_id, "", "getImage");
            //              imageByte = (Byte[])(dsImage.Tables[0].Rows[0]["image_employee"]);
            try
            {

                this.imageByte = (Byte[])(this.dsImage.Tables[0].Rows[0]["image_employee"]);
                if (this.imageByte.Length == 0)
                {
                    this.loadDefaultImage();
                }
                else
                {
                    try
                    {

                        this.pbImage.Image = Image.FromStream(new MemoryStream(imageByte));
             
                    }
                    catch (Exception exception)
                    {
                        this.Show();
                        this.loadDefaultImage();
                        MessageBox.Show("Error  :  Image of" + lblFirstName.Text + "  Failed To Load. \n\n" + exception.Message, "HR Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception) { loadDefaultImage(); }
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {            // Calling the Stored PROC 
           
            this.ConnectionInit();

            //this.Size = new Size(1300, 700); //Size of Windows
           
            this.RoundPictureAss();

            this.showReceivingData();

   


            //btnUsers.Enabled = true;
            this.lblFirstName.Text = userinfo.emp_name.ToString() + new string(' ', 1) + userinfo.emp_lastname.ToString();// First Name Session
            //lblLastName.Text = userinfo.emp_lastname.ToUpper(); // Last Name Session
            this.lblPosition.Text = userinfo.position.ToUpperInvariant(); // Position of User
            MostrarFormLogo();// loading logo
                              //rights here
            this.Menu.ImageParse = userinfo.image_employee;
            if(this.Menu.ImageParse == String.Empty)
            {
                this.loadDefaultImage();
            }
            else
            {
                this.loadImage();
            }
            this.rights_id = userinfo.user_rights_id;

            this.user_section_controlBox = userinfo.user_section;
          
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
                        btnUsers1.Visible = true;
                    }
                    else if (parent_form_name == "bt")
                    {
                        btnDashBoard1.Visible = true;
                      /*  MostrarFormLogo()*/;
                    }


                    else if (parent_form_name == "Dry Warehouse")
                    {
                        btnDryWarehouse1.Visible = true;
                    }
                    else if (parent_form_name == "Production Planner")
                    {
                        btnProductionPlanner1.Visible = true;
                    }
                    else if (parent_form_name == "Preparation Department")
                    {
                        btnPreparationDepartment1.Visible = true;
                    }
                    else if (parent_form_name == "Research & Development")
                    {
                        btnResearchAndDevelopment1.Visible = true;
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
                    else if (form_name == "frmDryWHInventory.cs")
                    {
                        dryWHInventoryToolStripMenuItem.Enabled = true;
                    }
                    else if (form_name == "frmListofReceiving.cs")
                    {
                        listOfReceivingToolStripMenuItem.Enabled = true;
                    }
                    else if (form_name == "frmDryReceivingModule.cs")
                    {
                        rMReceivingToolStripMenuItem.Enabled = true;
                    }
                    else if (form_name == "frmLotManagement.cs")
                    {
                        lotManagementToolStripMenuItem.Enabled = true;
                    }
                    else if (form_name == "rMBarcodeModuleToolStripMenuItem")
                    {
                        rMBarcodeModuleToolStripMenuItem.Enabled = true;
                    }
                    else if (form_name == "rMBarcodeReprintingToolStripMenuItem")
                    {
                        rMBarcodeReprintingToolStripMenuItem.Enabled = true;
                    }

                }
            }

     
            this.CancelledforStorePreparationatLogisticChecker();

            this.DispatchingforStorePreparationatLogisticChecker();
   
            this.showLabTestForReceiving();
            this.BadgeNotification();



            //MessageBox.Show(this.TotalLabTestReceivingViewing);
            //bool v = Adorner.AddBadgeTos(btnDashBoard1, "123");

        }

        private void showLabTestForReceiving()    //method for loading available_menus
        {
            // Try this Fuck!!
            dSet.Clear();
            try
            {

                xClass.fillDataGridView(this.dgvParseData, "DryWarehouseLabTestReceivingViewing", this.dSet);

                this.Menu.TotalLabTestReceivingViewing = this.dgvParseData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }


        private void CancelledforStorePreparationatLogisticChecker()      //method for loading available_menus
        {
            try
            {
                
                xClass.fillDataGridView(this.dgvParseData, "Store_Order_Cancelled_by_WH_Checker", dSet);

                this.Menu.TotalStoreOrderCancelatWhChecker = this.dgvParseData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void DispatchingforStorePreparationatLogisticChecker()     
        {
            try
            {

                xClass.fillDataGridView(this.dgvParseData, "Store_Order_Dispatched_by_Logistic_Checker", this.dSet);

                this.Menu.TotalStoreOrderDistinctLogisticChecker = this.dgvParseData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                    else if(form_name == "toolReceiving")
                    {
                        toolReceiving.Visible = true;
                    }
                    else if (form_name == "toolStripMoveOrderSetup")
                    {
                        toolStripMoveOrderSetup.Visible = true;
                    }



                }
            }
        }

        private void showReceivingData()      //method for loading available_menus
        {
            try
            {

               this.xClass.fillDataGridView(dgvParseData, "Po_Receiving_Warehouse", this.dSet);       
               this.Menu.total_receiving_dry_wh = dgvParseData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            toolStripRawMaterials.Visible = true;

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


            this.ShowInTaskbar = false;

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
            //UpdateUserPasswordModal uptsetting = new UpdateUserPasswordModal();
            //uptsetting.ShowDialog();
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Logout " + lblFirstName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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


        private void NormalSizeofSideBar()
        {
             if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
                this.lblFirstName.Visible = true;

                this.lblPosition.Visible = true;
                this.pbImage.Visible = true;
                DashboardEpicComebackofText();
            }
        }
        private void toolClosePanelSelection_Click_1(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            ////this.timerSubMenuOut.Start();

            //timerSubMenuOut_Tick(sender, e);


            panelMenuSelection.Visible = false;
            MainMajorData.Visible = true;
        }
    

        private void btnGrandChildForms_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmModulesAvailableForms fm = new frmModulesAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDepartment_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDepartment fm = new frmDepartment();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolUserManagement_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmUserManagement2 fm = new frmUserManagement2();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolUserRights_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmUserRight fm = new frmUserRight();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDepartmentUnit_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDepartmentUnit fm = new frmDepartmentUnit();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolTypeofApprover_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmTypeofApprover fm = new frmTypeofApprover();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolPosition_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmPosition fm = new frmPosition();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolGrandChildMenu_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmModulesAvailableForms fm = new frmModulesAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolParentMenu_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmMajorAvailableForms fm = new frmMajorAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolChildMenu_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmSubMenusAvailableForms fm = new frmSubMenusAvailableForms();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnApproverTagging_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
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
            lblTimeFinal.Text = DateTime.Now.ToString("h:mm:ss");
        }

        private void toolStripModuleItemClass_Click_1(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmItemClass fm = new frmItemClass();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModuleMajorCategory_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmWarehouses fm = new frmWarehouses();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModuleSubCategory_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmSubCategory fm = new frmSubCategory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModulePrimaryUnit_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmPrimaryUnit fm = new frmPrimaryUnit();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripModuleItemType_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmItemType fm = new frmItemType();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDropdownLocation_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmLocation fm = new frmLocation();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolModuleRawMaterialsDry_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryMiscellaneouseIssue fm = new frmDryMiscellaneouseIssue();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
        public string sidecolor { get; set; }
        private void txtMatSideBarColor_TextChanged(object sender, EventArgs e)
        {

            if (txtMatSideBarColor.Text == "Light Gray")
            {
                panelMenu.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnDashBoard1.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnUsers1.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnDryWarehouse1.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnProductionPlanner1.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnPreparationDepartment1.BackColor = ColorTranslator.FromHtml("#D6D6D6");
                btnResearchAndDevelopment1.BackColor = ColorTranslator.FromHtml("#D6D6D6");
            }
            else if (txtMatSideBarColor.Text == "Matte Black")
            {
                panelMenu.BackColor = ColorTranslator.FromHtml("#4F4F51");
                //Button
                btnDashBoard1.ForeColor = Color.White;
                btnUsers1.ForeColor = Color.White;
                btnDryWarehouse1.ForeColor = Color.White;
                btnProductionPlanner1.ForeColor = Color.White;
                btnPreparationDepartment1.ForeColor = Color.White;
                btnResearchAndDevelopment1.ForeColor = Color.White;

                panelMenu.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnDashBoard1.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnUsers1.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnDryWarehouse1.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnProductionPlanner1.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnPreparationDepartment1.BackColor = ColorTranslator.FromHtml("#4F4F51");
                btnResearchAndDevelopment1.BackColor = ColorTranslator.FromHtml("#4F4F51");
            }
            else
            {

            }

            //panelMenu.BackColor = System.Drawing.Color.MidnightBlue;



        }

        private void toolModulePrimaryUnitMgmt_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
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
            this.NormalSizeofSideBar();
            frmUserManagement2 fm = new frmUserManagement2();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void dryRawMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmImportRawMatsExcel fm = new frmImportRawMatsExcel();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void poSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmImportPoSummary fm = new frmImportPoSummary();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
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
            this.NormalSizeofSideBar();
            frmListofReceiving fm = new frmListofReceiving();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }



        private void rMBarcodeModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myglobal.REPORT_NAME = "MicroBook";
            //rpt.Load(Rpt_Path + "\\MicroBook.rpt");
            //this.NormalSizeofSideBar();
            frmReport fm = new frmReport();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void rMReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryReceivingModule fm = new frmDryReceivingModule();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryWHInventory fm = new frmDryWHInventory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void dryWHInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryWHInventory fm = new frmDryWHInventory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void rMBarcodeReprintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmBarcodeReprinting fm = new frmBarcodeReprinting();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void panelMenuSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashBoard1_Click(object sender, EventArgs e)
        {
            panelMenuSelection.Visible = false;
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Logout " + lblFirstName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnDashBoard1_Click_1(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            this.panelMenuSelection.Visible = false;
            FormLogo fm = new FormLogo();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnUsers1_Click(object sender, EventArgs e)
        {
            panelMenuSelection.Visible = true;

            SubMenu();

            //Research And Development
            toolPreparation.Visible = false;
            //Receiving Collection
            this.toolReceiving.Visible = false;
            //Store Collection
            this.toolStore.Visible = false;
            //Raw Materials Per Items
            toolStripRawMaterials.Visible = false;
            //Import Collection
            toolImportDry.Visible = false;
            //Miscellaneouse Receipt
            this.toolStripMoveOrderSetup.Visible = false;
            this.toolStripDropDownButtonLabTest.Visible = false;
            //Miscellaneous Process
            this.toolStripDropDownMiscellaneousDryWh.Visible = false;
            this.timeSubMenuIn.Start();
       
        }

        private void btnDryWarehouse1_Click(object sender, EventArgs e)
        {
            this.panelMenuSelection.Visible = true;
            //Raw Material Collection
            this.toolStripRawMaterials.Visible = false;
            this.SubMenu();
            this.toolDropdownMenu.Visible = false;
            //User Data Collection
            this.toolDropdownUser.Visible = false;
            //Research And Development
            //RM Preparation
            this.toolPreparation.Visible = true;
            //Raw Materials Collection
            this.toolStripRawMaterials.Visible = false;
            //Inventory Viewing
            this.toolStripInventoryDry.Visible = true;
            //Store Collections
            this.toolStore.Visible = false;
            //Miscellaneouse Receipt
            this.toolStripMoveOrderSetup.Visible = false;
            this.toolStripDropDownButtonLabTest.Visible = true;
            this.timeSubMenuIn.Start();
            //Miscellaneouse Receipt Module Process
            this.toolStripDropDownMiscellaneousDryWh.Visible = true;

        }

        private void btnProductionPlanner_Click(object sender, EventArgs e)
        {

        }

        private void btnPreparationDepartment1_Click(object sender, EventArgs e)
        {
            frmDashBoardFormMenu addNew = new frmDashBoardFormMenu(this);
            addNew.ShowDialog();
     
        }

        private void btnResearchAndDevelopment1_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Form1());
            this.panelMenuSelection.Visible = true;
            this.SubMenu();
            this.toolImportDry.Visible = false;
            //User major Menu
            this.toolDropdownUser.Visible = false;
            this.toolDropdownMenu.Visible = false;
      
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductionPlanner1_Click(object sender, EventArgs e)
        {
            this.MainMajorData.Visible = false;
        }

        private void btnProductionPlanner1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void storesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmImportStore fm = new frmImportStore();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void storeAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmAreaManagement fm = new frmAreaManagement();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

      

        private void consolidatedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmImportConsolidatedOrder fm = new frmImportConsolidatedOrder();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void orderRESTAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmStoreOrderRestAPIcall fm = new frmStoreOrderRestAPIcall();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void pendingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmPendingOrder fm = new frmPendingOrder();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void warehouseCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmWarehouseCrewMgmt fm = new frmWarehouseCrewMgmt();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSetUp_Click(object sender, EventArgs e)
        {
            this.panelMenuSelection.Visible = true;

            this.toolStripRawMaterials.Visible = false;
            this.SubMenu();
            this.toolDropdownMenu.Visible = false;
            this.toolDropdownUser.Visible = false;
            //Research And Development
            toolPreparation.Visible = false;
            this.toolStripRawMaterials.Visible = true;
            this.toolImportDry.Visible = false;
            //Store Collection
            this.toolStore.Visible = true;
            //Miscellaneouse Receipt
            //this.toolStripMoveOrderSetup.Visible = true;
            this.toolStripInventoryDry.Visible = false;
            this.toolReceiving.Visible = false;
            this.toolStripDropDownButtonLabTest.Visible = false;
            this.timeSubMenuIn.Start();

            //RM RECEIPT PROCESS MODULE
            this.toolStripDropDownMiscellaneousDryWh.Visible = false;
        }

        private void toolStripStoreArea_Click(object sender, EventArgs e)
        {
            frmAreaManagement fm = new frmAreaManagement();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void storeRoute_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmStoreRoute fm = new frmStoreRoute();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStores_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmListofStore fm = new frmListofStore();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void dryWHInventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryWHInventory fm = new frmDryWHInventory();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);

        }

        private void lotManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmLotManagement fm = new frmLotManagement();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolDryForApproval_Click(object sender, EventArgs e)
        {
            //frmStoreOrderforApproval fm = new frmStoreOrderforApproval();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void forApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmStoreOrderforApproval fm = new frmStoreOrderforApproval();
                fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                AbrirFormEnPanel(fm);
          
       
        }

        private void averageOrderTrendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmAVGOrderTrendSetup fm = new frmAVGOrderTrendSetup();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void approvedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmNewStoreOrderApproved StoreApproved = new frmNewStoreOrderApproved();
           StoreApproved.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(StoreApproved);
        }

        private void orderCancelRemarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmStoreOrderActivationRemarks StoreOrderCancelled = new frmStoreOrderActivationRemarks();
            StoreOrderCancelled.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(StoreOrderCancelled);
        }

        private void allocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmAllocationModule AllocationModule = new frmAllocationModule();
            AllocationModule.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(AllocationModule);
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotificationsBell_Click(object sender, EventArgs e)
        {
            frmViewAllNotifications ViewNotification = new frmViewAllNotifications();
            ViewNotification.ShowDialog();
        }

        private void moveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmStoreOrderDispatching fm = new frmStoreOrderDispatching();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripMenuItemRMNearlyExpiryMgmt_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryWarehouseNearlyExpiryItems fm = new frmDryWarehouseNearlyExpiryItems();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void toolStripMenuItemLabTransaction_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmLabTestModule fm = new frmLabTestModule();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void allocationModule_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmAllocationModule AllocationModule = new frmAllocationModule();
            AllocationModule.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(AllocationModule);
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmRegion RegionForm = new frmRegion();
            RegionForm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(RegionForm);
        }

        private void syncConsolidatedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmSyncConsolidatedOrderSetUp SyncOrderForm = new frmSyncConsolidatedOrderSetUp();
            SyncOrderForm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(SyncOrderForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.showLabTestForReceiving();
            MessageBox.Show(this.Menu.TotalLabTestReceivingViewing);
        }

        private void tSReceipt_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryWarehouses Warehouses = new frmDryWarehouses();
            Warehouses.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Warehouses);
        }

        private void TsIssue_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmCustomers Customer = new frmCustomers();
            Customer.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Customer);
        }

        private void readyForSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.NormalSizeofSideBar();
            frmInternalForScheduling Scheduling = new frmInternalForScheduling();
            Scheduling.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Scheduling);
        }

        private void approvedScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmInternalApprovedOrder ApprovedScheduled = new frmInternalApprovedOrder();
            ApprovedScheduled.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(ApprovedScheduled);
        }

        private void preparationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmDryPreparationInternal InternalPreparation = new frmDryPreparationInternal();
            InternalPreparation.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(InternalPreparation);
        }

        private void mRSCancelRemarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmInternalOrderActivationRemarks InternalOrderCancelled = new frmInternalOrderActivationRemarks();
            InternalOrderCancelled.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(InternalOrderCancelled);
        }

        private void toolStripMenuReceipt_Click(object sender, EventArgs e)
        {
            // this.NormalSizeofSideBar();
            //frmDryMiscellanouseReceipt Receipt = new frmDryMiscellanouseReceipt();
            // Receipt.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            // AbrirFormEnPanel(Receipt);
            frmDryWhMiscellaneousReceipts FrmReceipt = new frmDryWhMiscellaneousReceipts();
            FrmReceipt.ShowDialog();

        }

        private void toolStripMenuIssue_Click(object sender, EventArgs e)
        {
            FrmDryWhMiscellaneouseIssue FrmIssue = new FrmDryWhMiscellaneouseIssue();
            FrmIssue.ShowDialog();
        }

        private void panelContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void preparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnMenu_Click(sender, e);

            frmDryPreparationStore Preparation = new frmDryPreparationStore();
            Preparation.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Preparation);
        }

   


      


    }
}
