using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmEditItemModal : MaterialForm
    {
        frmDryRawMaterials ths;
        public frmEditItemModal(frmDryRawMaterials frm, string created_by, 
            string item_code, 
            string item_description,
            string item_class,
            string major_category,
            string sub_category,
            string primary_unit,
            string conversion,
            string item_type
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.created_by = created_by;
            this.item_code = item_code;
            this.item_description = item_description;
            this.item_class = item_class;
            this.major_category = major_category;
            this.sub_category = sub_category;
            this.primary_unit = primary_unit;
            this.conversion = conversion;
            this.item_type = item_type;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public string created_by { get; set; }
        public string item_code { get; set; }
        public string item_description { get; set; }
        public string item_class { get; set; }
        public string major_category { get; set; }
        public string sub_category { get; set; }
        public string primary_unit { get; set; }
        public string conversion { get; set; }
        public string item_type { get; set; }
        private void frmEditItemModal_Load(object sender, EventArgs e)
        {
            FirstLoadBindingOrb();

        }


        private void FirstLoadBindingOrb()
        {
            txtcreatedBy.Text = created_by;
            txtMatItemCode.Text = item_code;
            txtMatItemDesc.Text = item_description;
            cboItemClass.Text = item_class;
            cboMajorCategory.Text = major_category;
            cboSubCat.Text = sub_category;
            cboPrimaryUnit.Text = primary_unit;
            txtmatConversion.Text = conversion;
            cboItemType.Text = item_type;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
    }
}
