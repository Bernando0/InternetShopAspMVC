﻿using System.ComponentModel.DataAnnotations;

namespace InternetShop.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
