namespace rmbh_backoffice.MVC.Views
{
    public partial class BaseChildForm : Form
    {
        public BaseChildForm()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn border
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí xuất hiện

            this.Padding = new Padding(1);               // Đặt padding cho form
            this.BackColor = Color.Gainsboro;                 
        }
    }
}
