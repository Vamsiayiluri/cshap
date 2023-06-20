namespace BusinessLayer
{
    /// <summary>
    /// This class contains methods to create objects for appropriate classes
    /// </summary>
    public class BALFactory
    {
        /// <summary>
        /// This method will create object for BALAuthentication class
        /// </summary>
        /// <returns></returns>
        public IBALAuthentication GetBALAuthObj()
        {
            return new BALAuthentication();
        }
        /// <summary>
        /// This method will create object for BALValidations class
        /// </summary>
        /// <returns></returns>
        public IBALValidations GetBALValidationObj()
        {
            return new BALValidations();
        }
    }
}
