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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmWarehouseCrewMgmt : MaterialForm
    {
        //Main Constructor Bugok

        myclasses xClass = new myclasses();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet = new DataSet();
        public frmWarehouseCrewMgmt()
        {
            InitializeComponent();
        }

        private void frmWarehouseCrewMgmt_Load(object sender, EventArgs e)
        {
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
                objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class


                this.displayUsers();
            }


        }
        private void hiDeDatagridColumn()
        {
            this.dgvUsers.Columns["password"].Visible = false;
            //this.dgvUsers.Columns["password"].Visible = false;
            //this.dgvUsers.Columns["user_section"].Visible = false;
            //this.dgvUsers.Columns["receiving_status"].Visible = false;
            //this.dgvUsers.Columns["user_rights_name"].Visible = false;
            //this.dgvUsers.Columns["department_name"].Visible = false;
            //this.dgvUsers.Columns["type_of_approver"].Visible = false;
            //this.dgvUsers.Columns["gender"].Visible = false;
            //this.dgvUsers.Columns["Unit"].Visible = false;
        }

        private void displayUsers()
        {

            xClass.fillDataGridView(dgvUsers, "userdrywarehouseminor", dSet);

            lbltotalrecords.Text = dgvUsers.RowCount.ToString();
        }
    }

}