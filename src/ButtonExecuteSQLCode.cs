namespace SQLProgram                        
{
    class ButtonExecuteSQLCode : IControlsUI
    {   
        public void CreateControls(ref Form form)
        {
            Button buttonExecuteSQLCode = new Button();

            buttonExecuteSQLCode.Text = "Execute";
            buttonExecuteSQLCode.Size = new Size((form.ClientSize.Width / 2) - IControlsUI.SHIFT * 2, IControlsUI.SHIFT);
            buttonExecuteSQLCode.Location = new Point((form.ClientSize.Width / 2) + IControlsUI.SHIFT,
                form.ClientSize.Height - (IControlsUI.SHIFT + buttonExecuteSQLCode.Height));

            buttonExecuteSQLCode.Click += buttonExecuteSQLCode_Click;

            form.Controls.Add(buttonExecuteSQLCode);
        }

        //private void buttonExecuteSQLCode_Click(object sender, EventArgs e) => SQLCommandEventHandler.Notify(PanelSQLCode.GetCommandFromPanel());
        private void buttonExecuteSQLCode_Click(object sender, EventArgs e) => SQLServer.ExecuteCommand(PanelSQLCode.GetCommandFromPanel());
    }
}