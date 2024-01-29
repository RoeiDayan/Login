using Login.Model;
using Login.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ViewModels
{
    public class LoginPageViewModel:ViewModelBase
    {   
        private string name;
        private string password;
        private string msg;
        private Color msgColor;
        public string Msg { get { return msg; } set { msg = value; OnPropertyChanged(); }}
        public string Name { get { return name; } set { name = value; OnPropertyChanged();  } }
        public string Password { get { return password; } set { password = value; OnPropertyChanged(); } }
        public Color MsgColor { get { return msgColor; } set { msgColor = value; OnPropertyChanged(); }}
        public Command LoginCheck { get; set; }
        public Command CancelCommand { get; set; }
        public LoginPageViewModel()
        {
            LoginCheck = new Command(LoginCommand);
            CancelCommand = new Command(Cancel);
        }
        private void Cancel()
        {
            Password = "";
            Name = "";
            msg = "";
            msgColor = Colors.Black;
        }
        private void LoginCommand()
        {
            User user = new User(this.password, this.name);
            UserService userService = new UserService();
            if (userService.TryLogin(user))
            {
                msg = "Succeded!";
                msgColor = Colors.Green;
            }
            else
            {
                msg = "Failed!";
                msgColor = Colors.Red;
            }

        }


    }
}
    