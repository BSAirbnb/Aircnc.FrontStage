using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aircnc.FrontStage.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<int>(type: "int", nullable: false, comment: "身分別Enum(主管理者、小管理者)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "BankVerification",
                columns: table => new
                {
                    BankVerificationId = table.Column<int>(type: "int", nullable: false, comment: "收款帳戶驗證Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "驗證狀態Enum(驗證通過、未驗證"),
                    BankAccount = table.Column<int>(type: "int", nullable: false, comment: "銀行帳號"),
                    ApplyTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "使用者申請驗證時間"),
                    CertificationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "後台驗證通過時間"),
                    AdminId = table.Column<int>(type: "int", nullable: false, comment: "後台驗者者(誰審核的)"),
                    BankbookImg = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "帳本封面照")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankVerification", x => x.BankVerificationId);
                    table.ForeignKey(
                        name: "FK_BankVerification_Admin",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserVerification",
                columns: table => new
                {
                    UserVerificationId = table.Column<int>(type: "int", nullable: false, comment: "身分驗證Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<int>(type: "int", nullable: false, comment: "驗證文件Enum(身分證、護照、駕照)"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "驗證狀態IdEnum(驗證通過、未驗證"),
                    ApplyTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "使用者申請驗證時間"),
                    CertificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "後台驗證通過時間"),
                    AdminId = table.Column<int>(type: "int", nullable: false, comment: "後台驗者者(誰審核的)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVerification", x => x.UserVerificationId);
                    table.ForeignKey(
                        name: "FK_UserVerification_Admin",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserVerificationId = table.Column<int>(type: "int", nullable: true, comment: "身分驗證Id"),
                    BankVerificationId = table.Column<int>(type: "int", nullable: true, comment: "收款帳戶驗證Id"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "(CONVERT([bit],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_BankVerification",
                        column: x => x.BankVerificationId,
                        principalTable: "BankVerification",
                        principalColumn: "BankVerificationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserVerification",
                        column: x => x.UserVerificationId,
                        principalTable: "UserVerification",
                        principalColumn: "UserVerificationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false, comment: "發信人"),
                    RecipientId = table.Column<int>(type: "int", nullable: false, comment: "收信人"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SendTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message_User",
                        column: x => x.RecipientId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_User1",
                        column: x => x.SenderId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "房東"),
                    HouseType = table.Column<int>(type: "int", nullable: false, comment: "房源類型enum(特色房源etc)，看ron的切板頁"),
                    RoomType = table.Column<int>(type: "int", nullable: false, comment: "房間類型enum(套房雅房等etc)"),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pax = table.Column<int>(type: "int", nullable: false, comment: "房客人數"),
                    BedCount = table.Column<int>(type: "int", nullable: false),
                    RoomCount = table.Column<int>(type: "int", nullable: false),
                    BathroomCount = table.Column<int>(type: "int", nullable: false),
                    RoomDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "enum房源狀態(建立中/已上架/已下架)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Stars = table.Column<double>(type: "float", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CkeckIn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CkeckOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false, comment: "付款方式Enum()"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "付款狀態Enum(已付款未入住、已付款已入住、退款處理中、已退款)"),
                    Discount = table.Column<decimal>(type: "decimal(18,0)", nullable: true, comment: "折扣"),
                    BedCount = table.Column<int>(type: "int", nullable: false),
                    RoomCount = table.Column<int>(type: "int", nullable: false, comment: "訂購房源數"),
                    GuestCount = table.Column<int>(type: "int", nullable: false, comment: "訂購人數"),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: false, comment: "這張訂單的原價(如果定很多晚，會是每晚單價的加總)"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomCalendar",
                columns: table => new
                {
                    RoomCalendarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastChangeTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新時間"),
                    RoomCalendarStatus = table.Column<int>(type: "int", nullable: false, comment: "enum被更改的狀態(被屏蔽、被訂)"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: false, comment: "更改的單價"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "月曆房東自行備註")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCalendar", x => x.RoomCalendarId);
                    table.ForeignKey(
                        name: "FK_RoomCalendar_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomImg",
                columns: table => new
                {
                    RoomImgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImg", x => x.RoomImgId);
                    table.ForeignKey(
                        name: "FK_RoomPicture_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomServiceLabel",
                columns: table => new
                {
                    RoomServiceLabelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    TypeOfLabel = table.Column<int>(type: "int", nullable: false, comment: "enum(wifi,etc...)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomServiceLabel", x => x.RoomServiceLabelId);
                    table.ForeignKey(
                        name: "FK_RoomServiceLabel_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    WishListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.WishListId);
                    table.ForeignKey(
                        name: "FK_WishList_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishList_User1",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatus",
                columns: table => new
                {
                    TransactionStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "房東Id"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: false, comment: "扣除平台抽成後付給房東的金額"),
                    StatusType = table.Column<int>(type: "int", nullable: false, comment: "交易狀態Enum(還在系統、已轉帳給房東、已退款給房客)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatus", x => x.TransactionStatusId);
                    table.ForeignKey(
                        name: "FK_TransactionStatus_Admin",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionStatus_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionStatus_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankVerification_AdminId",
                table: "BankVerification",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_RoomId",
                table: "Comment",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_RecipientId",
                table: "Message",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_RoomId",
                table: "Order",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HouseType",
                table: "Room",
                column: "HouseType");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomType",
                table: "Room",
                column: "RoomType");

            migrationBuilder.CreateIndex(
                name: "IX_Room_UserId",
                table: "Room",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCalendar_RoomCalendarStatusId",
                table: "RoomCalendar",
                column: "RoomCalendarStatus");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCalendar_RoomId",
                table: "RoomCalendar",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImg_RoomId",
                table: "RoomImg",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomServiceLabel_RoomId",
                table: "RoomServiceLabel",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomServiceLabel_TypeOfLabeId",
                table: "RoomServiceLabel",
                column: "TypeOfLabel");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionStatus_AdminId",
                table: "TransactionStatus",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionStatus_OrderId",
                table: "TransactionStatus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionStatus_UserId",
                table: "TransactionStatus",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountVerificationId",
                table: "User",
                column: "BankVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserVerificationId",
                table: "User",
                column: "UserVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVerification_AdminId",
                table: "UserVerification",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_RoomId",
                table: "WishList",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_UserId",
                table: "WishList",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_WishListId",
                table: "WishList",
                column: "WishListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "RoomCalendar");

            migrationBuilder.DropTable(
                name: "RoomImg");

            migrationBuilder.DropTable(
                name: "RoomServiceLabel");

            migrationBuilder.DropTable(
                name: "TransactionStatus");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BankVerification");

            migrationBuilder.DropTable(
                name: "UserVerification");

            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
