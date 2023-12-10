namespace SQLProgram
{
    class DataTabelSQL : IControlsUI
    {
        public void CreateControls(ref Form form)
        {
            DataGridView dataGridView = new DataGridView();

            dataGridView.Location = new Point(ISQL.SHIFT, ISQL.SHIFT);
            dataGridView.Size = new Size(form.ClientSize.Width / 2 - ISQL.SHIFT, form.ClientSize.Height - (ISQL.SHIFT * 2));
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            dataGridView.ScrollBars = ScrollBars.Vertical;
            SQLServer.GetData(ref dataGridView);

            form.Controls.Add(dataGridView);
        }
    }
}
