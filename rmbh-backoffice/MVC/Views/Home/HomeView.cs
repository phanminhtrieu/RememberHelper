using rmbh_backoffice.MVC.Views;

namespace rmbh_backoffice.MVC.Views
{
    public partial class HomeView : Form, IView
    {

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
        private void hideSubMenu()
        {

            if (panel_FlashsCards.Visible == true)
                panel_FlashsCards.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void button_Home_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
           label_Title.Text = "Home";

        }

        private void button_UsersManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            
            label_Title.Text = "Users Management";
        }

        private void button_TeamsManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
            label_Title.Text = "Teams Management";
        }

        private void button_FlashsCards_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_FlashsCards);
            label_Title.Text = "Flashs Cards";
        }
        #region tool
        private void button_ClassManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }

        private void button_DeckManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }

        private void button_CardsManagement_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
        }
        #endregion
        private void button_Help_Click(object sender, EventArgs e)
        {
            //.. 
            //.. code minh
            hideSubMenu();
            label_Title.Text = "Help";

        }
        private Form acctiveform = null;
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
    }
}


    
    



