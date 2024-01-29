using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    public class User
    {
        public string name {  get; set; }
        public string password {  get; set; }

        public User(string pass, string name) 
        {
            this.name = name;
            this.password = pass;
        }
        
        public bool compare(User other)
        {
            if(other == null) return false;
            if(other.name != name) return false;
            if(password != other.password) return false;
            return true;
        }
    }
}
