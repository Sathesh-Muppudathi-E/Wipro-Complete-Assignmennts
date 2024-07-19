using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodeFirstApproach
{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext()
            : base("name=BlogPostDBEntities")
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<BlogPostContext>());
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogPostContext>());
            Database.SetInitializer(new SeedDefaultData());
        }


        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
    public class SeedDefaultData : DropCreateDatabaseIfModelChanges<BlogPostContext>
    {
        protected override void Seed(BlogPostContext context)
        {
            Blog bg = new Blog();
            bg.BlogId = 1;
            bg.BlogName = "satish";
            bg.BlogDescription = "Description";
            bg.BlogHeader = "Blog";
            bg.BlogType = "study";

            Post pt = new Post();
            pt.BlogId = 1;
            pt.CreationDate = DateTime.Now;
            pt.PostDescription = "Post Description";

            context.Blogs.Add(bg);
            // context.Posts.Add(pt);
            context.SaveChanges();
            base.Seed(context);
        }

    }
}

