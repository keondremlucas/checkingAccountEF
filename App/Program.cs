using System;
using System.Linq;
using System.Collections.Generic;
using Lib;
using Microsoft.EntityFrameworkCore;

namespace app
{
  class Program
  {
    static void Main(string[] args)
    {
      using var db = new Context();

      // Create
      Console.WriteLine("Inserting a new blog");
      var blog = new Blog { Url = "http://wowblog.com/" };
      Console.WriteLine($"blog before state : {db.Entry(blog).State}");
      db.Add(blog);
      Console.WriteLine($"blog add state : {db.Entry(blog).State}");
      db.SaveChanges();
      // Console.WriteLine($"blog after state : {db.Entry(blog).State}");

      // // Read
      // Console.WriteLine("Querying for a blog");
      // var firstBlog = db.Blogs
      //     .OrderBy(b => b.BlogID)
      //     .First();
      // Console.WriteLine($"First Blog: {firstBlog.BlogID} {firstBlog.Url}");

      // // Update
      // Console.WriteLine("Updating the blog and adding a post");
      // blog.Url = "http://superblog.com/";
      // Console.WriteLine($"blog alter state : {db.Entry(blog).State}");
      // var post = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" };
      // blog.Posts.Add(post);
      // db.SaveChanges();
      // Console.WriteLine($"blog after state : {db.Entry(blog).State}");

      // // Delete
      // Console.WriteLine("Delete the blog with associated posts");
      // db.Remove(blog);
      // db.SaveChanges();
    }
  }
}