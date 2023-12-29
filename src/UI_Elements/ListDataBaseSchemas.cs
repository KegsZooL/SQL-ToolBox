namespace SQLProgram
{   
    class ListDataBaseSchemas : IControlsUI
    {
        Label label;
        ComboBox comboBox;

        public ListDataBaseSchemas() 
        {
            IControlsUI.LabelSchemasCurrentDb = new Label();
            IControlsUI.ComboBox = new ComboBox();
            
            comboBox = IControlsUI.ComboBox;
            label = IControlsUI.LabelSchemasCurrentDb;
        }

        public void CreateControls(ref Form form)
        {
            label.Location = new Point((form.ClientSize.Width / 2) + IControlsUI.SHIFT,
                (form.ClientSize.Height / 2) - IControlsUI.SHIFT * 3 + 5);

            label.Text = "Schema:";
            label.Size = new Size(comboBox.Width / 2, comboBox.Height);

            comboBox.Location = new Point(label.Location.X + label.Width, label.Location.Y);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.AddRange(SQLServer.ExecuteListCommand("SHOW DATABASES")?.ToArray());

            comboBox.SelectedIndexChanged += SelectedDataBaseChanged;

            form.Controls.AddRange(new List<Control>(){ label, comboBox}.ToArray());
        }

        private void SelectedDataBaseChanged(object? sender, EventArgs e) => 
            SQLServer.ChangeDataBase(comboBox.SelectedItem?.ToString());
    }
}