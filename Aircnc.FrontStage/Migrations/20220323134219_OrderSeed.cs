using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class OrderSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(7973), new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(8805), new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(8811), new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "Address", "BedCount", "BookingDateTime", "CkeckIn", "CkeckOut", "Discount", "GuestCount", "OriginalPrice", "PaymentType", "RoomCount", "RoomId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, "台中市", 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2000m, 1, 1, 1, 1, 1 },
                    { 4, "台中市", 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1000m, 1, 1, 1, 1, 1 },
                    { 3, "台中市", 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2000m, 1, 1, 1, 1, 1 },
                    { 2, "花蓮市", 2, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 6000m, 1, 1, 1, 1, 1 },
                    { 5, "新竹市", 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1500m, 1, 1, 1, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 42, 19, 159, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 42, 19, 156, DateTimeKind.Local).AddTicks(9181), new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(6456), new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 3, 23, 21, 42, 19, 157, DateTimeKind.Local).AddTicks(6464) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(8685), new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(8691), new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 33, 45, 773, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 33, 45, 771, DateTimeKind.Local).AddTicks(8719), new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(6047), new DateTime(2022, 3, 23, 21, 33, 45, 772, DateTimeKind.Local).AddTicks(6048) });
        }
    }
}
