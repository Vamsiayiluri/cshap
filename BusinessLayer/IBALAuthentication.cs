using BusinessModels;

namespace BusinessLayer
{
    /// <summary>
    /// This interface contains methods to be implemented in BALAuthentication class
    /// </summary>
    public interface IBALAuthentication
    {
        public void SignUp(User userObj);
        public bool Login(User userObj);
        public bool ForgotPassword(User userObj);
        public void UpdatePassword(User userObj);
    }
}
