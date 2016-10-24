using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class Blog : IBlog<PostTag>
    {
        public Blog() { }

        public Blog(string name) : this()
        {
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual IList<PostTag> Posts { get; set; }
    }
}