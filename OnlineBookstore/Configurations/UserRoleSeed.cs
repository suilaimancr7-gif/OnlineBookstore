using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineBookstore.Configurations
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    // Matches 'Administrator' role ID from RoleSeed.cs
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    // Matches 'admin@localhost.com' user ID from UserSeed.cs
                    UserId = "3781ad74-f56b-4599-92ed-dea6a3f30526"
                }
            );
        }
    }
}
