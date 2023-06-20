namespace BusinessLayer
{
    /// <summary>
    /// The interface contains methods to be implemented in BALValidation class
    /// </summary>
    public interface IBALValidations
    {
        public bool ValidatePassword(string password);
        public bool ValidateUsername(string username);
        public bool ValidateEmail(string username);
    }
}
