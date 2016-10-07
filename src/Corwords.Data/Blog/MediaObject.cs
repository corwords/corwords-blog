using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Data.Blog
{
    public class MediaObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MediaObjectId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Bits { get; set; }
    }
}
