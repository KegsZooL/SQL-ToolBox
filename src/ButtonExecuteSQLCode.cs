namespace SQLProgram                        
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

            buttonExecuteSQLCode.Click += buttonExecuteSQLCode_Click;

            form.Controls.Add(buttonExecuteSQLCode);
        }

        private void buttonExecuteSQLCode_Click(object sender, EventArgs e)
        {
            string command = PanelSQLCode.GetCommandFromPanel();
            new SQLCommandEventHandler().Notify(ref command);
        }
    }
}