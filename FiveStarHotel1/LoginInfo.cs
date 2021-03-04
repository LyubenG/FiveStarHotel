using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FiveStarHotel1
{
    class LoginInfo
    {
        bool admin = false;
        public void AdminRights(bool isadmin)
        {
            if (isadmin)
            {
                admin = true;
            }
        }
        public bool HasAdminRights()
        {
            return admin;
        }
    }
}
