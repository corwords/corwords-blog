using System.Collections.Generic;

namespace Corwords.Data.Blog
{
    public class IndividualBlog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }

        public List<Post> Posts { get; set; }
    }
}