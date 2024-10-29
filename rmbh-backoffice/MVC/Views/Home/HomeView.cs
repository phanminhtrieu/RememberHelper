using rmbh_backoffice.MVC.Controllers.Login;
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

        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Nếu người dùng chọn "Yes", thực hiện hành động logout
            if (result == DialogResult.Yes)
            {

                AppManager.Instance.Load<LoginController>();
            }
        }

        #region Mouse_Color_Home

        private void button_Home_MouseEnter(object sender, EventArgs e)
        {
            button_Home.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_Home.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột vào}
        }

        private void button_Home_Leave(object sender, EventArgs e)
        {
            button_Home.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_Home.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định
        }

        private void button_Home_Down(object sender, MouseEventArgs e)
        {
            button_Home.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_Home.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_Home_Up(object sender, MouseEventArgs e)
        {
            button_Home.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_Home.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }
        #endregion

        #region Mouse_Color_UsersManagement
        private void button_UsersManagement_MouseDown(object sender, MouseEventArgs e)
        {
            button_UsersManagement.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_UsersManagement.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_UsersManagement_MouseEnter(object sender, EventArgs e)
        {
            button_UsersManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_UsersManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột vào}
        }

        private void button_UsersManagement_MouseLeave(object sender, EventArgs e)
        {
            button_UsersManagement.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_UsersManagement.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }

        private void button_UsersManagement_MouseUp(object sender, MouseEventArgs e)
        {
            button_UsersManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_UsersManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }
        #endregion

        #region Mouse_Color_TeamsManagement

        private void button_TeamsManagement_MouseEnter(object sender, EventArgs e)
        {
            button_TeamsManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_TeamsManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột vào}
        }

        private void button_TeamsManagement_MouseLeave(object sender, EventArgs e)
        {
            button_TeamsManagement.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_TeamsManagement.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }

        private void button_TeamsManagement_MouseDown(object sender, MouseEventArgs e)
        {
            button_TeamsManagement.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_TeamsManagement.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_TeamsManagement_MouseUp(object sender, MouseEventArgs e)
        {
            button_TeamsManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_TeamsManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }
        #endregion

        #region Mouse_Color_FlashsCard

        private void button_FlashsCards_MouseEnter(object sender, EventArgs e)
        {
            button_FlashsCards.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_FlashsCards.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột 
        }

        private void button_FlashsCards_MouseLeave(object sender, EventArgs e)
        {
            button_FlashsCards.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_FlashsCards.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }


        private void button_FlashsCards_MouseDown(object sender, MouseEventArgs e)
        {
            button_FlashsCards.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_FlashsCards.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_FlashsCards_MouseUp(object sender, MouseEventArgs e)
        {
            button_FlashsCards.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_FlashsCards.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }
        #endregion

        #region Mouse_Color_Help

        private void button_Help_MouseEnter(object sender, EventArgs e)
        {
            button_Help.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_Help.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột
        }

        private void button_Help_MouseLeave(object sender, EventArgs e)
        {

            button_Help.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_Help.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }

        private void button_Help_MouseDown(object sender, MouseEventArgs e)
        {
            button_Help.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_Help.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_Help_MouseUp(object sender, MouseEventArgs e)
        {
            button_Help.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_Help.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }

        #endregion

        #region Mouse_Color_ClassesManament

        private void button_ClassesManagement_MouseEnter(object sender, EventArgs e)
        {
            button_ClassesManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_ClassesManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột
        }

        private void button_ClassesManagement_MouseLeave(object sender, EventArgs e)
        {
            button_ClassesManagement.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_ClassesManagement.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }

        private void button_ClassesManagement_MouseDown(object sender, MouseEventArgs e)
        {
            button_ClassesManagement.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_ClassesManagement.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_ClassesManagement_MouseUp(object sender, MouseEventArgs e)
        {
            button_ClassesManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_ClassesManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }
        #endregion

        #region Mouse_Color_DeckManagement

        private void button_DeckManagement_MouseEnter(object sender, EventArgs e)
        {

            button_DeckManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_DeckManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột
        }

        private void button_DeckManagement_MouseLeave(object sender, EventArgs e)
        {
            button_DeckManagement.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_DeckManagement.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }

        private void button_DeckManagement_MouseDown(object sender, MouseEventArgs e)
        {
            button_DeckManagement.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_DeckManagement.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }


        private void button_DeckManagement_MouseUp(object sender, MouseEventArgs e)
        {
            button_DeckManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_DeckManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }

        #endregion

        #region Mouse_Color_CardsManagement

        private void button_CardsManagement_MouseEnter(object sender, EventArgs e)
        {
            button_CardsManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng khi di chuột vào
            button_CardsManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng khi di chuột
        }

        private void button_CardsManagement_MouseLeave(object sender, EventArgs e)
        {
            button_CardsManagement.BackColor = Color.OliveDrab; // Màu nền mặc định
            button_CardsManagement.FlatAppearance.BorderColor = Color.OliveDrab; // Viền mặc định nút
        }

        private void button_CardsManagement_MouseDown(object sender, MouseEventArgs e)
        {
            button_CardsManagement.BackColor = Color.FromArgb(65, 105, 225); // Màu tối hơn khi nhấn nút
            button_CardsManagement.FlatAppearance.BorderColor = Color.RoyalBlue; // Viền tối hơn khi nhấn nút
        }

        private void button_CardsManagement_MouseUp(object sender, MouseEventArgs e)
        {
            button_CardsManagement.BackColor = Color.FromArgb(100, 149, 237); // Màu sáng trở lại khi thả chuột
            button_CardsManagement.FlatAppearance.BorderColor = Color.CornflowerBlue; // Viền sáng trở lại
        }
        #endregion

       
    }

}


    
    



