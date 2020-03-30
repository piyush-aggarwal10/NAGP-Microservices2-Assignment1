using Common;
using UserBDC.Interfaces;

namespace UserBDC.Classes
{
    public class UserBDC : IUserBDC
    {
        public UserDTO userDetails;

        public UserBDC()
        {
            CreateDummyUser();
        }

        public void CreateDummyUser()
        {
            UserDTO user1 = new UserDTO
            {
                Name = "Piyush Aggarwal",
                Age = 26,
                Email = "piyush.aggarwal02@nagarro.com"
            };

            userDetails = user1;
        }

        public UserDTO GetUserDetails(int userId)
        {
            return userDetails;
        }
    }
}
