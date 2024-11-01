using rmbh.Entity.Enums;
using rmbh_backoffice.MVC.Models.Dtos.Users;

namespace rmbh_backoffice.MVC.Views.User
{
    public partial class UserAddModal : Form
    {
        public UserRequest UserRequest { get; set; } = new UserRequest();

        public UserAddModal()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UserAddModal_Load(object sender, EventArgs e)
        {
            comboBox_Role.DataSource = Enum.GetValues(typeof(UserRole));

            dateTimePicker_CreatedDate.Value = DateTime.Now;
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

        private void button_Add_Click(object sender, EventArgs e)
        {
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
                "Do you want to create a user?",
                "Create Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
