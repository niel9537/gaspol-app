using System;
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
        public int price { get; set; }
        public int dine_in_price { get; set; }
        public int take_away_price { get; set; }
        public int delivery_service_price { get; set; }
        public int gofood_price { get; set; }
        public int grabfood_price { get; set; }
        public int shopeefood_price { get; set; }
        public List<MenuDetailS> menu_details { get; set; }
    }

    public class MenuDetailS
    {
        public int menu_detail_id { get; set; }
        public string varian { get; set; }
        public int price { get; set; }
        public int dine_in_price { get; set; }
        public int take_away_price { get; set; }
        public int delivery_service_price { get; set; }
        public int gofood_price { get; set; }
        public int grabfood_price { get; set; }
        public int shopeefood_price { get; set; }
    }
}
