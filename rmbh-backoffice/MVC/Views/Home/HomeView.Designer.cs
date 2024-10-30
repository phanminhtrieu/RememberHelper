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
            panel_FlashsCards = new Panel();
            button_CardsManagement = new Button();
            button_DeckManagement = new Button();
            button_ClassesManagement = new Button();
            panel3 = new Panel();
            button_Logout = new Button();
            button_Home = new Button();
            button_FlashsCards = new Button();
            panel_Footer = new Panel();
            panel_Body = new Panel();
            panel_Header = new Panel();
            label_Title = new Label();
            sideparTimer = new System.Windows.Forms.Timer(components);
            panel_SideMenu.SuspendLayout();
            panel_SidebarItem.SuspendLayout();
            panel_FlashsCards.SuspendLayout();
            panel_Body.SuspendLayout();
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
            panel_SideMenu.Name = "panel_SideMenu";
            panel_SideMenu.Size = new Size(256, 853);
            panel_SideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 132);
            panelLogo.TabIndex = 1;
            // 
            // panel_SidebarItem
            // 
            panel_SidebarItem.Controls.Add(button_UsersManagement);
            panel_SidebarItem.Controls.Add(panel_FlashsCards);
            panel_SidebarItem.Controls.Add(button_Logout);
            panel_SidebarItem.Controls.Add(button_Home);
            panel_SidebarItem.Controls.Add(button_FlashsCards);
            panel_SidebarItem.Dock = DockStyle.Top;
            panel_SidebarItem.Location = new Point(3, 141);
            panel_SidebarItem.Name = "panel_SidebarItem";
            panel_SidebarItem.Size = new Size(250, 700);
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
            button_UsersManagement.Location = new Point(0, 40);
            button_UsersManagement.Name = "button_UsersManagement";
            button_UsersManagement.Padding = new Padding(10, 0, 0, 0);
            button_UsersManagement.Size = new Size(250, 40);
            button_UsersManagement.TabIndex = 3;
            button_UsersManagement.Text = "Users Management";
            button_UsersManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_UsersManagement.UseVisualStyleBackColor = false;
            button_UsersManagement.Click += button_UsersManagement_Click;
            // 
            // panel_FlashsCards
            // 
            panel_FlashsCards.BackColor = Color.OliveDrab;
            panel_FlashsCards.Controls.Add(button_CardsManagement);
            panel_FlashsCards.Controls.Add(button_DeckManagement);
            panel_FlashsCards.Controls.Add(button_ClassesManagement);
            panel_FlashsCards.Controls.Add(panel3);
            panel_FlashsCards.Location = new Point(0, 114);
            panel_FlashsCards.Name = "panel_FlashsCards";
            panel_FlashsCards.Size = new Size(250, 105);
            panel_FlashsCards.TabIndex = 7;
            // 
            // button_CardsManagement
            // 
            button_CardsManagement.Dock = DockStyle.Top;
            button_CardsManagement.FlatAppearance.BorderSize = 0;
            button_CardsManagement.FlatStyle = FlatStyle.Flat;
            button_CardsManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_CardsManagement.ForeColor = SystemColors.ButtonHighlight;
            button_CardsManagement.Location = new Point(0, 72);
            button_CardsManagement.Name = "button_CardsManagement";
            button_CardsManagement.Padding = new Padding(35, 0, 0, 0);
            button_CardsManagement.Size = new Size(250, 36);
            button_CardsManagement.TabIndex = 2;
            button_CardsManagement.Text = "Cards Management";
            button_CardsManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_CardsManagement.UseVisualStyleBackColor = true;
            button_CardsManagement.Click += button_CardsManagement_Click;
            // 
            // button_DeckManagement
            // 
            button_DeckManagement.Dock = DockStyle.Top;
            button_DeckManagement.FlatAppearance.BorderSize = 0;
            button_DeckManagement.FlatStyle = FlatStyle.Flat;
            button_DeckManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_DeckManagement.ForeColor = SystemColors.ButtonHighlight;
            button_DeckManagement.Location = new Point(0, 36);
            button_DeckManagement.Name = "button_DeckManagement";
            button_DeckManagement.Padding = new Padding(35, 0, 0, 0);
            button_DeckManagement.Size = new Size(250, 36);
            button_DeckManagement.TabIndex = 1;
            button_DeckManagement.Text = "Deck Management";
            button_DeckManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_DeckManagement.UseVisualStyleBackColor = true;
            button_DeckManagement.Click += button_DeckManagement_Click;
            // 
            // button_ClassesManagement
            // 
            button_ClassesManagement.Dock = DockStyle.Top;
            button_ClassesManagement.FlatAppearance.BorderSize = 0;
            button_ClassesManagement.FlatStyle = FlatStyle.Flat;
            button_ClassesManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_ClassesManagement.ForeColor = SystemColors.ButtonHighlight;
            button_ClassesManagement.Location = new Point(0, 0);
            button_ClassesManagement.Name = "button_ClassesManagement";
            button_ClassesManagement.Padding = new Padding(35, 0, 0, 0);
            button_ClassesManagement.Size = new Size(250, 36);
            button_ClassesManagement.TabIndex = 0;
            button_ClassesManagement.Text = "Classes Management";
            button_ClassesManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_ClassesManagement.UseVisualStyleBackColor = true;
            button_ClassesManagement.Click += button_ClassManagement_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 572);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // button_Logout
            // 
            button_Logout.BackColor = Color.OliveDrab;
            button_Logout.Dock = DockStyle.Bottom;
            button_Logout.FlatStyle = FlatStyle.Flat;
            button_Logout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Logout.ForeColor = SystemColors.ButtonHighlight;
            button_Logout.Location = new Point(0, 655);
            button_Logout.Name = "button_Logout";
            button_Logout.Padding = new Padding(10, 0, 0, 0);
            button_Logout.Size = new Size(250, 45);
            button_Logout.TabIndex = 8;
            button_Logout.Text = "Logout";
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
            button_Home.Name = "button_Home";
            button_Home.Padding = new Padding(10, 0, 0, 0);
            button_Home.Size = new Size(250, 40);
            button_Home.TabIndex = 2;
            button_Home.Text = "Home";
            button_Home.TextAlign = ContentAlignment.MiddleLeft;
            button_Home.UseVisualStyleBackColor = false;
            button_Home.Click += button_Home_Click;
            // 
            // button_FlashsCards
            // 
            button_FlashsCards.BackColor = Color.OliveDrab;
            button_FlashsCards.FlatAppearance.BorderSize = 0;
            button_FlashsCards.FlatStyle = FlatStyle.Flat;
            button_FlashsCards.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_FlashsCards.ForeColor = SystemColors.ButtonHighlight;
            button_FlashsCards.Location = new Point(0, 77);
            button_FlashsCards.Name = "button_FlashsCards";
            button_FlashsCards.Padding = new Padding(10, 0, 0, 0);
            button_FlashsCards.Size = new Size(250, 40);
            button_FlashsCards.TabIndex = 6;
            button_FlashsCards.Text = "Flashs Cards ";
            button_FlashsCards.TextAlign = ContentAlignment.MiddleLeft;
            button_FlashsCards.UseVisualStyleBackColor = false;
            button_FlashsCards.Click += button_FlashsCards_Click;
            // 
            // panel_Footer
            // 
            panel_Footer.BackColor = Color.YellowGreen;
            panel_Footer.Dock = DockStyle.Bottom;
            panel_Footer.Location = new Point(256, 782);
            panel_Footer.Name = "panel_Footer";
            panel_Footer.Size = new Size(1326, 71);
            panel_Footer.TabIndex = 1;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Snow;
            panel_Body.Controls.Add(panel_Header);
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(256, 0);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1326, 782);
            panel_Body.TabIndex = 2;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.YellowGreen;
            panel_Header.Controls.Add(label_Title);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1326, 66);
            panel_Header.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.ForeColor = Color.DarkOliveGreen;
            label_Title.Location = new Point(3, 3);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(144, 57);
            label_Title.TabIndex = 0;
            label_Title.Text = "Home";
            // 
            // sideparTimer
            // 
            sideparTimer.Interval = 10;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel_Body);
            Controls.Add(panel_Footer);
            Controls.Add(panel_SideMenu);
            Name = "HomeView";
            Text = "HomeView";
            panel_SideMenu.ResumeLayout(false);
            panel_SidebarItem.ResumeLayout(false);
            panel_FlashsCards.ResumeLayout(false);
            panel_Body.ResumeLayout(false);
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_SideMenu;
        private Panel panelLogo;
        private Button button_Home;
        private Button button_UsersManagement;
        private Button button_FlashsCards;
        private Panel panel_FlashsCards;
        private Button button_CardsManagement;
        private Button button_DeckManagement;
        private Button button_ClassesManagement;
        private Panel panel_Footer;
        private Panel panel_Body;
        private Panel panel_Header;
        private System.Windows.Forms.Timer sideparTimer;
        private Label label_Title;
        private Panel panel3;
        private Button button_Logout;
        private Panel panel_SidebarItem;
    }
}