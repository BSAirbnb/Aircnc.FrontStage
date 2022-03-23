using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Room",
                type: "int",
                maxLength: 50,
                nullable: false,
                comment: "enum房源狀態(建立中/已上架/已下架)",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "enum房源狀態(建立中/已上架/已下架)");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Room",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.InsertData(
                table: "BankVerification",
                columns: new[] { "BankVerificationId", "AdminId", "ApplyTime", "BankAccount", "BankbookImg", "CertificationTime", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(312), "80222222222220", "https://picsum.photos/seed/picsum/200/300", new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(726), 1 },
                    { 2, 1, new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1351), "80222222222221", "https://picsum.photos/seed/picsum/200/300", new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1354), 1 },
                    { 3, 2, new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1356), "80222222222222", "https://picsum.photos/seed/picsum/200/300", new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1357), 1 }
                });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 54, 4, 72, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 3, 23, 20, 54, 4, 73, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 54, 4, 73, DateTimeKind.Local).AddTicks(6969), new DateTime(2022, 3, 23, 20, 54, 4, 73, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 54, 4, 73, DateTimeKind.Local).AddTicks(6976), new DateTime(2022, 3, 23, 20, 54, 4, 73, DateTimeKind.Local).AddTicks(6977) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Room");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Room",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "enum房源狀態(建立中/已上架/已下架)",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50,
                oldComment: "enum房源狀態(建立中/已上架/已下架)");

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 4, 51, 262, DateTimeKind.Local).AddTicks(4667), new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4857), new DateTime(2022, 3, 23, 20, 4, 51, 263, DateTimeKind.Local).AddTicks(4858) });
        }
    }
}
