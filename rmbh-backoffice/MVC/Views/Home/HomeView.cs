using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Views;

namespace rmbh_backoffice.MVC.Views
{
    public partial class HomeView : Form, IView
    {
        private Button activeButton = null;
        public HomeView()
        {
            InitializeComponent();
            cutomizeDesing();
        }

        public Form Form
        {
            get
            {
                return this;
            }
        }

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        private void cutomizeDesing()
        {

            panel_FlashsCards.Visible = false;

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null) 
                setActiveButton(clickedButton);

            label_Title.Text = "Home";

        }

        private void button_UsersManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            label_Title.Text = "Users Management";
        }

        private void button_FlashsCards_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            showSubMenu(panel_FlashsCards);
        }

        private void button_ClassManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            label_Title.Text = "Classes Management";
        }

        private void button_DeckManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            label_Title.Text = "Decks Management";
        }

        private void button_CardsManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            label_Title.Text = "Cards Management";
        }

        private Form acctiveform = null;

        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm log out.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AppManager.Instance.Load<LoginController>();
            }
        }

        private void openChildForm(Form childFrom)
        {
            if (acctiveform != null)
                acctiveform.Close();
            acctiveform = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childFrom);
            panel_Body.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void setActiveButton(Button clickedButton)
        {
            // Nếu có nút active trước đó, đặt lại màu cho nó
            if (activeButton != null)
            {
                activeButton.BackColor = Color.OliveDrab; // Màu mặc định
            }

            // Đặt màu active cho nút vừa nhấn
            activeButton = clickedButton;
            activeButton.BackColor = Color.YellowGreen; // Màu cho trạng thái active
        }

        private void hideSubMenu(Panel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
    }

}







