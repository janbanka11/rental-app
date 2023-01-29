namespace rental_app.Utils
{
    internal class dataGridViewUtils
    {
        static public void rentFormColumnHeadersStyle(DataGridView dataGridView)
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns["GenreName"].HeaderText = "Genre";
            dataGridView.Columns["ItemTypeName"].Visible = false;
            dataGridView.Columns["GenreId"].Visible = false;
            dataGridView.Columns["ItemTypeId"].Visible = false;
        }
        static public void userRentalFormColumnHeadersStyle(DataGridView dataGridView)
        {
            dataGridView.Columns["RentalId"].Visible = false;
            dataGridView.Columns["CustomerName"].Visible = false;
            dataGridView.Columns["ItemTitle"].HeaderText = "Title";
            dataGridView.Columns["ItemType"].HeaderText = "Type";
            dataGridView.Columns["RentalStart"].HeaderText = "Start date";
            dataGridView.Columns["RentalEnd"].HeaderText = "End date";
            dataGridView.Columns["RentalPrice"].HeaderText = "Price";
        }
    }
}
