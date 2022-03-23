using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class testdatetimeseed02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3886), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 741, DateTimeKind.Local).AddTicks(4367), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1463) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(2022, 3, 23, 20, 59, 18, 423, DateTimeKind.Local).AddTicks(4955) });

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
    }
}
