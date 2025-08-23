namespace Medical.Domain.Dto.Doctor
{
    public record class DoctorForUpdateDto
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? Email { get; init; }
        public string? Phone { get; init; }
        public bool Status { get; init; }
    }
}
