using rmbh_backoffice.MVC.Models.Dtos.Cards;
using rmbh_backoffice.MVC.Models.Services.Cards;
using rmbh_backoffice.MVC.Views;
using rmbh_backoffice.MVC.Views.Learning.Card;
using rmbh_backoffice.MVC.Views.User;

namespace rmbh_backoffice.MVC.Controllers.Learning.Card
{
    public class CardController : BaseController
    {
        private CardView _cardView { get; set; } = new CardView();
        private IView? _view;
        private ICardService? _cardService;

        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new CardView();
                }
                if (_view is CardView cardView)
                {
                    _cardView = cardView;
                    _cardView.Form.Load += Form_Load;
                    _cardView.AddButton.Click += AddButton_Click;
                    _cardView.DataGridView.CellContentClick += DataGridView_CellContenClick;
                    _cardView.DataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
                    _cardView.TextBoxSearching.TextChanged += TextBox_Search_TextChanged;
                }   

                return _view ?? new CardView();
            }
        }

        public CardController(ICardService cardService) 
        {
            _cardService = cardService;
        }

        private void TextBox_Search_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridView_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            addingOrderNumberValue();
        }

        private void addingOrderNumberValue()
        {
            for (int i = 0; i < _cardView.DataGridView.RowCount; i++)
            {
                _cardView.DataGridView.Rows[i].Cells["numberColumn"].Value = i + 1;
            }
        }

        private void DataGridView_CellContenClick(object? sender, DataGridViewCellEventArgs e)
        {
            //if (_cardView != null)
            //{
            //    // Kiểm tra nếu người dùng nhấn vào cột "Edit"
            //    if (e.ColumnIndex == _cardView.DataGridView.Columns["button_Edit"].Index && e.RowIndex >= 0)
            //    {
            //        CardDto? card = _cardView.DataGridView.Rows[e.RowIndex].DataBoundItem as CardDto;

            //        if (card != null)
            //        {
            //            //var cardEditModal = new CardEditModal(card);

            //            if (cardEditModal.ShowDialog() == DialogResult.OK)
            //            {
            //                var updatedRecord = _cardService.Update(cardEditModal.CardRequest.Id, cardEditModal.CardRequest);

            //                if (updatedRecord > 0)
            //                {
            //                    MessageBox.Show($"Update Card {cardEditModal.CardRequest.Id} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Nothing to edited. Please try again.", "Nothing Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }

            //                LoadData();
            //            }
            //        }
            //    }

            //    // Kiểm tra nếu người dùng nhấn vào cột "Delete"
            //    if (e.ColumnIndex == _cardView.DataGridView.Columns["button_Delete"].Index && e.RowIndex >= 0)
            //    {
            //        CardDto? card = _cardView.DataGridView.Rows[e.RowIndex].DataBoundItem as CardDto;

            //        if (card != null)
            //        {
            //            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //            if (result == DialogResult.Yes)
            //            {
            //                var deletedRecord = _cardService.Delete(card.Id);

            //                if (deletedRecord > 0)
            //                {
            //                    MessageBox.Show($"Delete Card {card.Id} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Nothing to delete. Please try again.", "Nothing deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }

            //                LoadData();
            //            }
            //        }
            //    }
            //}
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            //var cardAddModal = new CardAddModal();

            //if (cardAddModal.ShowDialog() == DialogResult.OK)
            //{
            //    var addedRecord = _cardService.Add(cardAddModal.CardRequest);

            //    if (addedRecord > 0)
            //    {
            //        MessageBox.Show("Card added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No card was added. Please try again.", "Nothing added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //    LoadData();
            //}
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
            _cardView.DataGridView.Columns.Insert(0, numberColumn);

            // Thêm cột ID nhưng ẩn đi để có thể lấy data nhưng không show ra
            DataGridViewTextBoxColumn cardIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false,
            };
            _cardView.DataGridView.Columns.Insert(1, cardIdColumn);

            LoadData();

            addingEditButtonAndDeleteButtonIntoDataGridView();
        }

        public override bool Loadable()
        {
            return true;
        }

        public void LoadData()
        {
            if (_cardView != null)
            {
                if (_cardService != null)
                {
                    List<CardDto> cards = _cardService.GetAll();

                    _cardView.DataGridView.DataSource = cards;
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
            _cardView.DataGridView.Columns.Add(editButtonColumn);

            // Thêm cột chứa nút "Delete"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "button_Delete";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản trong các ô
            _cardView.DataGridView.Columns.Add(deleteButtonColumn);
        }
    }
}
