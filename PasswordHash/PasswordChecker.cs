using System.Text;

namespace PasswordHash
{
    public class PasswordChecker : IPasswordChecker
    {
        private readonly TokenStorage _token;
        public PasswordChecker()
        {
            _token = new TokenStorage();
        }
        public string CheckUserPassword(UserLoginModel userType)
        {
            if (userType.Username == "Bob Martin" && (_token.BobMartinPasswordHash== userType.Password))
            {
                return _token.AdminToken;
            }
            if (userType.Username == "Tony Stark" && (_token.TonyStarkPasswordHash== userType.Password))
            {
                return _token.UserToken;
            }
            return String.Empty;
        }
     }
}