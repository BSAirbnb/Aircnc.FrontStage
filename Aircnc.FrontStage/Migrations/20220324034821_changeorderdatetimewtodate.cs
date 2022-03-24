using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class changeorderdatetimewtodate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CkeckOut",
                table: "Order",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CkeckIn",
                table: "Order",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CkeckOut",
                table: "Order",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CkeckIn",
                table: "Order",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 22, 1, 41, 571, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 22, 1, 41, 569, DateTimeKind.Local).AddTicks(6701), new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(4668), new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 3, 23, 22, 1, 41, 570, DateTimeKind.Local).AddTicks(4675) });
        }
    }
}
