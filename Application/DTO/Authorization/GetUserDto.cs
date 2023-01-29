namespace Core.DTO.Authorization;

public class GetUserDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Token { get; set; }
    public DateOnly  RegisteredDate { get; set; }
}