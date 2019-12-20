using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DgInitEFCore
{
    /// <summary>
    ///     EF Core 入门
    /// https://docs.microsoft.com/zh-cn/ef/core/get-started/?tabs=netcore-cli
    /// 
    /// </summary>
    public class BloggingContext : DbContext
    {
        public string conStr =
"User ID=postgres;Password=wsx1001;Host=localhost;Port=5432;Database=IdentityServerDemoDb;Pooling=true;";

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(conStr);
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        //public List<Post> Posts { get; } = new List<Post>();


        /// <summary>
        /// dotnet new webapi --name EFGetStarted --no-https
        /// dotnet tool install --global dotnet-ef
        // dotnet add package Microsoft.EntityFrameworkCore.Design
        // dotnet ef migrations add InitialCreate
        // dotnet ef database update
        /// </summary>
        public void initDg()
        {

        }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        //public Blog Blog { get; set; }
    }

}
