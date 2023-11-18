namespace SQLProgram
{
    partial class SQLToolBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEnter = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelYourPassword = new Label();
            labelYourLogin = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            buttonEnter.Anchor = AnchorStyles.Bottom;
            buttonEnter.Location = new Point(315, 422);
            buttonEnter.Name = "button1";
            buttonEnter.Size = new Size(158, 51);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(254, 160);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(284, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Location = new Point(254, 231);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(284, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // label2
            // 
            labelYourPassword.AutoSize = true;
            labelYourPassword.Location = new Point(254, 203);
            labelYourPassword.Name = "label2";
            labelYourPassword.Size = new Size(117, 15);
            labelYourPassword.TabIndex = 4;
            labelYourPassword.Text = "Enter your password:";
            // 
            // label1
            // 
            labelYourLogin.AutoSize = true;
            labelYourLogin.Location = new Point(254, 132);
            labelYourLogin.Name = "label1";
            labelYourLogin.Size = new Size(94, 15);
            labelYourLogin.TabIndex = 3;
            labelYourLogin.Text = "Enter your login:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(labelYourLogin);
            Controls.Add(labelYourPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxPassword);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "SQL-ToolBox";
            Load += SQLTooLBox_Load;
            Resize += SQLToolBox_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelYourPassword;
        private Label labelYourLogin;
    }
}