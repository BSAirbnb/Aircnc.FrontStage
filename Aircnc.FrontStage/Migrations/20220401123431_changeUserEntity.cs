using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class changeUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "MailIsVerify",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5224), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone", "MailIsVerify" },
                values: new object[] { new DateTime(1996, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(1203), "Bill123@gmail.com", "力宏", "0944412456", true });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateTime", "Email", "EmergencyContactName", "MailIsVerify", "Name", "Phone" },
                values: new object[] { new DateTime(1997, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2312), "sin123d@gmail.com", "怡萱", true, "新樺", "09122324343" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "CreateTime", "MailIsVerify", "Name", "Phone" },
                values: new object[] { "台北市大安區仁愛路一段66號", new DateTime(1982, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2383), true, "曹聖光", "0987987987" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone", "MailIsVerify", "Name", "Phone" },
                values: new object[] { "台北市大安區忠孝東路一段420號", new DateTime(1973, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2389), "123dann@gmail.com", "Andy", "0912222222", true, "Dann", "0912344543" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone", "MailIsVerify", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段966號12弄1樓", new DateTime(1998, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2392), "123dchen@gmail.com", "秉承", "0922222222", true, "陳育成", "0913313133" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "CreateTime", "EmergencyContactName", "EmergencyContactPhone", "MailIsVerify", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段9566號11樓", new DateTime(1996, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2394), "美茜", "0912234234", true, "婷怡", "0911232423" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "CreateTime", "EmergencyContactName", "EmergencyContactPhone", "MailIsVerify", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段666號", new DateTime(1966, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 34, 30, 576, DateTimeKind.Local).AddTicks(2397), "路加封", "0911422422", true, "向李", "0966666666" });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 574, DateTimeKind.Local).AddTicks(3196), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2538), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2545), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 4,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2548), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 5,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2551), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 6,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2554), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 7,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2556), new DateTime(2022, 4, 1, 20, 34, 30, 575, DateTimeKind.Local).AddTicks(2557) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailIsVerify",
                table: "User");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(317), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1205), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(6649), "123@gmail.com", "你爸", "0911111111" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateTime", "Email", "EmergencyContactName", "Name", "Phone" },
                values: new object[] { new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7513), "123d@gmail.com", "你爸", "c老師", "091112315553" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "CreateTime", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段9266號", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7520), "曹老師", "09111231512121" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段966號33", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7523), "123d@gmail.com", "你爸", "0911111111", "d老師", "091112315553" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "CreateTime", "Email", "EmergencyContactName", "EmergencyContactPhone", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段966號12", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7525), "123d@gmail.com", "你爸f", "0911111111", "d5老師", "091112315553" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "CreateTime", "EmergencyContactName", "EmergencyContactPhone", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段9566號11", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7584), "你爸fff", "0911111111", "d老師", "091112315553" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "CreateTime", "EmergencyContactName", "EmergencyContactPhone", "Name", "Phone" },
                values: new object[] { "台北市大安區建國南路一段9266號", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7587), "你爸", "0911111111", "d老師", "091112315553" });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(1109), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8376), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8383), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 4,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8387), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 5,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 6,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8392), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 7,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8394), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8395) });
        }
    }
}
