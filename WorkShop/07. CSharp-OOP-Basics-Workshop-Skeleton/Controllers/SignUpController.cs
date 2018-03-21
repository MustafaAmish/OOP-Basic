using System;
using Forum.App.Services;
using Forum.App.UserInterface;

namespace Forum.App.Controllers
{
	using Forum.App;
	using Forum.App.Controllers.Contracts;
	using Forum.App.UserInterface.Contracts;

	public class SignUpController : IController, IReadUserInfoController
	{
	    private enum Command
	    {
	        ReadUsername,ReadPassword,SingUp,Back
	    }

        public enum SingUpStatus
        {
            Success, DetailsError,UsernameTakenError
        }

		private const string DETAILS_ERROR = "Invalid Username or Password!";
		private const string USERNAME_TAKEN_ERROR = "Username already in use!";
	    public string ErrorMassage { get; set; }
	    public string Username { get; set; }
	    public string Password { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.ReadUsername:ReadUsername();
                    return MenuState.Signup;
                case Command.ReadPassword:ReadPassword();
                    return MenuState.Signup;
                case Command.SingUp:
                    var signUp = UserService.TrySignUpUser(this.Username, this.Password);
                    switch (signUp)
                    {
                        case SingUpStatus.Success:
                            return MenuState.SuccessfulLogIn;
                          
                        case SingUpStatus.DetailsError:
                            this.ErrorMassage = DETAILS_ERROR;
                            return MenuState.Error;
                        case SingUpStatus.UsernameTakenError:
                            this.ErrorMassage = USERNAME_TAKEN_ERROR;
                            return MenuState.Error;
                    }
                    
                    return MenuState.Error;
                case Command.Back:ResetSingUp(); return MenuState.Back;
            }
            throw new InvalidOperationException();
        }

        public IView GetView(string userName)
        {
            return new SignUpView(this.ErrorMassage);
        }

        public void ReadPassword()
        {
            this.Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
            this.Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

	    private void ResetSingUp()
	    {
	        this.ErrorMassage = string.Empty;
	        this.Username = string.Empty;
	        this.Password = string.Empty;
	    }
    }
}
