namespace SQLPrograms
{
    class ButtonExecuteSQLCode : IControlsUI
    {   
        public void CreateControls(ref Form form)
        {
            Button buttonExecuteSQLCode = new Button();

            buttonExecuteSQLCode.Size = new Size((form.ClientSize.Width / 2) - ISQL.SHIFT * 2, ISQL.SHIFT);

            buttonExecuteSQLCode.Location = new Point((form.ClientSize.Width / 2) + ISQL.SHIFT,
                form.ClientSize.Height - (ISQL.SHIFT + buttonExecuteSQLCode.Height));

            buttonExecuteSQLCode.Text = "Execute";

            form.Controls.Add(buttonExecuteSQLCode);
        }
    }
}