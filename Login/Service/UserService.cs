using Login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            users.Add(new User("password", "Amitay"));

            users.Add(new User("password", "Sagi"));

            users.Add(new User("password", "Ori"));

            users.Add(new User("123" ,"Ofer"));
        }
        public bool TryLogin(User u)
        {
            
            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].compare(u)) 
                {
                    return true;
                }
            }
            return false;
        }



    }
}
