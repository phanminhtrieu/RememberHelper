using rmbh_backoffice.MVC.Controllers;
using rmbh_backoffice.MVC.Views;

namespace rmbh_backoffice.MVC
{
    public class AppManager
    {
        private static bool _started;

        private static AppManager _instance;

        public static AppManager Instance
        {
            get
            {
                if (!_started)
                    throw new Exception("Tried to call the singleton instance of the AppManager before the AppManager started.");

                return _instance;
            }
        }

        /// <summary>
        /// The current WinForms-Form instance
        /// </summary>
        private IView _currentView;

        /// <summary>
        /// The current WinForms-Child-Form instance
        /// </summary>
        private IView _currentChildView;

        /// <summary>
        /// The controller factory for creating controllers
        /// </summary>
        private readonly ControllerFactory _controllerFactory;

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private AppManager(ControllerFactory controllerFactory)
        {
            _controllerFactory = controllerFactory;
        }

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private AppManager() { }

        /// <summary>
        /// Starts the AppManager and creates a singleton for this class
        /// </summary>
        public static void Start<T>(ControllerFactory controllerFactory) where T : BaseController
        {
            if (_started) return;

            _started = true;

            // Create Controller with ControllerFactory
            T controller = controllerFactory.CreateController<T>();

            if (controller != null)
            {
                _instance = new AppManager(controllerFactory)
                {
                    _currentView = controller.View
                };

                _instance.openForm();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Loads a Controller, handles the loading state
        /// </summary>
        /// <typeparam name="T">Generic Type where T extends Controller</typeparam>
        public void Load<T>() where T : BaseController
        {
            T controller = _controllerFactory.CreateController<T>();

            if (controller != null)
            {
                if (controller.Loadable())
                {
                    controller.OnLoadSuccess(EventArgs.Empty);
                }
                else
                {
                    controller.OnLoadFailure(EventArgs.Empty);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Shows the View of the Controller parameter  
        /// </summary>
        /// <param name="controller">The controller instance</param>
        public void Show(BaseController controller)
        {
            if (_currentView != null)
            {
                closeForm();
            }

            _currentView = controller.View;

            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void LoadChildView<T>() where T : BaseController
        {
            var controller = _controllerFactory.CreateController<T>();

            if (controller != null)
            {
                ShowChildView(controller.View);
            }
        }

        private async void ShowChildView(IView childView) 
        {
            if (_currentChildView != null)
            {
                closeChildForm();
            }

            _currentChildView = childView;
            var childForm = _currentChildView.Form;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            await Task.Delay(500);

            // Lấy panel_ContentContainer từ _currentView
            var panelContentContainer = _currentView.Form.Controls["panel_ContentContainer"] as Panel;
            if (panelContentContainer != null)
            {
                var panelBody = panelContentContainer.Controls["panel_Body"] as Panel;

                if (panelBody != null)
                {
                    // Lấy panel_Body từ panel_ContentContainer

                    // Xóa tất cả controls hiện tại trong panel_Body
                    panelBody.Controls.Clear();

                    // Thiết lập thuộc tính cho childForm
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;

                    // Thêm childForm vào panel_Body
                    panelBody.Controls.Add(childForm);
                    childForm.BringToFront();

                    childForm.Show();
                }
            }
        }

        private void closeForm()
        {
            _currentView.Close();
            _currentView.Form.Dispose();
        }

        private void closeChildForm()
        {
            //_currentChildView.Close();
            _currentChildView.Form.Dispose();
        }

        /// <summary>
        /// Used as single-threaded appartment thread-callback to keep the main thread running
        /// </summary>
        private void openForm()
        {
            Application.Run(_currentView.Form);
        }
    }
}
