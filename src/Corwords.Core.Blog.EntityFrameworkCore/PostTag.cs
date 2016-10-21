using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int PostCategoryId { get; set; }

        public virtual int PostId { get; set; }
        public virtual IBlogPost Post { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual ITag Category { get; set; }
    }
}
