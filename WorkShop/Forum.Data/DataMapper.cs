using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Forum.Models;

namespace Forum.Data
{
    class DataMapper
    {
        private const string DATA_PATH = "../data/";
        private const string CONFIG_PATH = "config.ini";
        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv";

        private static readonly Dictionary<string, string> config;

        static DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);
        }

        private static void EnsureConfigFile(string configPath)
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath,DEFAULT_CONFIG);
            }
        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);
            var contents = ReadLines(configPath);
            var config = contents.Select(l => l.Split('=')).ToDictionary(t => t[0], t => DATA_PATH + t[1]);
            return config;
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            var lines = File.ReadAllLines(path);
            return lines;
        }
       
        private static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path,lines);
        }

        public static List<Category> LoadCategories()
        {
            var lines = ReadLines(config["categories"]);
            List<Category>categories=new List<Category>();
            foreach (var line in lines)
            {
                var splitLine = line.Split(';');
                var postids = splitLine[2].Split(',',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                var category=new Category(int.Parse(splitLine[0]),splitLine[1],postids);
                categories.Add(category);
            }
            return categories;
        }

        public static void SaveCategories(List<Category> categories)
        {
            List<string> lines=new List<string>();
            foreach (var category in categories)
            {
                const string categoryFormat = "{0};{1};{2}";
                string line=String.Format(categoryFormat,category.Id,category.Name,string.Join(", ",category.PostIds));

                lines.Add(line);
            }
            WriteLines(config["categories"], lines.ToArray());
        }

        public static List<User> LoadUser()
        {
            var lines = ReadLines(config["users"]);
            List<User> categories = new List<User>();
            foreach (var line in lines)
            {
                var splitLine = line.Split(';');
                var postids = splitLine[3].Split(',',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                var category = new User(int.Parse(splitLine[0]), splitLine[1], splitLine[2], postids);
                categories.Add(category);
            }
            return categories;
        }

        public static void SavePosts(List<Post> posts)
        {
            List<string> lines = new List<string>();
            foreach (var category in posts)
            {
                const string categoryFormat = "{0};{1};{2};{3};{4};{5}";
                string line = String.Format(categoryFormat, category.Id, category.Title, category.Content , category.CategoryId, category.AuthorId, string.Join(", ", category.ReplyIds));

                lines.Add(line);
            }
            WriteLines(config["posts"], lines.ToArray());
        }

        public static List<Post> LoadPosts()
        {
            var lines = ReadLines(config["posts"]);
            List<Post> categories = new List<Post>();
            foreach (var line in lines)
            {
                var splitLine = line.Split(';');
                var postids = splitLine[3].Split(',' /*StringSplitOptions.RemoveEmptyEntries*/).Select(int.Parse).ToList();
                var category = new Post(int.Parse(splitLine[0]), splitLine[1], splitLine[2], int.Parse(splitLine[3]), int.Parse(splitLine[4]), postids);
                categories.Add(category);
            }
            return categories;
        }

        public static void SaveUser(List<User> categories)
        {
            List<string> lines = new List<string>();
            foreach (var category in categories)
            {
                const string categoryFormat = "{0};{1};{2};{3}";
                string line = String.Format(categoryFormat, category.Id, category.UserName, category.Password, string.Join(", ", category.PostIds));

                lines.Add(line);
            }
            WriteLines(config["users"], lines.ToArray());
        }

        public static void SaveReplies(List<Reply> posts)
        {
            List<string> lines = new List<string>();
            foreach (var category in posts)
            {
                const string categoryFormat = "{0};{1};{2};{3}";
                string line = String.Format(categoryFormat, category.Id, category.Content, category.AuthorId, category.PostIds);

                lines.Add(line);
            }
            WriteLines(config["replies"], lines.ToArray());
        }

        public static List<Reply> LoadReplies()
        {
            var lines = ReadLines(config["replies"]);
            List<Reply> categories = new List<Reply>();
            foreach (var line in lines)
            {
                var splitLine = line.Split(';',StringSplitOptions.RemoveEmptyEntries);
                var category = new Reply(int.Parse(splitLine[0]),splitLine[1],  int.Parse(splitLine[2]), int.Parse(splitLine[3]));
                categories.Add(category);
            }
            return categories;
        }
    }
}
