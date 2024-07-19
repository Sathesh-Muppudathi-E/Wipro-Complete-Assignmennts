using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day17;


namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BloggingSystemsEntities())
            {
                // Create a new blog
                var newBlog = new Blog
                {
                    BlogName = "Langchain Booming",
                    BlogType = "Technology",
                    BlogHeader = "Latest in Tech",
                    BlogDescription = "A blog about the latest trends in technology."
                };


                context.Blogs.Add(newBlog);

                context.SaveChanges();

                // Retrieve and display blogs
                var blogs = context.Blogs.ToList();
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Blog: {blog.BlogName}, Type: {blog.BlogType},Header:{blog.BlogHeader},Description :{blog.BlogDescription}");
                }

                // Create a new post
                var newPost = new Post
                {
                    BlogId = newBlog.BlogId,
                    Title = "Introduction to LLM",
                    Content = "This post discusses the basics of LARGE LANGUAGE MODELS...",
                    CreationDate = DateTime.Now
                };

                context.Posts.Add(newPost);
                context.SaveChanges();

                // Retrieve and display posts
                var posts = context.Posts.Where(p => p.BlogId == newBlog.BlogId).ToList();
                foreach (var post in posts)
                {
                    Console.WriteLine($"Post: {post.Title}, Date: {post.CreationDate}");
                }
            }
        }
    }
}
