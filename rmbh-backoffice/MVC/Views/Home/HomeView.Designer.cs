namespace rmbh_backoffice.VC.Views
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
            button_Home = new Button();
            button_UsersManagement = new Button();
            button_TeamsManagement = new Button();
            button_FlashsCards = new Button();
            panel_FlashsCards = new Panel();
            button_CardsManagement = new Button();
            button_DeckManagement = new Button();
            button_ClassesManagement = new Button();
            button_Help = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            panel_Footer = new Panel();
            panel_Body = new Panel();
            panel_Header = new Panel();
            label_Title = new Label();
            sideparTimer = new System.Windows.Forms.Timer(components);
            panel_SideMenu.SuspendLayout();
            panel_FlashsCards.SuspendLayout();
            panel4.SuspendLayout();
            panel_Body.SuspendLayout();
            panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_SideMenu
            // 
            panel_SideMenu.AutoScroll = true;
            panel_SideMenu.BackColor = Color.Black;
            panel_SideMenu.Controls.Add(panelLogo);
            panel_SideMenu.Controls.Add(button_Home);
            panel_SideMenu.Controls.Add(button_UsersManagement);
            panel_SideMenu.Controls.Add(button_TeamsManagement);
            panel_SideMenu.Controls.Add(button_FlashsCards);
            panel_SideMenu.Controls.Add(panel_FlashsCards);
            panel_SideMenu.Controls.Add(button_Help);
            panel_SideMenu.Controls.Add(panel2);
            panel_SideMenu.Controls.Add(panel3);
            panel_SideMenu.Controls.Add(panel4);
            panel_SideMenu.Dock = DockStyle.Left;
            panel_SideMenu.Location = new Point(0, 0);
            panel_SideMenu.Name = "panel_SideMenu";
            panel_SideMenu.Size = new Size(256, 876);
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
            // button_Home
            // 
            button_Home.Dock = DockStyle.Top;
            button_Home.FlatAppearance.BorderSize = 0;
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.ForeColor = SystemColors.ButtonHighlight;
            button_Home.Location = new Point(3, 141);
            button_Home.Name = "button_Home";
            button_Home.Padding = new Padding(10, 0, 0, 0);
            button_Home.Size = new Size(250, 40);
            button_Home.TabIndex = 2;
            button_Home.Text = "Home";
            button_Home.TextAlign = ContentAlignment.MiddleLeft;
            button_Home.UseVisualStyleBackColor = true;
            button_Home.Click += button_Home_Click;
            // 
            // button_UsersManagement
            // 
            button_UsersManagement.Dock = DockStyle.Top;
            button_UsersManagement.FlatAppearance.BorderSize = 0;
            button_UsersManagement.FlatStyle = FlatStyle.Flat;
            button_UsersManagement.ForeColor = SystemColors.ButtonHighlight;
            button_UsersManagement.Location = new Point(3, 187);
            button_UsersManagement.Name = "button_UsersManagement";
            button_UsersManagement.Padding = new Padding(10, 0, 0, 0);
            button_UsersManagement.Size = new Size(250, 40);
            button_UsersManagement.TabIndex = 3;
            button_UsersManagement.Text = "Users Management";
            button_UsersManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_UsersManagement.UseVisualStyleBackColor = true;
            button_UsersManagement.Click += button_UsersManagement_Click;
            // 
            // button_TeamsManagement
            // 
            button_TeamsManagement.Dock = DockStyle.Top;
            button_TeamsManagement.FlatAppearance.BorderSize = 0;
            button_TeamsManagement.FlatStyle = FlatStyle.Flat;
            button_TeamsManagement.ForeColor = SystemColors.ButtonHighlight;
            button_TeamsManagement.Location = new Point(3, 233);
            button_TeamsManagement.Name = "button_TeamsManagement";
            button_TeamsManagement.Padding = new Padding(10, 0, 0, 0);
            button_TeamsManagement.Size = new Size(250, 40);
            button_TeamsManagement.TabIndex = 5;
            button_TeamsManagement.Text = "Teams Management";
            button_TeamsManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_TeamsManagement.UseVisualStyleBackColor = true;
            button_TeamsManagement.Click += button_TeamsManagement_Click;
            // 
            // button_FlashsCards
            // 
            button_FlashsCards.Dock = DockStyle.Top;
            button_FlashsCards.FlatAppearance.BorderSize = 0;
            button_FlashsCards.FlatStyle = FlatStyle.Flat;
            button_FlashsCards.ForeColor = SystemColors.ButtonHighlight;
            button_FlashsCards.Location = new Point(3, 279);
            button_FlashsCards.Name = "button_FlashsCards";
            button_FlashsCards.Padding = new Padding(10, 0, 0, 0);
            button_FlashsCards.Size = new Size(250, 40);
            button_FlashsCards.TabIndex = 6;
            button_FlashsCards.Text = "Flashs Cards ";
            button_FlashsCards.TextAlign = ContentAlignment.MiddleLeft;
            button_FlashsCards.UseVisualStyleBackColor = true;
            button_FlashsCards.Click += button_FlashsCards_Click;
            // 
            // panel_FlashsCards
            // 
            panel_FlashsCards.BackColor = Color.FromArgb(35, 32, 39);
            panel_FlashsCards.Controls.Add(button_CardsManagement);
            panel_FlashsCards.Controls.Add(button_DeckManagement);
            panel_FlashsCards.Controls.Add(button_ClassesManagement);
            panel_FlashsCards.Location = new Point(3, 325);
            panel_FlashsCards.Name = "panel_FlashsCards";
            panel_FlashsCards.Size = new Size(250, 105);
            panel_FlashsCards.TabIndex = 7;
            // 
            // button_CardsManagement
            // 
            button_CardsManagement.FlatAppearance.BorderSize = 0;
            button_CardsManagement.FlatStyle = FlatStyle.Flat;
            button_CardsManagement.ForeColor = SystemColors.ButtonHighlight;
            button_CardsManagement.Location = new Point(0, 64);
            button_CardsManagement.Name = "button_CardsManagement";
            button_CardsManagement.Padding = new Padding(35, 0, 0, 0);
            button_CardsManagement.Size = new Size(247, 36);
            button_CardsManagement.TabIndex = 2;
            button_CardsManagement.Text = "Cards Management";
            button_CardsManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_CardsManagement.UseVisualStyleBackColor = true;
            button_CardsManagement.Click += button_CardsManagement_Click;
            // 
            // button_DeckManagement
            // 
            button_DeckManagement.FlatAppearance.BorderSize = 0;
            button_DeckManagement.FlatStyle = FlatStyle.Flat;
            button_DeckManagement.ForeColor = SystemColors.ButtonHighlight;
            button_DeckManagement.Location = new Point(0, 32);
            button_DeckManagement.Name = "button_DeckManagement";
            button_DeckManagement.Padding = new Padding(35, 0, 0, 0);
            button_DeckManagement.Size = new Size(247, 36);
            button_DeckManagement.TabIndex = 1;
            button_DeckManagement.Text = "Deck Management";
            button_DeckManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_DeckManagement.UseVisualStyleBackColor = true;
            button_DeckManagement.Click += button_DeckManagement_Click;
            // 
            // button_ClassesManagement
            // 
            button_ClassesManagement.FlatAppearance.BorderSize = 0;
            button_ClassesManagement.FlatStyle = FlatStyle.Flat;
            button_ClassesManagement.ForeColor = SystemColors.ButtonHighlight;
            button_ClassesManagement.Location = new Point(0, 0);
            button_ClassesManagement.Name = "button_ClassesManagement";
            button_ClassesManagement.Padding = new Padding(35, 0, 0, 0);
            button_ClassesManagement.Size = new Size(247, 36);
            button_ClassesManagement.TabIndex = 0;
            button_ClassesManagement.Text = "Classes Management";
            button_ClassesManagement.TextAlign = ContentAlignment.MiddleLeft;
            button_ClassesManagement.UseVisualStyleBackColor = true;
            button_ClassesManagement.Click += button_CardsManagement_Click;
            // 
            // button_Help
            // 
            button_Help.Dock = DockStyle.Top;
            button_Help.FlatAppearance.BorderSize = 0;
            button_Help.FlatStyle = FlatStyle.Flat;
            button_Help.ForeColor = SystemColors.ButtonHighlight;
            button_Help.Location = new Point(3, 436);
            button_Help.Name = "button_Help";
            button_Help.Padding = new Padding(10, 0, 0, 0);
            button_Help.Size = new Size(250, 40);
            button_Help.TabIndex = 8;
            button_Help.Text = "Help";
            button_Help.TextAlign = ContentAlignment.MiddleLeft;
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button_Help_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 84);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 572);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 703);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(51, 26);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 9;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel_Footer
            // 
            panel_Footer.BackColor = Color.FromArgb(0, 0, 20);
            panel_Footer.Dock = DockStyle.Bottom;
            panel_Footer.Location = new Point(256, 780);
            panel_Footer.Name = "panel_Footer";
            panel_Footer.Size = new Size(1126, 96);
            panel_Footer.TabIndex = 1;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.FromArgb(0, 0, 30);
            panel_Body.Controls.Add(panel_Header);
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(256, 0);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1126, 780);
            panel_Body.TabIndex = 2;
            // 
            // panel_Header
            // 
            panel_Header.BackColor = Color.FromArgb(0, 0, 45);
            panel_Header.Controls.Add(label_Title);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(1126, 62);
            panel_Header.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.ForeColor = Color.Brown;
            label_Title.Location = new Point(16, 9);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(50, 20);
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
            ClientSize = new Size(1382, 876);
            Controls.Add(panel_Body);
            Controls.Add(panel_Footer);
            Controls.Add(panel_SideMenu);
            Name = "HomeView";
            Text = "HomeView";
            panel_SideMenu.ResumeLayout(false);
            panel_FlashsCards.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private Button button_TeamsManagement;
        private Button button_FlashsCards;
        private Panel panel_FlashsCards;
        private Button button_CardsManagement;
        private Button button_DeckManagement;
        private Button button_ClassesManagement;
        private Button button_Help;
        private Panel panel_Footer;
        private Panel panel_Body;
        private Panel panel_Header;
        private System.Windows.Forms.Timer sideparTimer;
        private Label label_Title;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
    }
}