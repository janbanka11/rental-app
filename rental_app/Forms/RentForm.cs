using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using rental_app.Data;
using rental_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rental_app.Forms
{
    public partial class RentForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public RentForm()
        {
            InitializeComponent();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            context.Items.Load();

            //var g = new List<ItemType>{new Genres("Thriller"),
            //                         new Genres("Horror"),
            //                         new Genres("Comedy"),
            //                         new Genres("Action"),
            //};
            //var i = new List<Item> {new Item(1,1,"Robert", "DUpa", 100),
            //                        new Item(3,2,"Ksiazka", "Maklowicz", 30),
            //                        new Item(4,3,"Dolowy", "Marcin", 110),
            //                        new Item(2,2,"Robert", "Dolowy", 120),};

            var c = context.Items
                .Include(i => i.Genres)
                .Include(i => i.ItemType).ToList();
            List<ItemDTO> listdto = new List<ItemDTO>();
            foreach (var item in c)
            {
                listdto.Add(new ItemDTO(item.ItemId,item.Genres.Genre, item.ItemType.Type, item.Author, item.Title, item.Price));
            }



            //context.AddRange(i);
            // context.SaveChanges();
            this.dataGridView1.DataSource = listdto;

            //Item item = new Item();
            //    var c = context.Items
            //        .Include(i => i.Items.)
            //        .Include(i => i.ItemTypeId)
            //        .Include(i => i.Author)
            //        .Include(i => i.Title)
            //        .Include(i => i.Price)
            //        .ToList();
            //    dataGridView1.DataSource = c;

            //ItemType itemType = new ItemType();
            //var query = from g in item.GenresId
            //            join m in item.GenresId on g


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount =
            dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                var cellValue = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (!cellValue.IsNullOrEmpty())
                {
                    var itemById = context.Items
                        .Include(i => i.Genres)
                        .Include(i => i.ItemType).First(g => g.ItemId == Int32.Parse(cellValue)); // pobrany obiekt, na tym context.remove
                    Console.WriteLine(itemById);

                }
            }

        }
    }
}
