using System.Windows.Forms;

namespace rmbh_backoffice.MVC.Views
{
    public partial class BaseChildForm : Form
    {
        private Panel _panelOperation;
        private Panel _panelDataGrid;
        private DataGridView _dataGridView;

        public BaseChildForm()
        {
            InitializeComponent();
            //this.Load += BaseChildForm_Load;

            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn border
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí xuất hiện

            this.Padding = new Padding(2, 2, 2, 2);               // Đặt padding cho form
            this.BackColor = Color.Gainsboro;
        }

        private void BaseChildForm_Load(object sender, EventArgs e)
        {
            // Tạo panel cho phần operation (trên cùng)
            _panelOperation = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60, // Chiều cao có thể tùy chỉnh
                BackColor = Color.LightGray
            };

            // Tạo panel cho phần DataGridView (dưới cùng)
            _panelDataGrid = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // Tạo DataGridView và thêm vào panelDataGrid
            _dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true
            };

            _panelDataGrid.Controls.Add(_dataGridView);

            // Thêm các panel vào form
            this.Controls.Add(_panelDataGrid);
            this.Controls.Add(_panelOperation);

            // Gọi hàm để tùy chỉnh các control trên panelOperation nếu cần
            CustomizeOperationPanel();
        }

        private void CustomizeOperationPanel()
        {
            // Thêm các control vào panelOperation, ví dụ: button, textbox cho phần thao tác
            Button button_Add = new Button
            {
                Text = "Add",
                Dock = DockStyle.Left,
                Width = 100,
                Margin = new Padding(20, 0, 20, 0)
            };

            button_Add.Click += BtnAction_Click;

            _panelOperation.Controls.Add(button_Add);

            TextBox textbox_Search = new TextBox
            {
                Dock = DockStyle.Top,  // Đặt TextBox chiếm toàn bộ chiều ngang ở trên cùng
                Height = 30,           // Chiều cao của TextBox
                Margin = new Padding(10), // Khoảng cách giữa TextBox và các control khác
                PlaceholderText = "Search...", // Text hiển thị khi TextBox trống (chỉ có sẵn từ .NET 5 trở lên)
                Font = new Font("Arial", 12), // Chọn font chữ và kích thước
                ForeColor = Color.Black, // Màu chữ
                BackColor = Color.White,  // Màu nền
                BorderStyle = BorderStyle.FixedSingle // Kiểu viền
            };
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Action button clicked!");
        }
    }
}
