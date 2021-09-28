using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Lib
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs {get;set;}
        public DbSet<Post> Posts {get;set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var basedir = System.AppContext.BaseDirectory;
            var soldndir = Directory.GetParent(basedir).Parent.Parent.Parent.Parent;
            options.UseSqlite($"Data Source= {soldndir.FullName}/db/app.db");

        }
    }
}