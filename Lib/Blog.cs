using System;
using System.Collections.Generic;
namespace Lib
{
    public class Blog
    {
        public int BlogID{get; set;}
        public string Url{get; set;}
        public List<Post> Posts {get;} = new List<Post>();
    }

}