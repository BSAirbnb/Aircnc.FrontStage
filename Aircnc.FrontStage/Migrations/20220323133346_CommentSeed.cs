using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class CommentSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentContent", "CreateTime", "RoomId", "Stars", "UserId" },
                values: new object[,]
                {
                    { 1, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4.0, 1 },
                    { 2, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3.0, 3 },
                    { 3, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2.0, 3 },
                    { 4, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5.0, 5 },
                    { 5, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5.0, 6 },
                    { 6, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4.0, 7 },
                    { 7, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4.0, 1 },
                    { 8, "環境整潔，還不錯", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3.0, 5 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(9816), new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(689), new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(694), new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 30, 40, 331, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(8337), new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(8344), new DateTime(2022, 3, 23, 21, 30, 40, 330, DateTimeKind.Local).AddTicks(8345) });
        }
    }
}
