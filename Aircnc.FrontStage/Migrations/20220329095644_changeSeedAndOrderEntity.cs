using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class changeSeedAndOrderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Order",
                newName: "Street");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

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
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "City", "District", "RoomName", "Street" },
                values: new object[] { "台中市", "沙鹿區", "高級馬桶", "沙鹿路87樓" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "City", "District", "RoomName", "Street" },
                values: new object[] { "花蓮市", "吉安鄉", "麻糬吃到飽飯店", "曾記麻糬路3號" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "City", "District", "RoomName", "Street" },
                values: new object[] { "台北市", "信義區", "台北市政府柯文哲辦公室", "市府路一號" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "City", "District", "RoomName", "Street" },
                values: new object[] { "台南市", "中西區", "堯平布朗尼吃到飽飯店", "國華街" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "City", "District", "RoomName", "Street" },
                values: new object[] { "新竹市", "東區", "高階工程師聚集旅社", "新竹科學園區路78號" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "HouseType",
                value: 2);

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "BathroomCount", "BedCount", "City", "Country", "CreateTime", "District", "HouseType", "LastChangeTime", "Note", "Pax", "RoomCount", "RoomDescription", "RoomName", "RoomType", "Status", "Street", "UnitPrice", "UserId" },
                values: new object[,]
                {
                    { 9, 1, 2, "南投縣", "台灣", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "南投市", 4, null, null, 4, 2, "超級優質", "免費午餐，交通方便、溫馨舒適", 2, 3, "省府路130號", 950m, 6 },
                    { 16, 1, 2, "高雄市", "台灣", new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "苓雅區", 4, null, null, 4, 2, "我們這裡大位 來騎車", "免費午餐，交通方便", 2, 3, "凱旋2路132-1號號", 300m, 6 },
                    { 15, 1, 2, "台中市", "台灣", new DateTime(2017, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "西屯區", 4, null, null, 3, 2, "我們這裡大床位，有免費歪泛", "免費午餐，溫馨寬敞的樓中樓套房，超大床", 2, 1, "台灣大道3段99號", 400m, 6 },
                    { 17, 1, 2, "花蓮縣", "台灣", new DateTime(2019, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "花蓮市", 4, null, null, 2, 2, "大車位，有回饋", "免費午餐，語言交換，超大床", 2, 2, "府前路17號", 750m, 6 },
                    { 14, 1, 2, "桃園市", "台灣", new DateTime(2016, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "桃園區", 4, null, null, 2, 2, "我們這裡床位，有午餐", "漫步在雲端，語言交換，超大床", 2, 2, "縣府路1號", 500m, 6 },
                    { 13, 1, 2, "台南市", "台灣", new DateTime(2015, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "麻豆區", 4, null, null, 1, 2, "這裡超吵 不要來", "免費午餐，語言交換，超大床", 2, 1, "忠孝路250號", 600m, 6 },
                    { 12, 1, 2, "台東縣", "台灣", new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "台東市", 4, null, null, 1, 2, "鄰近花園 可以慢跑", "交通方便、溫馨舒適，超大床", 2, 2, "南京路19號", 2890m, 6 },
                    { 11, 1, 2, "屏東縣", "台灣", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "新埤鄉", 4, null, null, 2, 2, "必需來住 必需來住 必需來住 必需來住", "免費午餐，鄰近夜市", 2, 1, "中正路66號", 1230m, 6 },
                    { 10, 1, 2, "彰化縣", "台灣", new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "彰化市", 4, null, null, 3, 2, "一定要來", "溫馨有事，超大床", 2, 2, "中山路二段", 1560m, 6 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Order",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(9055), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(626), new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(631), new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "SendTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Address",
                value: "台中市");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Address",
                value: "花蓮市");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Address",
                value: "台中市");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "Address",
                value: "台中市");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "Address",
                value: "新竹市");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                column: "HouseType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2022, 3, 29, 12, 31, 58, 339, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 337, DateTimeKind.Local).AddTicks(2933), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6315), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 3, 29, 12, 31, 58, 338, DateTimeKind.Local).AddTicks(6323) });
        }
    }
}
