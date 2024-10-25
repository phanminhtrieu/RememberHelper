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
            sideparTimer = new System.Windows.Forms.Timer(components);
            panelSideMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            btnHome = new Button();
            btnUsersManagement = new Button();
            btnTeamsManagament = new Button();
            btnFlashsCards = new Button();
            panelFlashsCards = new Panel();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            btnHelp = new Button();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelFlashsCards.SuspendLayout();
            SuspendLayout();
            // 
            // sideparTimer
            // 
            sideparTimer.Interval = 10;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.Black;
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Controls.Add(btnHome);
            panelSideMenu.Controls.Add(btnUsersManagement);
            panelSideMenu.Controls.Add(btnTeamsManagament);
            panelSideMenu.Controls.Add(btnFlashsCards);
            panelSideMenu.Controls.Add(panelFlashsCards);
            panelSideMenu.Controls.Add(btnHelp);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(256, 876);
            panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 132);
            panelLogo.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(3, 141);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(250, 40);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnUsersManagement
            // 
            btnUsersManagement.Dock = DockStyle.Top;
            btnUsersManagement.FlatAppearance.BorderSize = 0;
            btnUsersManagement.FlatStyle = FlatStyle.Flat;
            btnUsersManagement.ForeColor = SystemColors.ButtonHighlight;
            btnUsersManagement.Location = new Point(3, 187);
            btnUsersManagement.Name = "btnUsersManagement";
            btnUsersManagement.Padding = new Padding(10, 0, 0, 0);
            btnUsersManagement.Size = new Size(250, 40);
            btnUsersManagement.TabIndex = 3;
            btnUsersManagement.Text = "Users Management";
            btnUsersManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUsersManagement.UseVisualStyleBackColor = true;
            // 
            // btnTeamsManagament
            // 
            btnTeamsManagament.Dock = DockStyle.Top;
            btnTeamsManagament.FlatAppearance.BorderSize = 0;
            btnTeamsManagament.FlatStyle = FlatStyle.Flat;
            btnTeamsManagament.ForeColor = SystemColors.ButtonHighlight;
            btnTeamsManagament.Location = new Point(3, 233);
            btnTeamsManagament.Name = "btnTeamsManagament";
            btnTeamsManagament.Padding = new Padding(10, 0, 0, 0);
            btnTeamsManagament.Size = new Size(250, 40);
            btnTeamsManagament.TabIndex = 5;
            btnTeamsManagament.Text = "Teams Management";
            btnTeamsManagament.TextAlign = ContentAlignment.MiddleLeft;
            btnTeamsManagament.UseVisualStyleBackColor = true;
            // 
            // btnFlashsCards
            // 
            btnFlashsCards.Dock = DockStyle.Top;
            btnFlashsCards.FlatAppearance.BorderSize = 0;
            btnFlashsCards.FlatStyle = FlatStyle.Flat;
            btnFlashsCards.ForeColor = SystemColors.ButtonHighlight;
            btnFlashsCards.Location = new Point(3, 279);
            btnFlashsCards.Name = "btnFlashsCards";
            btnFlashsCards.Padding = new Padding(10, 0, 0, 0);
            btnFlashsCards.Size = new Size(250, 40);
            btnFlashsCards.TabIndex = 6;
            btnFlashsCards.Text = "Flashs Cards ";
            btnFlashsCards.TextAlign = ContentAlignment.MiddleLeft;
            btnFlashsCards.UseVisualStyleBackColor = true;
            // 
            // panelFlashsCards
            // 
            panelFlashsCards.BackColor = Color.FromArgb(35, 32, 39);
            panelFlashsCards.Controls.Add(button13);
            panelFlashsCards.Controls.Add(button14);
            panelFlashsCards.Controls.Add(button15);
            panelFlashsCards.Location = new Point(3, 325);
            panelFlashsCards.Name = "panelFlashsCards";
            panelFlashsCards.Size = new Size(250, 105);
            panelFlashsCards.TabIndex = 7;
            // 
            // button13
            // 
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Location = new Point(0, 64);
            button13.Name = "button13";
            button13.Padding = new Padding(35, 0, 0, 0);
            button13.Size = new Size(247, 36);
            button13.TabIndex = 2;
            button13.Text = "Cards Management";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = SystemColors.ButtonHighlight;
            button14.Location = new Point(0, 32);
            button14.Name = "button14";
            button14.Padding = new Padding(35, 0, 0, 0);
            button14.Size = new Size(247, 36);
            button14.TabIndex = 1;
            button14.Text = "Deck Management";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Location = new Point(0, 0);
            button15.Name = "button15";
            button15.Padding = new Padding(35, 0, 0, 0);
            button15.Size = new Size(247, 36);
            button15.TabIndex = 0;
            button15.Text = "Classes Management";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = SystemColors.ButtonHighlight;
            btnHelp.Location = new Point(3, 436);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(10, 0, 0, 0);
            btnHelp.Size = new Size(250, 40);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(0, 0, 37);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(256, 780);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(1126, 96);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(0, 0, 37);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(256, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1126, 780);
            panelChildForm.TabIndex = 2;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 876);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            Name = "HomeView";
            Text = "HomeView";
            panelSideMenu.ResumeLayout(false);
            panelFlashsCards.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer sideparTimer;
        private FlowLayoutPanel panelSideMenu;
        private Panel panelLogo;
        private Button btnHome;
        private Button btnUsersManagement;
        private Button btnTeamsManagament;
        private Button btnFlashsCards;
        private Panel panelFlashsCards;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button btnHelp;
        private Panel panelPlayer;
        private Panel panelChildForm;
    }
}