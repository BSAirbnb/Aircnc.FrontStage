using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class commentToContent03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Comment",
                newName: "Content");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(2691), new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 893, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 29, 20, 894, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 29, 20, 891, DateTimeKind.Local).AddTicks(7278), new DateTime(2022, 3, 23, 21, 29, 20, 892, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 29, 20, 892, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 3, 23, 21, 29, 20, 892, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 29, 20, 892, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 3, 23, 21, 29, 20, 892, DateTimeKind.Local).AddTicks(9771) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Comment",
                newName: "Comment");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(5402), new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(6267), new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(6272), new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 620, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 620, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 620, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 23, 3, 619, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 23, 3, 617, DateTimeKind.Local).AddTicks(5974), new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(3891), new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(3897), new DateTime(2022, 3, 23, 21, 23, 3, 618, DateTimeKind.Local).AddTicks(3898) });
        }
    }
}
