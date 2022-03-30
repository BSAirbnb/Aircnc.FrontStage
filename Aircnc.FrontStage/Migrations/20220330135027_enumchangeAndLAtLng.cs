using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class enumchangeAndLAtLng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Lat",
                table: "Room",
                type: "decimal(10,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Lng",
                table: "Room",
                type: "decimal(10,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime", "Status" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(317), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(544), 2 });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime", "Status" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1203), 2 });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1205), new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 5,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 7,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentContent", "CreateTime", "RoomId", "Stars", "UserId" },
                values: new object[,]
                {
                    { 9, "環境整潔，還不錯", new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5.0, 2 },
                    { 13, "環境整潔，還不錯", new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4.0, 7 },
                    { 17, "環境整潔，還不錯", new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 4.0, 6 },
                    { 16, "環境整潔，還不錯", new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 4.0, 3 },
                    { 15, "環境整潔，還不錯", new DateTime(2017, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3.0, 5 },
                    { 14, "環境整潔，還不錯", new DateTime(2017, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5.0, 6 },
                    { 12, "環境整潔，還不錯", new DateTime(2016, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3.0, 1 },
                    { 11, "環境整潔，還不錯", new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3.0, 3 },
                    { 10, "環境整潔，還不錯", new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5.0, 6 }
                });

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
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "BookingDateTime", "City", "CkeckIn", "CkeckOut", "District", "RoomName", "Street" },
                values: new object[] { new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "台北市", new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "大安區", "工業風舒適雙人房", "忠孝東路三段96號11樓" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "BookingDateTime", "City", "CkeckIn", "CkeckOut", "District", "RoomId", "RoomName", "Street", "UserId" },
                values: new object[] { new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "台南市", new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "中西區", 2, "利多文旅", "西門路二段76號", 2 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "BookingDateTime", "District", "PaymentType", "RoomId", "RoomName", "Status", "Street" },
                values: new object[] { new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "大安區", 2, 3, "混和宿舍:女性專用房間|光華商場 華山文創園區阜杭豆漿 捷運1分鐘 台北車站 三創", 2, "忠孝東路三段30號" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "BookingDateTime", "City", "District", "RoomId", "RoomName", "Status", "Street" },
                values: new object[] { new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "台中市", "中區", 4, "4人車站木地板大房間|鄰近旱溪夜市", 3, "旱溪東路一段201號" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "BookingDateTime", "CkeckIn", "CkeckOut", "PaymentType", "RoomId", "RoomName", "Status", "Street" },
                values: new object[] { new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "背包客或騎車環島的舒適簡易單人房", 3, "經國路一段156巷" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "BedCount", "BookingDateTime", "City", "CkeckIn", "CkeckOut", "Country", "Discount", "District", "GuestCount", "OriginalPrice", "PaymentType", "RoomCount", "RoomId", "RoomName", "Status", "Street", "UserId" },
                values: new object[] { 6, 1, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "澎湖市", new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "馬公區", 2, 1500m, 1, 1, 6, "樂圖漫遊會館", 1, "西衛里261-8號", 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                columns: new[] { "Lat", "Lng", "RoomType" },
                values: new object[] { 25.04450m, 121.52942m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                columns: new[] { "HouseType", "Lat", "Lng" },
                values: new object[] { 1, 25.043540m, 121.514942m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType" },
                values: new object[] { 1, 25.024350m, 121.519432m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType" },
                values: new object[] { 1, 25.044150m, 121.152942m, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                columns: new[] { "Lat", "Lng", "RoomType" },
                values: new object[] { 25.104450m, 121.532942m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "HouseType", "Lat", "Lng", "Status" },
                values: new object[] { 3, 25.043430m, 121.352942m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                columns: new[] { "Lat", "Lng", "RoomType" },
                values: new object[] { 25.044350m, 121.529432m, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType" },
                values: new object[] { 1, 25.044530m, 121.529342m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "HouseType", "Lat", "Lng", "Status" },
                values: new object[] { 1, 25.044503m, 121.523942m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType", "Status" },
                values: new object[] { 3, 25.044350m, 121.529342m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType", "Status" },
                values: new object[] { 3, 25.044250m, 121.522942m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "HouseType", "Lat", "Lng", "Status" },
                values: new object[] { 2, 25.044510m, 121.529242m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType" },
                values: new object[] { 1, 25.044530m, 121.529412m, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType", "Status" },
                values: new object[] { 3, 25.044504m, 121.529442m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                columns: new[] { "HouseType", "Lat", "Lng" },
                values: new object[] { 1, 25.044520m, 121.529422m });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType", "Status" },
                values: new object[] { 2, 25.044250m, 121.529422m, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "HouseType", "Lat", "Lng", "RoomType", "Status" },
                values: new object[] { 2, 25.044520m, 121.529242m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 3,
                column: "LastChangeTime",
                value: new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 4,
                column: "LastChangeTime",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 5,
                columns: new[] { "LastChangeTime", "RoomCalendarStatus" },
                values: new object[] { new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 3,
                column: "TypeOfLabel",
                value: 6);

            migrationBuilder.UpdateData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 4,
                column: "TypeOfLabel",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 1,
                columns: new[] { "AdminId", "CreateTime", "StatusType", "UserId" },
                values: new object[] { 3, new DateTime(2015, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 2,
                columns: new[] { "AdminId", "CreateTime", "OrderId", "StatusType", "UserId" },
                values: new object[] { 3, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 3,
                columns: new[] { "AdminId", "CreateTime", "OrderId", "StatusType" },
                values: new object[] { 2, new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 4,
                columns: new[] { "CreateTime", "OrderId", "StatusType", "TotalAmount" },
                values: new object[] { new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 7100m });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 5,
                columns: new[] { "AdminId", "OrderId", "StatusType", "UserId" },
                values: new object[] { 2, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7520));

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

            migrationBuilder.InsertData(
                table: "UserVerification",
                columns: new[] { "UserVerificationId", "AdminId", "ApplyTime", "CertificationTime", "DocumentType", "Status" },
                values: new object[,]
                {
                    { 6, 2, new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8392), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8393), 1, 1 },
                    { 4, 1, new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8387), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8388), 1, 1 },
                    { 5, 2, new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8391), 1, 1 },
                    { 7, 1, new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8394), new DateTime(2022, 3, 30, 21, 50, 26, 992, DateTimeKind.Local).AddTicks(8395), 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2015, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2017, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2015, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2017, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "TransactionStatus",
                columns: new[] { "TransactionStatusId", "AdminId", "CreateTime", "OrderId", "StatusType", "TotalAmount", "UserId" },
                values: new object[] { 6, 2, new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 5200m, 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7523), 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7525), 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7584), 6 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 50, 26, 993, DateTimeKind.Local).AddTicks(7587), 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserVerification",
                keyColumn: "UserVerificationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Room");

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 1,
                columns: new[] { "ApplyTime", "CertificationTime", "Status" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 309, DateTimeKind.Local).AddTicks(9623), new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(80), 1 });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 2,
                columns: new[] { "ApplyTime", "CertificationTime", "Status" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1365), new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1369), 1 });

            migrationBuilder.UpdateData(
                table: "BankVerification",
                keyColumn: "BankVerificationId",
                keyValue: 3,
                columns: new[] { "ApplyTime", "CertificationTime" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1522), new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 5,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 7,
                columns: new[] { "CreateTime", "RoomId" },
                values: new object[] { new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "BookingDateTime", "City", "CkeckIn", "CkeckOut", "District", "RoomName", "Street" },
                values: new object[] { new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "台中市", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "沙鹿區", "高級馬桶", "沙鹿路87樓" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "BookingDateTime", "City", "CkeckIn", "CkeckOut", "District", "RoomId", "RoomName", "Street", "UserId" },
                values: new object[] { new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "花蓮市", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "吉安鄉", 1, "麻糬吃到飽飯店", "曾記麻糬路3號", 1 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "BookingDateTime", "District", "PaymentType", "RoomId", "RoomName", "Status", "Street" },
                values: new object[] { new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "信義區", 1, 1, "台北市政府柯文哲辦公室", 1, "市府路一號" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "BookingDateTime", "City", "District", "RoomId", "RoomName", "Status", "Street" },
                values: new object[] { new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "台南市", "中西區", 1, "堯平布朗尼吃到飽飯店", 1, "國華街" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "BookingDateTime", "CkeckIn", "CkeckOut", "PaymentType", "RoomId", "RoomName", "Status", "Street" },
                values: new object[] { new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "高階工程師聚集旅社", 1, "新竹科學園區路78號" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 1,
                column: "RoomType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "HouseType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 3,
                columns: new[] { "HouseType", "RoomType" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 4,
                columns: new[] { "HouseType", "RoomType" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "RoomType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 6,
                columns: new[] { "HouseType", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 7,
                column: "RoomType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 8,
                columns: new[] { "HouseType", "RoomType" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 9,
                columns: new[] { "HouseType", "Status" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 10,
                columns: new[] { "HouseType", "RoomType", "Status" },
                values: new object[] { 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 11,
                columns: new[] { "HouseType", "RoomType", "Status" },
                values: new object[] { 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 12,
                columns: new[] { "HouseType", "Status" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 13,
                columns: new[] { "HouseType", "RoomType" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 14,
                columns: new[] { "HouseType", "RoomType", "Status" },
                values: new object[] { 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 15,
                column: "HouseType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 16,
                columns: new[] { "HouseType", "RoomType", "Status" },
                values: new object[] { 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "RoomId",
                keyValue: 17,
                columns: new[] { "HouseType", "RoomType", "Status" },
                values: new object[] { 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 3,
                column: "LastChangeTime",
                value: new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 4,
                column: "LastChangeTime",
                value: new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RoomCalendar",
                keyColumn: "RoomCalendarId",
                keyValue: 5,
                columns: new[] { "LastChangeTime", "RoomCalendarStatus" },
                values: new object[] { new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 3,
                column: "TypeOfLabel",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RoomServiceLabel",
                keyColumn: "RoomServiceLabelId",
                keyValue: 4,
                column: "TypeOfLabel",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 1,
                columns: new[] { "AdminId", "CreateTime", "StatusType", "UserId" },
                values: new object[] { 1, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 2,
                columns: new[] { "AdminId", "CreateTime", "OrderId", "StatusType", "UserId" },
                values: new object[] { 1, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 3,
                columns: new[] { "AdminId", "CreateTime", "OrderId", "StatusType" },
                values: new object[] { 1, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 4,
                columns: new[] { "CreateTime", "OrderId", "StatusType", "TotalAmount" },
                values: new object[] { new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 3500m });

            migrationBuilder.UpdateData(
                table: "TransactionStatus",
                keyColumn: "TransactionStatusId",
                keyValue: 5,
                columns: new[] { "AdminId", "OrderId", "StatusType", "UserId" },
                values: new object[] { 1, 2, 3, 1 });

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
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7919), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7923), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7926), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreateTime", "UserVerificationId" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 3, 43, 310, DateTimeKind.Local).AddTicks(7929), null });

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

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishList",
                keyColumn: "WishListId",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
