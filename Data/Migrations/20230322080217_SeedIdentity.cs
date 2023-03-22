using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b24f9bff-6932-4c9d-8d62-70965891b54c", "b5de3b35-9ee7-477e-b0a3-7c91143ca2ff", "Customer", "CUSTOMER" },
                    { "b8e2992d-9ff8-4162-94e1-74f7d5d29970", "bb06e6b5-0569-4616-b19f-20f3b61ec7d2", "Admin", "ADMIN" },
                    { "ca1f092b-5957-44c3-bbb6-2bc31e7a6ffe", "a6fb97ba-ee0d-4392-9621-e1cfdb62bf14", "Business", "BUSINESS" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48c9b4c6-7da9-4c27-81eb-4921838fe32c", 0, "2756e4c8-fb9e-4a0d-b452-592cad52d1c2", "carter@business.com", false, false, null, "CARTER@BUSINESS.COM", "CARTER@BUSINESS.COM", "AQAAAAEAACcQAAAAENgsFC2KsiBB4StXvRMm+f8l7f5lkdKcPESTZ3DqySDQy1KE01+xqV2Fk8EtqOer9A==", null, false, "0cc3ec4c-1a0b-4d1d-9fe4-054fc6f0be2e", false, "carter@business.com" },
                    { "a382e998-4c02-4ecf-ae92-9aa12cb22fa8", 0, "1b2f56fe-a467-4461-a0a9-b6b489923e1f", "carter@admin.com", false, false, null, "CARTER@ADMIN.COM", "CARTER@ADMIN.COM", "AQAAAAEAACcQAAAAEHDVcXjPgFYDLTKdLmloNsWObDQd9r/LjG8ZGHHNjkQ9wylMhrDPADahj8he2emzyg==", null, false, "2f02e8dd-5ae0-4308-8b53-7c6a096361a8", false, "carter@admin.com" },
                    { "c746ba10-a8a8-48e3-9089-400b57cffdc1", 0, "df698c16-8707-4035-b178-79b326287381", "carter@customer.com", false, false, null, "CARTER@CUSTOMER.COM", "CARTER@CUSTOMER.COM", "AQAAAAEAACcQAAAAECUOQvHJEfVOEA4/VQylZ89/wYQ26+1UMRYCk0E2AG0Q4VsHPL4KvZRa2XD/GGAOmg==", null, false, "e9ba2de8-9e2f-49d1-887e-a037e308ee08", false, "carter@customer.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ca1f092b-5957-44c3-bbb6-2bc31e7a6ffe", "48c9b4c6-7da9-4c27-81eb-4921838fe32c" },
                    { "b24f9bff-6932-4c9d-8d62-70965891b54c", "a382e998-4c02-4ecf-ae92-9aa12cb22fa8" },
                    { "b8e2992d-9ff8-4162-94e1-74f7d5d29970", "a382e998-4c02-4ecf-ae92-9aa12cb22fa8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca1f092b-5957-44c3-bbb6-2bc31e7a6ffe", "48c9b4c6-7da9-4c27-81eb-4921838fe32c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b24f9bff-6932-4c9d-8d62-70965891b54c", "a382e998-4c02-4ecf-ae92-9aa12cb22fa8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8e2992d-9ff8-4162-94e1-74f7d5d29970", "a382e998-4c02-4ecf-ae92-9aa12cb22fa8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c746ba10-a8a8-48e3-9089-400b57cffdc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b24f9bff-6932-4c9d-8d62-70965891b54c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8e2992d-9ff8-4162-94e1-74f7d5d29970");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca1f092b-5957-44c3-bbb6-2bc31e7a6ffe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48c9b4c6-7da9-4c27-81eb-4921838fe32c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a382e998-4c02-4ecf-ae92-9aa12cb22fa8");
        }
    }
}
