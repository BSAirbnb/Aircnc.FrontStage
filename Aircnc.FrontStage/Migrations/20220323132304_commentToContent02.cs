using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class commentToContent02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(5763), new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(6614), new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(6619), new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 20, 9, 771, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 20, 9, 769, DateTimeKind.Local).AddTicks(6472), new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(4229), new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 3, 23, 21, 20, 9, 770, DateTimeKind.Local).AddTicks(4236) });
        }
    }
}
