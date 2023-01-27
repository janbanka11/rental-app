using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rental_app.Utils
{
    internal class dataGridViewUtils
    {
        static public void rentFormColumnHeadersStyle(DataGridView dataGridView)
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns["GenreName"].HeaderText = "Genre";
            dataGridView.Columns["ItemTypeName"].Visible = false;
        }
    }
}
