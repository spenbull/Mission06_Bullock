using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mission06_Bullock.Models;

using System.ComponentModel.DataAnnotations;

public class Application
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Category { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    public bool? Edited { get; set; }  
    public string? LentTo { get; set; }  
    public string? Notes { get; set; }  
}

