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
    public partial class frmUpdateLotData : MaterialForm
    {
        frmLotManagement ths;
        //myclasses xClass = new myclasses();
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        public frmUpdateLotData(frmLotManagement frm, string created_by)
        {
            ths = frm;
            //textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            InitializeComponent();
        }

        public string created_by { get; set; }
        private void frmUpdateLotData_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmUpdateLotData_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "Gerard Singian";
        }
    }
}
