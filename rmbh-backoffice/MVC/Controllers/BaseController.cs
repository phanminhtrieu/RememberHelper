using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rmbh_backoffice.MVC.Views;

namespace rmbh_backoffice.MVC.Controllers
{
    public abstract class BaseController
    {
        public abstract IView View { get; }

        public event EventHandler LoadSuccess, LoadFailed;

        public BaseController()
        {
            LoadSuccess += OnLoadSucceededHandler;
            LoadFailed += OnLoadFailedHandler;
        }

        public abstract bool Loadable();

        public virtual void OnLoadSucceededHandler(object sender, EventArgs e)
        {
            AppManager.Instance.Show(this);
        }

        public virtual void OnLoadFailedHandler(object sender, EventArgs e)
        {
            if (MessageBox.Show("You don't have access to load this page.\nThe application will exit now.") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void OnLoadSuccess(EventArgs e)
        {
            if (LoadSuccess != null)
                LoadSuccess(this, e);
        }

        public void OnLoadFailure(EventArgs e)
        {
            if (LoadFailed != null)
                LoadFailed(this, e);
        }
    }
}
