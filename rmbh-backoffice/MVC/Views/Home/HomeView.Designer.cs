namespace rmbh_backoffice.MVC.Views
{
    partial class HomeView
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
            components = new System.ComponentModel.Container();
            panel_SideMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            panel_SidebarItem = new Panel();
            button_UsersManagement = new Button();
            panel_LearningItem = new Panel();
            button_CardManagement = new Button();
            button_DeckManagement = new Button();
            button_ClassManagement = new Button();
            panel3 = new Panel();
            button_Logout = new Button();
            button_Home = new Button();
            button_Learning = new Button();
            panel_Footer = new Panel();
            panel_ContentContainer = new Panel();
            panel_Body = new Panel();
            panel_Header = new Panel();
            label_Title = new Label();
            sideparTimer = new System.Windows.Forms.Timer(components);
            panel_SideMenu.SuspendLayout();
            panel_SidebarItem.SuspendLayout();
            panel_LearningItem.SuspendLayout();
            panel_ContentContainer.SuspendLayout();
            panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_SideMenu
            // 
            panel_SideMenu.AutoScroll = true;
            panel_SideMenu.BackColor = Color.OliveDrab;
            panel_SideMenu.Controls.Add(panelLogo);
            panel_SideMenu.Controls.Add(panel_SidebarItem);
            panel_SideMenu.Dock = DockStyle.Left;
            panel_SideMenu.Location = new Point(0, 0);
            panel_SideMenu.Margin = new Padding(3, 2, 3, 2);
            panel_SideMenu.Name = "panel_SideMenu";
            panel_SideMenu.Size = new Size(224, 634);
            panel_SideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 2);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(216, 99);
            panelLogo.TabIndex = 1;
            // 
            // panel_SidebarItem
            // 
            panel_SidebarItem.Controls.Add(button_UsersManagement);
            panel_SidebarItem.Controls.Add(panel_LearningItem);
            panel_SidebarItem.Controls.Add(button_Logout);
            panel_SidebarItem.Controls.Add(button_Home);
            panel_SidebarItem.Controls.Add(button_Learning);
            panel_SidebarItem.Dock = DockStyle.Top;
            panel_SidebarItem.Location = new Point(3, 105);
            panel_SidebarItem.Margin = new Padding(3, 2, 3, 2);
            panel_SidebarItem.Name = "panel_SidebarItem";
            panel_SidebarItem.Size = new Size(219, 525);
            panel_SidebarItem.TabIndex = 9;
            // 
            // button_UsersManagement
            // 
            button_UsersManagement.BackColor = Color.OliveDrab;
            button_UsersManagement.Dock = DockStyle.Top;
            button_UsersManagement.FlatAppearance.BorderSize = 0;
            button_UsersManagement.FlatStyle = FlatStyle.Flat;
            button_UsersManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_UsersManagement.ForeColor = SystemColors.ButtonHighlight;
            button_UsersManagement.Location = new Point(0, 30);
            button_UsersManagement.Margin = new Padding(3, 2, 3, 2);
            button_UsersManagement.Name = "button_UsersManagement";
            button_UsersManagement.Padding = new Padding(9, 0, 0, 0);
            button_UsersManagement.Size = new Size(219, 30);
            button_UsersManagement.TabIndex = 3;
            button_UsersManagement.Text = "User Management";
            button_UsersManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_UsersManagement.UseVisualStyleBackColor = false;
            button_UsersManagement.Click += button_UsersManagement_Click;
            // 
            // panel_LearningItem
            // 
            panel_LearningItem.BackColor = Color.OliveDrab;
            panel_LearningItem.Controls.Add(button_CardManagement);
            panel_LearningItem.Controls.Add(button_DeckManagement);
            panel_LearningItem.Controls.Add(button_ClassManagement);
            panel_LearningItem.Controls.Add(panel3);
            panel_LearningItem.Location = new Point(0, 86);
            panel_LearningItem.Margin = new Padding(3, 2, 3, 2);
            panel_LearningItem.Name = "panel_LearningItem";
            panel_LearningItem.Size = new Size(219, 79);
            panel_LearningItem.TabIndex = 7;
            // 
            // button_CardManagement
            // 
            button_CardManagement.Dock = DockStyle.Top;
            button_CardManagement.FlatAppearance.BorderSize = 0;
            button_CardManagement.FlatStyle = FlatStyle.Flat;
            button_CardManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_CardManagement.ForeColor = SystemColors.ButtonHighlight;
            button_CardManagement.Location = new Point(0, 54);
            button_CardManagement.Margin = new Padding(3, 2, 3, 2);
            button_CardManagement.Name = "button_CardManagement";
            button_CardManagement.Padding = new Padding(31, 0, 0, 0);
            button_CardManagement.Size = new Size(219, 27);
            button_CardManagement.TabIndex = 2;
            button_CardManagement.Text = "Card Management";
            button_CardManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_CardManagement.UseVisualStyleBackColor = true;
            button_CardManagement.Click += button_CardsManagement_Click;
            // 
            // button_DeckManagement
            // 
            button_DeckManagement.Dock = DockStyle.Top;
            button_DeckManagement.FlatAppearance.BorderSize = 0;
            button_DeckManagement.FlatStyle = FlatStyle.Flat;
            button_DeckManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_DeckManagement.ForeColor = SystemColors.ButtonHighlight;
            button_DeckManagement.Location = new Point(0, 27);
            button_DeckManagement.Margin = new Padding(3, 2, 3, 2);
            button_DeckManagement.Name = "button_DeckManagement";
            button_DeckManagement.Padding = new Padding(31, 0, 0, 0);
            button_DeckManagement.Size = new Size(219, 27);
            button_DeckManagement.TabIndex = 1;
            button_DeckManagement.Text = "Deck Management";
            button_DeckManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_DeckManagement.UseVisualStyleBackColor = true;
            button_DeckManagement.Click += button_DeckManagement_Click;
            // 
            // button_ClassManagement
            // 
            button_ClassManagement.Dock = DockStyle.Top;
            button_ClassManagement.FlatAppearance.BorderSize = 0;
            button_ClassManagement.FlatStyle = FlatStyle.Flat;
            button_ClassManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_ClassManagement.ForeColor = SystemColors.ButtonHighlight;
            button_ClassManagement.Location = new Point(0, 0);
            button_ClassManagement.Margin = new Padding(3, 2, 3, 2);
            button_ClassManagement.Name = "button_ClassManagement";
            button_ClassManagement.Padding = new Padding(31, 0, 0, 0);
            button_ClassManagement.Size = new Size(219, 27);
            button_ClassManagement.TabIndex = 0;
            button_ClassManagement.Text = "Class Management";
            button_ClassManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_ClassManagement.UseVisualStyleBackColor = true;
            button_ClassManagement.Click += button_ClassManagement_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 429);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 94);
            panel3.TabIndex = 1;
            // 
            // button_Logout
            // 
            button_Logout.BackColor = Color.OliveDrab;
            button_Logout.Dock = DockStyle.Bottom;
            button_Logout.FlatStyle = FlatStyle.Flat;
            button_Logout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Logout.ForeColor = SystemColors.ButtonHighlight;
            button_Logout.Location = new Point(0, 491);
            button_Logout.Margin = new Padding(3, 2, 3, 2);
            button_Logout.Name = "button_Logout";
            button_Logout.Padding = new Padding(9, 0, 0, 0);
            button_Logout.Size = new Size(219, 34);
            button_Logout.TabIndex = 8;
            button_Logout.Text = "Log out";
            button_Logout.UseVisualStyleBackColor = true;
            button_Logout.Click += button_Logout_Click;
            // 
            // button_Home
            // 
            button_Home.BackColor = Color.OliveDrab;
            button_Home.Dock = DockStyle.Top;
            button_Home.FlatAppearance.BorderSize = 0;
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Home.ForeColor = SystemColors.ButtonHighlight;
            button_Home.Location = new Point(0, 0);
            button_Home.Margin = new Padding(3, 2, 3, 2);
            button_Home.Name = "button_Home";
            button_Home.Padding = new Padding(9, 0, 0, 0);
            button_Home.Size = new Size(219, 30);
            button_Home.TabIndex = 2;
            button_Home.Text = "Home";
            button_Home.TextAlign = ContentAlignment.MiddleLeft;
            button_Home.UseVisualStyleBackColor = false;
            button_Home.Click += button_Home_Click;
            // 
            // button_Learning
            // 
            button_Learning.BackColor = Color.OliveDrab;
            button_Learning.FlatAppearance.BorderSize = 0;
            button_Learning.FlatStyle = FlatStyle.Flat;
            button_Learning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Learning.ForeColor = SystemColors.ButtonHighlight;
            button_Learning.Location = new Point(0, 58);
            button_Learning.Margin = new Padding(3, 2, 3, 2);
            button_Learning.Name = "button_Learning";
            button_Learning.Padding = new Padding(9, 0, 0, 0);
            button_Learning.Size = new Size(219, 30);
            button_Learning.TabIndex = 6;
            button_Learning.Text = "Learning";
            button_Learning.TextAlign = ContentAlignment.MiddleLeft;
            button_Learning.UseVisualStyleBackColor = false;
            button_Learning.Click += button_Learning_Click;
            // 
            // panel_Footer
            // 
            panel_Footer.BackColor = Color.YellowGreen;
            panel_Footer.Dock = DockStyle.Bottom;
            panel_Footer.Location = new Point(224, 581);
            panel_Footer.Margin = new Padding(3, 2, 3, 2);
            panel_Footer.Name = "panel_Footer";
            panel_Footer.Size = new Size(1161, 53);
            panel_Footer.TabIndex = 1;
            // 
            // panel_ContentContainer
            // 
            panel_ContentContainer.BackColor = Color.Snow;
            panel_ContentContainer.Controls.Add(panel_Body);
            panel_ContentContainer.Controls.Add(panel_Header);
            panel_ContentContainer.Location = new Point(224, 0);
            panel_ContentContainer.Margin = new Padding(3, 2, 3, 2);
            panel_ContentContainer.Name = "panel_ContentContainer";
            panel_ContentContainer.Size = new Size(1160, 586);
            panel_ContentContainer.TabIndex = 2;
            // 
            // panel_Body
            // 
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(0, 50);
            panel_Body.Margin = new Padding(3, 2, 3, 2);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1160, 536);
            panel_Body.TabIndex = 1;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.YellowGreen;
            panel_Header.Controls.Add(label_Title);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Margin = new Padding(3, 2, 3, 2);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1160, 50);
            panel_Header.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.ForeColor = Color.DarkOliveGreen;
            label_Title.Location = new Point(3, 2);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(116, 46);
            label_Title.TabIndex = 0;
            label_Title.Text = "Home";
            // 
            // sideparTimer
            // 
            sideparTimer.Interval = 10;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 634);
            Controls.Add(panel_ContentContainer);
            Controls.Add(panel_Footer);
            Controls.Add(panel_SideMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeView";
            Text = "HomeView";
            panel_SideMenu.ResumeLayout(false);
            panel_SidebarItem.ResumeLayout(false);
            panel_LearningItem.ResumeLayout(false);
            panel_ContentContainer.ResumeLayout(false);
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_SideMenu;
        private Panel panelLogo;
        private Button button_Home;
        private Button button_UsersManagement;
        private Button button_Learning;
        private Panel panel_LearningItem;
        private Button button_CardManagement;
        private Button button_DeckManagement;
        private Button button_ClassManagement;
        private Panel panel_Footer;
        private Panel panel_ContentContainer;
        private Panel panel_Header;
        private System.Windows.Forms.Timer sideparTimer;
        private Label label_Title;
        private Panel panel3;
        private Button button_Logout;
        private Panel panel_SidebarItem;
        private Panel panel_Body;
    }
}