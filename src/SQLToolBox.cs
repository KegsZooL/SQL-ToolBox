namespace SQLProgram
{
    public partial class SQLToolBox : Form
    {
        SQLServer sqlServerHandler = new SQLServer();

        Rectangle originalFormSize;

        Dictionary<Control, Rectangle> originalControlRectangle = new Dictionary<Control, Rectangle>();
        
        Form CurrentForm;

        UIEventHandler UI = new UIEventHandler();

        public SQLToolBox()
        {
            CurrentForm = this;
            
            InitializeComponent();
        }

        private void SQLTooLBox_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            foreach (Control control in Controls)
            {
                originalControlRectangle.Add(control, new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (sqlServerHandler.Connect(textBoxHost.Text, textBoxUser.Text, textBoxPassword.Text))
            {
                while (Controls.Count != 0)
                {
                    Controls.Remove(Controls[Controls.Count - 1]);
                }

                UI.Subscribe(new List<IControlsUI>() { new DataTableSQL(), new PanelSQLCode(), new ButtonExecuteSQLCode(), 
                                                       new ListDataBaseSchemas(), new ListDataBaseTables() });
                UI.Notify(ref CurrentForm);

                originalControlRectangle.Clear();

                foreach (Control control in Controls)
                {
                    originalControlRectangle.Add(control, new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
                }
                SQLToolBox_Resize(this, e);
            }
        }

        private void SQLToolBox_Resize(object sender, EventArgs e)
        {
            foreach (Control control in originalControlRectangle.Keys)
            {
                float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
                float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

                int newX = (int)(originalControlRectangle[control].X * xRatio);
                int newY = (int)(originalControlRectangle[control].Y * yRatio);

                int newWidth = (int)(originalControlRectangle[control].Width * xRatio);
                int newHeight = (int)(originalControlRectangle[control].Height * yRatio);

                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
            }
        }
    }
}