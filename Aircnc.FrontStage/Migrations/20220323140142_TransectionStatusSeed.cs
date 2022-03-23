using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class TransectionStatusSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TransactionStatus",
                columns: new[] { "TransactionStatusId", "AdminId", "CreateTime", "OrderId", "StatusType", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1700m, 1 },
                    { 4, 1, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 3500m, 1 },
                    { 3, 1, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, 1400m, 2 },
                    { 2, 1, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1900m, 1 },
                    { 5, 1, new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, 1100m, 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(2689), new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(2694), new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 660, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 660, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 660, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 57, 4, 658, DateTimeKind.Local).AddTicks(2747), new DateTime(2022, 3, 23, 21, 57, 4, 658, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(333), new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 3, 23, 21, 57, 4, 659, DateTimeKind.Local).AddTicks(341) });
        }
    }
}
