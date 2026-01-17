using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalAmountToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bcfc9bc-84cb-442c-a188-c6eb76c0c965", "AQAAAAIAAYagAAAAEMpyz4Q0NOyv4aB5TAu208pceB+vsb7as0MVMNtCzMiV9Mq8lGEVeHCCcMuqL8O1QA==", "57ec9e07-574d-44c5-a3b2-171a6815e421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8834f7a3-3983-4552-b8c4-ae67c214c15b", "AQAAAAIAAYagAAAAEJgthBWhG/o7bbor2QnlDT5lsnbEzEUoBtmL3dPWgZW4ASsyZEOY9EwHPumXaJOzBA==", "44598b49-2a0e-42f4-8c71-6984a8ff8af7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871275f0-0e17-48c6-8e8d-2e46a2c3e0c1", "AQAAAAIAAYagAAAAEEo2TeFJNy8eiZYDuopKYB1OJYlsSKuhJ5HSZDNZFVGslZvD4qsGwXdaiMWaGcwGug==", "1050e348-ea97-4881-aa32-0922888f29f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f1d95d-8c7e-492f-b071-f527a8f2e6f3", "AQAAAAIAAYagAAAAECUxcih3DoWRikpAelsXeYftfcLMtSeTdZPOUeixB3yd0jcqhm92nas1wz8o0FzRNA==", "9e995f08-88be-4a22-b626-78c7a4cae08a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68bb4f5b-2adf-46c7-ada9-acdd2a3953d6", "AQAAAAIAAYagAAAAEDoCGDCnEMCNl1eUrg0ldjNj81Ar1LEtnH5ohaShJtFPb1h54N1ctgQfUlp/McY2/w==", "51266a34-0ced-4860-92da-73d1f95eba30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "113f1d47-459b-450f-9b17-186ce58b93e6", "AQAAAAIAAYagAAAAEEeeptBZO3AUPT1DICCJ1rWSKPzNlFE/jCWcjRdAsegdhVVR7xoaSnDBhC5O7pxdWQ==", "3206fd06-64ca-4cb1-82aa-1985990ccfd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c4bc7b4-028a-462a-b36c-c6357b5d2467", "AQAAAAIAAYagAAAAELv3z35CVtJMMwESzSSMPaEV9GkVQi36JPOGd9WVgkXAYU6Gd687WiPX/3ziOcYlOg==", "507999a3-cefe-437b-9950-522ba36607a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d4ce0fa-d980-451c-b627-b71d327635ed", "AQAAAAIAAYagAAAAEEtd693R+T1VqZO9PpXV/RH20ot6mRbu69UBoIbnThIK9l3RFqZp6nz9LwT46hZoTg==", "d5c3bbcd-3641-408e-a1d2-8c45b1113ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d9a8569-2bee-4bd0-80c6-80c83ef2b860", "AQAAAAIAAYagAAAAEFbvkThdDptw61zvYUYcqYyIZUE91sF1ByCBY9kjEOuKGvKIu55DIwTG9N4pvP7bEQ==", "58be0bc8-836d-4a8c-aa71-67670aeccd0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9883cbcf-49ff-4ba4-9425-dbacc7bdb9c9", "AQAAAAIAAYagAAAAEEMnl0rRD8qUt0F0yUNxjXK9gg9ObH1dVV2QikbABSotucM5aUMx6vHF2DOXbbYmOA==", "65d71fd6-ed59-46c9-bc73-12bb9619a792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f680fe3c-0802-442c-a8ab-0133014e1a13", "AQAAAAIAAYagAAAAEOHpZVHqVQXmqwqKsxYeCfWiB9EqHR74Oo5dFWXvU5M6L5aribzhEUARc+Yz7/WUaQ==", "fc6b2ea5-1712-4bee-9e11-72ba7e5ed0d0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

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
    }
}
