namespace DataLayer
{
    /// <summary>
    /// this class contains 
    /// </summary>
    public class DALFactory
    {
        /// <summary>
        /// This method will create objects for the DALAuthentication class
        /// </summary>
        /// <returns></returns>
        public IDALAuthentication GetDALAuthobj()
        {
            return new DALAuthentication();
        }

    }
}
