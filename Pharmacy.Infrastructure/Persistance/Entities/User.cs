namespace Pharmacy.Infrastructure.Persistance.Entities
{
    public class User : AuditableEntity
    {
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
        public ICollection<Role> Roles { get; set; }

    }
}
