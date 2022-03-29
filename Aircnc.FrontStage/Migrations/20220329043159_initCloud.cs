using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class initCloud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(9055), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(626), new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(631), new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 337, DateTimeKind.Local).AddTicks(2933), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6315), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6323) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(5687), new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 24, 11, 48, 20, 944, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 48, 20, 942, DateTimeKind.Local).AddTicks(2673), new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(4046), new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(4054), new DateTime(2022, 3, 24, 11, 48, 20, 943, DateTimeKind.Local).AddTicks(4055) });
        }
    }
}
