using DataLayer;
using BusinessModels;

namespace BusinessLayer
{
    /// <summary>
    /// This class performs business layer operations like signup login and logout and change password if we forgot password.
    /// </summary>
    public class BALAuthentication : IBALAuthentication
    {
        DALFactory dataLogicFactory = new DALFactory();
        /// <summary>
        /// the signup method will will add user details by calling adddata method in data layer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        public void SignUp(User userObj)
        {
            IDALAuthentication idalobj = dataLogicFactory.GetDALAuthobj();
            idalobj.AddData(userObj);
        }

        /// <summary>
        /// the login method logs in user by checking  whether the input credential are true or not by calling validatelogin method of data layer and also logsout the user 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(User userObj)
        {
            IDALAuthentication idalobj = dataLogicFactory.GetDALAuthobj();
            bool isCorrect = idalobj.ValidateLogin(userObj);

            return isCorrect;
        }
        /// <summary>
        /// This method will allow user to
        /// </summary>
        /// <returns></returns>
        public bool ForgotPassword(User userObj)
        {
            IDALAuthentication idalobj = dataLogicFactory.GetDALAuthobj();
            bool isCorrect = idalobj.ValidateUser(userObj);

            return isCorrect;

        }

        public void UpdatePassword(User userObj)
        {
            IDALAuthentication idalobj = dataLogicFactory.GetDALAuthobj();
            idalobj.UpdatePassword(userObj);
        }
    }
}