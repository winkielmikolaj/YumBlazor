﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace YumBlazor.Data;

public class Product
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    public string? SpecialTag { get; set; }
    
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    
    public string? ImageUrl { get; set; }
}