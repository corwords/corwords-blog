﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corwords.Core.Blog.EntityFrameworkCore
{
    public class Enclosure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnclosureId { get; set; }
        public int Length { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }
}