namespace PBO_Gymly
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Label_Username = new Label();
            Label_Password = new Label();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            Button_Login = new Button();
            ButtonExit = new Button();
            Button_Regist = new Button();
            SuspendLayout();
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.BackColor = Color.Transparent;
            Label_Username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Username.ForeColor = Color.Black;
            Label_Username.Location = new Point(584, 232);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(129, 35);
            Label_Username.TabIndex = 0;
            Label_Username.Text = "Username";
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.BackColor = Color.Transparent;
            Label_Password.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Password.ForeColor = Color.Black;
            Label_Password.Location = new Point(584, 343);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(122, 35);
            Label_Password.TabIndex = 1;
            Label_Password.Text = "Password";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.BackColor = Color.White;
            TextBoxUsername.BorderStyle = BorderStyle.None;
            TextBoxUsername.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxUsername.ForeColor = Color.Black;
            TextBoxUsername.Location = new Point(592, 276);
            TextBoxUsername.Margin = new Padding(3, 4, 3, 4);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(286, 29);
            TextBoxUsername.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.BackColor = Color.White;
            TextBoxPassword.BorderStyle = BorderStyle.None;
            TextBoxPassword.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxPassword.ForeColor = Color.Black;
            TextBoxPassword.Location = new Point(592, 384);
            TextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(286, 29);
            TextBoxPassword.TabIndex = 3;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.FromArgb(45, 48, 71);
            Button_Login.FlatAppearance.BorderSize = 0;
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Login.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Login.Location = new Point(791, 479);
            Button_Login.Margin = new Padding(3, 4, 3, 4);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(88, 53);
            Button_Login.TabIndex = 4;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = true;
            Button_Login.Click += Button_Login_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.BackColor = Color.FromArgb(45, 48, 71);
            ButtonExit.FlatAppearance.BorderSize = 0;
            ButtonExit.FlatStyle = FlatStyle.Flat;
            ButtonExit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonExit.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonExit.Location = new Point(592, 479);
            ButtonExit.Margin = new Padding(3, 4, 3, 4);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(88, 53);
            ButtonExit.TabIndex = 5;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // Button_Regist
            // 
            Button_Regist.BackColor = Color.FromArgb(45, 48, 71);
            Button_Regist.FlatAppearance.BorderSize = 0;
            Button_Regist.FlatStyle = FlatStyle.Flat;
            Button_Regist.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Regist.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Regist.Location = new Point(686, 479);
            Button_Regist.Margin = new Padding(3, 4, 3, 4);
            Button_Regist.Name = "Button_Regist";
            Button_Regist.Size = new Size(99, 53);
            Button_Regist.TabIndex = 6;
            Button_Regist.Text = "Regist";
            Button_Regist.UseVisualStyleBackColor = true;
            Button_Regist.Click += Button_Regist_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(Button_Regist);
            Controls.Add(ButtonExit);
            Controls.Add(Button_Login);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(Label_Password);
            Controls.Add(Label_Username);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Username;
        private Label Label_Password;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button Button_Login;
        private Button ButtonExit;
        private Button Button_Regist;
    }
}
