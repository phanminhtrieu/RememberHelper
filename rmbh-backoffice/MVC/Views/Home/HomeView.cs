using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Views.UsersManagement;

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

            openChildForm(new UsersView());
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

        private Form activeChildForm = null;

        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm log out.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AppManager.Instance.Load<LoginController>();
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeChildForm != null)
                activeChildForm.Close();

            activeChildForm = childForm;
            activeChildForm.TopLevel = false;
            activeChildForm.FormBorderStyle = FormBorderStyle.None;
            activeChildForm.Dock = DockStyle.Fill;

            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(activeChildForm);
            panel_Body.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
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







