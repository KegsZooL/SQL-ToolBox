namespace SQLProgram
{
    class ListDataBaseTables : IControlsUI
    {
        Label label;

        public ListDataBaseTables() 
        {
            IControlsUI.LabelDataBaseList = new Label();

            label = IControlsUI.LabelDataBaseList;
        }
        
        public void CreateControls(ref Form form)
        {
            IControlsUI.ComboBox.SelectedIndexChanged += SelectedDataBaseChanged;
            
            label.Location = new Point(IControlsUI.LabelSchemasCurrentDb.Location.X, 
                IControlsUI.LabelSchemasCurrentDb.Location.Y + IControlsUI.SHIFT);

            label.Size = new Size(form.ClientSize.Width / 2, label.Size.Height);

            form.Controls.Add(label);
        }

        private void SelectedDataBaseChanged(object? sender, EventArgs e) =>
            label.Text = $"Tabels: {string.Join(';', SQLServer.GetAllTableNames())}";
    }
}