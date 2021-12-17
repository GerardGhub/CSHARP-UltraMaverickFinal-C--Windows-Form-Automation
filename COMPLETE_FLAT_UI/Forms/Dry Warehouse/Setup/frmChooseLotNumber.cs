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
    public partial class frmChooseLotNumber : MaterialForm
    {
        frmDryReceivingModule ths;
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

  
        DateTime dNow = DateTime.Now;


        string mode = "";   
        DataSet dSet_temp = new DataSet();
        public frmChooseLotNumber(frmDryReceivingModule frm, string major_category)
        {
            InitializeComponent();
            ths = frm;
            //textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.sp_major_category = major_category;
        }

        public string sp_major_category { get; set; }
        public string sp_lot_number { get; set; }
        public string sp_lot_description { get; set; }
        private void frmChooseLotNumber_Load(object sender, EventArgs e)
        {
            this.WindowsLoadingBinder();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        }

        private void WindowsLoadingBinder()
        {
            this.mode = "false";
            this.mattxtCategory.Text = sp_major_category;
        }

        private void mattxtCategory_TextChanged(object sender, EventArgs e)
        {
       
        this.doSearchInTextBoxCmb();
                

            
        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("lot_management_major");

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




                        dv.RowFilter = "category = '" + mattxtCategory.Text + "' and lot_number like '%" + mattxtLotnumber.Text + "%'  ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvLotData.DataSource = dv;
                    lbltotalrecords.Text = dgvLotData.RowCount.ToString();
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
            this.dgvLotData.Columns["category"].Visible = false;
            this.dgvLotData.Columns["added_by"].Visible = false;
            this.dgvLotData.Columns["date_added"].Visible = false;

            this.dgvLotData.Columns[1].Width = 128;

        }

        private void mattxtLotnumber_TextChanged(object sender, EventArgs e)
        {
            this.doSearchInTextBoxCmb();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ths.textBox1.Text = textBox1.Text;
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
                    if (dgvLotData.CurrentRow.Cells["lot_number"].Value != null)
                    {
                  
                        sp_lot_number = dgvLotData.CurrentRow.Cells["lot_number"].Value.ToString();
                        sp_lot_description = dgvLotData.CurrentRow.Cells["description"].Value.ToString();


                        //Binding Data
                        ths.mattxtlotno.Text = sp_lot_number;
                        ths.mattxtLotDescription.Text = sp_lot_description;
                    }
                }
            }
        }

        private void frmChooseLotNumber_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmChooseLotNumber_FormClosed(object sender, FormClosedEventArgs e)
        {
         
            if (mode == "false")
            {
                ths.mattxtlotno.Text = String.Empty;
                ths.mattxtLotDescription.Text = String.Empty;
            }
        }

        private void matbtnSelect_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to select the lot area?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mode = "true";
                this.Close();
            }
            else
            {
                return;
            }

            }

        private void mattxtLotnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
