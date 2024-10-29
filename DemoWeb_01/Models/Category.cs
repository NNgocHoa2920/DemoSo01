﻿using System.ComponentModel.DataAnnotations;

namespace DemoWeb_01.Models
{
    public class Category
    {
        [Key]
        public int Ma { get; set; }
        [Required]
        [MaxLength(255)]
        [MinLength(3)]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="phải nhập kí tự tự trong khoảng 1-100 kí tự")]
        public string Description { get; set; }
    }
}
