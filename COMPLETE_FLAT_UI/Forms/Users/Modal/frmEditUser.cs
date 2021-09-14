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
using ULTRAMAVERICK.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ULTRAMAVERICK.Forms.Users.Modal
{
    public partial class frmEditUser : MaterialForm
    {
        frmUserManagement2 ths;
        public frmEditUser(frmUserManagement2 frm, string first_name, string last_name, string user_rights, 
            string username, string password, string department, string position, string unit, string user_layout,
            string requestor_type)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.first_name = first_name;
            this.last_name = last_name;
            this.user_rights = user_rights;
            this.username = username;
            this.password = password;
            this.department = department;
            this.position = position;
            this.unit = unit;
            this.user_layout = user_layout;
        }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_rights { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string department { get; set; }
        public string position { get; set; }
        public string unit { get; set; }
        public string user_layout { get; set; }
        public string requestor_type { get; set; }
        private void frmEditUser_Load(object sender, EventArgs e)
        {
          
            callDataBinding();
        }

        private void callDataBinding()
        {
            txtname.Text = first_name;
            txtLastName.Text = last_name;
            cbousertype.Text = user_rights;
            txtuser.Text = username;
            txtpassword.Text = password;
            cbodepartment.Text = department;
            cboPosition.Text = position;
            cboUnit.Text = unit;
            cmbLocation.Text = user_layout;
            cboRequestorType.Text = requestor_type;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = "Save Gerard Singian";
        }
    }
}
