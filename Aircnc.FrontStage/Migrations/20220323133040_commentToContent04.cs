using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class commentToContent04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Comment",
                newName: "CommentContent");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentContent",
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
    }
}
