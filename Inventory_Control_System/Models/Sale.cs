using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Control_System.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Client Client { get; set; }
        public Inventory Inventory { get; set; }

       
    }
}

