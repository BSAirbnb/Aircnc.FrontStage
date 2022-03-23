using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class bankaccountinttostringmax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BankAccount",
                table: "BankVerification",
                type: "nvarchar(max)",
                nullable: false,
                comment: "銀行帳號",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "銀行帳號");

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminId", "AccountName", "Password", "Permission" },
                values: new object[] { 1, "MainAdmin", "123", 1 });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminId", "AccountName", "Password", "Permission" },
                values: new object[] { 2, "SubAdmin01", "1234", 2 });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminId", "AccountName", "Password", "Permission" },
                values: new object[] { 3, "SubAdmin02", "1234", 2 });

            migrationBuilder.InsertData(
                table: "UserVerification",
                columns: new[] { "UserVerificationId", "AdminId", "ApplyTime", "CertificationTime", "DocumentType", "Status" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 23, 20, 4, 51, 262, DateTimeKind.Local).AddTicks(4667), new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(3859), 1, 1 });

            migrationBuilder.InsertData(
                table: "UserVerification",
                columns: new[] { "UserVerificationId", "AdminId", "ApplyTime", "CertificationTime", "DocumentType", "Status" },
                values: new object[] { 3, 1, new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4857), new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4858), 1, 1 });

            migrationBuilder.InsertData(
                table: "UserVerification",
                columns: new[] { "UserVerificationId", "AdminId", "ApplyTime", "CertificationTime", "DocumentType", "Status" },
                values: new object[] { 2, 2, new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4855), 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "BankAccount",
                table: "BankVerification",
                type: "int",
                nullable: false,
                comment: "銀行帳號",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "銀行帳號");
        }
    }
}
