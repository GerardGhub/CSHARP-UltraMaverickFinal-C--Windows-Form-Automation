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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreApprovedOrderUpdatePreparationDate : MaterialForm
    {
        frmNewStoreOrderApproved ths;
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        DataSet dset2 = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        string mode = "";

        public frmStoreApprovedOrderUpdatePreparationDate(frmNewStoreOrderApproved frm, string current_preparation_date, string category)
        {
            InitializeComponent();
            ths = frm;
            textBox2.TextChanged += new EventHandler(textBox1_TextChanged);
            this.Sp_PrepaDate_BindingSource = current_preparation_date;
            this.bunifuPrepaDate.Text = Sp_PrepaDate_BindingSource;
            this.Sp_Category = category;

        }

        public string Sp_PrepaDate_BindingSource { get; set; }
        public string Sp_Category { get; set; }

        private void frmStoreApprovedOrderUpdatePreparationDate_Load(object sender, EventArgs e)
        {
          
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.InitiliazeDatePickerMinDate();

       

            this.lblArrayPrepaDateStatus.Text = Sp_PrepaDate_BindingSource;
            this.Sp_Category = Sp_Category;

            //MessageBox.Show(this.Sp_Category);
            //return;

        }


            private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox2.Text = textBox2.Text;
        }

        private void frmStoreApprovedOrderUpdatePreparationDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.bunifuPrepaDate.Text == lblArrayPrepaDateStatus.Text)
            {

            }
            else
            {
                if (mode == "good")
                {
                    this.textBox2.Text = this.bunifuPrepaDate.Text;
                }

              
            }

        
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            this.TaggingConflictCategoryValidation();
       
        }



        private void bunifuPrepaDate_FormatChanged(object sender, EventArgs e)
        {
            this.lblArrayPrepaDateStatus.Text = "1";
        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            //this.TaggingConflictCategoryValidation();
        }


        private void TaggingConflictCategoryValidation()
        {
            //CheckIifAlreayHaveAnewRecord


            dset2.Clear();
            dset2 = objStorProc.sp_Store_Preparation_Logs(0,
           this.Sp_Category,
            this.bunifuPrepaDate.Text,
            "", "", "", "", "", "", 0,
              this.Sp_Category, "", "",
            "check_if_already_prepared_conflict_category_getcount_storeApproved");

            if (dset2.Tables[0].Rows.Count > 0)
            {
             

                //Update Status Already Repack
                dSet.Clear();
                dSet = objStorProc.sp_Store_Preparation_Logs(0,
               this.Sp_Category,
                this.bunifuPrepaDate.Text,
                "", "", "", "", "", "", 0,
                  this.Sp_Category, "", "",
                "check_if_already_prepared_conflict_category_storeApproved");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("good");
                    this.mode = "good";
                    if (MetroFramework.MetroMessageBox.Show(this, "Update the Preparation Date ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {



                    this.GlobalStatePopup.TripleTaggingCategoryInformation();
                    this.mode = "error";
            
                    //this.DoubleTaggingFound();

                }
            }
            else
            {
                this.mode = "good";
                if (MetroFramework.MetroMessageBox.Show(this, "Update the Preparation Date ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    this.Close();
                }
                else
                {
                    return;
                }
                //MessageBox.Show("Wala");
                //this.DoubleTaggingNotFound();
            }


        }


     
    }
}
