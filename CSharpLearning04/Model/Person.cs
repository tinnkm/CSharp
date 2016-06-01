using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning04.Model
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }

        public int Id
        {
            get; set;
            
        }

        public string UserName
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }
    }
}
