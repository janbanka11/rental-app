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

            var c = context.Items
                .Include(i => i.Genres)
                .Include(i => i.ItemType).ToList();
            List<ItemDTO> listdto = new List<ItemDTO>();
            foreach (var item in c)
            {
                listdto.Add(new ItemDTO(item.ItemId,item.Genres.Genre, item.ItemType.Type, item.Author, item.Title, item.Price));
            }

            this.dataGridView1.DataSource = listdto;

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
