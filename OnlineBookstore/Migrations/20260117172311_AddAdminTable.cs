using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f01b0e5-b93e-4374-a80b-0a46de40ac67", "AQAAAAIAAYagAAAAEMblxfP2o2Fk/YqNfI0i7TmpZK2Lbwr6VgqUNokZE7SM6Vgy502XO4paREdsMaoDrg==", "b7dcec3e-1ce5-4eab-891d-aca49ec8d61c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2c8fa7-1777-4dd9-bb7b-acb22f34679a", "AQAAAAIAAYagAAAAEPpY45st4WdUF0fodNdXG7NJ9jWicqqvz/uSsQchT3DxrcoB/RB+0CpT9SP0dUiJLg==", "064528bd-1c01-4d6a-bfd4-6449f4de1199" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d3ec2a7-5496-4079-b39e-2fe2c833af52", "AQAAAAIAAYagAAAAEB3vDwg4Hj1eiLSDLiT4iwVsPthrcZt7dVwvFoYJBIszCzp103RKfRRPxw0Ct8XKcA==", "860c7f44-1bf5-41bc-b68f-9efcd4951e2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95bd597e-b34e-43ff-a670-60eaeeaa1108", "AQAAAAIAAYagAAAAEL1sZ/iNW6jwusGnw0gkDwagwA4mab/1X7LaVwjEBPjAx8wmI5MHImU8sYnkaGjNFQ==", "4cf1e28d-69ed-4f2f-b477-0a6f758c8550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9f756e7-4417-445c-a09e-910714a0fea9", "AQAAAAIAAYagAAAAEMChGqiGom7d9Q2+3B0b9dMTTEC9cplH2+gJmL5S1AzP+AIT85boxaKL5gPPnEF2cQ==", "a02ce386-e3c6-4d77-8ae2-304657144ba5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2660ba90-be05-4d76-ba6c-55062f73b02f", "AQAAAAIAAYagAAAAEE1oMTQ8Eyy/VOVXB4BWUQm6QXGq2mkcoPntqM6FzkR04XOx0DF8UA/9EUwtqGZf5A==", "bbe2fec7-fd76-4f76-be15-f846df92c8ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8497faf-656e-40d5-8258-b755c52e9180", "AQAAAAIAAYagAAAAEPsPH8XhhhWScTi+c36ft2oTHr9Lr/48Yq6RITaCle1X0CX+epDQ2DCdm+S6z9mLjA==", "e099083d-b35c-4ed1-833a-9a4fe8550df5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24123a8f-3831-42bb-bf9a-eaa558323eb5", "AQAAAAIAAYagAAAAEFxDpR+wnijEikfXUfaevhQWxekBgnxPlPkmkLY+2JAj3bDFvN8L3JtDYwPb27FBSA==", "97a7bb8e-bb8f-4e0c-8840-d97b9c69a677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ac36888-6bea-4fd3-9b1e-ad6ff6edbe74", "AQAAAAIAAYagAAAAEHcbGsNOwW9no+ZyNXxGuwKTDjRDRDT46JPuwE5b1d1Cj3NzNJHPkICQ8rXyLZbxYw==", "7fdd9c07-5322-43c1-813f-9b773d074ee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfa95fb9-e13b-4b45-872d-2eeef041be70", "AQAAAAIAAYagAAAAENvidOkX3sqF2aI+UZHP/xRiy6MAyljYY999OL4xTxhN1+fDcG4NG9iB8vV0KELUPg==", "3f833f1d-f1fc-4117-92e3-2b9f0ea3d64d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f985d9a-c7c7-423a-ba53-9d0c37c302cc", "AQAAAAIAAYagAAAAEHe+brq+mHj+7Z66Ddz6qObiOH+28ulozqKFDDz6hSrS0SlGwTuHavt7B+tmtUBQJw==", "47abb5f6-7eb1-443b-81ed-31e84be6ebd6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3223c8b6-d030-415a-b573-140c4de0c6d6", "AQAAAAIAAYagAAAAEA+D/hY/sZuQngpoBXeV3zHTDXUShrrNbLzHpnsbKFAz9CzQHacEENz1Dm4bGOPbtA==", "5b51d531-2a87-4ef1-ba3a-f50fc0597768" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1f20535-43bf-4ad5-a172-b0c6d4d7a349", "AQAAAAIAAYagAAAAEOzUALdEYNyHmGInhJWiti+ds8MjWRgCeTNx718ncK3M5Wa9kVq1PECw25zHqmmhtw==", "1c274140-557e-45c2-baec-1b63b4d1ed70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ec67b3a-1f16-4d11-9605-03a1b3feaeea", "AQAAAAIAAYagAAAAEM/rTITGjA6l8jmsy0lBevRWZlk/MtbDEYuZNBOO8D6CnGEx/u+hakjDvLACSX7bAA==", "202ed93f-e624-4026-a33f-c13f38f8555a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e782efe-8d79-4c95-845f-8414a2dc203e", "AQAAAAIAAYagAAAAEAH/OOaIx5ZqjAfdIOWTycAI3cAOk5KylpSb6O33ESIKiUSZynLKPz8BdhWyXFWB/A==", "00af5015-0b13-4bb2-b2c1-44b940e5f6f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a8f00b0-1d54-48f1-9003-b1614bb3ac72", "AQAAAAIAAYagAAAAEDgzwYHpdBNopmlCxI06tsPCtqw7oL10Z7FgY6oqaIeq3uYpgksevgd7fSfFnJXRPg==", "4a982a83-01ef-4fd5-a60a-399965613831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e89bbff5-46c3-417b-9b52-a413a44ce8c6", "AQAAAAIAAYagAAAAEFRmUIeiDs9jYSFcESdsJ+/Iz3rDhXbEjZUCRgolKkGl1qBfVnMZ/oTaV7YqWSmy0Q==", "625bca98-4fc2-4662-bf0a-4f824f6e323b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb388a62-8ee1-4b51-85e3-288952af4887", "AQAAAAIAAYagAAAAEPB36NozmA+z4NMN9JUr7X8NSSWgJVBM113GR0oIIGvZFsnL7Pup0NV1HNSVI0QTUQ==", "4bc52ff7-203a-473b-a5f5-f4dacf779642" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6477e0da-38a5-4c0b-9015-c8dc09770147", "AQAAAAIAAYagAAAAEOk7T+J2ZQRe2+5RQ8ZSwv5UqpuDkrB85+n5MVm0W5ONOC/++RTfCFmx5y13rceBRQ==", "0bfc2924-164f-487e-aedb-e8966bf6ad33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb0ca288-bc1b-4206-b3b2-fe1682f71b55", "AQAAAAIAAYagAAAAEMzWfxhX5zzO3ymkXLVwdjC3ACqMEskTWyvMOS50XXj6PmLe0Nxd2SnIUVhh2verAw==", "3557c26c-8314-49dc-86bd-7ff91cf49430" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66161adf-25be-42f7-a08d-f4aefe587302", "AQAAAAIAAYagAAAAEFczjbPPE10OLmDcY8lMyR1l+vK1vHj+KcLKE4tXe2a+QOOD0GQScka0c8giO3HzzQ==", "8e94d817-37b7-4f93-b86f-b3debda8c898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3ad02b0-1a62-47d4-a545-72c2fafd501d", "AQAAAAIAAYagAAAAEHkxchaVQemVGlf8m3WQqC6/TnmQoG0iaQZEOazpLjb1JooxM287Ho6BVG+9yeHVIg==", "58f0d61d-6067-4d97-aa97-421bbfd808eb" });
        }
    }
}
