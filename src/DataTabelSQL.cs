namespace SQLProgram
{
    class DataTabelSQL : IControlsUI
    {
        public void CreateControls(ref Form form)
        {
            DataGridView dataGridView = SQLServer.dataGridView;

            dataGridView.Location = new Point(IControlsUI.SHIFT, IControlsUI.SHIFT);
            dataGridView.Size = new Size(form.ClientSize.Width / 2 - IControlsUI.SHIFT, form.ClientSize.Height - (IControlsUI.SHIFT * 2));
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ScrollBars = ScrollBars.Vertical;

            SQLServer.ExecuteCommand("SELECT * FROM othertable;");
            form.Controls.Add(dataGridView);
        }
    }
}
