using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class LinkAdminUserToRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781ad74-f56b-4599-92ed-dea6a3f30526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "802385cb-03c3-439c-94fc-ea7b52ddcfaa", "AQAAAAIAAYagAAAAENKthUOSJqp7aFtZFlG70Ls7iE75iaUQmqdzEyldJdJR8ck1aLJ6jveeMuGmwFGOwQ==", "1fffd261-b5ba-4677-83a9-a6f0cdcf1e8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "873a5c8b-1e17-47ae-b67b-732ebe292afa", "AQAAAAIAAYagAAAAEBy57ewNVfvJbL9MHn6dY8Bx6QXtPx4skyoG1RsrsR5PfAesKxyq1C/wA3Ke2VHiqg==", "20e656d1-e872-491d-bde9-4e2ab0b9b55e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30704fdd-98c2-4249-83a2-8002a59fb6e7", "AQAAAAIAAYagAAAAEBmXZrLN7dB1nxIBJG1NxGYF+nVfbi/9ndJikMaOgCj/Jw6ax8ei9h5MCbzlDoO9YQ==", "b381a571-34dc-4e92-b9d8-a583e86c3b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b988598-fced-47bc-babb-1fe86e67af72", "AQAAAAIAAYagAAAAELsW/JGMA7mckwielCJ5C/6IVocJL1sqYoHHwrw/goA7EEByYQO0Z0z7HbXAnnM3ig==", "3e4c8d5a-3061-4417-8673-c25c4c559e0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b0112fd-868a-4c65-8ced-2272b5bd9954", "AQAAAAIAAYagAAAAEHexkmoBXkM3H0V71keP5/Bfnkb9Ql/DxpGfO9kd2RZt5FVAiQYFNQDeowmlzjLHDw==", "cbacf9eb-297b-4307-bf85-b3a77e16be7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef0ad44a-8cd0-4958-bd57-e608c3f63448", "AQAAAAIAAYagAAAAELH95SUCvuTBLupH2hyc5SsmgjhoFPUPN6o7JXi9k61lIoSpvfr3vv7A5gKEauzWsA==", "8b9a311a-f41b-481f-ab8a-cb344ff4147c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3283bd3e-9c4e-4637-8a04-b721ab658325", "AQAAAAIAAYagAAAAEI2YZ62NMSZbJHPGXke0kvymtqRekm3MX5G96o+Oe1IZ+PUKOXQvgO43Xfi9j7eLog==", "43e35dc4-6bf2-4b77-a539-d6cd165f4146" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b0342e-d4cc-4ffe-bcf6-e3ef165e6efb", "AQAAAAIAAYagAAAAEBF3wCmC32dvSdndHYrGUaJMN5vLU3FJs27+U9es9i9YG2fBO1p5x29rcpi6fuuUdw==", "6417a686-1656-4a96-af88-6922b638794b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60069978-8f01-40f5-ba78-7f4097bca0ee", "AQAAAAIAAYagAAAAEFa8E7B1DQUNtaHFF0Sh71AGkUChxvraPI9kT7jx8EimXJKlAZ7K4XmdBzBc74QL1w==", "1e6d277a-8e9e-48af-be02-959d87b69f85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54a44ac-1bab-48ae-9d9e-cd47a4709580", "AQAAAAIAAYagAAAAEM2si3miJLCd+X9/0r4mJCxlKVqETDgECkyyqebBYFjUtNNpFgx6qqaltLnY4nmHZA==", "3bc002d1-7358-4faa-b15e-5606efa0ef69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0962e9d-5c83-4282-bec6-0412868edd53", "AQAAAAIAAYagAAAAEFY2HnGwvtL69n/T3icpxegbPxWqNwYZ8ItJcoXq9g3RLljwDJguLOoHAwU5f+EWUg==", "5f5c5640-e4c6-469e-8d07-171e9c0323d2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781ad74-f56b-4599-92ed-dea6a3f30526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be131e5d-6d39-4959-b336-30dc2a023b23", "AQAAAAIAAYagAAAAEDXlMdOAkF6NRAbtLJWfDZrmAhztLPFT7//Ssx13r9YjevdpLMLOdE/a1xM+bj/8Cw==", "6188ee0b-1fc7-4d38-ac66-2c3d8b87e061" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cd7c1dc-3515-4d9f-a0f9-36aeb45c912b", "AQAAAAIAAYagAAAAEMJyqDOmpdPl4nYZD0BQViSJ0TAM3IMmfKneehXa6wmkEKt3eoNVgkySBArxrJkp1g==", "5b8a456c-8995-4a15-b5f8-ba1252415b31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "205783ef-ed39-429b-8fa7-c138117ac701", "AQAAAAIAAYagAAAAECJntopQyMUpNmYgXM3CcbhnUa2YogpDf7Y12NLqapclVGSsjYVlPTU3qkpvBLI9uA==", "9b9529df-265f-4d20-9f09-513f4baa8af4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c0c00d-343e-4f31-8705-1b95bf53a29f", "AQAAAAIAAYagAAAAEObjNfm8qID9AbdcHZbJVR5ydKpEkZsHvv3mJd2o7Z9H4XUsqWNCOUZHBLgY63s0nA==", "f5814f30-2a82-4222-a5ad-02bfc569e59f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bc8d482-ccb3-4ab6-8a15-a1641a7e315b", "AQAAAAIAAYagAAAAEKXxJD0cFt9hntDCWQBK6fZDDKA9i4at4n/7Pyb57jj9g68FgwnD35IEIxzTdmvd/w==", "85b3cbda-7740-43ff-913d-f3cc82bd10c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4356261a-32ba-4d3e-b67f-91cadb811983", "AQAAAAIAAYagAAAAEOMjRuM6Jur+PZLj95KktV7tnHcgF1IZ2ZOM6QKX0x3CeybCEKLHrv4W4Eocc2onBw==", "21c5fe86-570d-4abe-a4aa-4d485577f5bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf17747e-cb86-4e18-a026-c9639c6f14b3", "AQAAAAIAAYagAAAAEDr5TXvOqlDF2RUl9ooUe5U9NWbkqEZWmx59G5tzJliZ7lZe3pgsKvK55o+N9VNZQg==", "72c1d4ad-50c0-417f-b5ee-227246c87beb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f77396c6-11e0-4255-bfbb-4ad0f9e53f58", "AQAAAAIAAYagAAAAECuHT403rR4t7Km0fQI5/C3WOkBXIjcqkpi3H0YMRhKn0iffk2DB8yRTrSnKlWDaWQ==", "1a2f6a2f-af78-41cd-a59a-112f0eaff043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a51817d-1b79-4830-9e24-752a38752243", "AQAAAAIAAYagAAAAEIc/mY0wc5EkE5BWBcRJaLvIptec8gcq9ZJURTWUGJs/HWY6Tc78ef7H18i0M598Wg==", "4e6c4f5f-f1e2-4214-861a-9cea95b8f786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ee852d6-6232-4ff8-ac1f-8a79062ef820", "AQAAAAIAAYagAAAAEPSnCR9rRSRLkqf42V1DKE/jGMHA+77WZteW5521+kWiVScc/cZsyDzeawFl0URY5g==", "d724d887-723a-4b45-8a5f-4081de2179f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "642b8e31-df36-4966-b7df-93a4412aa8be", "AQAAAAIAAYagAAAAEO4XoElAoGZqBf43s1tOF1KPFuapNPbsdqfjX4uqWU5/8XaucBP+h9Z/zXRTHPbXtQ==", "e192582b-b4ef-4a38-afb3-cd8f7764f2e1" });
        }
    }
}
