using System;
using System.Collections.Generic;
using System.Text;
using Forum.Models;

namespace Forum.Data
{
    public class ForumData
    {
        public  List<User> Users { get; set; }
        public List<Category> Categories { get; set; }
        public List<Reply> Replies { get; set; }
        public List<Post> Posts { get; set; }

        public ForumData()
        {
            Posts = DataMapper.LoadPosts();
            Users = DataMapper.LoadUser();
            Categories = DataMapper.LoadCategories();
            Replies = DataMapper.LoadReplies();
            
        }

        public void SaveChanges()
        {
            DataMapper.SaveCategories(Categories);
            DataMapper.SavePosts(Posts);
            DataMapper.SaveReplies(Replies);
            DataMapper.SaveUser(Users);
        }
    }
}
