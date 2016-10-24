using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class PostTag : IPostTag<PostTag>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int PostTagId { get; set; }

        public virtual int PostId { get; set; }
        public virtual IBlogPost<PostTag> Post { get; set; }

        public virtual int TagId { get; set; }
        public virtual ITag<PostTag> Tag { get; set; }
    }
}
