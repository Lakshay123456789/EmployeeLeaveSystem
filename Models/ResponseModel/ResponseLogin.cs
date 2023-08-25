using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ResponseModel
{
    public class ResponseLogin
    {

       public string ? Token { get; set; }

       public string ? UserName { get; set; }
       
       public bool IsSuccess { get; set; }


    }
}
