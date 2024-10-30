namespace rmbh_backoffice.MVC.Views
{
    public interface IView
    {
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
