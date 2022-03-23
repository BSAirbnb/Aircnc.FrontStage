using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class commentToContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "WishList",
                columns: new[] { "WishListId", "CreateTime", "RoomId", "UserId" },
                values: new object[,]
                {
                    { 7, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 6, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { 5, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 4, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 3, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 2, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 8, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 1, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(9699), new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(9704), new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 11, 14, 443, DateTimeKind.Local).AddTicks(8743), new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(7089), new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(7096), new DateTime(2022, 3, 23, 21, 11, 14, 444, DateTimeKind.Local).AddTicks(7097) });
        }
    }
}
