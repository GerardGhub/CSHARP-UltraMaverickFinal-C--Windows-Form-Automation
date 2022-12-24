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

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class UpdateUserPasswordModal : MaterialForm
    {
        public UpdateUserPasswordModal()
        {
            InitializeComponent();
        }

        private void UpdateUserPasswordModal_Load(object sender, EventArgs e)
        {
            RoundPictureAss();
        }
        private void RoundPictureAss()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, PcUser.Width - 3, PcUser.Height - 3);
            Region rg = new Region(gp);
            PcUser.Region = rg;
        }
    }
}
