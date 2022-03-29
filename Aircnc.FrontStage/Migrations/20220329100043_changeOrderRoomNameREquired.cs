using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class changeOrderRoomNameREquired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 17, 56, 43, 264, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 56, 43, 262, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(2948), new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 3, 29, 17, 56, 43, 263, DateTimeKind.Local).AddTicks(2955) });
        }
    }
}
