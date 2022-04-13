using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class addidimgInUServerify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdPhoto",
                table: "UserVerification",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(8931), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(9773), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(9779), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 210, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 210, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 210, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 4, 13, 19, 50, 45, 209, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 207, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6944), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 4,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6946), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 5,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 6,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 7,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 4, 13, 19, 50, 45, 208, DateTimeKind.Local).AddTicks(6954) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPhoto",
                table: "UserVerification");

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
    }
}
