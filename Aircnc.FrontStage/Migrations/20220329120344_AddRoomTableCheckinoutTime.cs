using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class AddRoomTableCheckinoutTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoomCheckInTime",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomCheckOutTime",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(9623), new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1365), new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1522), new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(870), new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(7874), new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(7882), new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(7883) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomCheckInTime",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomCheckOutTime",
                table: "Room");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(3546), new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(4410), new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(4415), new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 18, 0, 42, 429, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 42, 427, DateTimeKind.Local).AddTicks(4079), new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 3, 29, 18, 0, 42, 428, DateTimeKind.Local).AddTicks(1950) });
        }
    }
}
