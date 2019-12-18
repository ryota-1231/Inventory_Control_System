using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Control_System.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Item Item { get; set; }
        public Store Store { get; set; }
        public Warehouse Warehouse { get; set; }

    }
}