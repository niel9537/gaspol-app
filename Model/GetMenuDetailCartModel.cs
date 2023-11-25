﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIR.Model
{
    public class GetMenuDetailCartModel
    {
        public DataMenuDetail data { get; set; }
    }

    public class DataMenuDetail
    {
        public int id { get; set; }
        public string menu_type { get; set; }
        public List<MenuDetailDataCart> menu_details { get; set; }
   
    }

    public class MenuDetailDataCart
    {
        public int index { get; set; }
        public int menu_detail_id { get; set; }
        public string varian { get; set; }
        public string name { get; set; }
        public List<ServingTypes> serving_types { get; set; }

    }
    public class ServingTypes
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
}
