using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        public int GenresId { get; set; }
        public Genres Genres { get; set; }

        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        ICollection<Rental> Rentals { get; set; }

    }
}