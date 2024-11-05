using rmbh_backoffice.MVC.Models.Dtos.Decks;
using rmbh_backoffice.MVC.Models.Services.Classes;
using rmbh_backoffice.MVC.Models.Services.Decks;
using rmbh_backoffice.MVC.Views;
using rmbh_backoffice.MVC.Views.Learning.Deck;
using rmbh_backoffice.MVC.Views.User;

namespace rmbh_backoffice.MVC.Controllers.Learning.Deck
{
    public class DeckController : BaseController
    {
        private DeckView _deckView { get; set; } = new DeckView();
        private DeckAddModal _deckAddModal { get; set; }
        private DeckEditModal _deckEditModal { get; set; }
        private IView? _view;
        private IDeckService _deckService;
        private IClassService _classService;


        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new DeckView();
                }
                if (_view is DeckView deckView)
                {

                    _deckView = deckView;
                    _deckView.Form.Load += Form_Load;
                    _deckView.AddButton.Click += AddButton_Click;
                    _deckView.DataGridView.CellContentClick += DataGridView_CellContenClick;
                    _deckView.DataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
                    _deckView.TextBox.TextChanged += TextBox_Search_TextChanged;
                }

                return _view;
            }
        }

        public DeckController(IDeckService deckService, IClassService classService)
        {
            _deckService = deckService;
            _classService = classService;
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
            _deckView.DataGridView.Columns.Insert(0, numberColumn);

            // Thêm cột Id nhưng ẩn đi để có thể lấy data nhưng không show ra
            DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false,
            };
            _deckView.DataGridView.Columns.Insert(1, userIdColumn);

            //hiện thị db còn lại
            LoadData();
            //theem 2 nuts delete and edit

            addingEditButtonAndDeleteButtonIntoDataGridView();

        }

        private void LoadData()
        {
            if (_deckView != null)
            {
                List<DeckDto> decks = _deckService.GetAll();

                _deckView.DataGridView.DataSource = decks;
            }
        }

        public override bool Loadable()
        {
            return true;
        }

        private void DataGridView_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            addingOrderNumberValue();
        }

        private void TextBox_Search_TextChanged(object? sender, EventArgs e)
        {
            //if (_deckView != null)
            //{
            //    string searchValue = _deckView.TextBox.Text.ToLower();
            //    var filteredUsers = _deckView.GetAll().Where(user =>
            //        user.Email.ToLower().Contains(searchValue) ||
            //        user.FisrtName.ToLower().Contains(searchValue) ||
            //        user.LastName.ToLower().Contains(searchValue)).ToList();

            //    _deckView.DataGridView.DataSource = filteredUsers; // Cập nhật DataSource với danh sách đã lọc
            //}
        }

        private void DataGridView_CellContenClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            _deckAddModal = new DeckAddModal();

            _deckAddModal.Load += DeckAddModal_Load;
            

            if (_deckAddModal.ShowDialog() == DialogResult.OK)
            {
                var addedRecord = _deckService.Add(_deckAddModal.DeckRequest);

                if (addedRecord > 0)
                {
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No deck was added. Please try again.", "Nothing added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
            }
        }

        private void DeckAddModal_Load(object? sender, EventArgs e)
        {
            if(_deckAddModal != null) 
            {
                if(_classService != null)
                {
                    var classes = _classService.GetAll();

                    _deckAddModal.ComboBoxClassTitle.DataSource = classes;
                    _deckAddModal.ComboBoxClassTitle.DisplayMember = "Title";
                    _deckAddModal.ComboBoxClassTitle.ValueMember = "Id";
                }
            }
        }

        private void addingEditButtonAndDeleteButtonIntoDataGridView()
        {
            // Thêm cột chứa nút "Edit"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "button_Edit";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản trong các ô
            _deckView.DataGridView.Columns.Add(editButtonColumn);

            // Thêm cột chứa nút "Delete"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "button_Delete";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản trong các ô
            _deckView.DataGridView.Columns.Add(deleteButtonColumn);
        }

        private void addingOrderNumberValue()
        {
            for (int i = 0; i < _deckView.DataGridView.RowCount; i++)
            {
                _deckView.DataGridView.Rows[i].Cells["numberColumn"].Value = i + 1;
            }
        }

    }
}

