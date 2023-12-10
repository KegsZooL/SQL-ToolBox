namespace SQLProgram
{
    class PanelSQLCode : IControlsUI
    {
        static RichTextBox richTextBox = new RichTextBox();
        
        public void CreateControls(ref Form form)
        {
            richTextBox.Location = new Point((form.ClientSize.Width / 2) + ISQL.SHIFT, ISQL.SHIFT);
            richTextBox.Multiline = true;
            richTextBox.Size = new Size((form.ClientSize.Width / 2) - ISQL.SHIFT * 2, (form.ClientSize.Height / 2) - ISQL.SHIFT * 4);

            form.Controls.Add(richTextBox);                            
        }

        public static string GetCommandFromPanel() => richTextBox.Text;
    }
}