﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIR.Model
{
    public class CartDetailStrukCustomerTransaction
    {
        public int cart_detail_id { get; set; }
        public int menu_id { get; set; }
        public string menu_name { get; set; }
        public string menu_type { get; set; }
        public object menu_detail_id { get; set; }
        public string? varian { get; set; }
        public int serving_type_id { get; set; }
        public string serving_type_name { get; set; }
        public int? discount_id { get; set; }
        public string? discount_code { get; set; }
        public object discounts_value { get; set; }
        public decimal? discounted_price { get; set; }
        public object discounts_is_percent { get; set; }
        public int price { get; set; }
        public int total_price { get; set; }
        public int qty { get; set; }
        public object note_item { get; set; }
    }

    public class DataStrukCustomerTransaction
    {
        public int transaction_id { get; set; }
        public string receipt_number { get; set; }
        public string customer_name { get; set; }
        public int customer_seat { get; set; }
        public string payment_type { get; set; }
        public string delivery_type { get; set; }
        public string delivery_note { get; set; }
        public int cart_id { get; set; }
        public int subtotal { get; set; }
        public int total { get; set; }
        public int? discount_id { get; set; }
        public string discount_code { get; set; }
        public decimal? discounts_value { get; set; }
        public int? discounts_is_percent { get; set; }
        public List<CartDetailStrukCustomerTransaction> cart_details { get; set; }
        public int customer_cash { get; set; }
        public int customer_change { get; set; }
        public string invoice_due_date { get; set; }
    }

    public class GetStrukCustomerTransaction
    {
        public int code { get; set; }
        public string message { get; set; }
        public DataStrukCustomerTransaction data { get; set; }
    }


}
