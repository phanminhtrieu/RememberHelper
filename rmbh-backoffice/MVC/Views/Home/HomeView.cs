using rmbh_backoffice.MVC.Controllers.Learning.Class;
using rmbh_backoffice.MVC.Controllers.Learning.Deck;
using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Controllers.User;
using rmbh_backoffice.MVC.Views.Learning.Card;
using rmbh_backoffice.MVC.Views.Learning.Class;
using rmbh_backoffice.MVC.Views.Learning.Deck;
using rmbh_backoffice.MVC.Views.User;

namespace rmbh_backoffice.MVC.Views
{
    public partial class HomeView : Form, IView
    {
        private Button? _activeButton = null;
        private Form? _activeChildForm = null;

        public HomeView()
        {
            InitializeComponent();
            hideAllSubMenu();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void hideAllSubMenu()
        {

            panel_LearningItem.Visible = false;

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            changeTitle("Home");
        }

        private void button_UsersManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            AppManager.Instance.LoadChildView<UserController>();

            changeTitle("User Management");
        }

        private void button_Learning_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            showSubMenu(panel_LearningItem);
        }

        private void button_ClassManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            AppManager.Instance.LoadChildView<ClassController>();

            label_Title.Text = "Class Management";
        }

        private void button_DeckManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

           AppManager.Instance.LoadChildView<DeckController>();

            label_Title.Text = "Deck Management";

        }

        private void button_CardsManagement_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton != null)
                setActiveButton(clickedButton);

            //openChildForm(new CardView());

            label_Title.Text = "Class Management";

        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm log out.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AppManager.Instance.Load<LoginController>();
            }
        }

        private void changeTitle(string title)
        {
            label_Title.Text = title;
        }

        private void setActiveButton(Button clickedButton)
        {
            // Nếu có nút active trước đó, đặt lại màu cho nó
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.OliveDrab; // Màu mặc định
            }

            // Đặt màu active cho nút vừa nhấn
            _activeButton = clickedButton;
            _activeButton.BackColor = Color.YellowGreen; // Màu cho trạng thái active
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

        private void HomeView_Load(object sender, EventArgs e)
        {

        }
    }

}







