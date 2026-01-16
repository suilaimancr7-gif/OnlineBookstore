using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderCustomerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Payments_OrderId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Orders",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId1",
                table: "Orders",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Payments_OrderId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderStatus",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { "02310646-3bc8-4016-9480-a077e2f28735", "AQAAAAIAAYagAAAAEDdfV+WC47ckoVyuIoKbE2et7lX7CgQIn3apMc2d4STAvc6VvUrLe9vbtCMf7/l57w==", "816ad29e-5b07-4662-be23-b5e8ee81b26e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e1b4e92-eac2-4d06-8146-63e6cae05a7b", "AQAAAAIAAYagAAAAEEW5+ZThKOTwXlLN/TjpG/JazXvqJVxpr12cOck9emxyznlv775Ob7DwlElPcVU/qA==", "daa30fb7-2f29-40ec-b632-28e7cdefe3c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12271a0e-fc73-4d21-b219-d53f2cba828a", "AQAAAAIAAYagAAAAECThxPUZlS6AtxBGAjdSq4RNBKnGs3aGUMI4lE7QnrWnga6CtxDzacyOBo3cArv0yg==", "f87eca4b-a8cd-4a83-8c2b-3c6fc47eb219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6bb573d-cb0c-46e2-831d-d24d0419c73f", "AQAAAAIAAYagAAAAEEST6pljGFLXvT5U6YxTHL27OJhm+66HS/pjamXy4WpXSXucsYxdGxYeU3O5wbsrLQ==", "6f3707d7-6726-49c0-9d7c-be25bb92de66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e945799-02b3-4431-8d6d-96337ab798c9", "AQAAAAIAAYagAAAAEABlhlkIQugOoGnxJxKtWwOkomPYjE+SKRvL9hAqldsm/l+mt5UhP7rkykgXSIYS/g==", "69e4ac60-5f8a-4437-9bca-1fa3a08e9349" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "150fcd15-f04f-43f5-83c0-4db311174f29", "AQAAAAIAAYagAAAAEIHGK4xbNXG5r9xb21/uJLzDly1ei8gCx5hqURTpI4vfwixD0cz4dZYT27FA3EKpqw==", "1a602ec7-47b5-437f-aa6c-5a1a77da0d45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be5855c1-c691-4477-9d79-5c95cb77ac2f", "AQAAAAIAAYagAAAAEO3Ao9ytRL7B4QYwyxQkIdJREJEX+rvTeqTyZmkb9WIUX1D5zyHaAez0REUbF94T5Q==", "c3a0e436-3cd1-4ba4-adcc-d536d4d4922a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d3a55bf-da2a-47f7-b973-66a810aadf32", "AQAAAAIAAYagAAAAEIxGV4YpipK3RWAOKgE2IOyea6QkZoiDs0RCq+Kaf8VFFDyLEnJm2oxZR9AQuwlLqg==", "49753c6a-cc8f-4f08-afb2-a18503a99a64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5e7e6e2-2687-42e3-a9c6-c94987b6cebb", "AQAAAAIAAYagAAAAEKk5Wv1Q/dYL2NHfV3nPT+U4yqoqlH/fbXDPuxQCCrZ8JJfKRxInoZOJAXvQUlGQYQ==", "bfd7c30a-038c-4f5d-bda4-e9a488800569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f48b36f-4293-461d-8513-d770292e2f59", "AQAAAAIAAYagAAAAEJtz4SWLxkYyYki6bnoLSdadkFdbQfvFtNt2xshxc0tC6sjEOupjdFsct3Zcv91qqA==", "2846f6e9-9173-4e32-97fa-37a93b16a14a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4ac4e08-0c2c-47ac-a7c9-88f9bc394ab3", "AQAAAAIAAYagAAAAEHPsn/lEU6FKEdP806j88HDOJCg9k1Y2czkWRS2JcObxiqHak3qBeyRsSzQV7sMGcw==", "123ea03e-8dcc-481f-86af-f8e2de7435a3" });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
