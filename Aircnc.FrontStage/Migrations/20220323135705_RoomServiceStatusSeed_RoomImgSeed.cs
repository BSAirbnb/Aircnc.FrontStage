using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class RoomServiceStatusSeed_RoomImgSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "RoomImg",
                columns: new[] { "RoomImgId", "CreateTime", "ImageUrl", "RoomId", "Sort" },
                values: new object[,]
                {
                    { 8, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 2, 3 },
                    { 1, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 1, 1 },
                    { 2, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 1, 2 },
                    { 7, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 2, 2 },
                    { 3, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 1, 5 },
                    { 4, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 1, 3 },
                    { 5, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 1, 4 },
                    { 6, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/seed/picsum/200/300", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "RoomServiceLabel",
                columns: new[] { "RoomServiceLabelId", "RoomId", "TypeOfLabel" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 5, 2 },
                    { 4, 4, 2 },
                    { 3, 3, 3 },
                    { 2, 1, 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RoomImg",
                keyColumn: "RoomImgId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 5);

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
    }
}
