using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class changebirthdaynullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "User",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(3980), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(5216), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 23, 9, 52, 6, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 4, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1795), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1803), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 4,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1806), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 5,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 6,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1810), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 7,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1812), new DateTime(2022, 4, 1, 23, 9, 52, 5, DateTimeKind.Local).AddTicks(1813) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "User",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5224), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 574, DateTimeKind.Local).AddTicks(3196), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2538), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2545), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 4,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2548), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 5,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2551), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 6,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2554), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 7,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2556), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2557) });
        }
    }
}
