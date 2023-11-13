namespace SQLPrograms
{
    class PanelSQLCode : IControlsUI
    {
        public void CreateControls(ref Form form)
        {
            RichTextBox frameSqlCode = new RichTextBox();

            frameSqlCode.Location = new Point((form.ClientSize.Width / 2) + ISQL.SHIFT, ISQL.SHIFT);
            frameSqlCode.Multiline = true;
            frameSqlCode.Size = new Size((form.ClientSize.Width / 2) - ISQL.SHIFT * 2, form.ClientSize.Height - ISQL.SHIFT * 4);

            form.Controls.Add(frameSqlCode);
        }
    }
}