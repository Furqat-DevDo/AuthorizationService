namespace Domain.DTO.Authorization;

public class CreateUserDto
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public string PassWord { get; set; }
}