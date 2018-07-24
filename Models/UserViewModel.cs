using System.ComponentModel.DataAnnotations;

namespace CoreEditor.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public UserViewModel() { }

        public UserViewModel(User user)
        {
            ID = user.ID;
            Login = user.Login;
        }

        public void Apply(User user)
        {
            user.Login = Login;
            if (!string.IsNullOrEmpty(Password))
            {
                user.Password = Password;
            }
        }
    }
}
