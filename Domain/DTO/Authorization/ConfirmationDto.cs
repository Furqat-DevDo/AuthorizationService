namespace Domain.DTO.Authorization;

public class ConfirmationDto
{
    public Guid Id { get; set; }
    public string Otp { get; set; }
}