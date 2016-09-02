using System;
using System.Collections.Generic;

namespace Corwords.Data.Blog
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public string Author { get; set; }
        public string AuthorUsername { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public List<Category> Categories { get; set; }
    }
}