using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    public class Genres
    {
        public int GenresId { get; set; }
        public string Genre { get; set; }

        public Genres(string genre)
        {
            Genre = genre;
        }
        public ICollection<Item> Items { get; set; }
    }
}