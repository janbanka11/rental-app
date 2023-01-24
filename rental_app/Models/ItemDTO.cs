using rental_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Forms
{
    public class ItemDTO
    {
        public ItemDTO(int itemId, string genreName, string itemTypeName, string author, string title, int price)
        {
            ItemId = itemId;
            GenreName = genreName;
            ItemTypeName = itemTypeName;
            Author = author;
            Title = title;
            Price = price;
        }

        public int ItemId { get; set; }

        public string GenreName { get; set; }

        public string ItemTypeName { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

    }
}
