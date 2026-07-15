using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Infrastructure.Persistance.Entities
{
    public class Role :AuditableEntity
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public string RoleDescription { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; }
    }
}
