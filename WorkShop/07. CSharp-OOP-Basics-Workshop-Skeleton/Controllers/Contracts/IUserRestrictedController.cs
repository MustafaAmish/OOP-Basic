namespace Forum.App.Controllers.Contracts
{
    public interface IUserRestrictedController
    {
        bool LoggedInUser { get; }

         //string Username { get; set; }
        void UserLogIn();

        void UserLogOut();
    }
}
