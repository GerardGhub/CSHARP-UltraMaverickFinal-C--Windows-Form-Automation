﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class Available_Menu
    {
        public int Menu_Id { get; set; }
        public string Menu_Name { get; set; }
        public string Menu_Form_Name { get; set; }
        public bool Is_Active { get; set; }
        public string Count { get; set; }
        public string Created_At { get; set; }
        public string Created_By { get; set; }
        public string Updated_At { get; set; }
        public string Updated_By { get; set; }
        public string Tagging_RelationShip { get; set; }
        public string Mode { get; set; }
        public string ParentMenuName { get; set; }
        public  int User_Rights_Id { get; set; }
        public int MajorMenuID { get; set; }

    }
}
