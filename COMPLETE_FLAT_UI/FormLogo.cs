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

namespace COMPLETE_FLAT_UI
{
    public partial class FormLogo : MaterialForm
    {
        public FormLogo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            pictureBox1.Padding = new Padding(0);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
