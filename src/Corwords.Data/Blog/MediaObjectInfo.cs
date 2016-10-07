using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Data.Blog
{
    public class MediaObjectInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MediaObjectInfoId { get; set; }
        public string Url { get; set; }
    }
}
