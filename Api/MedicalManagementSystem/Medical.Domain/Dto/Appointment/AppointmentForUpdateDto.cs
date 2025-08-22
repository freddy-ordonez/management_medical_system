namespace Medical.Domain.Dto.Appointment
{
    public record AppointmentForUpdateDto
    {
        public int? PatientID { get; init; }
        public int? DoctorID { get; init; }
        public DateOnly? Date { get; init; }
        public DateTime? Time { get; init; }
        public string? Status { get; init; }
    }
}
