using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class testdatetimeseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(7113), new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(8047), new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(8053), new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "BankVerificationId", "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone", "Gender", "IsDelete", "Name", "Password", "Phone", "Photo", "UserVerificationId" },
                values: new object[,]
                {
                    { 1, "台北市大安區建國南路一段96號", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4007), "123@gmail.com", "你爸", "0911111111", true, false, "Bill", "123", "0911123123", "https://picsum.photos/seed/picsum/200/300", 1 },
                    { 2, "台北市大安區建國南路一段966號", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4937), "123d@gmail.com", "你爸", "0911111111", false, false, "c老師", "1234", "091112315553", "https://picsum.photos/seed/picsum/200/300", 2 },
                    { 3, "台北市大安區建國南路一段9266號", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4945), "1232d@gmail.com", null, null, false, true, "曹老師", "1234", "09111231512121", "https://picsum.photos/seed/picsum/200/300", 3 },
                    { 4, "台北市大安區建國南路一段966號33", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4948), "123d@gmail.com", "你爸", "0911111111", false, false, "d老師", "1234", "091112315553", "https://picsum.photos/seed/picsum/200/300", null },
                    { 5, "台北市大安區建國南路一段966號12", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4950), "123d@gmail.com", "你爸f", "0911111111", false, false, "d5老師", "1234", "091112315553", "https://picsum.photos/seed/picsum/200/300", null },
                    { 6, "台北市大安區建國南路一段9566號11", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4953), "123d@gmail.com", "你爸fff", "0911111111", false, false, "d老師", "1234", "091112315553", "https://picsum.photos/seed/picsum/200/300", null },
                    { 7, "台北市大安區建國南路一段9266號", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4955), "123d@gmail.com", "你爸", "0911111111", false, false, "d老師", "1234", "091112315553", "https://picsum.photos/seed/picsum/200/300", null }
                });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 59, 18, 421, DateTimeKind.Local).AddTicks(6699), new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(5412), new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(5419), new DateTime(2022, 3, 23, 20, 59, 18, 422, DateTimeKind.Local).AddTicks(5420) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1351), new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1356), new DateTime(2022, 3, 23, 20, 54, 4, 74, DateTimeKind.Local).AddTicks(1357) });

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
    }
}
