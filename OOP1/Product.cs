using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product // entitiy - varlık
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        
        // ürün adı
        public string ProductName { get; set; }
        //ürün fiyatı
        public double UnitPrice { get; set; }
        //urun stok adedi
        public int UnitInStock { get; set; }

    }
}
