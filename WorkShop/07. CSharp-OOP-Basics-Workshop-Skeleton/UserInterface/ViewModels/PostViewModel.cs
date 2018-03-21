using System.Linq;
using Forum.App.Services;
using Forum.Models;

namespace Forum.App.UserInterface.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class PostViewModel
    {
        private const int LINE_LENGHT = 37;

        public PostViewModel()
        {
            Content=new List<string>();
        }

        public PostViewModel(Post post)
        {
            Author = UserService.GetUser(post.AuthorId).UserName;
            Category = PostService.GetCategory(post.CategoryId).Name;
            Title = post.Title;
            PostId = post.Id;
            this.Content = GetLines(post.Content);
            Replies = PostService.GetPostReplies(post.Id);
        }

        private IList<string> GetLines(string content)
        {
            var contentChars = content.ToCharArray();
            IList<string> lines=new List<string>();

            for (int i = 0; i < content.Length; i+=LINE_LENGHT)
            {
                var row = contentChars.Skip(i).Take(LINE_LENGHT).ToArray();
                string rowString = string.Join("", row);
                lines.Add(rowString);
            }
            return lines;
        }

        public int PostId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public IList<string> Content { get; set; }

        public IList<ReplyViewModel> Replies { get; set; }
    }
}
