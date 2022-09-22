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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals
{
    public partial class AddNewConsolidatedOrderSync : MaterialForm
    {
        frmSyncConsolidatedOrderSetUp ths;

        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        TblStoreOrderManageSyncing TblStoreOrderManageSyncingEntity = new TblStoreOrderManageSyncing();
        public AddNewConsolidatedOrderSync(
            frmSyncConsolidatedOrderSetUp frm,
            string created_by, 
            string time_from_desc, 
            string mode, 
            int identitys)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.TblStoreOrderManageSyncingEntity.Added_By = created_by;
            this.TblStoreOrderManageSyncingEntity.Time_From_Desc = time_from_desc;
            this.TblStoreOrderManageSyncingEntity.Mode = mode;
            this.TblStoreOrderManageSyncingEntity.Id = identitys;
        }


        private void AddNewConsolidatedOrderSync_Load(object sender, EventArgs e)
        {
            this.InitilizeTimeAsync();

            this.ConnectionInit();
            this.CallingMainFormWindowBinder();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void CallingMainFormWindowBinder()
        {
            this.TblStoreOrderManageSyncingEntity.Mode = TblStoreOrderManageSyncingEntity.Mode;


            if (TblStoreOrderManageSyncingEntity.Mode == "add")
            {
                this.Text = "Add New Consolidated Order Sync";
                this.matbtnSave.Text = "ADD";
                this.TblStoreOrderManageSyncingEntity.Added_By = TblStoreOrderManageSyncingEntity.Added_By;
                this.bunifuTimeFrom.Text = String.Empty;
            }
            else
            {
                this.Text = "Update Consolidated Order Sync";
                this.matbtnSave.Text = "UPDATE";
                this.TblStoreOrderManageSyncingEntity.Added_By = this.TblStoreOrderManageSyncingEntity.Added_By;

                this.bunifuTimeFrom.Text = this.TblStoreOrderManageSyncingEntity.Time_From_Desc;
            }
            this.bunifuTimeFrom.Focus();

        }

        private void InitilizeTimeAsync()
        {
            this.bunifuTimeFrom.Format = DateTimePickerFormat.Time;
            this.bunifuTimeFromTo.Format = DateTimePickerFormat.Time;
            this.bunifuTimeFromTo.Text = "03:00:00 PM";
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

            if (Convert.ToDateTime(this.bunifuTimeFrom.Value) >= Convert.ToDateTime(this.bunifuTimeFromTo.Value))
            {
                this.GlobalStatePopup.NoDataFound();
                return;
            }
        


            this.dSet.Clear();
            this.dSet = this.g_objStoredProcCollection
                .sp_TblStoreOrderManageSyncing(0, 
                this.bunifuTimeFrom.Text,
                this.bunifuTimeFromTo.Text, 
                this.TblStoreOrderManageSyncingEntity.Added_By,
                "",
                "",
                "",
                "getbyname");

            if (this.dSet.Tables[0].Rows.Count > 0)
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
            if (TblStoreOrderManageSyncingEntity.Added_By == "add")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_TblStoreOrderManageSyncing(0,
                         this.bunifuTimeFrom.Text.Trim(),
                        this.bunifuTimeFromTo.Text.Trim(),                    
                        this.TblStoreOrderManageSyncingEntity.Added_By,
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


                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_TblStoreOrderManageSyncing(this.TblStoreOrderManageSyncingEntity.Id,
                this.bunifuTimeFrom.Text.Trim(),
                this.bunifuTimeFromTo.Text.Trim(),
                this.TblStoreOrderManageSyncingEntity.Added_By,
                "",
                this.TblStoreOrderManageSyncingEntity.Added_By,
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.TextBox1.Text = textBox1.Text;
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
