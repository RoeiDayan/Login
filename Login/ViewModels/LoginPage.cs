using Login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Java.Util.Jar.Attributes;

namespace Login.ViewModels
{
    public class LoginPage:ViewModelBase
    {
        public string name;
        public string password;
        public string Name { get { return name; } set { OnPropertyChanged(); name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public Command LoginCheck { get; set; }
        public LoginPage()
        {
            LoginCheck = new Command();
        
        }
        private void GetDetails()
        {
            User user = new User();

        }

    }
}
    