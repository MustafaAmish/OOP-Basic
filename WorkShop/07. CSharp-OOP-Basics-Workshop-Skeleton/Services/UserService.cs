using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Forum.Data;
using Forum.Models;
using static Forum.App.Controllers.SignUpController;

namespace Forum.App.Services
{
    public static class UserService
    {

        public static bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username)||string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            ForumData forumData=new ForumData();

            var userExists = forumData.Users.Any(u => u.UserName == username && u.Password == password);
            return userExists;
        }

        public static SingUpStatus TrySignUpUser(string username, string password)
        {
            bool validUsername = !string.IsNullOrWhiteSpace(username) && username.Length > 3;
            bool validPassword = !string.IsNullOrWhiteSpace(password) && password.Length > 3;

            if (!validPassword || !validUsername)
            {
                return SingUpStatus.DetailsError;
            }
            ForumData forumData = new ForumData();

            bool userAlreadyExists = forumData.Users.Any(u => u.UserName == username);

            if (!userAlreadyExists)
            {
                int userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
                var user = new User(userId, username, password, new List<int>());
                forumData.Users.Add(user);
                forumData.SaveChanges();
                return SingUpStatus.Success;

            }
            return SingUpStatus.UsernameTakenError;
        }

        public static User GetUser(int userId)
        {
            var forumData=new ForumData();
            var user = forumData.Users.Single(u => u.Id == userId);
            return user;
        }
    }
}
