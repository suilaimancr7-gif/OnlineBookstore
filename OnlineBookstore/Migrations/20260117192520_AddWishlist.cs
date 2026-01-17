using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddWishlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5704617-18f4-4a76-83c0-c3ff21bf8266", "AQAAAAIAAYagAAAAEC9jQiLsadNPHDZEDP1SLSWkntw6kbjgmLeI757PsmP8mGBDkkNahJWagmAwBgUG3g==", "8d412534-4273-4ddc-904f-993d6b2eb1db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09be57e2-ffda-433d-817b-7157b76703d0", "AQAAAAIAAYagAAAAED4Xy3dlSQcY0q9ov98qWe8/SnEPL+hcDiegGxfhQK7c1Y2y/ImjLOIze2AFg1V2xg==", "7e38ddff-3f14-4d7c-b1b8-48219d052673" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee26d4c-1443-44d1-9162-0d4b90d9ba73", "AQAAAAIAAYagAAAAEF7Yv472Utf6B568E2t5aeQYPQKOGggpj9S5v0lIs2r8NtZEd8CKPqKP2kC7QGxVIQ==", "87e83e7d-688e-47ed-9c5b-d3b7556635d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5b1d1b7-ebab-4936-80b1-42f86ea90948", "AQAAAAIAAYagAAAAEJ9BwGULQZCYvzvG3Br46uR0SsL2K0++iZEzWgNGMVznOmkf2Yz4dd6vZPPfG4FTRQ==", "e266b4e4-581a-43f4-a2f4-b511ccda24cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8460b419-4076-4b18-add8-4f3dd54b939a", "AQAAAAIAAYagAAAAEMS0GpemZ6AX2n+AHTXixQC0IewYbH+KPe4X6z4cyjCy15YHeYb37vU/bmu4FK0WRw==", "db2ebe54-8eba-4bc3-a436-1b2fabb9dabe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "282e3476-b2e2-473c-8472-15e612fe3842", "AQAAAAIAAYagAAAAEDgyuuSjVU+roY2pZCn099lJloAGBwYMAo1iZEnyG4NsJWyw5ZjHcHf8HnAI8xFs+A==", "18633d88-15e5-4d4b-b97d-99a86bcb78e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03113c5d-9ff7-4559-aae8-3c4c98b87893", "AQAAAAIAAYagAAAAEALp9tyNyYY1vLb5B0iG/GscsbUQEjrY9+kFLilEBFTNfei1QSjettWFNhzj2V+2XQ==", "6d057aea-9693-4007-ac5f-976fb98fa2dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b91e2a-9f96-42c2-aceb-bd35c840e2f0", "AQAAAAIAAYagAAAAEEiJ9oxjl3scOH2cFt/5QNK/02OBxYnIS+RhsRaGa3FTR9kgovZmF/poSLGwBWqHfA==", "010afa0c-af50-4a98-aca8-3f5758766cd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72cb5d05-e162-4900-ad2a-a30ed80afdaf", "AQAAAAIAAYagAAAAECKGGO4L5s5t6XT2F6enuHn0HxGmTJajmCUM74QgPI8E5iW11aOzVJfrkDF8KbTb3A==", "46cadd4e-7b7d-447b-9df3-a7c45a074492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35c4b4c5-32cd-4011-8950-938d98aa9fc7", "AQAAAAIAAYagAAAAEEgBTBBcy2r4j1X+H6s7kPrJp6r42Gb/kldgS6iY7wUSZU2+x3arqJKJQXsuDtVg4A==", "b7949a5a-bc50-48b5-835f-fe9cb20d8db3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeb9708f-0843-4057-b9ee-42e5d1aa8c61", "AQAAAAIAAYagAAAAEBU9hVNow9JmauDyl4zBX1MrS3a0cOWEBi/EwzCWdOho4sWN1IapkS6cnGenMgA1xg==", "46c0096c-9093-4a67-918c-dd37dd0ba62e" });

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_BookId",
                table: "Wishlists",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781ad74-f56b-4599-92ed-dea6a3f30526",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7400a33-5c17-4108-98eb-43e5a8dc1335", "AQAAAAIAAYagAAAAED4oxMtE2rA3H/tvB1fgUIWKthXbY6pcVjnvvWHpZkmUBvXRcl4JXyHr7+Xla8TvXw==", "46fca73b-3445-4b39-b49b-d89192769743" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e12de28c-789b-42bb-9cc7-c307cddef565", "AQAAAAIAAYagAAAAEDGy4HhYezZBUaQ5APuH9jsLfvsmrMd2Kkg6rH0sjO5ycH1VP3BuU1/xeXNfHvcgug==", "b45b3cf4-0595-4363-ae06-64e237d1d23b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7b8c9d0-e1f2-4fb1-4c5d-6e7f8a9b0c1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd2b1eb7-8696-44db-bc24-e7ec020a16e9", "AQAAAAIAAYagAAAAEF2x8fbF+1Dxb6A9xRc2rUaTBR/w2gVq3QNG1Hh1MrKo6x7vDBnuGH53Oss7iBAIzg==", "cf7163e1-9e55-44df-926f-0cbdf0a9f094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c3d4e5-f6a7-4b6c-9d0e-1f2a3b4c5d6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "289ef562-3c73-482a-b086-a109e04e8196", "AQAAAAIAAYagAAAAED011zWupqwbznIQxHsNRqqnYDx7Lhvosnb8AwSO+pv3NqSNSmkuIFHySRbl0vwVWg==", "b44e5f2d-9021-476d-9733-f7f1b0450eaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c9d0e1-f2a3-4fc2-5d6e-7f8a9b0c1d2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ed6a47a-1fd1-40e9-89a8-f51470fad002", "AQAAAAIAAYagAAAAENapz5KQQ9QRd5urDw8zP9dfCiSgKOD2TKq7EP86QetTpN4n6gbMPbvRMQmp5ZiViQ==", "5b9cc355-a1a5-461f-a098-60f5b3a63875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d4e5f6-a7b8-4c7d-0e1f-2a3b4c5d6e7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee5ab502-e7d5-48f8-bbdc-c59eb19061c1", "AQAAAAIAAYagAAAAEAPC1DotNZwkgBnJT/auIwDWZLevcU8dvnYboBxhKbWJVakBaTR9BM7tE6jJ2PlnXA==", "faa0c9df-89e9-4fe8-89ac-a071cb942d11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d0e1f2-a3b4-4fd3-6e7f-8a9b0c1d2e3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db1f28cc-e7a6-45a2-8bcc-9a3a029cc621", "AQAAAAIAAYagAAAAEJJtAIF43GPL11AF5czzSy0pAjr7X+y1jA1Bauo1VlmM/olCoLvQPGGx30eFQ73jrQ==", "8d4ed092-c239-48f3-9b58-7e0a68267f52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e1f2a3-b4c5-4fe4-7f8a-9b0c1d2e3f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d29fbc3e-68ab-4cc6-873e-1cf197a0d672", "AQAAAAIAAYagAAAAENUREs+m61hbN6t5Ds2w/M4VGf9kFf6dksqarw7te9lNxpf3iomn8WK2dhLTVSOdYQ==", "9340db23-512a-4a69-add3-076deefbba29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4e5f6a7-b8c9-4d8e-1f2a-3b4c5d6e7f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b01b3a19-eb14-4013-b9d2-7d6546e1ab28", "AQAAAAIAAYagAAAAEEWYZXpBm3GD1qqGfxgfrh3T8rldcqpRwqWqBigWHukt5sRqYXoo9P0HW1A8xINgNQ==", "bec66e0e-7d9a-4472-92e2-b63e2cd77b22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5f6a7b8-c9d0-4e9f-2a3b-4c5d6e7f8a9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6131b7f2-24de-44d8-a715-491a36a486a0", "AQAAAAIAAYagAAAAEPh3E50kHVwmnhV9WHPGYBjBjBLs7z8w7SmDRjA1Vx47cQmMNwNFAqCa2Xn3vRI4Mw==", "98f408f9-6153-40ea-9f8e-c5f45d95e7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a7b8c9-d0e1-4fa0-3b4c-5d6e7f8a9b0c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37082a05-d760-4228-85aa-564ecce85b02", "AQAAAAIAAYagAAAAEMxfqIKjYtuZkxGeSzbkimqJ/bW6pjhGK7xAkDL20+DJRX+LPl0neaVpotNhNYXzYw==", "2d8f9894-8891-4057-b8d0-34f1813c0c14" });
        }
    }
}
