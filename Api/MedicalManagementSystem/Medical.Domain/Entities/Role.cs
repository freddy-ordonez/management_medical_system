namespace Medical.Domain.Entities
{
    public class Role
    {
        public int? RoleID { get; set; }
        public string? RoleName { get; set; }

        public User? User { get; set; }
    }
}
