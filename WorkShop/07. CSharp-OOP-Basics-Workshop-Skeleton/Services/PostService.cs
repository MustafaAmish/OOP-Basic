using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;

namespace Forum.App.Services
{
    public static class PostService
    {
        public static Category GetCategory(int categoryId)
        {
            var forumData = new ForumData();
            var category = forumData.Categories.Single(c => c.Id == categoryId);
            return category;
        }

        public static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Single(p => p.Id == postId);
            var replies = new List<ReplyViewModel>();
            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Single(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        public static string[] GetAllCategoryNames()
        {
            ForumData forumData = new ForumData();
            var allCategories = forumData.Categories.Select(c => c.Name).ToArray();
            return allCategories;
        }

        public static IEnumerable<Post> GetPostByCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            var postIds = forumData.Categories.FirstOrDefault(c => c.Id == categoryId).PostIds;
            IEnumerable<Post> posts = forumData.Posts.Where(p => postIds.Contains(p.Id));
            return posts;
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            ForumData forumData = new ForumData();
            var post = forumData.Posts.SingleOrDefault(p => p.Id == postId);
            return new PostViewModel(post);
        }

        private static Category EnsureCategory(PostViewModel postViewModel, ForumData forumData)
        {
            var categoryNAme = postViewModel.Category;
            Category category = forumData.Categories.SingleOrDefault(x => x.Name == categoryNAme);

            if (category == null)
            {
                var categories = forumData.Categories;
                int categoryId = categories.Any() ? categories.LastOrDefault().Id + 1 : 1;
                category = new Category(categoryId, categoryNAme, new List<int>());
                forumData.Categories.Add(category);
            }
            return category;
        }

        public static bool TrySavePost(PostViewModel postViewModel)
        {
            var isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
            var IsCategoryValid = !string.IsNullOrWhiteSpace(postViewModel.Category);
            var isContentValid = postViewModel.Content.Any();
            if (!isContentValid || !isTitleValid || !IsCategoryValid)
            {
                return false;
            }

            ForumData forumData = new ForumData();
           var category= EnsureCategory(postViewModel, forumData);

            var postId = forumData.Posts.LastOrDefault()?.Id + 1 ?? 1;
            var author = forumData.Users.SingleOrDefault(u => u.UserName == postViewModel.Author);
            var content = string.Join("", postViewModel.Content);
            var post=new Post(postId,postViewModel.Title,content,category.Id, author.Id, new List<int>() );
            forumData.Posts.Add(post);
            category.PostIds.Add(postId);
            author.PostIds.Add(postId);
            forumData.SaveChanges();
            postViewModel.PostId = postId;
            return true;
        }
    }
}
