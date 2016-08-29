using System;
using System.Collections.Generic;

namespace Corwords.Data.Blog
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        //public string htmlUrl;
        //public string rssUrl;

        public List<Post> Posts { get; set; }
    }
}
