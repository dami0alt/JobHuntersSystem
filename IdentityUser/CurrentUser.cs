using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityUser
{
    public static class CurrentUser
    {
        public static User MainUser { get; set; }
    }

    public class User
    {
        public int idUser { get; set; }
        public string CodeUser { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        //Path Image
        public string Photo { get; set; }
        public int AccesLevel { get; set; }
        public string DescRank { get; set; }]
    }
}
