using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderPaymentFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrackingNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReferenceCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TrackingNumber",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c245f5a-94c6-4b04-8fe9-802dbb2a4f1d", "AQAAAAIAAYagAAAAEBt5YdHgA8hMMSjSDaUteBSsywmzmD6K8ZrE/xWGiLk2QOo8bdJi+atq0kbT2F6WUg==", "fef08faf-48ed-40c0-80c7-d92483553431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bc28065-67ee-43fc-95b9-001207437728", "AQAAAAIAAYagAAAAELan4KbKAI5BhPPvk1GHta2qJ9ujr5vwSEHRv1qsnjHhE/0p9YTzav4AvY9gzjkZuw==", "84037725-c98d-47e0-87f2-140b8b2231b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cd889bd-08a6-43ab-a130-8579cc26ce99", "AQAAAAIAAYagAAAAEEjxGCyv6n1IxlhCAcaan0H4rmRo8qkG0zlX6xSBz0SgPKvZOnIUGUVNjr+297jKlg==", "7bd95c1c-8390-4055-9674-0c3ba529e1d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "333206a4-c85c-4eda-b1e1-1766a285f0e6", "AQAAAAIAAYagAAAAENtK9xKb0ix1Ngv1c0+KC9Y+WFegJVHZRhA5jvk1prV8kQ+cqFzp3HbXlRSsUyDvIg==", "e246d8a3-634b-46f4-8aa6-c9fb79c6ea36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eaa844d-4a0e-4ea6-b366-9b1740e591b6", "AQAAAAIAAYagAAAAEHbnb6OZL+o5bDlq/sj7MLer1o0b9eov1n9u8fge1LQkbG/OjmkYRoy0PvR82PhVUQ==", "2b2614bb-9282-4b5b-bbe3-e07a5f0ce2ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2133d5d-db0b-4ae1-aa0e-4d85277c23a0", "AQAAAAIAAYagAAAAEGrf4CEWvXI6dHvTbB98lXvhYWuVI6KoaEVHM6+nBOGWvr2kYv3efQvXiC9xv59NfQ==", "3aa1a3fb-954b-4865-a1e7-45148628ce6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7901234a-1ce0-4bdc-a79a-1a5f98bebbdd", "AQAAAAIAAYagAAAAECnpvd8E37QiKxHJ1UGMFlyeGmuw52e9l7azqfeOubVwBsML9uebTDThXS5yLXTvag==", "c705b852-c8b3-45ad-b8b6-afb44fd6ccf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32455635-0a6b-4b53-9cf7-b21d5b4793d7", "AQAAAAIAAYagAAAAEGrSqlP4lEtBytIr5LdyC456keoOEESP9BG0yL8Wr5gnuVzGCYerZAvheQYiaxTJrQ==", "673ed6e2-4240-4d45-9840-3dfa505dcaea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7b981d8-7c8b-4f7c-8ca6-fe1826771800", "AQAAAAIAAYagAAAAEFnqIRD/YfttK9rUEocl1FFb4d8z/Q/hBOPohCf0XisWdQNnzrwoyr30LBCMkn+0cg==", "a8ab23d8-ef92-4315-800a-4f90b82f2166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4eaee6-1a57-481b-9136-e0c3411da24b", "AQAAAAIAAYagAAAAECJfR4ZckVZWHg1zlPJPewLkmJ7jTWZV6HEhscxWSK439c+mcD4Kr/MV9ey7BeU03A==", "a0d50152-e18f-4c58-a40a-2b062666ebd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "541a251e-868b-45f6-bc9b-cfe7ffe00c9d", "AQAAAAIAAYagAAAAENyyFffzeQ7DpnhHe/5wPgk2oNkhCnPzVigNAr5r7SzQps7APcRpyD/OQxIsrf9b2g==", "5f8737c2-0543-4a4a-89b5-183db5ed66b2" });
        }
    }
}
