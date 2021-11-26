using COMPLETE_FLAT_UI.Models;
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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAddNewPartialRejectReceiving : MaterialForm
    {
        frmDryReceivingModule ths;
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();





     
        DataSet dSet_temp = new DataSet();
        public frmAddNewPartialRejectReceiving(frmDryReceivingModule frm, string item_description, string quantity,
            int primary_key, int po_number)
        {
            InitializeComponent();
            ths = frm;
            //textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.sp_item_description = item_description;
            this.sp_quantity = quantity;
            this.sp_index_id = primary_key;
            this.sp_po_number = po_number;
        }


        public string sp_item_description { get; set; }
        public string sp_quantity { get; set; }

        public int sp_index_id { get; set; }
        public int sp_po_number { get; set; }
  
        public string sp_added_by { get; set; }
  
        public string sp_primary_key{get; set;}

        public string sp_ActualQty { get; set; }
        private void frmAddNewPartialRejectReceiving_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.sp_added_by = userinfo.user_id.ToString();
            this.WindowsLoadingBinder();
            this.loadItemClassDropdown();
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("tblDryPartialReceivingRejection_major");

        }

        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "index_id = '" + sp_index_id + "' ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.dgvLotData.DataSource = dv;
                    //lbltotalrecords.Text = dgvLotData.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            this.dgvLotData.Columns["id"].Visible = false;
            this.dgvLotData.Columns["index_id"].Visible = false;
            this.dgvLotData.Columns["po_number"].Visible = false;
            //this.dgvLotData.Columns["date_added"].Visible = false;

            //this.dgvLotData.Columns[1].Width = 128;
            this.SumofTotalReject();
        }


        private void SumofTotalReject()
        {
            decimal Total = 0;

            for (int i = 0; i < dgvLotData.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvLotData.Rows[i].Cells["qty_reject"].Value);
            }

          lbltotalReject.Text = Total.ToString();
            //Bind External Label
            ths.mattxtqtyreject.Text = Total.ToString();
        }
        public void loadItemClassDropdown()
        {

            myClass.fillComboBoxDepartment(metroCmbRejectRemarks, "tblRejectedStatus_dropdown", dSet);


           //sp_reject_remarks = metroCmbRejectRemarks.SelectedValue.ToString();
        }
        private void WindowsLoadingBinder()
        {

            this.mattxtItemDesc.Text = sp_item_description;
            this.mattxtQtyReceived.Text = sp_quantity;
            this.sp_index_id = sp_index_id;
        }

        public void LessThanQtyReceived()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Less Than Qty Received";
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
        public void AlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Remarks Already Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        private void doSearchInTextBoxCmbDoubleEntry()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "index_id = '" + sp_index_id + "' and reject_remarks = '"+ metroCmbRejectRemarks.Text + "' ";

                    }
             
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvLotData.DataSource = dv;
                    //lbltotalrecords.Text = dgvLotData.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            this.dgvLotData.Columns["id"].Visible = false;
            this.dgvLotData.Columns["index_id"].Visible = false;
            this.dgvLotData.Columns["po_number"].Visible = false;
            //this.dgvLotData.Columns["date_added"].Visible = false;

            //this.dgvLotData.Columns[1].Width = 128;
            //this.SumofTotalReject();
        }

        private void matBtnAdd_Click(object sender, EventArgs e)
        {

            this.dSet.Clear();
            this.dSet = objStorProc.sp_tblDryPartialReceivingRejection(0,
              sp_index_id, 0, 0, metroCmbRejectRemarks.Text, sp_added_by, "", sp_added_by, "", "getbyname");
            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.AlreadyExist();

                //this.metroCmbRejectRemarks.Text = String.Empty;
                //this.metroCmbRejectRemarks.Focus();
                double orderScope1;
                double currentrejectScope1;
                double qtyRejectScope1;
                double AllowancesScope1;

                orderScope1 = double.Parse(mattxtQtyReceived.Text);
                currentrejectScope1 = double.Parse(lbltotalReject.Text);
                qtyRejectScope1 = double.Parse(mattxtqtyreject.Text);

                AllowancesScope1 = currentrejectScope1 + qtyRejectScope1;

                if (orderScope1 < AllowancesScope1)
                {
                    // code
                    this.mattxtqtyreject.Text = String.Empty;
                    this.mattxtqtyreject.Focus();
                    this.LessThanQtyReceived();

                    return;
                }
                //Initialize();
                this.doSearchInTextBoxCmbDoubleEntry();
                double totalExistingReject;
                double QtyRejectCommits;
                double totalSummaryofReject;

                totalExistingReject = double.Parse(sp_ActualQty);
                QtyRejectCommits = double.Parse(mattxtqtyreject.Text);


                totalSummaryofReject = totalExistingReject + QtyRejectCommits;
                if (MetroFramework.MetroMessageBox.Show(this, "You already have same reject/remark, Are you sure you want to update an existing reject '"+totalSummaryofReject+"'?  ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                 
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_tblDryPartialReceivingRejection(Convert.ToInt32(sp_primary_key),
                        sp_index_id, sp_po_number, Convert.ToInt32(totalSummaryofReject), metroCmbRejectRemarks.Text, sp_added_by, "", sp_added_by, "", "edit");
                    this.AddedSuccessfully();
                    this.SearchMethodJarVarCallingSP();
                    this.doSearchInTextBoxCmb();
                    frmAddNewPartialRejectReceiving_Load(sender, e);
                    this.Close();
                }
                else
                {
                    return;
                }
                    return;
            }

            double order;
            double currentreject;
            double qtyReject;
            double Allowances;

            order = double.Parse(mattxtQtyReceived.Text);
            currentreject = double.Parse(lbltotalReject.Text);
            qtyReject = double.Parse(mattxtqtyreject.Text);

            Allowances = currentreject + qtyReject;

            if (order < Allowances)
            {
                // code
                this.mattxtqtyreject.Text = String.Empty;
                this.mattxtqtyreject.Focus();
                this.LessThanQtyReceived();
            
                return;
            }
            else
            {
                //MessageBox.Show("Bebes");
                //return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add a reject?  ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                this.dSet.Clear();
                this.dSet = objStorProc.sp_tblDryPartialReceivingRejection(0,
                    sp_index_id, sp_po_number, Convert.ToInt32(mattxtqtyreject.Text), metroCmbRejectRemarks.Text, sp_added_by, "", sp_added_by, "", "add");
                this.AddedSuccessfully();
                frmAddNewPartialRejectReceiving_Load(sender, e);
                this.Close();
            }
            else
            {
                return;
            }

            }


        public void AddedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Added Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        private void dgvLotData_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }


        private void showValueCell()
        {
            if (dgvLotData.Rows.Count > 0)
            {
                if (dgvLotData.CurrentRow != null)
                {
                    if (dgvLotData.CurrentRow.Cells["index_id"].Value != null)
                    {

                        sp_primary_key= dgvLotData.CurrentRow.Cells["id"].Value.ToString();
                      sp_ActualQty = dgvLotData.CurrentRow.Cells["qty_reject"].Value.ToString();



                    }
                }
            }
        }

        public void DeletedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Deleted Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void dgvLotData_DoubleClick(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you remove the reject?  ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.dSet.Clear();
                //MessageBox.Show(sp_primary_key.ToString());
                this.dSet = objStorProc.sp_tblDryPartialReceivingRejection(Convert.ToInt32(sp_primary_key),
                    0, 0, 0, "", sp_added_by, "", sp_added_by, "", "delete");
                this.DeletedSuccessfully();
                frmAddNewPartialRejectReceiving_Load(sender, e);

            }
            else
            {
                return;
            }

            }

        private void frmAddNewPartialRejectReceiving_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SumofTotalReject();
        }

        private void mattxtqtyreject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dgvLotData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
