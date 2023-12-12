using System.Windows.Forms;
using WarehouseApp.Model;
using WarehouseApp.Model.Repo;

namespace WarehouseApp.Controller
{
    public class UserController
    {
        private Connection connection;
        private UserRepository repository;
        public UserController(Connection _connection)
        {
            connection = _connection;
            repository = new UserRepository(connection);
        }



        public int SignIn(User user)
        {
            int result = 0;


            if (string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password))
            {
                MessageBox.Show("Username or Password Incorrect!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (Connection connect = new Connection())
            {
                result = repository.SignIn(user);
            }

            if (result != 1)
            {
                MessageBox.Show("Username or Password Not Found!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            return result;
        }
    }
}