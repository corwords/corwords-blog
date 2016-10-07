using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Data.Blog
{
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostCategoryId { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
