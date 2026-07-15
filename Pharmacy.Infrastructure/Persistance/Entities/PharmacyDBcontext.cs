using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Infrastructure.Persistance.Entities
{
    public class PharmacyDBcontext:DbContext
    {
        public PharmacyDBcontext(DbContextOptions<PharmacyDBcontext> options) : base(options)
        {

        }
        DbSet<User> Users { get; set; }
    }
}
