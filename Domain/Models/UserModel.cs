namespace Domain.Models;

public class UserModel
{
    public string FullName { get; set; }
    public uint Age { get; set; }
    public string Email { get; set; }
    public string PassWord { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateOnly RegisteredDate { get; set; }
    public DateOnly ChangedDate { get; set; }
    public string Gender { get; set; }
}