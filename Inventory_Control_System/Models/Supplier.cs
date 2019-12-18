using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Control_System.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
