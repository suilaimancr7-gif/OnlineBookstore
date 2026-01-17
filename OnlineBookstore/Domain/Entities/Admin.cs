using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Admin : BaseDomainEntity
    {
        // Aligned with your project's naming conventions
        public string? AdminName { get; set; }
        public string? AdminEmail { get; set; }
        public string? AdminRole { get; set; } // e.g., "SuperAdmin", "Staff"
        public DateTime DateAssigned { get; set; } = DateTime.Now;
    }
}
