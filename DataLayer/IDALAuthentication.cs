using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// The interface contains the methods to be implemented by DALAuthentication class
    /// </summary>
    public interface IDALAuthentication
    {
        public void AddData(User userObj);
        public bool ValidateLogin(User userObj);
        public bool ValidateUser(User userObj);
        public void UpdatePassword(User userObj);
        public bool ValidateUsername(string Username);

    }
}
