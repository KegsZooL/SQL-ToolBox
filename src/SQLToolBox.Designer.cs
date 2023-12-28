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
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            textBoxHost = new TextBox();
            buttonConnect = new Button();
            labelUser = new Label();
            labelHost = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(254, 310);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(284, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUser.Location = new Point(254, 231);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(284, 23);
            textBoxUser.TabIndex = 2;
            // 
            // textBoxHost
            // 
            textBoxHost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxHost.Location = new Point(254, 160);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.Size = new Size(284, 23);
            textBoxHost.TabIndex = 1;
            // 
            // buttonConnect
            // 
            buttonConnect.Anchor = AnchorStyles.Bottom;
            buttonConnect.Location = new Point(315, 422);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(158, 51);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(254, 203);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(33, 15);
            labelUser.TabIndex = 4;
            labelUser.Text = "User:";
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Location = new Point(254, 132);
            labelHost.Name = "labelHost";
            labelHost.Size = new Size(35, 15);
            labelHost.TabIndex = 3;
            labelHost.Text = "Host:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(254, 283);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password:";
            // 
            // SQLToolBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelHost);
            Controls.Add(labelUser);
            Controls.Add(textBoxUser);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxHost);
            MinimumSize = new Size(800, 600);
            Name = "SQLToolBox";
            Text = "SQL-ToolBox";
            Load += SQLTooLBox_Load;
            Resize += SQLToolBox_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private TextBox textBoxHost;
        private TextBox textBoxUser;
        private Label labelUser;
        private Label labelHost;
        private TextBox textBoxPassword;
        private Label labelPassword;
    }
}