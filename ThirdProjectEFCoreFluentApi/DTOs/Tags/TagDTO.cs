﻿using System.ComponentModel.DataAnnotations;

namespace ThirdProjectEFCoreFluentApi.DTOs.Tags
{
    public class TagDTO
    {
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string Value { get; set; }
    }
}
