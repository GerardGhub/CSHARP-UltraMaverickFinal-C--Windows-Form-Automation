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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{

    public partial class frmServeInternalPreparation : MaterialForm
    {
        frmDryPreparationInternal ths;
        //Main Classs
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        //Variable Declaration
        int p_id = 0;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmServeInternalPreparation(frmDryPreparationInternal frm,
            string Dry_Order_GUID,
            string Barcode_id,
            string Item_Description,
            string Unit_Of_Measure,
            string Converted_Qty,
            string Preparation_Date,
            string Qty_Served,
            string Fox,
            string Route,
            string Area,
            string Category,
            string TotalRawMaterialPreparationActive
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            Sp_Material_Id = Dry_Order_GUID;
            Sp_Barcode_Id = Barcode_id;
            Sp_Item_Desc = Item_Description;
            Sp_Unit_Of_Measure = Unit_Of_Measure;
            Sp_Converted_Qty = Converted_Qty;
            Sp_Preparation_Date = Preparation_Date;
            Sp_Qty_Served = Qty_Served;
            sp_Fox = Fox;
            sp_Route = Route;
            sp_Area = Area;
            Sp_Category = Category;
            Sp_TotalRawMaterialPreparationActive = TotalRawMaterialPreparationActive;
        }


        public string sp_Fox { get; set; }
        public string sp_Route { get; set; }
        public string sp_Area { get; set; }

        public string Sp_Qty_Served { get; set; }
        public string Sp_Preparation_Date { get; set; }
        public string Sp_Converted_Qty { get; set; }
        public string Sp_Unit_Of_Measure { get; set; }
        public string Sp_Item_Desc { get; set; }
        public string receiving_identity { get; set; }
        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        public string sp_quantity_serve { get; set; }
        public string sp_receiving_id { get; set; }
        public string sp_qty_order { get; set; }
        public string sp_uom { get; set; }
        public string Sp_Material_Id { get; set; }
        public string Sp_Barcode_Id { get; set; }
        public int Sp_User_ID { get; set; }
        public int Sp_RepackIncement { get; set; }

        public string TotalItemPreparedPerItemIncrementation { get; set; }

        public string TotalRecordofPrepared { get; set; }

        public string dgvStoreOrderApproval_Primary_ID { get; set; }
        public string dgvStoreOrderApproval_Is_wh_checker_cancel { get; set; }

        public string Sp_Category { get; set; }
        public string Sp_TotalRawMaterialPreparationActive { get; set; }

        private void frmServeInternalPreparation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
    }
}
