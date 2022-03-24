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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals
{
    public partial class AddNewConsolidatedOrderSync : MaterialForm
    {
        frmSyncConsolidatedOrder ths;
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public AddNewConsolidatedOrderSync(frmSyncConsolidatedOrder frm, string created_by, string area_name, string mode, int identitys)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            this.sp_route_name = area_name;
            this.modes = mode;
            this.sp_route_id = identitys;
        }
        public string created_by { get; set; }
        public string sp_route_name { get; set; }
        public string modes { get; set; }
        public int sp_route_id { get; set; }

        private void AddNewConsolidatedOrderSync_Load(object sender, EventArgs e)
        {
            this.InitilizeTimeAsync();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.CallingMainFormWindowBinder();
        }

        private void CallingMainFormWindowBinder()
        {
            this.modes = modes;


            if (modes == "add")
            {
                this.Text = "Add New Consolidated Order Sync";
                this.matbtnSave.Text = "ADD";
                this.created_by = created_by;
                this.bunifuTimeFrom.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Consolidated Order Sync";
                this.matbtnSave.Text = "UPDATE";
                this.created_by = created_by;

                this.bunifuTimeFrom.Text = sp_route_name;
            }
            this.bunifuTimeFrom.Focus();

        }

        private void InitilizeTimeAsync()
        {
            this.bunifuTimeFrom.Format = DateTimePickerFormat.Time;
            this.bunifuTimeFromTo.Format = DateTimePickerFormat.Time;
            this.bunifuTimeFromTo.Text = "11:59:00 pm";
        }

        private void AddNewConsolidatedOrderSync_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void matbtnSave_Click(object sender, EventArgs e)
        {
            if (this.bunifuTimeFrom.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.bunifuTimeFrom.Focus();
                return;
            }

            if (this.bunifuTimeFromTo.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.bunifuTimeFromTo.Focus();
                return;
            }


            dSet.Clear();
            dSet = objStorProc.sp_TblStoreOrderManageSyncing(0, this.bunifuTimeFrom.Text,
                this.bunifuTimeFromTo.Text, this.created_by,"","", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();
                this.bunifuTimeFrom.Text = String.Empty;


                this.bunifuTimeFrom.Focus();
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
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = objStorProc.sp_TblStoreOrderManageSyncing(0,
                         this.bunifuTimeFrom.Text.Trim(),
                        this.bunifuTimeFromTo.Text.Trim(),                    
                        this.created_by,
                        "",
                        "",
                        "",
                        "add");
                    this.textBox1.Text = "data Already Save!";
                    this.GlobalStatePopup.CommittedSuccessFully();
                    this.textBox1.Text = String.Empty;
                    this.AddNewConsolidatedOrderSync_Load(new object(), new System.EventArgs());
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


                dSet.Clear();
                dSet = objStorProc.sp_TblStoreOrderManageSyncing(sp_route_id,
                this.bunifuTimeFrom.Text.Trim(),
                this.bunifuTimeFromTo.Text.Trim(),
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
    }
}
