using System;
using System.Linq;

using ConsoleAppCodeFirstApproach;

namespace BloggingSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogPostContext())
            {
                // Create a new blog
                var blog = new Blog
                {
                    BlogName = "Tech Trends",
                    BlogType = "Technology",
                    BlogHeader = "Latest in Tech",
                    BlogDescription = "All about the latest trends in technology."
                };
                context.Blogs.Add(blog);
                context.SaveChanges();

                // Display all blogs
                var blogs = context.Blogs.ToList();
                foreach (var b in blogs)
                {
                    Console.WriteLine($"Blog: {b.BlogName}, Type: {b.BlogType}");
                }
            }
        }
    }
}
