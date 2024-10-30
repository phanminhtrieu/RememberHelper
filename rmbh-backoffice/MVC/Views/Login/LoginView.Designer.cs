﻿namespace rmbh_backoffice.MVC.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Name = new Label();
            button_Login = new Button();
            textBox_Username = new TextBox();
            label_Login = new Label();
            label_Username = new Label();
            label_Password = new Label();
            textBox_Password = new TextBox();
            checkBox_Passwordshow = new CheckBox();
            button_CloseForm = new Button();
            panel_UserName = new Panel();
            panel2 = new Panel();
            panel_Password = new Panel();
            panel_UserName.SuspendLayout();
            panel_Password.SuspendLayout();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.ForeColor = Color.OliveDrab;
            label_Name.Location = new Point(42, 66);
            label_Name.Margin = new Padding(4, 0, 4, 0);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(244, 28);
            label_Name.TabIndex = 0;
            label_Name.Text = "Remember Helper";
            label_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Login
            // 
            button_Login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button_Login.BackColor = Color.OliveDrab;
            button_Login.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(134, 371);
            button_Login.Margin = new Padding(4, 3, 4, 3);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(109, 40);
            button_Login.TabIndex = 3;
            button_Login.Text = "Log in";
            button_Login.UseVisualStyleBackColor = false;
            // 
            // textBox_Username
            // 
            textBox_Username.BorderStyle = BorderStyle.None;
            textBox_Username.Dock = DockStyle.Fill;
            textBox_Username.Location = new Point(0, 0);
            textBox_Username.Margin = new Padding(4, 3, 4, 3);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(272, 16);
            textBox_Username.TabIndex = 1;
            // 
            // label_Login
            // 
            label_Login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Login.ForeColor = Color.Black;
            label_Login.Location = new Point(155, 138);
            label_Login.Margin = new Padding(4, 0, 4, 0);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(58, 18);
            label_Login.TabIndex = 3;
            label_Login.Text = "LOGIN";
            label_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Username
            // 
            label_Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label_Username.ForeColor = Color.Black;
            label_Username.Location = new Point(58, 196);
            label_Username.Margin = new Padding(4, 0, 4, 0);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(159, 15);
            label_Username.TabIndex = 4;
            label_Username.Text = "Enter your username";
            label_Username.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Password
            // 
            label_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label_Password.ForeColor = Color.Black;
            label_Password.Location = new Point(58, 260);
            label_Password.Margin = new Padding(4, 0, 4, 0);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(159, 15);
            label_Password.TabIndex = 6;
            label_Password.Text = "Enter your password";
            label_Password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Password
            // 
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Dock = DockStyle.Fill;
            textBox_Password.Location = new Point(0, 0);
            textBox_Password.Margin = new Padding(4, 3, 4, 3);
            textBox_Password.MaxLength = 50;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(272, 16);
            textBox_Password.TabIndex = 2;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // checkBox_Passwordshow
            // 
            checkBox_Passwordshow.AutoSize = true;
            checkBox_Passwordshow.BackColor = Color.Transparent;
            checkBox_Passwordshow.Font = new Font("Lucida Sans Typewriter", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox_Passwordshow.Location = new Point(58, 330);
            checkBox_Passwordshow.Margin = new Padding(4, 3, 4, 3);
            checkBox_Passwordshow.Name = "checkBox_Passwordshow";
            checkBox_Passwordshow.Size = new Size(117, 18);
            checkBox_Passwordshow.TabIndex = 8;
            checkBox_Passwordshow.Text = "Show password";
            checkBox_Passwordshow.UseVisualStyleBackColor = false;
            checkBox_Passwordshow.CheckedChanged += checkBox_Passwordshow_CheckedChanged;
            // 
            // button_CloseForm
            // 
            button_CloseForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_CloseForm.BackColor = Color.Transparent;
            button_CloseForm.FlatStyle = FlatStyle.Flat;
            button_CloseForm.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_CloseForm.ForeColor = Color.DarkRed;
            button_CloseForm.Location = new Point(352, 12);
            button_CloseForm.Margin = new Padding(4, 3, 4, 3);
            button_CloseForm.Name = "button_CloseForm";
            button_CloseForm.Size = new Size(32, 25);
            button_CloseForm.TabIndex = 9;
            button_CloseForm.Text = "X";
            button_CloseForm.UseVisualStyleBackColor = false;
            button_CloseForm.Click += button_CloseForm_Click;
            // 
            // panel_UserName
            // 
            panel_UserName.BorderStyle = BorderStyle.FixedSingle;
            panel_UserName.Controls.Add(textBox_Username);
            panel_UserName.Location = new Point(58, 218);
            panel_UserName.Name = "panel_UserName";
            panel_UserName.Size = new Size(274, 23);
            panel_UserName.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Location = new Point(58, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 23);
            panel2.TabIndex = 11;
            // 
            // panel_Password
            // 
            panel_Password.BorderStyle = BorderStyle.FixedSingle;
            panel_Password.Controls.Add(textBox_Password);
            panel_Password.Location = new Point(58, 282);
            panel_Password.Name = "panel_Password";
            panel_Password.Size = new Size(274, 23);
            panel_Password.TabIndex = 11;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(398, 454);
            Controls.Add(panel_Password);
            Controls.Add(panel2);
            Controls.Add(panel_UserName);
            Controls.Add(button_CloseForm);
            Controls.Add(checkBox_Passwordshow);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Controls.Add(label_Login);
            Controls.Add(button_Login);
            Controls.Add(label_Name);
            Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            panel_UserName.ResumeLayout(false);
            panel_UserName.PerformLayout();
            panel_Password.ResumeLayout(false);
            panel_Password.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Login;
        private Button button_CloseForm;
        private Label label_Name;
        private Label label_Login;
        private Label label_Username;
        private Label label_Password;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private CheckBox checkBox_Passwordshow;
        private Panel panel_UserName;
        private Panel panel2;
        private Panel panel_Password;
    }
}