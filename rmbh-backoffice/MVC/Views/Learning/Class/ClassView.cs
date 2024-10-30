namespace rmbh_backoffice.MVC.Views.Learning.Class
{
    public partial class ClassView : BaseChildForm, IView
    {
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

        public ClassView()
        {
            InitializeComponent();
        }
    }
}
