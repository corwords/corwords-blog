using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class Tag : ITag<PostTag>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime DateCreated { get; set; }
        //public string htmlUrl;
        //public string rssUrl;

        public virtual IList<PostTag> PostTags { get; set; }
    }
}