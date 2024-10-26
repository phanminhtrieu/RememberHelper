using rmbh_backoffice.MVC;
using rmbh_backoffice.MVC.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmbh_backoffice.MVC.Views
{
    public partial class LoginView : Form, IView
    {
        public TextBox TextBoxUserName => textBox_Username;
        public TextBox TextBoxPassword => textBox_Password;
        public Panel PanelUserName => panel_UserName;
        public Panel PanelPassword => panel_Password;
        public Button ButtonLogin => button_Login;

        public LoginView()
        {
            InitializeComponent();
        }

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
    }
}
