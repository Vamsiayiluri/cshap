using DataLayer;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    /// <summary>
    /// This class validates whether the given input from the user is valid or not
    /// </summary>
    public class BALValidations : IBALValidations
    {
        /// <summary>
        /// this method validates whether the password entered is valid or not
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()_+=\[{\]};:<>|./?,-])[A-Za-z\d!@#$%^&*()_+=\[{\]};:<>|./?,-]{8,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(password);
            return match.Success;
        }
        /// <summary>
        /// this method validates whether the username entered is valid or not
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool ValidateUsername(string username)
        {
            DALFactory dataLogicFactory = new DALFactory();
            IDALAuthentication idalobj = dataLogicFactory.GetDALAuthobj();
            return idalobj.ValidateUsername(username);
        }
        /// <summary>
        /// This method validates whether email id contains @gmail.com or not
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            string pattern = @"^[\w]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
