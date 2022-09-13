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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Setup.Modal
{
    public partial class FrmAddNewOrderTrend : MaterialForm
    {

        readonly frmAVGOrderTrendSetup ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly Avg_Order_Trend AvgOrderTrendEntity = new Avg_Order_Trend();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public FrmAddNewOrderTrend(
           frmAVGOrderTrendSetup frm,
            int Created_by,
            string AverageDesc,
            int AverageDays,
            string Mode,
            int AverageIdentity
            )
        {
            InitializeComponent();
            ths = frm;
            TextBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            this.AvgOrderTrendEntity.Added_By = Created_by.ToString();
            this.AvgOrderTrendEntity.Avg_Desc = AverageDesc;
            this.AvgOrderTrendEntity.Avg_Days = AverageDays;
            this.AvgOrderTrendEntity.Mode = Mode;
            this.AvgOrderTrendEntity.Avg_Id = AverageIdentity;
            this.AvgOrderTrendEntity.Updated_By = Created_by.ToString();
        }

        private void FrmAddNewOrderTrend_Load(object sender, EventArgs e)
        {
            
                this.ConnectionInit();
                this.LoadTaskMode();
            
        }


        private void LoadTaskMode()
        {
            this.AvgOrderTrendEntity.Mode = AvgOrderTrendEntity.Mode;


            if (AvgOrderTrendEntity.Mode == "ADD")
            {
                this.Text = "Add New Avg Trend";
                this.MatBtnSave.Text = "ADD";
                this.AvgOrderTrendEntity.Added_By = this.AvgOrderTrendEntity.Added_By;
     
            }
            else
            {
                this.Text = "Update Avg Trend";
                this.MatBtnSave.Text = "UPDATE";
                this.AvgOrderTrendEntity.Updated_By = this.AvgOrderTrendEntity.Updated_By;
                this.AvgOrderTrendEntity.Avg_Id = this.AvgOrderTrendEntity.Avg_Id;
                this.Txtmatavgdescription.Text = AvgOrderTrendEntity.Avg_Desc;
                this.TxtmatAverageqty.Text = this.AvgOrderTrendEntity.Avg_Days.ToString();
            }
            this.Txtmatavgdescription.Focus();
        }




        private void ConnectionInit()
        {
            this.g_objStoredProcCollection =
            this.myClass.g_objStoredProc.GetCollections();
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = TextBox1.Text;
        }

        private void FrmAddNewOrderTrend_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.TextBox1.Text = "Gerard Singian";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (this.Txtmatavgdescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.Txtmatavgdescription.Focus();
                return;
            }
            else if (this.TxtmatAverageqty.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtmatAverageqty.Focus();
                return;
            }

            if (this.AvgOrderTrendEntity.Avg_Desc == this.Txtmatavgdescription.Text
                && this.AvgOrderTrendEntity.Avg_Days == Convert.ToInt32(this.TxtmatAverageqty.Text))
            {
                this.SaveProcessClicker();
            }
            else
            {

                dSet.Clear();
                dSet = g_objStoredProcCollection
                    .sp_avg_order_trend(0,
                    this.Txtmatavgdescription.Text.Trim(),
                    Convert.ToInt32(this.TxtmatAverageqty.Text.Trim()),
                    "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    this.Txtmatavgdescription.Text = String.Empty;
                    this.TxtmatAverageqty.Text = String.Empty;
                    this.Txtmatavgdescription.Focus();
                    return;
                }
                else
                {
                    this.SaveProcessClicker();
                }
            }

        }

        private void SaveProcessClicker()
        {

            if (this.AvgOrderTrendEntity.Mode == "ADD")
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                        .sp_avg_order_trend(0,
                        this.Txtmatavgdescription.Text,
                        Convert.ToInt32(this.TxtmatAverageqty.Text),
                        this.AvgOrderTrendEntity.Added_By,
                        this.AvgOrderTrendEntity.Date_Added,
                        "",
                        "",
                        "add");
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();


                }

                else
                {
                    return;
                }
            }

            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                        .sp_avg_order_trend(this.AvgOrderTrendEntity.Avg_Id,
                        this.Txtmatavgdescription.Text,
                        Convert.ToInt32(this.TxtmatAverageqty.Text),
                        this.AvgOrderTrendEntity.Added_By,
                        this.AvgOrderTrendEntity.Date_Added,
                        this.AvgOrderTrendEntity.Updated_By,
                        "",
                        "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();

                }

                else
                {
                    return;
                }
            }
        }

        private void Txtmatavgdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void TxtmatAverageqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(this.TxtmatAverageqty.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

      

        private void Txtmatavgdescription_TextChanged_1(object sender, EventArgs e)
        {
            this.ValueChanger();
        }

        private void ValueChanger()
        {
            if (this.TxtmatAverageqty.Text == String.Empty)
            {
                this.MatBtnSave.Visible = false;
            }
            else if (this.Txtmatavgdescription.Text == String.Empty)
            {
                this.MatBtnSave.Visible = false;
            }
            else
            {
                this.MatBtnSave.Visible = true;
            }
        }

        private void TxtmatAverageqty_TextChanged(object sender, EventArgs e)
        {
            this.ValueChanger();
        }
    }
}
