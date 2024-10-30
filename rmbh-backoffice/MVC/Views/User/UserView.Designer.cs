namespace rmbh_backoffice.MVC.Views.User
{
    partial class UserView
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
            panel_Operation = new Panel();
            textBox_Searching = new TextBox();
            button_Add = new Button();
            panel_DataGrid = new Panel();
            dataGridView = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Avatar = new DataGridViewImageColumn();
            Email = new DataGridViewTextBoxColumn();
            Bio = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewComboBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            ModifiedDate = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel_Operation.SuspendLayout();
            panel_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel_Operation
            // 
            panel_Operation.Controls.Add(textBox_Searching);
            panel_Operation.Controls.Add(button_Add);
            panel_Operation.Dock = DockStyle.Top;
            panel_Operation.Location = new Point(2, 3);
            panel_Operation.Margin = new Padding(3, 4, 3, 4);
            panel_Operation.Name = "panel_Operation";
            panel_Operation.Size = new Size(910, 73);
            panel_Operation.TabIndex = 0;
            // 
            // textBox_Searching
            // 
            textBox_Searching.BorderStyle = BorderStyle.FixedSingle;
            textBox_Searching.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Searching.Location = new Point(134, 19);
            textBox_Searching.Margin = new Padding(3, 4, 3, 4);
            textBox_Searching.Name = "textBox_Searching";
            textBox_Searching.PlaceholderText = "   Search by first name, last name...";
            textBox_Searching.Size = new Size(443, 34);
            textBox_Searching.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.YellowGreen;
            button_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.Location = new Point(14, 13);
            button_Add.Margin = new Padding(3, 4, 3, 4);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(101, 45);
            button_Add.TabIndex = 0;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            // 
            // panel_DataGrid
            // 
            panel_DataGrid.Controls.Add(dataGridView);
            panel_DataGrid.Dock = DockStyle.Fill;
            panel_DataGrid.Location = new Point(2, 76);
            panel_DataGrid.Margin = new Padding(3, 4, 3, 4);
            panel_DataGrid.Name = "panel_DataGrid";
            panel_DataGrid.Padding = new Padding(17, 0, 17, 20);
            panel_DataGrid.Size = new Size(910, 521);
            panel_DataGrid.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Avatar, Email, Bio, Password, Role, CreatedDate, ModifiedDate, Edit, Delete });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(17, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(876, 501);
            dataGridView.TabIndex = 0;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 125;
            // 
            // Avatar
            // 
            Avatar.HeaderText = "Avatar";
            Avatar.MinimumWidth = 6;
            Avatar.Name = "Avatar";
            Avatar.Resizable = DataGridViewTriState.True;
            Avatar.SortMode = DataGridViewColumnSortMode.Automatic;
            Avatar.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Bio
            // 
            Bio.HeaderText = "Bio";
            Bio.MinimumWidth = 6;
            Bio.Name = "Bio";
            Bio.Width = 125;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "Created date";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Resizable = DataGridViewTriState.True;
            CreatedDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            CreatedDate.Width = 125;
            // 
            // ModifiedDate
            // 
            ModifiedDate.HeaderText = "ModifiedDate";
            ModifiedDate.MinimumWidth = 6;
            ModifiedDate.Name = "ModifiedDate";
            ModifiedDate.Resizable = DataGridViewTriState.True;
            ModifiedDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ModifiedDate.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.Width = 125;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_DataGrid);
            Controls.Add(panel_Operation);
            Margin = new Padding(3, 5, 3, 5);
            Name = "UserView";
            Padding = new Padding(2, 3, 2, 3);
            Text = "UserView";
            Load += UserView_Load;
            panel_Operation.ResumeLayout(false);
            panel_Operation.PerformLayout();
            panel_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Operation;
        private TextBox textBox_Searching;
        private Button button_Add;
        private Panel panel_DataGrid;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewImageColumn Avatar;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Bio;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewComboBoxColumn Role;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn ModifiedDate;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}