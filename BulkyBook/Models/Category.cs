using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models;

public class Category
{
    [Key]
    public int Id { get; set; } //ID is primary key

    [Required] //NAME IS REQUIRED PROPERTY
    public string Name{ get; set; }
    public string DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; }= DateTime.Now;

 }