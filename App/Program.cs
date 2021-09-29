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
      Console.WriteLine("Inserting a new Account");
      var Checking = new Checking { Owner = "Dre", Balance = 1000 };
      var Bank = new Bank {receipt = "New Account Created"};
      Console.WriteLine($"blog before state : {db.Entry(Checking).State}");
      db.Add(Checking);
      Console.WriteLine($"blog add state : {db.Entry(Checking).State}");
      db.SaveChanges();
      Checking.Deposit(100);
      Bank.receipt = "Deposited $100";
      db.Update(Checking);
      db.Add(Bank);
      db.SaveChanges();
      Checking.Withdraw(400);
      Bank.receipt = "Withdraw $400";
      db.Update(Checking);
      db.Update(Bank);
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