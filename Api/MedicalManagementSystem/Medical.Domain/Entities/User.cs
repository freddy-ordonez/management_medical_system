namespace Medical.Domain.Entities
{

    public class User
    {
        public int? UserID { get; set; }
        public int? RoleID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool Status { get; set; }
        public string? PasswordHash { get; set; }

        public ICollection<Role>? Roles { get; set; }
    }
}
