using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning03
{
   public class LoginModel:EventArgs
    {
       public string UserName
       {
           get; set;
           
       }

       public string Password
       {
           get; set;
       }

       public bool IsLogin
       {
           get; set;
       }
    }
}
