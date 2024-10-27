namespace rmbh_backoffice.MVC.Views
{
    public partial class LoginView : Form, IView
    {
        public TextBox TextBoxUserName => textBox_Username;
        public TextBox TextBoxPassword => textBox_Password;
        public Panel PanelUserName => panel_UserName;
        public Panel PanelPassword => panel_Password;
        public Button ButtonLogin => button_Login;

        // Make sure each IView should have a Form
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

        public LoginView()
        {
            InitializeComponent();
        }

        private void button_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_Passwordshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Passwordshow.Checked == true)
            {
                textBox_Password.UseSystemPasswordChar = false;
                return;
            }
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
