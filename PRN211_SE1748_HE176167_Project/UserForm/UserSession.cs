using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace UserForm
{
    public static partial class UserSession
    {

        public static User SessionUser { get; set; }

        

        public static void SetSessionEmployee(User user)
        {
            SessionUser = user;
        }

       

        public static void ClearSession()
        {
            SessionUser = null;
        }
    }
}