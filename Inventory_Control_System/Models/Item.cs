using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Control_System.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int lot { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Client Client { get; set; }
        public Supplier Supplier { get; set; }
           
    }
}



