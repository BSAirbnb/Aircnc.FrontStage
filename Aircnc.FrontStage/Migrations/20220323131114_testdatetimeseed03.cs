using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class testdatetimeseed03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "MessageId", "RecipientId", "SendTime", "SenderId", "Text" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(7744), 1, "HI" },
                    { 2, 2, new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(7974), 1, "HI" },
                    { 3, 2, new DateTime(2022, 3, 23, 21, 11, 14, 445, DateTimeKind.Local).AddTicks(7977), 1, "HI" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "BathroomCount", "BedCount", "City", "Country", "CreateTime", "District", "HouseType", "LastChangeTime", "Note", "Pax", "RoomCount", "RoomDescription", "RoomName", "RoomType", "Status", "Street", "UnitPrice", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 3, "台北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "內湖區", 1, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 3, "優質房源", "星雲小屋", 1, 2, "石潭路88號", 2310m, 1 },
                    { 8, 2, 3, "新北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "三重區", 3, null, null, 6, 3, "優質房源", "[K] 38 ✦ 大雙人房 含獨立衛浴 沙發", 3, 2, "大仁街44號", 865m, 5 },
                    { 7, 2, 3, "新北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "永和區", 2, null, null, 6, 3, "優質房源", "榮星花園旁靜巷溫馨小宅～適合親子同遊！", 2, 2, "中正路570號", 1495m, 6 },
                    { 2, 2, 2, "台北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "松山區", 2, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1, "優質房源", "小葉-懶人-溫馨寬敞的樓中樓套房,青山綠樹景色,適合宅度假", 2, 2, "南京東路3段25號9樓", 710m, 2 },
                    { 5, 2, 2, "台北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "中正區", 1, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 2, "優質房源", "捷運站步行3分鐘 近夜市與101 Near MRT & Taipei 101", 2, 2, "林森南路17號", 990m, 1 },
                    { 4, 2, 5, "台北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "大安區", 4, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1, "優質房源", "303魚池白宮", 3, 2, "敦化南路二段201號", 1110m, 4 },
                    { 3, 2, 1, "台北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "南港區", 3, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, "優質房源", "景觀雙人房A25，免費早餐、交通方便、溫馨舒適", 3, 2, "東新街116-3號", 500m, 3 },
                    { 6, 2, 3, "台北市", "台灣", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "士林區", 5, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 3, "優質房源", "1 min walk to YounChun MRT, center of Taipei city", 1, 2, "福德路57巷2號1樓", 3210m, 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3886), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 23, 21, 2, 44, 743, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 741, DateTimeKind.Local).AddTicks(4367), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 3, 23, 21, 2, 44, 742, DateTimeKind.Local).AddTicks(1463) });
        }
    }
}
