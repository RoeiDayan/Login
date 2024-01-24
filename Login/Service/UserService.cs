using Login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Mac;

namespace Login.Service
{
    public class UserService
    {
        public List<User> users { get; private set; }
        public UserService() 
        {     
            this.users = new List<User>();
            FillList();
        
        }
        private void FillList()
        {
            users.Add(new User
            {
                name = "Amitay",
                password = "password"
            });
            users.Add(new User
            {
                name = "Sagi",
                password = "password"
            });
            users.Add(new User
            {
                name = "Ori",
                password = "password"
            });
            users.Add(new User
            {
                name = "Ofer",
                password = "king"
            });
        }
        //public bool LoginSucceeded()
        //{
            
        //}



    }
}
