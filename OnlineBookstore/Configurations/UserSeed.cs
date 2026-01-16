using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookstore.Domain;
using OnlineBookstore.Domain.Data;

namespace OnlineBookstore.Configurations
{
    public class UserSeed : IEntityTypeConfiguration<OnlineBookstoreUser>
    {
        public void Configure(EntityTypeBuilder<OnlineBookstoreUser> builder)
        {
            var hasher = new PasswordHasher<OnlineBookstoreUser>();
            builder.HasData(
                new OnlineBookstoreUser
                {
                    Id = "3781ad74-f56b-4599-92ed-dea6a3f30526",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                    Email = "sarah.tan@example.com",
                    NormalizedEmail = "SARAH.TAN@EXAMPLE.COM",
                    FirstName = "Sarah",
                    LastName = "Tan",
                    UserName = "sarah.tan@example.com",
                    NormalizedUserName = "SARAH.TAN@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                    Email = "muhammad.ali@example.com",
                    NormalizedEmail = "MUHAMMAD.ALI@EXAMPLE.COM",
                    FirstName = "Muhammad",
                    LastName = "Ali",
                    UserName = "muhammad.ali@example.com",
                    NormalizedUserName = "MUHAMMAD.ALI@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                    Email = "emily.wong@example.com",
                    NormalizedEmail = "EMILY.WONG@EXAMPLE.COM",
                    FirstName = "Emily",
                    LastName = "Wong",
                    UserName = "emily.wong@example.com",
                    NormalizedUserName = "EMILY.WONG@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                    Email = "david.smith@example.com",
                    NormalizedEmail = "DAVID.SMITH@EXAMPLE.COM",
                    FirstName = "David",
                    LastName = "Smith",
                    UserName = "david.smith@example.com",
                    NormalizedUserName = "DAVID.SMITH@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                    Email = "priya.sharma@example.com",
                    NormalizedEmail = "PRIYA.SHARMA@EXAMPLE.COM",
                    FirstName = "Priya",
                    LastName = "Sharma",
                    UserName = "priya.sharma@example.com",
                    NormalizedUserName = "PRIYA.SHARMA@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                    Email = "jason.lee@example.com",
                    NormalizedEmail = "JASON.LEE@EXAMPLE.COM",
                    FirstName = "Jason",
                    LastName = "Lee",
                    UserName = "jason.lee@example.com",
                    NormalizedUserName = "JASON.LEE@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                    Email = "chloe.lim@example.com",
                    NormalizedEmail = "CHLOE.LIM@EXAMPLE.COM",
                    FirstName = "Chloe",
                    LastName = "Lim",
                    UserName = "chloe.lim@example.com",
                    NormalizedUserName = "CHLOE.LIM@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                    Email = "ahmad.hassan@example.com",
                    NormalizedEmail = "AHMAD.HASSAN@EXAMPLE.COM",
                    FirstName = "Ahmad",
                    LastName = "Hassan",
                    UserName = "ahmad.hassan@example.com",
                    NormalizedUserName = "AHMAD.HASSAN@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                    Email = "linda.nguyen@example.com",
                    NormalizedEmail = "LINDA.NGUYEN@EXAMPLE.COM",
                    FirstName = "Linda",
                    LastName = "Nguyen",
                    UserName = "linda.nguyen@example.com",
                    NormalizedUserName = "LINDA.NGUYEN@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new OnlineBookstoreUser
                {
                    Id = "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                    Email = "robert.brown@example.com",
                    NormalizedEmail = "ROBERT.BROWN@EXAMPLE.COM",
                    FirstName = "Robert",
                    LastName = "Brown",
                    UserName = "robert.brown@example.com",
                    NormalizedUserName = "ROBERT.BROWN@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}