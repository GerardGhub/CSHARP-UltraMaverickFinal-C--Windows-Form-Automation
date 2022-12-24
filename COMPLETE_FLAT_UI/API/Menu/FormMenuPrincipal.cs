using COMPLETE_FLAT_UI.Models;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ULTRAMAVERICK.Forms.Users;
using ULTRAMAVERICK.Models;
//using MaterialSkin;
//using MaterialSkin.Controls;
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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order;
using ULTRAMAVERICK.Menu.View_Models;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation;
using ULTRAMAVERICK.API.Extensions;
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.Application.Report;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMenuPrincipal : Form
    {
        readonly ReportDocument rpt = new ReportDocument();
        ParentFormsRepository parentFormsRepository = new ParentFormsRepository();
        readonly Modules Module = new Modules();
        //Constructor
        public Byte[] imageByte = null;
        readonly myglobal GlobalVariable = new myglobal();
        DataSet dset_rights = new DataSet();
        DataSet dSet = new DataSet();
        int rights_id = 0;
        readonly myclasses myClass = new myclasses();
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

        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, this.Menu.sizeGripRectangle);

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, this.Menu.sizeGripRectangle);
        }
       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


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



        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (this.panelMenu.Width == 185)
            {
                this.tmContraerMenu.Start();
                this.lblFirstName.Visible = false;
               
                this.lblPosition.Visible = false;
                this.pbImage.Visible = false;
                this.ClearDashboardtext();


            }
            else if (this.panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
                this.lblFirstName.Visible = true;
            
                this.lblPosition.Visible = true;
                this.pbImage.Visible = true;
                this.DashboardEpicComebackofText();
            }


         
        }

    private void DashboardEpicComebackofText()
        {
            btnDashBoard1.Text = "Dashboard";
            btnUsers1.Text = "Users";
            btnPreparationDepartment1.Text = "Preparation Dept";
            btnDryWarehouse1.Text = "Dry Warehouse";
            btnResearchAndDevelopment1.Text = "Research & Dev";
            btnProductionPlanner1.Text = "Planner";
            BtnSetUp.Text = "Set-Up";
        }

        private void ClearDashboardtext()
        {
            btnDashBoard1.Text = String.Empty;
            btnUsers1.Text = String.Empty;
            btnPreparationDepartment1.Text = String.Empty;
            btnDryWarehouse1.Text = String.Empty;
            btnResearchAndDevelopment1.Text = String.Empty;
            btnProductionPlanner1.Text = String.Empty;
            BtnSetUp.Text = String.Empty;
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

        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormLogo());
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
            gp.AddEllipse(0, 0, pbImage.Width - 10, pbImage.Height - 3);
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
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }


        public void ToolStripBadges()
        {
            this.ConnectionInit();
            //Store Preparation
            this.parentFormsRepository.GetStorePreparations(this.dataGridView1);
            this.preparationToolStripMenuItem.Text = "Preparation (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.preparationToolStripMenuItem.Text = "Preparation";
            }
 
            //Store Approval
            this.parentFormsRepository.GetStoreOrderForApproval(this.dataGridView1);
            this.forApprovalToolStripMenuItem.Text = "Ready For Scheduling (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.forApprovalToolStripMenuItem.Text = "Ready For Scheduling";
            }
 
            //Store Approved
            this.parentFormsRepository.GetStoreOrderApproved(this.dataGridView1);
            this.approvedOrderToolStripMenuItem.Text = "Approved Schedule (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.approvedOrderToolStripMenuItem.Text = "Approved Schedule";
            }

            //Internal Order For Scheduling
            this.parentFormsRepository.GetInternalOrderForScheduling(this.dataGridView1);
            this.readyForSchedulingToolStripMenuItem.Text = "Ready For Scheduling (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.readyForSchedulingToolStripMenuItem.Text = "Ready For Scheduling";
            }




            //Internal Order Preparation

            this.parentFormsRepository.GetInternalPreparation(this.dataGridView1);
            this.preparationToolStripMenuItem1.Text = "Preparation (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.preparationToolStripMenuItem1.Text = "Preparation";
            }



            //Internal Order Approved
            this.parentFormsRepository.GetInternalOrderApproved(this.dataGridView1);
            this.approvedScheduleToolStripMenuItem.Text = "Approved Schedule (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.approvedScheduleToolStripMenuItem.Text = "Approved Schedule";
            }
   
     

            //Dispatching Order
            this.parentFormsRepository.GetDispatchingData(this.dataGridView1);
            this.moveOrderToolStripMenuItem2.Text = "Move Order (" + this.parentFormsRepository.TotalRecords + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.moveOrderToolStripMenuItem2.Text = "Move Order";
            }

            //Recieving Dry
            int totalReceiving = 0;
            int totalNearlyExipiry = 0;
            int totalSummary = 0;
            this.parentFormsRepository.GetReceivingDataDry(this.dataGridView1);
   
            totalReceiving = this.parentFormsRepository.TotalRecords;
            this.parentFormsRepository.GetReceivingDataDryReject(this.dataGridView1);
            totalNearlyExipiry = this.parentFormsRepository.TotalRecords;
            totalSummary = totalReceiving + totalNearlyExipiry;

            this.listOfReceivingToolStripMenuItem.Text = "List of Receiving (" + totalSummary + ") ";
            if (this.parentFormsRepository.TotalRecords == 0)
            {
                this.listOfReceivingToolStripMenuItem.Text = "List of Receiving";
            }
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ToolStripBadges();
            this.RoundPictureAss();
            this.ShowReceivingData();
            this.lblFirstName.Text = userinfo.emp_name.ToString().ToUpper() + new string(' ', 1) + userinfo.emp_lastname.ToString().ToUpper();// First Name Session

            this.lblPosition.Text = userinfo.position.ToUpperInvariant(); // Position of User
            MostrarFormLogo();
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

            //if (user_section_controlBox == "Office")
            //{
            //    this.ControlBox = true;
            //}
            //else
            //{
            //    this.ControlBox = false;
            //}

            //get_accessible_menu

            //Start of Major Menu
            this.MajorMenuLoop();

            //Start of Sub Menu
            SubMenu();

            //END
            //MODULES
            this.ModulesLoop();
      
            btnMaximizedFinal_Click(sender, e);

            this.CancelledforStorePreparationatLogisticChecker();

            this.DispatchingforStorePreparationatLogisticChecker();
   
            this.showLabTestForReceiving();
            this.BadgeNotification();
        }

        private void ToolStripDropDownMajorMenu(Boolean val)
        { 
            if (val == false)
            {
                this.btnUsers1.Visible = false;
                this.BtnSetUp.Visible = false;
                this.btnDashBoard1.Visible = false;
                this.btnDryWarehouse1.Visible = false;
            }

        }

        private void MajorMenuLoop()
        {
            this.ToolStripDropDownMajorMenu(false);

            dset_rights.Clear();
            dset_rights = g_objStoredProcCollection.sp_getFilterTables("get_accessible_menu_parents", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
                {
                    string parent_form_name = dset_rights.Tables[0].Rows[x][1].ToString();




                    if (parent_form_name == "USERS")
                    {
                        btnUsers1.Visible = true;
                    }


                    else if (parent_form_name == "SETUP")
                    {
                        this.BtnSetUp.Visible = true;
                    }
                    else if (parent_form_name == "DASHBOARD")
                    {
                        btnDashBoard1.Visible = true;

                    }

                    else if (parent_form_name == "DRY WAREHOUSE")
                    {
                        this.btnDryWarehouse1.Visible = true;
                    }



                }
            }
        }

        private void ModulesLoop()
        {
            dset_rights.Clear();
            dset_rights = g_objStoredProcCollection.sp_getFilterTables("get_accessible_menu_grandChild", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                this.Module.SubMenu(

                    this.dset_rights,
                    this.toolUserManagement,
                    this.toolUserRights,
                    this.toolDepartment,
                    this.toolDepartmentUnit,
                    this.toolPosition,
                    this.toolStripMenuReceipt,
                    this.toolStripMenuIssue,
                    this.toolDryStorePreparation,
                    this.toolDryInternalPreparation,
                    this.allocationModule,
                    this.forApprovalToolStripMenuItem,
                    this.approvedOrderToolStripMenuItem,
                    this.preparationToolStripMenuItem,
                    this.moveOrderToolStripMenuItem2,
                    this.readyForSchedulingToolStripMenuItem,
                    this.approvedScheduleToolStripMenuItem,
                    this.preparationToolStripMenuItem1,
                    this.toolStripMenuDryLabTest,
                    this.toolStripMenuItemLabTransaction,
                    this.toolStripMenuItemRMNearlyExpiryMgmt,
                    this.dryRawMaterialsToolStripMenuItem,
                    this.poSummaryToolStripMenuItem,
                    this.ImportStoreDry,
                    this.consolidatedOrderToolStripMenuItem,
                    this.orderRESTAPIToolStripMenuItem,
                    this.pendingOrderToolStripMenuItem,
                    this.toolParentMenu,
                    this.toolChildMenu,
                    this.toolGrandChildMenu,
                    this.listOfReceivingToolStripMenuItem,
                    this.rMReceivingToolStripMenuItem,
                    this.rMBarcodeModuleToolStripMenuItem,
                    this.rMBarcodeReprintingToolStripMenuItem,
                    this.dryWHInventorySubMenu,
                    this.toolStripStoreArea,
                    this.storeRoute,
                    this.toolStores,
                    this.regionToolStripMenuItem,
                    this.syncConsolidatedOrderToolStripMenuItem,
                    this.TsCustomer,
                    this.toolStripModuleItemClass,
                    this.toolStripModuleMajorCategory,
                    this.toolStripModuleSubCategory,
                    this.toolStripModulePrimaryUnit,
                    this.toolStripModuleItemType,
                    this.toolModuleRawMaterialsDry,
                    this.toolModuleConversionMgmt,
                    this.lotManagementToolStripMenuItem,
                    this.averageOrderTrendToolStripMenuItem,
                    this.orderCancelRemarksToolStripMenuItem,
                    this.mRSCancelRemarksToolStripMenuItem,
                    this.mrsOrderImportToolStripMenuItem
                    );


            }
            //End
        }
        private void showLabTestForReceiving()    //method for loading available_menus
        {
            // Try this Fuck!!
            dSet.Clear();
            try
            {

                myClass.fillDataGridView(this.dgvParseData, "DryWarehouseLabTestReceivingViewing", this.dSet);

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
                
                myClass.fillDataGridView(this.dgvParseData, "Store_Order_Cancelled_by_WH_Checker", dSet);

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

                myClass.fillDataGridView(this.dgvParseData, "Store_Order_Dispatched_by_Logistic_Checker", this.dSet);

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
            dset_rights = g_objStoredProcCollection.sp_getFilterTables("get_accessible_menu", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
                {
                    string form_name = dset_rights.Tables[0].Rows[x][1].ToString();

                    if (form_name == "toolDropdownMenu")
                    {
                        this.toolDropdownMenu.Visible = true;
                    }
                    else if (form_name == "toolDropdownUserManager")
                    {
                        this.toolDropdownUserManager.Visible = true;

                    }

                    else if (form_name == "toolStripInventoryDry")
                    {
                        this.toolStripInventoryDry.Visible = true;

                    }
                    else if (form_name == "toolPreparation")
                    {
                        this.toolPreparation.Visible = true;

                    }

                    else if (form_name == "toolStripDropDownButtonLabTest")
                    {
                        this.toolStripDropDownButtonLabTest.Visible = true;

                    }
                    
               
                    //Raw Mats //Dry
                    else if (form_name == "toolStripRawMaterials")
                    {
                        this.toolStripRawMaterials.Visible = true;
                    }
                    //Import Dry
                    else if (form_name == "toolImportDry")
                    {
                        this.toolImportDry.Visible = true;
                    }
                    else if(form_name == "toolReceiving")
                    {
                        this.toolReceiving.Visible = true;
                    }
                    else if (form_name == "toolStripMoveOrderSetup")
                    {
                        this.toolStripMoveOrderSetup.Visible = true;
                    }
                    else if (form_name == "toolStoreSetup")
                    {
                        this.toolStoreSetup.Visible = true;
                    }




                }
            }
        }

        private void ShowReceivingData()      //method for loading available_menus
        {
            try
            {

               this.myClass.fillDataGridView(dgvParseData, "Po_Receiving_Warehouse", this.dSet);       
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
            this.panelMenuSelection.Visible = true;

            this.SubMenu();

            //Research And Development
            this.toolStripRawMaterials.Visible = false;
            this.toolImportDry.Visible = false;
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


            //this.ShowInTaskbar = false;

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
          
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Logout " + lblFirstName.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
   
                this.Hide();
                frmLoginForm sistema = new frmLoginForm();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {

                return;
            }
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

            this.ConnectionInit();
            this.MajorMenuLoop();
            this.SubMenu();
            this.ModulesLoop();

            this.panelMenuSelection.Visible = false;
            this. MainMajorData.Visible = true;
            MessageBox.Show("back");
            preparationToolStripMenuItem.Text = "pwetan";
            this.ToolStripBadges();

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
            frmMajorMenuAvailableForms fm = new frmMajorMenuAvailableForms();
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
            FrmItemClass fm = new FrmItemClass();
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
            frmCategory fm = new frmCategory();
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

  

        private void btnDashBoard1_Click_1(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            this.panelMenuSelection.Visible = false;
            FormLogo fm = new FormLogo();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
            this.FormMenuPrincipal_Load(sender, e);
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
            this.toolStoreSetup.Visible = false;
            //Raw Materials Per Items
            toolStripRawMaterials.Visible = false;
            //Import Collection
            toolImportDry.Visible = false;
            //Miscellaneouse Receipt
   
            this.toolStripDropDownButtonLabTest.Visible = false;

            //Inventory 
            this.toolStripInventoryDry.Visible = false;
            //Miscellaneous Process
            this.toolStripMoveOrderSetup.Visible = false;
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
            this.toolDropdownUserManager.Visible = false;
            //Research And Development
  
            //Raw Materials Collection
            this.toolStripRawMaterials.Visible = false;
      

            //Store Collections
            this.toolStoreSetup.Visible = false;
            //Miscellaneouse Receipt


            this.timeSubMenuIn.Start();
        }

    
        private void btnPreparationDepartment1_Click(object sender, EventArgs e)
        {
            frmDashBoardFormMenu addNew = new frmDashBoardFormMenu(this);
            addNew.ShowDialog();
        }

        private void btnResearchAndDevelopment1_Click(object sender, EventArgs e)
        {
            this.panelMenuSelection.Visible = true;
            this.SubMenu();
            this.toolImportDry.Visible = false;
            //User major Menu
            this.toolDropdownUserManager.Visible = false;
            this.toolDropdownMenu.Visible = false;
      
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
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
            frmPendingStoreOrder fm = new frmPendingStoreOrder();
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
            this.toolDropdownUserManager.Visible = false;
            this.toolPreparation.Visible = false;
            this.toolImportDry.Visible = false;
            this.toolStripInventoryDry.Visible = false;
            this.toolReceiving.Visible = false;
            this.toolStripDropDownButtonLabTest.Visible = false;
            this.timeSubMenuIn.Start();
            this.toolStripMoveOrderSetup.Visible = false;
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
            FrmStoreRoute fm = new FrmStoreRoute();
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



        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotificationsBell_Click(object sender, EventArgs e)
        {
            frmViewAllNotifications ViewNotification = new frmViewAllNotifications();
            ViewNotification.ShowDialog();
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
            btnMenu_Click(sender, e);
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
            this.NormalSizeofSideBar();
            frmDryWhMiscellaneousReceipts Receipt = new frmDryWhMiscellaneousReceipts();
            Receipt.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Receipt);
        }

        private void toolStripMenuIssue_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            FrmDryWhMiscellaneouseIssue Issue = new FrmDryWhMiscellaneouseIssue();
            Issue.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Issue);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            FrmCustomers Customer = new FrmCustomers();
            Customer.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(Customer);
        }

        private void moveOrderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            frmStoreOrderDispatching fm = new frmStoreOrderDispatching();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void mrsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NormalSizeofSideBar();
            FrmImportMrsOrders fm = new FrmImportMrsOrders();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void rMMiscellaneousTransactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemReceivingRpt_Click(object sender, EventArgs e)
        {
            frmRMReceivingReportDryWarehouse frmrpt = new frmRMReceivingReportDryWarehouse();
            frmrpt.ShowDialog();
        }

        private void moveOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoveOrderReports frmMovereport = new frmMoveOrderReports();
            frmMovereport.ShowDialog();
        }

        private void rMNearlyExpiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myglobal.REPORT_NAME = "PrintNearlyExpired";
            frmReport fr = new frmReport();
            fr.WindowState = FormWindowState.Maximized;
            fr.Show();
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
