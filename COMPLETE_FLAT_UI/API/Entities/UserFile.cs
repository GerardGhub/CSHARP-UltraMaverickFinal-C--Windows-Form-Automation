using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class UserFile
    {
        public int UserFile_id { get; set; }
        public int User_Rights_Id { get; set; }
        public string User_Rights_Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_LastName { get; set; }
        public bool Is_Active { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string User_Section { get; set; }
        public string Unit { get; set; }
        public string Receiving_Status { get; set; }
        public string Gender { get; set; }
        public string Requestor_Type { get; set; }

        public string Mode { get; set; }
    }
}
