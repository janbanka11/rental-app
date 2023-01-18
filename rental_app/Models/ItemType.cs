using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    public class ItemType
    {
        public int ItemTypeId { get; set; }
        public string Type { get; set; }

        ICollection<Item> Items { get; set; }
    }
}