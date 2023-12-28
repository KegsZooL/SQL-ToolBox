namespace SQLProgram                        
{
    class ButtonExecuteSQLCode : IControlsUI
    {
        Button button;
        public ButtonExecuteSQLCode() 
        {
            IControlsUI.ButtonExecuteSqlCode = new Button();
            button = IControlsUI.ButtonExecuteSqlCode;   
        }

        public void CreateControls(ref Form form)
        {
            button.Location = new Point((form.ClientSize.Width / 2) + IControlsUI.SHIFT,
                form.ClientSize.Height - (IControlsUI.SHIFT + button.Height));
            
            button.Text = "Execute";
            button.Size = new Size((form.ClientSize.Width / 2) - IControlsUI.SHIFT * 2, IControlsUI.SHIFT);
            button.Click += buttonExecuteSQLCode_Click;

            form.Controls.Add(button);
        }

        //private void buttonExecuteSQLCode_Click(object sender, EventArgs e) => SQLCommandEventHandler.Notify(PanelSQLCode.GetCommandFromPanel());
        private void buttonExecuteSQLCode_Click(object sender, EventArgs e) => SQLServer.ExecuteCommand(PanelSQLCode.GetCommandFromPanel());
    }
}