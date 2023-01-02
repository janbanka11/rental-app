using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    internal class Item
    {
        public int IdItem { get; set; }
        public int IdGenre { get; set; }
        public ItemType Type { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

    }
}
