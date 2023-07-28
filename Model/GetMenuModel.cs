using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIR.Model
{
    public class GetMenuModel
    {
        public List<Menu> data { get; set; }
    }

    public class Menu
    {
        public int id { get; set; }
        public string name { get; set; }
        public string menu_type { get; set; }
        public float price { get; set; }
    }
}
