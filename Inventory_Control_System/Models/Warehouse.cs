using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Control_System.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public int WarehouseNum { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Store Srore { get; set; }
    }
}

