namespace SQLProgram
{
    class DataTableSQL : IControlsUI
    {
        DataGridView dataGridView;

        public DataTableSQL() 
        {
            IControlsUI.DataGridView = SQLServer.dataGridView;
            dataGridView = IControlsUI.DataGridView;   
        }

        public void CreateControls(ref Form form)
        {
            dataGridView.Size = new Size(form.ClientSize.Width / 2 - IControlsUI.SHIFT, 
                form.ClientSize.Height - (IControlsUI.SHIFT * 2));

            dataGridView.Location = new Point(IControlsUI.SHIFT, IControlsUI.SHIFT);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ScrollBars = ScrollBars.Vertical;

            form.Controls.Add(dataGridView);
        }
    }
}
