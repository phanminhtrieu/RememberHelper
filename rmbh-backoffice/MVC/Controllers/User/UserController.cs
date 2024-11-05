using rmbh_backoffice.MVC.Models.Dtos.Users;
using rmbh_backoffice.MVC.Models.Services.Users;
using rmbh_backoffice.MVC.Views;
using rmbh_backoffice.MVC.Views.User;
using System.Windows.Forms;

namespace rmbh_backoffice.MVC.Controllers.User
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private IView? _view;
        private UserView? _userView;
        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new UserView();
                }

                if (_view is UserView userView)
                {
                    _userView = userView;
                    _userView.Form.Load += Form_Load;
                    _userView.AddButton.Click += AddButton_Click;
                    _userView.DataGridView.CellContentClick += DataGridView_CellContenClick;
                    _userView.DataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
                    _userView.TextBoxSearching.TextChanged += TextBox_Search_TextChanged;
                }

                return _view;
            }
        }

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public override bool Loadable()
        {
            return true;
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            // Thêm cột số thứ tự trước khi gán DataSource
            DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn
            {
                Name = "numberColumn",
                HeaderText = "No.",
                ReadOnly = true,
            };
            _userView.DataGridView.Columns.Insert(0, numberColumn);

            // Thêm cột Id nhưng ẩn đi để có thể lấy data nhưng không show ra
            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            };
            _userView.DataGridView.Columns.Insert(1, userIdColumn);

            LoadData();

            addingAddButtonAndEditButtonInToDataGridView();
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            var userAddModal = new UserAddModal();

            if (userAddModal.ShowDialog() == DialogResult.OK)
            {
                var addedRecord = _userService.Add(userAddModal.UserRequest);

                if (addedRecord > 0)
                {
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No user was added. Please try again.", "Nothing added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
            }
        }

        private void TextBox_Search_TextChanged(object? sender, EventArgs e)
        {
            if (_userView != null)
            {
                string searchValue = _userView.TextBoxSearching.Text.ToLower();

                var filteredUsers = _userService.GetAll().Where(user =>
                    user.Email.ToLower().Contains(searchValue) ||
                    user.FisrtName.ToLower().Contains(searchValue) ||
                    user.LastName.ToLower().Contains(searchValue)).ToList();

                _userView.DataGridView.DataSource = filteredUsers; // Cập nhật DataSource với danh sách đã lọc
            }
        }

        private void DataGridView_CellContenClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (_userView != null)
            {
                // Kiểm tra nếu người dùng nhấn vào cột "Edit"
                if (e.ColumnIndex == _userView.DataGridView.Columns["button_Edit"].Index && e.RowIndex >= 0)
                {
                    UserDto? user = _userView.DataGridView.Rows[e.RowIndex].DataBoundItem as UserDto;

                    if (user != null)
                    {
                        var userEditModal = new UserEditModal(user);

                        if (userEditModal.ShowDialog() == DialogResult.OK)
                        {
                            var updatedRecord = _userService.Update(userEditModal.UserRequest.Id, userEditModal.UserRequest);

                            if (updatedRecord > 0)
                            {
                                MessageBox.Show($"Update User {userEditModal.UserRequest.Id} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nothing to edited. Please try again.", "Nothing Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            LoadData();
                        }
                    }
                }

                // Kiểm tra nếu người dùng nhấn vào cột "Delete"
                if (e.ColumnIndex == _userView.DataGridView.Columns["button_Delete"].Index && e.RowIndex >= 0)
                {
                    UserDto? user = _userView.DataGridView.Rows[e.RowIndex].DataBoundItem as UserDto;

                    if (user != null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            var deletedRecord = _userService.Delete(user.Id);

                            if (deletedRecord > 0)
                            {
                                MessageBox.Show($"Delete User {user.Id} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nothing to delete. Please try again.", "Nothing deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            LoadData();
                        }
                    }
                }
            }
        }

        private void DataGridView_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            addingOrderNumberValue();
        }

        public void LoadData()
        {
            if (_userView != null)
            {
                var users = _userService.GetAll();

                _userView.DataGridView.DataSource = users;
            }
        }

        private void addingOrderNumberValue()
        {
            for (int i = 0; i < _userView.DataGridView.RowCount; i++)
            {
                _userView.DataGridView.Rows[i].Cells["numberColumn"].Value = i + 1;
            }
        }

        private void addingAddButtonAndEditButtonInToDataGridView()
        {
            // Thêm cột chứa nút "Edit"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "button_Edit";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản trong các ô
            _userView.DataGridView.Columns.Add(editButtonColumn);

            // Thêm cột chứa nút "Delete"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "button_Delete";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản trong các ô
            _userView.DataGridView.Columns.Add(deleteButtonColumn);
        }
    }
}
