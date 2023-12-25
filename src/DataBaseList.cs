namespace SQLProgram
{
    class DataBaseList : IControlsUI
    {
        public void CreateControls(ref Form form)
        {
            ComboBox comboBox = new ComboBox();
            
            comboBox.Location = new Point((form.ClientSize.Width / 2) + IControlsUI.SHIFT, 
                (form.ClientSize.Height / 2) - IControlsUI.SHIFT * 3 + 5);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            form.Controls.Add(comboBox);
        }
    }
}
