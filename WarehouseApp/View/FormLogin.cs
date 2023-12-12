using System.Threading;
using System.Windows.Forms;
using WarehouseApp.Controller;
using WarehouseApp.Model;

namespace WarehouseApp.View
{
    public partial class FormLogin : Form
    {
        private User user;
        private UserController controller;

        public FormLogin()
        {
            Connection _connection = new Connection();
            this.controller = new UserController(_connection);
            this.user = new User();

            InitializeComponent();

            TextPassword.UseSystemPasswordChar = true;
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            this.user.username = TextUsername.Text;
            this.user.password = TextPassword.Text;

            bool checking = ValidationLogin(this.user);

            if (checking)
            {
                Thread thread;
                this.Close();
                thread = new Thread(this.SetOpenForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        public bool ValidationLogin(User user) => (this.controller.SignIn(user) != 0) ? true : false;

        private void SetOpenForm() => Application.Run(new FormProducts());

        private void ButtonClose_Click(object sender, System.EventArgs e) => this.Close();
    }
}
