using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryRawMaterials : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

 
        int p_id = 0;
     
        DateTime dNow = DateTime.Now;
        //Boolean ready = false;


        DataSet dSet_temp = new DataSet();
        public frmDryRawMaterials()
        {
            InitializeComponent();
        }
        public string items_code { get; set; }
        public string items_description { get; set; }
        public string items_class { get; set; }
        public string majors_category { get; set; }
        public string subs_category { get; set; }
        public string primarys_unit { get; set; }
        public string conversions { get; set; }
        public string items_type { get; set; }
        public string is_active { get; set; }
        private void frmDryRawMaterials_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            lblUserID.Text = userinfo.user_id.ToString();
            showRawMaterialsInDryWH();
            LoadingrefresherOrb();
        }
        private void LoadingrefresherOrb()
        {

            if(textBox1.Text == "data Already Save!")
            {
         
            }
            else if(textBox1.Text == "Gerard Singian")
            {
                textBox1.Text = string.Empty;
                matBtnNew.Visible = true;
            }
            else
            {
         
                
            }


            if(lbltotalrecords.Text =="0")
            {

            }
            else
            {
                matBtnEdit.Visible = true;
            }
          
            
        }
        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {
             
                xClass.fillDataGridView(dgvRawMats, "Raw_Materials_Dry", dSet);
            
                lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            frmAddNewItemModal addNew = new frmAddNewItemModal(this, lblUserID.Text);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            frmDryRawMaterials_Load(sender, e);
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            matBtnEdit.Visible = false;
            matBtnNew.Visible = false;
            frmEditItemModal mywipwh = new frmEditItemModal(this, lblUserID.Text,items_code, 
                items_description,
                items_class,
                majors_category,
                subs_category,
                primarys_unit,
                conversions,
                items_type
                );
            mywipwh.ShowDialog();
        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvRawMats.Rows.Count > 0)
            {
                if (dgvRawMats.CurrentRow != null)
                {
                    if (dgvRawMats.CurrentRow.Cells["item_description"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvRawMats.CurrentRow.Cells["item_id"].Value);
                        items_code = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                        items_description = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        items_class = dgvRawMats.CurrentRow.Cells["item_class"].Value.ToString();
                        majors_category = dgvRawMats.CurrentRow.Cells["major_category"].Value.ToString();
                        subs_category = dgvRawMats.CurrentRow.Cells["sub_category"].Value.ToString();
                        primarys_unit = dgvRawMats.CurrentRow.Cells["primary_unit"].Value.ToString();
                        conversions = dgvRawMats.CurrentRow.Cells["conversion"].Value.ToString();
                        items_type = dgvRawMats.CurrentRow.Cells["item_type"].Value.ToString();
                    }
                }
            }
        }


    }
    }

