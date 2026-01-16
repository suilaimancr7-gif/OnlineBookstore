using Microsoft.AspNetCore.Identity;

namespace OnlineBookstore.Domain.Data
{
    public class OnlineBookstoreUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}