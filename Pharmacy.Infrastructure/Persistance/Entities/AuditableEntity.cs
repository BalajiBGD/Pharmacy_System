namespace Pharmacy.Infrastructure.Persistance.Entities
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? ModifiedDate { get; set; } = DateTime.UtcNow;
        public string? ModifiedBy { get; set; }
    }
}
