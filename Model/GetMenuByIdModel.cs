﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIR.Model
{
    public class GetMenuByIdModel
    {
        public DataMenu data { get; set; }
    }

    public class DataMenu
    {
        public int id { get; set; }
        public string name { get; set; }
        public string menu_type { get; set; }
        public string image_url { get; set; }
        public List<MenuPrice> menu_prices { get; set; }
        public List<ServingType> serving_types { get; set; }
        public List<MenuDetailS> menu_details { get; set; }

    }

    public class MenuDetailS
    {
        public int menu_detail_id { get; set; }
        public string varian { get; set; }
        public List<MenuPrice> menu_prices { get; set; }
    }
    public class MenuPrice
    {
        public int serving_type_id { get; set; }
        public int price { get; set; }
    }
    public class ServingType
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
