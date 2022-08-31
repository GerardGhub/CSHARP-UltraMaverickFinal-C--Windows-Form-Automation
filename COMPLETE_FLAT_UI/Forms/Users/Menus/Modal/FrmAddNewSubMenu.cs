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

namespace ULTRAMAVERICK.Forms.Users.Menus.Modal
{
    public partial class FrmAddNewSubMenu : MaterialForm
    {
        frmSubMenusAvailableForms ths;

        public FrmAddNewSubMenu(frmSubMenusAvailableForms frm,
            int UserId,
            string Mode,
            int MenuId,
            string MenuName)
        {
            InitializeComponent();
            ths = frm;
        }

        private void FrmAddNewSubMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
