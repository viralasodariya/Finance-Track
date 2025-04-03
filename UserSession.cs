using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Expense_Manager
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }

        public static void ClearSession()
        {
            UserId = 0;
            Username = null;
            Email = null;
        }
    }
}
