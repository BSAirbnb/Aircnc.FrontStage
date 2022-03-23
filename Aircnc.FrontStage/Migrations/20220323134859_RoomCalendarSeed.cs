using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class RoomCalendarSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(3958), new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(4786), new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.InsertData(
                table: "RoomCalendar",
                columns: new[] { "RoomCalendarId", "Date", "LastChangeTime", "Note", "RoomCalendarStatus", "RoomId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "價格異動", 1, 1, 2000m },
                    { 4, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "開啟租房", 1, 1, 2000m },
                    { 3, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "今天不租", 1, 1, 2000m },
                    { 2, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "價格異動", 1, 2, 3000m },
                    { 5, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "價格異動", 1, 1, 4500m }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 48, 59, 181, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 48, 59, 179, DateTimeKind.Local).AddTicks(5592), new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(2441), new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(2448), new DateTime(2022, 3, 23, 21, 48, 59, 180, DateTimeKind.Local).AddTicks(2449) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 5);

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
    }
}
