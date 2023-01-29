using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class User
{
    [Key]
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public uint Age { get; set; }
    [Index (nameof(Email),IsUnique = true)]
    public string Email { get; set; }
    public string PassWord { get; set; }
    [Index (nameof(Phone),IsUnique = true)]
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateOnly RegisteredDate { get; set; }
    public DateOnly ChangedDate { get; set; }
    public string Gender { get; set; }
}