using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.Models
{
    class userinfo
    {

    public static int USER_LOG = 0;

    public static int user_id;
    //public static int employee_id;  1/14/2020
    public static string user_name;
    public static string password;
    public static string emp_name;
    public static string emp_lastname;
    public static int user_rights_id;
    //public static string item_description; //microprofile
    public static string user_section;
    public static string receiving_status;


    public static void set_user_parameters(DataSet dset_user)
    {
    user_id = Convert.ToInt32(dset_user.Tables[0].Rows[0][0].ToString());
    user_rights_id = Convert.ToInt32(dset_user.Tables[0].Rows[0][1].ToString());
    user_name = dset_user.Tables[0].Rows[0][2].ToString();
    password = dset_user.Tables[0].Rows[0][3].ToString();
    emp_name = dset_user.Tables[0].Rows[0][4].ToString();
    user_section = dset_user.Tables[0].Rows[0][5].ToString();
    receiving_status = dset_user.Tables[0].Rows[0][6].ToString();
     emp_lastname = dset_user.Tables[0].Rows[0][7].ToString();
    USER_LOG = 1;
    }
    }
}
