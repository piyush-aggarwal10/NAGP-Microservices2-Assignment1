using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserBDC.Interfaces
{
    public interface IUserBDC
    {
        UserDTO GetUserDetails(int userId);
    }
}
