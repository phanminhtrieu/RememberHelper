using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Views
{
    public interface IView
    {
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
