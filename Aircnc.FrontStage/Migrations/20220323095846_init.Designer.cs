﻿// <auto-generated />
using System;
using Aircnc.FrontStage.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aircnc.FrontStage.Migrations
{
    [DbContext(typeof(AircncContext))]
    [Migration("20220323095846_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission")
                        .HasColumnType("int")
                        .HasComment("身分別Enum(主管理者、小管理者)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.BankVerification", b =>
                {
                    b.Property<int>("BankVerificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("收款帳戶驗證Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasComment("後台驗者者(誰審核的)");

                    b.Property<DateTime>("ApplyTime")
                        .HasColumnType("datetime")
                        .HasComment("使用者申請驗證時間");

                    b.Property<int>("BankAccount")
                        .HasColumnType("int")
                        .HasComment("銀行帳號");

                    b.Property<string>("BankbookImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("帳本封面照");

                    b.Property<DateTime>("CertificationTime")
                        .HasColumnType("datetime")
                        .HasComment("後台驗證通過時間");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("驗證狀態Enum(驗證通過、未驗證");

                    b.HasKey("BankVerificationId");

                    b.HasIndex(new[] { "AdminId" }, "IX_BankVerification_AdminId");

                    b.ToTable("BankVerification");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment1")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("Comment");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<double>("Stars")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex(new[] { "RoomId" }, "IX_Comment_RoomId");

                    b.HasIndex(new[] { "UserId" }, "IX_Comment_UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RecipientId")
                        .HasColumnType("int")
                        .HasComment("收信人");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("datetime");

                    b.Property<int>("SenderId")
                        .HasColumnType("int")
                        .HasComment("發信人");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("MessageId");

                    b.HasIndex(new[] { "RecipientId" }, "IX_Message_RecipientId");

                    b.HasIndex(new[] { "SenderId" }, "IX_Message_SenderId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CkeckIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CkeckOut")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,0)")
                        .HasComment("折扣");

                    b.Property<int>("GuestCount")
                        .HasColumnType("int")
                        .HasComment("訂購人數");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,0)")
                        .HasComment("這張訂單的原價(如果定很多晚，會是每晚單價的加總)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int")
                        .HasComment("付款方式Enum()");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int")
                        .HasComment("訂購房源數");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("付款狀態Enum(已付款未入住、已付款已入住、退款處理中、已退款)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex(new[] { "RoomId" }, "IX_Order_RoomId");

                    b.HasIndex(new[] { "UserId" }, "IX_Order_UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BathroomCount")
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("HouseType")
                        .HasColumnType("int")
                        .HasComment("房源類型enum(特色房源etc)，看ron的切板頁");

                    b.Property<DateTime?>("LastChangeTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Pax")
                        .HasColumnType("int")
                        .HasComment("房客人數");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.Property<string>("RoomDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int")
                        .HasComment("房間類型enum(套房雅房等etc)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("enum房源狀態(建立中/已上架/已下架)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasComment("房東");

                    b.HasKey("RoomId");

                    b.HasIndex(new[] { "HouseType" }, "IX_Room_HouseType");

                    b.HasIndex(new[] { "RoomType" }, "IX_Room_RoomType");

                    b.HasIndex(new[] { "UserId" }, "IX_Room_UserId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.RoomCalendar", b =>
                {
                    b.Property<int>("RoomCalendarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LastChangeTime")
                        .HasColumnType("datetime")
                        .HasComment("更新時間");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("月曆房東自行備註");

                    b.Property<int>("RoomCalendarStatus")
                        .HasColumnType("int")
                        .HasComment("enum被更改的狀態(被屏蔽、被訂)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,0)")
                        .HasComment("更改的單價");

                    b.HasKey("RoomCalendarId");

                    b.HasIndex(new[] { "RoomCalendarStatus" }, "IX_RoomCalendar_RoomCalendarStatusId");

                    b.HasIndex(new[] { "RoomId" }, "IX_RoomCalendar_RoomId");

                    b.ToTable("RoomCalendar");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.RoomImg", b =>
                {
                    b.Property<int>("RoomImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("Sort")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.HasKey("RoomImgId");

                    b.HasIndex(new[] { "RoomId" }, "IX_RoomImg_RoomId");

                    b.ToTable("RoomImg");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.RoomServiceLabel", b =>
                {
                    b.Property<int>("RoomServiceLabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfLabel")
                        .HasColumnType("int")
                        .HasComment("enum(wifi,etc...)");

                    b.HasKey("RoomServiceLabelId");

                    b.HasIndex(new[] { "RoomId" }, "IX_RoomServiceLabel_RoomId");

                    b.HasIndex(new[] { "TypeOfLabel" }, "IX_RoomServiceLabel_TypeOfLabeId");

                    b.ToTable("RoomServiceLabel");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.TransactionStatus", b =>
                {
                    b.Property<int>("TransactionStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("StatusType")
                        .HasColumnType("int")
                        .HasComment("交易狀態Enum(還在系統、已轉帳給房東、已退款給房客)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,0)")
                        .HasComment("扣除平台抽成後付給房東的金額");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasComment("房東Id");

                    b.HasKey("TransactionStatusId");

                    b.HasIndex(new[] { "AdminId" }, "IX_TransactionStatus_AdminId");

                    b.HasIndex(new[] { "OrderId" }, "IX_TransactionStatus_OrderId");

                    b.HasIndex(new[] { "UserId" }, "IX_TransactionStatus_UserId");

                    b.ToTable("TransactionStatus");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankVerificationId")
                        .HasColumnType("int")
                        .HasComment("收款帳戶驗證Id");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EmergencyContactPhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("(CONVERT([bit],(0)))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserVerificationId")
                        .HasColumnType("int")
                        .HasComment("身分驗證Id");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "BankVerificationId" }, "IX_User_AccountVerificationId");

                    b.HasIndex(new[] { "UserVerificationId" }, "IX_User_UserVerificationId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.UserVerification", b =>
                {
                    b.Property<int>("UserVerificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("身分驗證Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasComment("後台驗者者(誰審核的)");

                    b.Property<DateTime>("ApplyTime")
                        .HasColumnType("datetime")
                        .HasComment("使用者申請驗證時間");

                    b.Property<DateTime?>("CertificationTime")
                        .HasColumnType("datetime")
                        .HasComment("後台驗證通過時間");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int")
                        .HasComment("驗證文件Enum(身分證、護照、駕照)");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("驗證狀態IdEnum(驗證通過、未驗證");

                    b.HasKey("UserVerificationId");

                    b.HasIndex(new[] { "AdminId" }, "IX_UserVerification_AdminId");

                    b.ToTable("UserVerification");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.WishList", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WishListId");

                    b.HasIndex(new[] { "RoomId" }, "IX_WishList_RoomId");

                    b.HasIndex(new[] { "UserId" }, "IX_WishList_UserId");

                    b.HasIndex(new[] { "WishListId" }, "IX_WishList_WishListId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.BankVerification", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Admin", "Admin")
                        .WithMany("BankVerifications")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("FK_BankVerification_Admin")
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Comment", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Room", "Room")
                        .WithMany("Comments")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_Comment_Room")
                        .IsRequired();

                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Comment_User")
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Message", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "Recipient")
                        .WithMany("MessageRecipients")
                        .HasForeignKey("RecipientId")
                        .HasConstraintName("FK_Message_User")
                        .IsRequired();

                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "Sender")
                        .WithMany("MessageSenders")
                        .HasForeignKey("SenderId")
                        .HasConstraintName("FK_Message_User1")
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Order", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Room", "Room")
                        .WithMany("Orders")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_Order_Room")
                        .IsRequired();

                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Order_User")
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Room", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "User")
                        .WithMany("Rooms")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Room_User")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.RoomCalendar", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Room", "Room")
                        .WithMany("RoomCalendars")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_RoomCalendar_Room")
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.RoomImg", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Room", "Room")
                        .WithMany("RoomImgs")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_RoomPicture_Room")
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.RoomServiceLabel", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Room", "Room")
                        .WithMany("RoomServiceLabels")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_RoomServiceLabel_Room")
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.TransactionStatus", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Admin", "Admin")
                        .WithMany("TransactionStatuses")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("FK_TransactionStatus_Admin")
                        .IsRequired();

                    b.HasOne("Aircnc.FrontStage.Models.Entities.Order", "Order")
                        .WithMany("TransactionStatuses")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_TransactionStatus_Order")
                        .IsRequired();

                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "User")
                        .WithMany("TransactionStatuses")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_TransactionStatus_User")
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.User", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.BankVerification", "BankVerification")
                        .WithMany("Users")
                        .HasForeignKey("BankVerificationId")
                        .HasConstraintName("FK_User_BankVerification");

                    b.HasOne("Aircnc.FrontStage.Models.Entities.UserVerification", "UserVerification")
                        .WithMany("Users")
                        .HasForeignKey("UserVerificationId")
                        .HasConstraintName("FK_User_UserVerification");

                    b.Navigation("BankVerification");

                    b.Navigation("UserVerification");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.UserVerification", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Admin", "Admin")
                        .WithMany("UserVerifications")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("FK_UserVerification_Admin")
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.WishList", b =>
                {
                    b.HasOne("Aircnc.FrontStage.Models.Entities.Room", "Room")
                        .WithMany("WishLists")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_WishList_Room")
                        .IsRequired();

                    b.HasOne("Aircnc.FrontStage.Models.Entities.User", "User")
                        .WithMany("WishLists")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_WishList_User1")
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Admin", b =>
                {
                    b.Navigation("BankVerifications");

                    b.Navigation("TransactionStatuses");

                    b.Navigation("UserVerifications");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.BankVerification", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Order", b =>
                {
                    b.Navigation("TransactionStatuses");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.Room", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");

                    b.Navigation("RoomCalendars");

                    b.Navigation("RoomImgs");

                    b.Navigation("RoomServiceLabels");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("MessageRecipients");

                    b.Navigation("MessageSenders");

                    b.Navigation("Orders");

                    b.Navigation("Rooms");

                    b.Navigation("TransactionStatuses");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("Aircnc.FrontStage.Models.Entities.UserVerification", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
