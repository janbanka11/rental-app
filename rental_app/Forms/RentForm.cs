using Microsoft.EntityFrameworkCore;
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
            
            this.itemBindingSource.DataSource = context.Items.Local.ToBindingList();
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
    }
}
