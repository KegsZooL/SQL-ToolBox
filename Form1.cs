namespace SQLPrograms
{
    public partial class Form1 : Form
    {
        SQLServerHandler sqlServerHandler = new SQLServerHandler();

        Rectangle originalFormSize;

        Dictionary<Control, Rectangle> originalControlRectangle = new Dictionary<Control, Rectangle>();

        Form CurrentForm;

        public Form1()
        {
            CurrentForm = this;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlServerHandler.Connect();
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            foreach (Control control in Controls)
            {
                originalControlRectangle.Add(control, new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlServerHandler.Autorization(userPassword: textBoxPassword.Text, userLogin: textBoxLogin.Text))
            {
                while (Controls.Count != 0)
                {
                    Controls.Remove(Controls[Controls.Count - 1]);
                }

                EventHandler.AddToDelegate(new List<IControlsUI>() { new DataTabelSQL(), new PanelSQLCode(), new ButtonExecuteSQLCode() });
                EventHandler.NotifyCreateUI(ref CurrentForm);

                originalControlRectangle.Clear();

                foreach (Control control in Controls)
                {
                    originalControlRectangle.Add(control, new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
                }
                Form1_Resize(this, e);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
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