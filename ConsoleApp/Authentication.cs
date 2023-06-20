using BusinessLayer;
using BusinessModels;

namespace ConsoleApp
{
    /// <summary>
    /// This class will call signup or login method of business layer based on the input
    /// </summary>
    public class Authentication
    {
        BALFactory businessLogicFactory = new BALFactory();
        /// <summary>
        /// The signup method will take input detils from user and validate the user details and calls the sign up method in business layer
        /// </summary>
        public void Signup()
        {
            User userObj = new User();

            IBALValidations valid = businessLogicFactory.GetBALValidationObj();

            InputOutput inputOutput = new InputOutput();

            bool isValid = false;

            inputOutput.Display(Literals.username);
            userObj.Username = inputOutput.ReadInput();
            isValid = valid.ValidateUsername(userObj.Username);

            while (!isValid)
            {
                inputOutput.Display(Literals.validUsername);
                userObj.Username = inputOutput.ReadInput();
                isValid = valid.ValidateUsername(userObj.Username);
            }

            inputOutput.Display(Literals.password);
            userObj.Password = inputOutput.ReadInput();
            isValid = valid.ValidatePassword(userObj.Password);

            while (!isValid)
            {
                inputOutput.Display(Literals.validPassword);
                userObj.Password = inputOutput.ReadInput();
                isValid = valid.ValidatePassword(userObj.Password);
            }

            inputOutput.Display(Literals.email);
            userObj.Email = inputOutput.ReadInput();
            isValid = valid.ValidateEmail(userObj.Email);

            while (!isValid)
            {
                inputOutput.Display(Literals.validEmail);
                userObj.Email = inputOutput.ReadInput();
                isValid = valid.ValidateEmail(userObj.Email);
            }

            IBALAuthentication ibalobj = businessLogicFactory.GetBALAuthObj();

            ibalobj.SignUp(userObj);

            inputOutput.Display(Literals.signupSuccess);

        }
        /// <summary>
        /// This method will take input from user and call the login method in business layer
        /// </summary>
        public void Login()
        {
            User userObj = new User();

            InputOutput inputOutput = new InputOutput();

            inputOutput.Display(Literals.username);
            userObj.Username = inputOutput.ReadInput();
            inputOutput.Display(Literals.password);
            userObj.Password = inputOutput.ReadInput();

            IBALAuthentication ibalobj = businessLogicFactory.GetBALAuthObj();
            bool isCorrect = ibalobj.Login(userObj);

            if (isCorrect)
            {
                inputOutput.Display(Literals.loginSuccess);
                inputOutput.Display(Literals.logout);
                string input = inputOutput.ReadInput();

                if (input == "Yes")
                {
                    inputOutput.Display(Literals.logoutSuccess);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                inputOutput.Display(Literals.invalidLogin);
            }

        }

        /// <summary>
        /// This method will take input details from user and calls the forgotpassword method in business layer 
        /// </summary>
        public void ForgotPassword()
        {
            User userObj = new User();

            InputOutput inputOutput = new InputOutput();

            inputOutput.Display(Literals.username);
            userObj.Username = inputOutput.ReadInput();
            inputOutput.Display(Literals.email);
            userObj.Email = inputOutput.ReadInput();

            IBALAuthentication ibalobj = businessLogicFactory.GetBALAuthObj();
            bool isCorrect = ibalobj.ForgotPassword(userObj);

            if (isCorrect)
            {
                bool isValid = false;

                IBALValidations valid = businessLogicFactory.GetBALValidationObj();

                inputOutput.Display(Literals.newPassword);
                userObj.Password = inputOutput.ReadInput();
                isValid = valid.ValidatePassword(userObj.Password);

                while (!isValid)
                {
                    inputOutput.Display(Literals.validPassword);
                    userObj.Password = inputOutput.ReadInput();
                    isValid = valid.ValidatePassword(userObj.Password);
                }

                ibalobj.UpdatePassword(userObj);

                inputOutput.Display(Literals.passwordUpdateSuccess);
            }
            else
            {
                inputOutput.Display(Literals.invalidDetails);
            }
        }

        /// <summary>
        /// This method will close the application
        /// </summary>
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
