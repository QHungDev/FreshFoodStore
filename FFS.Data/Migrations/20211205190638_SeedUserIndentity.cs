using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FFS.Data.Migrations
{
    public partial class SeedUserIndentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c28f66ae-186e-4c5f-9df3-86b07f431013"), "0967c940-cded-4f5c-80af-38ed0b61cba5", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("c0d575dd-ee8b-4905-8fca-59f5ac4a05cd"), new Guid("c28f66ae-186e-4c5f-9df3-86b07f431013") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c0d575dd-ee8b-4905-8fca-59f5ac4a05cd"), 0, "845508ed-40bb-4cbe-b307-6f95de2b7a04", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongquochung204@gmail.com", true, "Toan", "Bach", false, null, "truongquochung204@gmail.com", "admin", "AQAAAAEAACcQAAAAEMWUNTFFW5fdSiCdSsgGXrPImOSzLkYe3KIqes3E2R6GHJVBoiKoU7YFFlxATJ/gYQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 6, 2, 6, 37, 660, DateTimeKind.Local).AddTicks(3204));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c28f66ae-186e-4c5f-9df3-86b07f431013"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c0d575dd-ee8b-4905-8fca-59f5ac4a05cd"), new Guid("c28f66ae-186e-4c5f-9df3-86b07f431013") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0d575dd-ee8b-4905-8fca-59f5ac4a05cd"));

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of Fresh Food Store");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of Fresh Food Store");

            migrationBuilder.UpdateData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of Fresh Food Store");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 6, 1, 53, 56, 256, DateTimeKind.Local).AddTicks(4055));
        }
    }
}
