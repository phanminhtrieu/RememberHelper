namespace rmbh_backoffice.MVC.Views.User
{
    partial class UserAddModal
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
            button_Cancel = new Button();
            button_Add = new Button();
            dateTimePicker_ModifiedDate = new DateTimePicker();
            dateTimePicker_CreatedDate = new DateTimePicker();
            comboBox_Role = new ComboBox();
            textBox_Bio = new TextBox();
            textBox_Password = new TextBox();
            textBox_Email = new TextBox();
            textBox_LastName = new TextBox();
            textBox_FirstName = new TextBox();
            label_ModifiedDate = new Label();
            label_CreatedDate = new Label();
            label_Role = new Label();
            label_Bio = new Label();
            label_Password = new Label();
            label_Email = new Label();
            label_LastName = new Label();
            label_FirstName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_Cancel
            // 
            button_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Cancel.Location = new Point(46, 602);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(235, 51);
            button_Cancel.TabIndex = 9;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.LightGreen;
            button_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.Location = new Point(320, 602);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(235, 51);
            button_Add.TabIndex = 9;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // dateTimePicker_ModifiedDate
            // 
            dateTimePicker_ModifiedDate.Enabled = false;
            dateTimePicker_ModifiedDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_ModifiedDate.Location = new Point(183, 519);
            dateTimePicker_ModifiedDate.Name = "dateTimePicker_ModifiedDate";
            dateTimePicker_ModifiedDate.Size = new Size(372, 30);
            dateTimePicker_ModifiedDate.TabIndex = 8;
            // 
            // dateTimePicker_CreatedDate
            // 
            dateTimePicker_CreatedDate.Enabled = false;
            dateTimePicker_CreatedDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_CreatedDate.Location = new Point(183, 467);
            dateTimePicker_CreatedDate.Name = "dateTimePicker_CreatedDate";
            dateTimePicker_CreatedDate.Size = new Size(372, 30);
            dateTimePicker_CreatedDate.TabIndex = 7;
            // 
            // comboBox_Role
            // 
            comboBox_Role.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Role.FormattingEnabled = true;
            comboBox_Role.Location = new Point(112, 414);
            comboBox_Role.Name = "comboBox_Role";
            comboBox_Role.Size = new Size(188, 33);
            comboBox_Role.TabIndex = 6;
            // 
            // textBox_Bio
            // 
            textBox_Bio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Bio.Location = new Point(99, 280);
            textBox_Bio.Multiline = true;
            textBox_Bio.Name = "textBox_Bio";
            textBox_Bio.ScrollBars = ScrollBars.Horizontal;
            textBox_Bio.Size = new Size(456, 112);
            textBox_Bio.TabIndex = 5;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(159, 225);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(397, 30);
            textBox_Password.TabIndex = 4;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(124, 176);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(437, 30);
            textBox_Email.TabIndex = 3;
            // 
            // textBox_LastName
            // 
            textBox_LastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_LastName.Location = new Point(164, 133);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(397, 30);
            textBox_LastName.TabIndex = 2;
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_FirstName.Location = new Point(158, 85);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(397, 30);
            textBox_FirstName.TabIndex = 1;
            // 
            // label_ModifiedDate
            // 
            label_ModifiedDate.AutoSize = true;
            label_ModifiedDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_ModifiedDate.Location = new Point(46, 524);
            label_ModifiedDate.Name = "label_ModifiedDate";
            label_ModifiedDate.Size = new Size(135, 25);
            label_ModifiedDate.TabIndex = 16;
            label_ModifiedDate.Text = "Modified date:";
            // 
            // label_CreatedDate
            // 
            label_CreatedDate.AutoSize = true;
            label_CreatedDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_CreatedDate.Location = new Point(46, 472);
            label_CreatedDate.Name = "label_CreatedDate";
            label_CreatedDate.Size = new Size(131, 25);
            label_CreatedDate.TabIndex = 15;
            label_CreatedDate.Text = "Created date:";
            // 
            // label_Role
            // 
            label_Role.AutoSize = true;
            label_Role.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Role.Location = new Point(49, 417);
            label_Role.Name = "label_Role";
            label_Role.Size = new Size(57, 25);
            label_Role.TabIndex = 14;
            label_Role.Text = "Role:";
            // 
            // label_Bio
            // 
            label_Bio.AutoSize = true;
            label_Bio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Bio.Location = new Point(49, 271);
            label_Bio.Name = "label_Bio";
            label_Bio.Size = new Size(46, 25);
            label_Bio.TabIndex = 13;
            label_Bio.Text = "Bio:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Password.Location = new Point(49, 228);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(104, 25);
            label_Password.TabIndex = 12;
            label_Password.Text = "Password:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Email.Location = new Point(49, 179);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(66, 25);
            label_Email.TabIndex = 11;
            label_Email.Text = "Email:";
            // 
            // label_LastName
            // 
            label_LastName.AutoSize = true;
            label_LastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_LastName.Location = new Point(49, 136);
            label_LastName.Name = "label_LastName";
            label_LastName.Size = new Size(109, 25);
            label_LastName.TabIndex = 10;
            label_LastName.Text = "Last name:";
            // 
            // label_FirstName
            // 
            label_FirstName.AutoSize = true;
            label_FirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_FirstName.Location = new Point(46, 88);
            label_FirstName.Name = "label_FirstName";
            label_FirstName.Size = new Size(109, 25);
            label_FirstName.TabIndex = 17;
            label_FirstName.Text = "First name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 29;
            label1.Text = "ADD USER";
            // 
            // UserAddModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 687);
            Controls.Add(label1);
            Controls.Add(button_Cancel);
            Controls.Add(button_Add);
            Controls.Add(dateTimePicker_ModifiedDate);
            Controls.Add(dateTimePicker_CreatedDate);
            Controls.Add(comboBox_Role);
            Controls.Add(textBox_Bio);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_LastName);
            Controls.Add(textBox_FirstName);
            Controls.Add(label_ModifiedDate);
            Controls.Add(label_CreatedDate);
            Controls.Add(label_Role);
            Controls.Add(label_Bio);
            Controls.Add(label_Password);
            Controls.Add(label_Email);
            Controls.Add(label_LastName);
            Controls.Add(label_FirstName);
            Name = "UserAddModal";
            Text = "UserAddView";
            Load += UserAddModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cancel;
        private Button button_Add;
        private DateTimePicker dateTimePicker_ModifiedDate;
        private DateTimePicker dateTimePicker_CreatedDate;
        private ComboBox comboBox_Role;
        private TextBox textBox_Bio;
        private TextBox textBox_Password;
        private TextBox textBox_Email;
        private TextBox textBox_LastName;
        private TextBox textBox_FirstName;
        private Label label_ModifiedDate;
        private Label label_CreatedDate;
        private Label label_Role;
        private Label label_Bio;
        private Label label_Password;
        private Label label_Email;
        private Label label_LastName;
        private Label label_FirstName;
        private Label label1;
    }
}