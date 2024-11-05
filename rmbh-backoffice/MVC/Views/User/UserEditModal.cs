using rmbh.Entity.Enums;
using rmbh_backoffice.MVC.Models.Dtos.Users;

namespace rmbh_backoffice.MVC.Views.User
{
    public partial class UserEditModal : Form
    {
        private readonly UserGetAllDto _user;
        public UserRequest UserRequest { get; set; } = new UserRequest();

        public UserEditModal(UserGetAllDto user)
        {
            InitializeComponent();

            _user = user;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UserEditModal_Load(object sender, EventArgs e)
        {
            comboBox_Role.DataSource = Enum.GetValues(typeof(UserRole));

            // Show
            textBox_Id.Text = _user.Id.ToString();
            textBox_FirstName.Text = _user.FisrtName;
            textBox_LastName.Text = _user.LastName;
            textBox_Email.Text = _user.Email;
            textBox_Password.Text = _user.Password;
            textBox_Bio.Text = _user.Bio;
            comboBox_Role.SelectedItem = _user.Role;
            dateTimePicker_CreatedDate.Value = _user.CreatedDate;
            dateTimePicker_ModifiedDate.Value = DateTime.Now;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit? Unsaved changes will be lost!",
                "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            UserRequest.Id = Guid.Parse(textBox_Id.Text);
            UserRequest.FirstName = textBox_FirstName.Text;
            UserRequest.LastName = textBox_LastName.Text;
            UserRequest.Email = textBox_Email.Text;
            UserRequest.Password = textBox_Password.Text;
            UserRequest.Bio = textBox_Bio.Text;
            UserRequest.Role = (UserRole)comboBox_Role.SelectedItem;
            UserRequest.CreatedDate = dateTimePicker_CreatedDate.Value;
            UserRequest.ModifiedDate = dateTimePicker_ModifiedDate.Value;

            this.DialogResult = DialogResult.OK; // Thiết lập kết quả modal là OK

            DialogResult result = MessageBox.Show(
                "Do you want to save your changes?",
                "Save changes Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UserEditModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show(
            //    "Are you sure you want to exit? Unsaved changes will be lost!",
            //    "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
