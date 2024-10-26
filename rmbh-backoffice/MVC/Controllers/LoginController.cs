using rmbh_backoffice.MVC;
using rmbh_backoffice.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace rmbh_backoffice.MVC.Controllers
{
    public class LoginController : Controller
    {
        private IView? _view;
        private LoginView? _loginView;

        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new LoginView();
                }

                if (_view is LoginView loginView)
                {
                    _loginView = loginView;
                    _loginView.ButtonLogin.Click += OnLoginAttempt;
                }

                return _view;
            }
        }

        public override bool Loadable()
        {
            return true;
        }

        private void OnLoginAttempt(object sender, EventArgs e)
        {
            // Kiểm tra _loginView có null hay không trước khi sử dụng
            if (_loginView != null)
            {
                string username = _loginView.TextBoxUserName.Text;
                string password = _loginView.TextBoxPassword.Text;

                if (isLoginValid(username, password) == true)
                {
                    AppManager.Instance.Load<HomeController>();
                }

                if (isLoginValid(username, password) == false)
                {
                    // Thông báo lỗi đăng nhập
                    showLoginError("Username or password is incorrect.");

                    // Làm nổi bật các ô nhập liệu
                    sighlightInputFields();
                }
            }   
        }

        private bool isLoginValid(string username, string password)
        {
            // Check username + pass + role trong Database
            // Và sẽ chuyển xuống phần 
            return username == "admin" && password == "1"; 
        }

        private void showLoginError(string message)
        {
            MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void sighlightInputFields()
        {
            _loginView.PanelUserName.BackColor = Color.Red; // Làm đỏ ô nhập username
            _loginView.PanelPassword.BackColor = Color.Red; // Làm đỏ ô nhập password
        }
    }
}
