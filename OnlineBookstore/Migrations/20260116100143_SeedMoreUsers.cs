using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d9bcc1e-7b64-4b8a-bce6-c6d924610c63", "AQAAAAIAAYagAAAAELXybFrNs5B1zZNzHOF6yUgFU4NXU9cQMzFh4aELz0AU+/bXcvc9qmxB0wsxIJbMEg==", "765a0e52-a866-4d7e-8528-a3cc74886c66" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", 0, "30e07781-99c0-43eb-bbf7-cb74c089792c", "sarah.tan@example.com", true, "Sarah", "Tan", false, null, "SARAH.TAN@EXAMPLE.COM", "SARAH.TAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK6Tg9krOgM9A/m1vh7QJ9qA7gb+XuUsbpXCLF+9kFA8M27xiIXYk5026w8lMZVQ5A==", null, false, "7e759eb2-9d01-4262-84a0-6cb47bf67827", false, "sarah.tan@example.com" },
                    { "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d", 0, "11eab70c-5764-4e88-817a-48a9e5a6ee0b", "chloe.lim@example.com", true, "Chloe", "Lim", false, null, "CHLOE.LIM@EXAMPLE.COM", "CHLOE.LIM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJP9vZHfRn2e0klhdkqmPHrdLvXnOdsZWbS8hH2wxM4Qp1V1ZurFjmtCwZrIgOUGlA==", null, false, "b00222b3-6a97-47b0-8f75-33d057c06dd0", false, "chloe.lim@example.com" },
                    { "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e", 0, "9f1890a9-55bc-49cd-8560-4473eb62f54c", "muhammad.ali@example.com", true, "Muhammad", "Ali", false, null, "MUHAMMAD.ALI@EXAMPLE.COM", "MUHAMMAD.ALI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL2tkMrhFZMO4BaqPd1HjcXK3M3/Xtn4Os50hZeIuPCR5/I8pmlZIZQCnuq6RjsJWA==", null, false, "9bbe8d02-a051-47fd-b43a-113c79c29bf0", false, "muhammad.ali@example.com" },
                    { "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e", 0, "1f4170ba-bfaa-48e1-b9d9-67d98484eb58", "ahmad.hassan@example.com", true, "Ahmad", "Hassan", false, null, "AHMAD.HASSAN@EXAMPLE.COM", "AHMAD.HASSAN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAf/rbdYR4d9E9qETgTBw6Dk118U28dZi5mggYrdYQkrv/V+O/0Ln2e3zl/wZ/fV1g==", null, false, "6c498aba-e336-475c-a0f7-516e403396e8", false, "ahmad.hassan@example.com" },
                    { "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f", 0, "835c0e75-9f33-48ef-b6d5-f090c33f46f0", "emily.wong@example.com", true, "Emily", "Wong", false, null, "EMILY.WONG@EXAMPLE.COM", "EMILY.WONG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBuT44OiWPMP8v6vOLOWisSBCeMq3eBoWqz+O1lq6zho+niOJTLhUVzhxGG6q0sYMg==", null, false, "d10cbe82-56ae-4bbb-af7a-a6c6e7336e1d", false, "emily.wong@example.com" },
                    { "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f", 0, "084a5b53-0297-4fff-bc0d-f59bfa1617bc", "linda.nguyen@example.com", true, "Linda", "Nguyen", false, null, "LINDA.NGUYEN@EXAMPLE.COM", "LINDA.NGUYEN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGR7C9CZ9rElqXmbyHraj9bcfNQhJU89abrRmmU0+X5KIevBMkALUeKXkS/jj8OlEg==", null, false, "beefba47-edac-4ee9-9330-376412f5c803", false, "linda.nguyen@example.com" },
                    { "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a", 0, "501b4bb5-0495-4af5-8d42-f1154c9c2cc8", "robert.brown@example.com", true, "Robert", "Brown", false, null, "ROBERT.BROWN@EXAMPLE.COM", "ROBERT.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECqqCaEFbjIwCfbeij6puls/0acJunpziPL3t1xcQleSksnUtl0Lqg6z/x4rLLnrug==", null, false, "eb554e52-7733-4c04-a822-bd10823cd8c8", false, "robert.brown@example.com" },
                    { "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a", 0, "849b1ae1-e3f8-4e62-aeb0-4b645b21ddb2", "david.smith@example.com", true, "David", "Smith", false, null, "DAVID.SMITH@EXAMPLE.COM", "DAVID.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL3/lIA6FEAXSjP5y+9sPXAu0tTLcIYKBxdKFUGSsbvCUOBcniHiNi9lQVoOtQUn8w==", null, false, "e361fb8e-4458-4c46-a3ec-21bd8222cc3a", false, "david.smith@example.com" },
                    { "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b", 0, "c03da8c8-2d5d-4bcc-8620-b0eadd0820ab", "priya.sharma@example.com", true, "Priya", "Sharma", false, null, "PRIYA.SHARMA@EXAMPLE.COM", "PRIYA.SHARMA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI8Ow7VSWjubi5Ty2LlCBNuIekSRpA0AZ6vvNj3mHx4oZC5b3R00IKnEpIiLbmjsew==", null, false, "54af65f1-03d8-4cba-857e-0df37abc927c", false, "priya.sharma@example.com" },
                    { "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c", 0, "ee5c124a-5570-4c1a-ad93-f3df37dc11e8", "jason.lee@example.com", true, "Jason", "Lee", false, null, "JASON.LEE@EXAMPLE.COM", "JASON.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFqIYDaJHKrwFywgpklKTXu93N/G5ANEUWHVifI3Gv6gWkQdCr+dIpPEtFpgJJbwhw==", null, false, "3368a3c1-cfcc-46d2-9dea-ebea25a71fb8", false, "jason.lee@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e176909-1410-4f4b-b4e8-096ba4799619", "AQAAAAIAAYagAAAAELPyv0OcTDBATPxDROuQAvYVMbVUcZbTHpmTsOZrBs8QZsxFkJ/q4WQwMc4ef/wwuA==", "ca91b8d8-5710-4517-b40a-99e17508205e" });
        }
    }
}
