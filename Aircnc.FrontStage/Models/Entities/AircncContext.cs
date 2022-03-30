using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class AircncContext : DbContext
    {
        public AircncContext()
        {
        }

        public AircncContext(DbContextOptions<AircncContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BankVerification> BankVerifications { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomCalendar> RoomCalendars { get; set; }
        public virtual DbSet<RoomImg> RoomImgs { get; set; }
        public virtual DbSet<RoomServiceLabel> RoomServiceLabels { get; set; }
        public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserVerification> UserVerifications { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=Airbnb_Sql_v5");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Permission).HasComment("身分別Enum(主管理者、小管理者)");
            });

            modelBuilder.Entity<BankVerification>(entity =>
            {
                entity.ToTable("BankVerification");

                entity.HasIndex(e => e.AdminId, "IX_BankVerification_AdminId");

                entity.Property(e => e.BankVerificationId).HasComment("收款帳戶驗證Id");

                entity.Property(e => e.AdminId).HasComment("後台驗者者(誰審核的)");

                entity.Property(e => e.ApplyTime)
                    .HasColumnType("datetime")
                    .HasComment("使用者申請驗證時間");

                entity.Property(e => e.BankAccount).HasComment("銀行帳號");

                entity.Property(e => e.BankbookImg)
                    .IsRequired()
                    .HasComment("帳本封面照");

                entity.Property(e => e.CertificationTime)
                    .HasColumnType("datetime")
                    .HasComment("後台驗證通過時間");

                entity.Property(e => e.Status).HasComment("驗證狀態Enum(驗證通過、未驗證");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.BankVerifications)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankVerification_Admin");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.HasIndex(e => e.RoomId, "IX_Comment_RoomId");

                entity.HasIndex(e => e.UserId, "IX_Comment_UserId");

                entity.Property(e => e.CommentContent)
                    .HasMaxLength(400)
                    .HasColumnName("CommentContent");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Room");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.HasIndex(e => e.RecipientId, "IX_Message_RecipientId");

                entity.HasIndex(e => e.SenderId, "IX_Message_SenderId");

                entity.Property(e => e.RecipientId).HasComment("收信人");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.SenderId).HasComment("發信人");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.MessageRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessageSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasIndex(e => e.RoomId, "IX_Order_RoomId");

                entity.HasIndex(e => e.UserId, "IX_Order_UserId");

                entity.Property(e => e.Country);

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.District).IsRequired();

                entity.Property(e => e.Street).IsRequired();

                entity.Property(e => e.RoomName).IsRequired();
                entity.Property(e => e.BookingDateTime).HasColumnType("datetime");

                entity.Property(e => e.CkeckIn).HasColumnType("date");

                entity.Property(e => e.CkeckOut).HasColumnType("date");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("折扣");

                entity.Property(e => e.GuestCount).HasComment("訂購人數");

                entity.Property(e => e.OriginalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("這張訂單的原價(如果定很多晚，會是每晚單價的加總)");

                entity.Property(e => e.PaymentType).HasComment("付款方式Enum()");

                entity.Property(e => e.RoomCount).HasComment("訂購房源數");

                entity.Property(e => e.Status).HasComment("付款狀態Enum(已付款未入住、已付款已入住、退款處理中、已退款)");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Room");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.HasIndex(e => e.HouseType, "IX_Room_HouseType");

                entity.HasIndex(e => e.RoomType, "IX_Room_RoomType");

                entity.HasIndex(e => e.UserId, "IX_Room_UserId");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HouseType).HasComment("房源類型enum(特色房源etc)，看ron的切板頁");

                entity.Property(e => e.LastChangeTime).HasColumnType("datetime");

                entity.Property(e => e.Pax).HasComment("房客人數");

                entity.Property(e => e.RoomDescription)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoomType).HasComment("房間類型enum(套房雅房等etc)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("enum房源狀態(建立中/已上架/已下架)");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserId).HasComment("房東");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Room_User");
            });

            modelBuilder.Entity<RoomCalendar>(entity =>
            {
                entity.ToTable("RoomCalendar");

                entity.HasIndex(e => e.RoomCalendarStatus, "IX_RoomCalendar_RoomCalendarStatusId");

                entity.HasIndex(e => e.RoomId, "IX_RoomCalendar_RoomId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LastChangeTime)
                    .HasColumnType("datetime")
                    .HasComment("更新時間");

                entity.Property(e => e.Note).HasComment("月曆房東自行備註");

                entity.Property(e => e.RoomCalendarStatus).HasComment("enum被更改的狀態(被屏蔽、被訂)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("更改的單價");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomCalendars)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomCalendar_Room");
            });

            modelBuilder.Entity<RoomImg>(entity =>
            {
                entity.ToTable("RoomImg");

                entity.HasIndex(e => e.RoomId, "IX_RoomImg_RoomId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).IsRequired();

                entity.Property(e => e.Sort).HasComment("排序");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomImgs)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomPicture_Room");
            });

            modelBuilder.Entity<RoomServiceLabel>(entity =>
            {
                entity.ToTable("RoomServiceLabel");

                entity.HasIndex(e => e.RoomId, "IX_RoomServiceLabel_RoomId");

                entity.HasIndex(e => e.TypeOfLabel, "IX_RoomServiceLabel_TypeOfLabeId");

                entity.Property(e => e.TypeOfLabel).HasComment("enum(wifi,etc...)");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomServiceLabels)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomServiceLabel_Room");
            });

            modelBuilder.Entity<TransactionStatus>(entity =>
            {
                entity.ToTable("TransactionStatus");

                entity.HasIndex(e => e.AdminId, "IX_TransactionStatus_AdminId");

                entity.HasIndex(e => e.OrderId, "IX_TransactionStatus_OrderId");

                entity.HasIndex(e => e.UserId, "IX_TransactionStatus_UserId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.StatusType).HasComment("交易狀態Enum(還在系統、已轉帳給房東、已退款給房客)");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("扣除平台抽成後付給房東的金額");

                entity.Property(e => e.UserId).HasComment("房東Id");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.TransactionStatuses)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionStatus_Admin");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TransactionStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionStatus_Order");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TransactionStatuses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionStatus_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.BankVerificationId, "IX_User_AccountVerificationId");

                entity.HasIndex(e => e.UserVerificationId, "IX_User_UserVerificationId");

                entity.Property(e => e.BankVerificationId).HasComment("收款帳戶驗證Id");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmergencyContactName).HasMaxLength(20);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(20);

                entity.Property(e => e.IsDelete)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserVerificationId).HasComment("身分驗證Id");

                entity.HasOne(d => d.BankVerification)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BankVerificationId)
                    .HasConstraintName("FK_User_BankVerification");

                entity.HasOne(d => d.UserVerification)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserVerificationId)
                    .HasConstraintName("FK_User_UserVerification");
            });

            modelBuilder.Entity<UserVerification>(entity =>
            {
                entity.ToTable("UserVerification");

                entity.HasIndex(e => e.AdminId, "IX_UserVerification_AdminId");

                entity.Property(e => e.UserVerificationId).HasComment("身分驗證Id");

                entity.Property(e => e.AdminId).HasComment("後台驗者者(誰審核的)");

                entity.Property(e => e.ApplyTime)
                    .HasColumnType("datetime")
                    .HasComment("使用者申請驗證時間");

                entity.Property(e => e.CertificationTime)
                    .HasColumnType("datetime")
                    .HasComment("後台驗證通過時間");

                entity.Property(e => e.DocumentType).HasComment("驗證文件Enum(身分證、護照、駕照)");

                entity.Property(e => e.Status).HasComment("驗證狀態IdEnum(驗證通過、未驗證");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.UserVerifications)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserVerification_Admin");
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.ToTable("WishList");

                entity.HasIndex(e => e.RoomId, "IX_WishList_RoomId");

                entity.HasIndex(e => e.UserId, "IX_WishList_UserId");

                entity.HasIndex(e => e.WishListId, "IX_WishList_WishListId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WishList_Room");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WishList_User1");
            });

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<Admin>().HasData(
                new Admin {AdminId = 1, AccountName = "MainAdmin", Password = "123", Permission = PermissionEnum.Main },
                new Admin { AdminId = 2, AccountName = "SubAdmin01", Password = "1234", Permission = PermissionEnum.Sub  },
                new Admin { AdminId = 3, AccountName = "SubAdmin02", Password = "1234", Permission = PermissionEnum.Sub}
           );
            modelBuilder.Entity<UserVerification>().HasData(
                new UserVerification { UserVerificationId = 1,DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime= DateTime.Now,AdminId = 1},
                new UserVerification { UserVerificationId = 2, DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 2 },
                new UserVerification { UserVerificationId = 3, DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 1 },
                new UserVerification { UserVerificationId = 4, DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 1 },
                new UserVerification { UserVerificationId = 5, DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 2 },
                new UserVerification { UserVerificationId = 6, DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 2 },
                new UserVerification { UserVerificationId = 7, DocumentType = DocumentTypeEnum.Identity, Status = VerifyStatusEnum.Verified, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 1 }
           );
            modelBuilder.Entity<BankVerification>().HasData(
                new BankVerification { BankVerificationId = 1, Status = StatusEnum.NotVerified, BankAccount = "80222222222220",ApplyTime=DateTime.Now,CertificationTime=DateTime.Now,AdminId=1,BankbookImg= "https://picsum.photos/seed/picsum/200/300" },
                new BankVerification { BankVerificationId = 2, Status = StatusEnum.NotVerified, BankAccount = "80222222222221", ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 1, BankbookImg = "https://picsum.photos/seed/picsum/200/300" },
                new BankVerification { BankVerificationId = 3, Status = StatusEnum.Verified, BankAccount = "80222222222222", ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 2, BankbookImg = "https://picsum.photos/seed/picsum/200/300" }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Bill",
                    Email = "123@gmail.com",
                    Phone = "0911123123",
                    Address = "台北市大安區建國南路一段96號",
                    Password = "123",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = true,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    EmergencyContactName = "你爸",
                    EmergencyContactPhone = "0911111111",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 1,
                    BankVerificationId = 1,
                    IsDelete = false
                },
                new User
                {
                    UserId = 2,
                    Name = "c老師",
                    Email = "123d@gmail.com",
                    Phone = "091112315553",
                    Address = "台北市大安區建國南路一段966號",
                    Password = "1234",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = false,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    EmergencyContactName = "你爸",
                    EmergencyContactPhone = "0911111111",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 2,
                    BankVerificationId = 2,
                    IsDelete = false
                },
                new User
                {
                    UserId = 3,
                    Name = "曹老師",
                    Email = "1232d@gmail.com",
                    Phone = "09111231512121",
                    Address = "台北市大安區建國南路一段9266號",
                    Password = "1234",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = false,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 3,
                    BankVerificationId = 3,
                    IsDelete = true
                },
                new User
                {
                    UserId = 4,
                    Name = "d老師",
                    Email = "123d@gmail.com",
                    Phone = "091112315553",
                    Address = "台北市大安區建國南路一段966號33",
                    Password = "1234",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = false,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    EmergencyContactName = "你爸",
                    EmergencyContactPhone = "0911111111",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 4,
                    IsDelete = false
                },
                new User
                {
                    UserId = 5,
                    Name = "d5老師",
                    Email = "123d@gmail.com",
                    Phone = "091112315553",
                    Address = "台北市大安區建國南路一段966號12",
                    Password = "1234",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = false,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    EmergencyContactName = "你爸f",
                    EmergencyContactPhone = "0911111111",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 5,
                    IsDelete = false
                },
                new User
                {
                    UserId = 6,
                    Name = "d老師",
                    Email = "123d@gmail.com",
                    Phone = "091112315553",
                    Address = "台北市大安區建國南路一段9566號11",
                    Password = "1234",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = false,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    EmergencyContactName = "你爸fff",
                    EmergencyContactPhone = "0911111111",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 6,
                    IsDelete = false
                },
                new User
                {
                    UserId = 7,
                    Name = "d老師",
                    Email = "123d@gmail.com",
                    Phone = "091112315553",
                    Address = "台北市大安區建國南路一段9266號",
                    Password = "1234",
                    Birthday = new DateTime(2011, 6, 10),
                    Gender = false,
                    Photo = "https://picsum.photos/seed/picsum/200/300",
                    EmergencyContactName = "你爸",
                    EmergencyContactPhone = "0911111111",
                    CreateTime = DateTime.Now,
                    UserVerificationId = 7,
                    IsDelete = false
                }

            );
            modelBuilder.Entity<Message>().HasData(
                new Message { MessageId = 1, SenderId = 1, RecipientId = 2, Text = "HI", SendTime = DateTime.Now },
                new Message { MessageId = 2, SenderId = 1, RecipientId = 2, Text = "HI", SendTime = DateTime.Now },
                new Message { MessageId = 3, SenderId = 1, RecipientId = 2, Text = "HI", SendTime = DateTime.Now }
            );
            modelBuilder.Entity<Room>().HasData(
                new Room() { RoomId = 1, UserId = 1, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.Solo, Street = "石潭路88號", District = "內湖區", City = "台北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "星雲小屋", UnitPrice = 2310, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat=  25.04450m,Lng = 121.52942m },
                new Room() { RoomId = 3, UserId = 3, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.Solo, Street = "東新街116-3號", District = "南港區", City = "台北市", Country = "台灣", Pax = 2, BedCount = 1, RoomCount = 1, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "景觀雙人房A25，免費早餐、交通方便、溫馨舒適", UnitPrice = 500, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat = 25.024350m, Lng = 121.519432m },
                new Room() { RoomId = 2, UserId = 2, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.Solo, Street = "南京東路3段25號9樓", District = "松山區", City = "台北市", Country = "台灣", Pax = 3, BedCount = 2, RoomCount = 1, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "小葉-懶人-溫馨寬敞的樓中樓套房,青山綠樹景色,適合宅度假", UnitPrice = 710, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat = 25.043540m, Lng = 121.514942m },
                new Room() { RoomId = 4, UserId = 4, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.Solo, Street = "敦化南路二段201號", District = "大安區", City = "台北市", Country = "台灣", Pax = 5, BedCount = 5, RoomCount = 1, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "303魚池白宮", UnitPrice = 1110, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat = 25.044150m, Lng = 121.152942m },
                new Room() { RoomId = 5, UserId = 1, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.FullHouse, Street = "林森南路17號", District = "中正區", City = "台北市", Country = "台灣", Pax = 4, BedCount = 2, RoomCount = 2, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "捷運站步行3分鐘 近夜市與101 Near MRT & Taipei 101", UnitPrice = 990, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat = 25.104450m, Lng = 121.532942m },
                new Room() { RoomId = 6, UserId = 2, HouseType = HouseTypeEnum.Special, RoomType = RoomTypeEnum.FullHouse, Street = "福德路57巷2號1樓", District = "士林區", City = "台北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "1 min walk to YounChun MRT, center of Taipei city", UnitPrice = 3210, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Online, Lat = 25.043430m, Lng = 121.352942m },
                new Room() { RoomId = 7, UserId = 6, HouseType = HouseTypeEnum.OneBuild, RoomType = RoomTypeEnum.Share, Street = "中正路570號", District = "永和區", City = "新北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "榮星花園旁靜巷溫馨小宅～適合親子同遊！", UnitPrice = 1495, CreateTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat = 25.044350m, Lng = 121.529432m },
                new Room() { RoomId = 8, UserId = 5, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.FullHouse, Street = "大仁街44號", District = "三重區", City = "新北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "[K] 38 ✦ 大雙人房 含獨立衛浴 沙發", UnitPrice = 865, CreateTime = new DateTime(2011, 6, 10), Status = RoomStatusEnum.Offline, Lat = 25.044530m, Lng = 121.529342m },
                new Room() { RoomId = 9, UserId = 6, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.Solo, Street = "省府路130號", District = "南投市", City = "南投縣", Country = "台灣", Pax = 4, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "超級優質", RoomName = "免費午餐，交通方便、溫馨舒適", UnitPrice = 950, CreateTime = new DateTime(2020, 9, 22), Status = RoomStatusEnum.Online, Lat = 25.044503m, Lng = 121.523942m },
                new Room() { RoomId = 10, UserId = 6, HouseType = HouseTypeEnum.Special, RoomType = RoomTypeEnum.FullHouse, Street = "中山路二段", District = "彰化市", City = "彰化縣", Country = "台灣", Pax = 3, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "一定要來", RoomName = "溫馨有事，超大床", UnitPrice = 1560, CreateTime = new DateTime(2019, 2, 25), Status = RoomStatusEnum.Online, Lat = 25.044350m, Lng = 121.529342m },
                new Room() { RoomId = 11, UserId = 6, HouseType = HouseTypeEnum.Special, RoomType = RoomTypeEnum.Share, Street = "中正路66號", District = "新埤鄉", City = "屏東縣", Country = "台灣", Pax = 2, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "必需來住 必需來住 必需來住 必需來住", RoomName = "免費午餐，鄰近夜市", UnitPrice = 1230, CreateTime = new DateTime(2022, 10, 15), Status = RoomStatusEnum.Pending, Lat = 25.044250m, Lng = 121.522942m },
                new Room() { RoomId = 12, UserId = 6, HouseType = HouseTypeEnum.OneBuild, RoomType = RoomTypeEnum.Solo, Street = "南京路19號", District = "台東市", City = "台東縣", Country = "台灣", Pax = 1, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "鄰近花園 可以慢跑", RoomName = "交通方便、溫馨舒適，超大床", UnitPrice = 2890, CreateTime = new DateTime(2018, 12, 05), Status = RoomStatusEnum.Online, Lat = 25.044510m, Lng = 121.529242m },
                new Room() { RoomId = 13, UserId = 6, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.FullHouse, Street = "忠孝路250號", District = "麻豆區", City = "台南市", Country = "台灣", Pax = 1, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "這裡超吵 不要來", RoomName = "免費午餐，語言交換，超大床", UnitPrice = 600, CreateTime = new DateTime(2015, 11, 02), Status = RoomStatusEnum.Online, Lat = 25.044530m, Lng = 121.529412m },
                new Room() { RoomId = 14, UserId = 6, HouseType = HouseTypeEnum.Special, RoomType = RoomTypeEnum.FullHouse, Street = "縣府路1號", District = "桃園區", City = "桃園市", Country = "台灣", Pax = 2, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "我們這裡床位，有午餐", RoomName = "漫步在雲端，語言交換，超大床", UnitPrice = 500, CreateTime = new DateTime(2016, 9, 06), Status = RoomStatusEnum.Online, Lat = 25.044504m, Lng = 121.529442m },
                new Room() { RoomId = 15, UserId = 6, HouseType = HouseTypeEnum.Apartment, RoomType = RoomTypeEnum.Solo, Street = "台灣大道3段99號", District = "西屯區", City = "台中市", Country = "台灣", Pax = 3, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "我們這裡大床位，有免費歪泛", RoomName = "免費午餐，溫馨寬敞的樓中樓套房，超大床", UnitPrice = 400, CreateTime = new DateTime(2017, 7, 08), Status = RoomStatusEnum.Online, Lat = 25.044520m, Lng = 121.529422m },
                new Room() { RoomId = 16, UserId = 6, HouseType = HouseTypeEnum.OneBuild, RoomType = RoomTypeEnum.Share, Street = "凱旋2路132-1號號", District = "苓雅區", City = "高雄市", Country = "台灣", Pax = 4, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "我們這裡大位 來騎車", RoomName = "免費午餐，交通方便", UnitPrice = 300, CreateTime = new DateTime(2018, 6, 19), Status = RoomStatusEnum.Online, Lat = 25.044250m, Lng = 121.529422m },
                new Room() { RoomId = 17, UserId = 6, HouseType = HouseTypeEnum.OneBuild, RoomType = RoomTypeEnum.FullHouse, Street = "府前路17號", District = "花蓮市", City = "花蓮縣", Country = "台灣", Pax = 2, BedCount = 2, RoomCount = 2, BathroomCount = 1, RoomDescription = "大車位，有回饋", RoomName = "免費午餐，語言交換，超大床", UnitPrice = 750, CreateTime = new DateTime(2019, 5, 26), Status = RoomStatusEnum.Online, Lat = 25.044520m, Lng = 121.529242m }
                );
            modelBuilder.Entity<WishList>().HasData(
                new WishList { WishListId = 1, UserId = 1, RoomId = 1, CreateTime = new DateTime(2020, 2, 25) },

                new WishList { WishListId = 2, UserId = 2, RoomId = 2, CreateTime = new DateTime(2015, 1, 19) },

                new WishList { WishListId = 3, UserId = 3, RoomId = 3, CreateTime = new DateTime(2019, 3, 15) },

                new WishList { WishListId = 4, UserId = 4, RoomId = 4, CreateTime = new DateTime(2017, 4, 7) },

                new WishList { WishListId = 5, UserId = 5, RoomId = 5, CreateTime = new DateTime(2015, 6, 5) },

                new WishList { WishListId = 6, UserId = 6, RoomId = 6, CreateTime = new DateTime(2020, 12, 30) },

                new WishList { WishListId = 7, UserId = 6, RoomId = 3, CreateTime = new DateTime(2021, 11, 21) },

                new WishList { WishListId = 8, UserId = 5, RoomId = 2, CreateTime = new DateTime(2017, 7, 18) });

            //    new WishList { WishListId = 9, UserId = 4, RoomId = 6, CreateTime = new DateTime(12 - 31 - 2011) },

            //    new WishList { WishListId = 10, UserId = 3, RoomId = 7, CreateTime = new DateTime(12 - 31 - 2011) },

            //    new WishList { WishListId = 11, UserId = 2, RoomId = 8, CreateTime = new DateTime(12 - 31 - 2011) }
            //);


            modelBuilder.Entity<Comment>().HasData(
                new Comment { CommentId = 1, UserId = 1, RoomId = 17, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2022, 1, 8) },

                new Comment { CommentId = 2, UserId = 3, RoomId = 10, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2022, 6, 14) },

                new Comment { CommentId = 3, UserId = 3, RoomId = 12, CommentContent = "環境整潔，還不錯", Stars = 2, CreateTime = new DateTime(2021, 8, 11) },

                new Comment { CommentId = 4, UserId = 5, RoomId = 4, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2019, 11, 23) },

                new Comment { CommentId = 5, UserId = 6, RoomId = 12, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2022, 12, 26) },

                new Comment { CommentId = 6, UserId = 7, RoomId = 2, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2022, 5, 27) },

                new Comment { CommentId = 7, UserId = 1, RoomId = 13, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2021, 4, 24) },

                new Comment { CommentId = 8, UserId = 5, RoomId = 1, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2021, 4, 19) },

                new Comment { CommentId = 9, UserId = 2, RoomId = 1, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2020, 2, 15) },

                new Comment { CommentId = 10, UserId = 6, RoomId = 4, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2020, 10, 7) },

                new Comment { CommentId = 11, UserId = 3, RoomId = 7, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2020, 9, 30) },

                new Comment { CommentId = 12, UserId = 1, RoomId = 8, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2016, 8, 3) },

                new Comment { CommentId = 13, UserId = 7, RoomId = 4, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2018, 11, 2) },

                new Comment { CommentId = 14, UserId = 6, RoomId = 5, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2017, 11, 10) },

                new Comment { CommentId = 15, UserId = 5, RoomId = 15, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2017, 10, 11) },

                new Comment { CommentId = 16, UserId = 3, RoomId = 14, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2019, 8, 23) },

                new Comment { CommentId = 17, UserId = 6, RoomId = 12, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2018, 7, 18) }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { 
                    OrderId = 1,
                    BookingDateTime = new DateTime (2021,07,01),
                    UserId = 1,
                    RoomId = 1,
                    RoomName = "工業風舒適雙人房",
                    CkeckIn = new DateTime(2021, 07, 11),
                    CkeckOut = new DateTime(2021, 07, 12),
                    PaymentType = PaymentTypeEnum.CreditCard,
                    Status = OrderStatusEnum.Past,
                    BedCount = 1,
                    RoomCount = 1,
                    GuestCount = 2,
                    OriginalPrice = 2000,
                    City = "台北市",
                    District = "大安區",
                    Street = "忠孝東路三段96號11樓"

                },
                 new Order
                 {
                     OrderId = 2,
                     BookingDateTime = new DateTime(2021, 03, 15),
                     UserId = 2,
                     RoomId = 2,
                     RoomName = "利多文旅",
                     CkeckIn = new DateTime(2021, 03, 27),
                     CkeckOut = new DateTime(2021, 03, 31),
                     PaymentType = PaymentTypeEnum.CreditCard,
                     Status = OrderStatusEnum.Past,
                     BedCount = 2,
                     RoomCount = 1,
                     GuestCount = 4,
                     OriginalPrice = 6000,
                     City = "台南市",
                     District = "中西區",
                     Street = "西門路二段76號",
                 },
                  new Order
                  {
                      OrderId = 3,
                      BookingDateTime = new DateTime(2022, 03, 30),
                      UserId = 1,
                      RoomId = 3,
                      RoomName = "混和宿舍:女性專用房間|光華商場 華山文創園區阜杭豆漿 捷運1分鐘 台北車站 三創",
                      CkeckIn = new DateTime(2022, 07, 11),
                      CkeckOut = new DateTime(2022, 07, 12),
                      PaymentType = PaymentTypeEnum.LinePay,
                      Status = OrderStatusEnum.Cancel,
                      BedCount = 1,
                      RoomCount = 1,
                      GuestCount = 2,
                      OriginalPrice = 2000,
                      City = "台北市",
                      District = "大安區",
                      Street = "忠孝東路三段30號",
                  },
                   new Order
                   {
                       OrderId = 4,
                       BookingDateTime = new DateTime(2022, 04, 01),
                       UserId = 1,
                       RoomId = 4,
                       RoomName = "4人車站木地板大房間|鄰近旱溪夜市",
                       CkeckIn = new DateTime(2022, 07, 11),
                       CkeckOut = new DateTime(2022, 07, 12),
                       PaymentType = PaymentTypeEnum.CreditCard,
                       Status = OrderStatusEnum.Future,
                       BedCount = 1,
                       RoomCount = 1,
                       GuestCount = 1,
                       OriginalPrice = 1000,
                       City = "台中市",
                       District = "中區",
                       Street = "旱溪東路一段201號",

                   },
                    new Order
                    {
                        OrderId = 5,
                        BookingDateTime = new DateTime(2022, 03, 25),
                        UserId = 1,
                        RoomId = 5,
                        RoomName = "背包客或騎車環島的舒適簡易單人房",
                        CkeckIn = new DateTime(2022, 04, 11),
                        CkeckOut = new DateTime(2022, 04, 12),
                        PaymentType = PaymentTypeEnum.LinePay,
                        Status = OrderStatusEnum.Future,
                        BedCount = 1,
                        RoomCount = 1,
                        GuestCount = 2,
                        OriginalPrice = 1500,
                        City = "新竹市",
                        District = "東區",
                        Street = "經國路一段156巷",

                    },
                    new Order
                    {
                        OrderId = 6,
                        BookingDateTime = new DateTime(2021, 09, 25),
                        UserId = 1,
                        RoomId = 6,
                        RoomName = "樂圖漫遊會館",
                        CkeckIn = new DateTime(2021, 10, 21),
                        CkeckOut = new DateTime(2021, 10, 23),
                        PaymentType = PaymentTypeEnum.CreditCard,
                        Status = OrderStatusEnum.Past,
                        BedCount = 1,
                        RoomCount = 1,
                        GuestCount = 2,
                        OriginalPrice = 1500,
                        City = "澎湖市",
                        District = "馬公區",
                        Street = "西衛里261-8號",

                    }

                );

            modelBuilder.Entity<RoomCalendar>().HasData(
                new RoomCalendar 
                { RoomCalendarId = 1,
                  RoomId = 1,
                  Date = new DateTime(2022, 01, 12),
                  LastChangeTime = new DateTime(2022, 03, 02),
                  RoomCalendarStatus = RoomCalendarStatusEnum.Booked,
                  UnitPrice = 2000,
                  Note = "價格異動"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 2,
                    RoomId = 2,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 02),
                    RoomCalendarStatus = RoomCalendarStatusEnum.Booked,
                    UnitPrice = 3000,
                    Note = "價格異動"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 3,
                    RoomId = 1,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 04),
                    RoomCalendarStatus = RoomCalendarStatusEnum.Booked,
                    UnitPrice = 2000,
                    Note = "今天不租"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 4,
                    RoomId = 1,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 05),
                    RoomCalendarStatus = RoomCalendarStatusEnum.Booked,
                    UnitPrice = 2000,
                    Note = "開啟租房"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 5,
                    RoomId = 1,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 06),
                    RoomCalendarStatus = RoomCalendarStatusEnum.Hided,
                    UnitPrice = 4500,
                    Note = "價格異動"
                }
                );


            modelBuilder.Entity<RoomImg>().HasData(
                new RoomImg 
                { RoomImgId = 1,
                  RoomId = 1,
                  ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                  Sort = 1,
                  CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 2,
                    RoomId = 1,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 2,
                    CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 3,
                    RoomId = 1,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 5,
                    CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 4,
                    RoomId = 1,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 3,
                    CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 5,
                    RoomId = 1,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 4,
                    CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 6,
                    RoomId = 2,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 1,
                    CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 7,
                    RoomId = 2,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 2,
                    CreateTime = new DateTime(2022, 03, 02)
                },
                new RoomImg
                {
                    RoomImgId = 8,
                    RoomId = 2,
                    ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                    Sort = 3,
                    CreateTime = new DateTime(2022, 03, 02)
                });

            modelBuilder.Entity<RoomServiceLabel>().HasData(
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 1,
                    RoomId = 1,
                    TypeOfLabel = TypeOfLabelEnum.Wifi
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 2,
                    RoomId = 1,
                    TypeOfLabel = TypeOfLabelEnum.Kitchen
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 3,
                    RoomId = 3,
                    TypeOfLabel = TypeOfLabelEnum.Parking
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 4,
                    RoomId = 4,
                    TypeOfLabel = TypeOfLabelEnum.TV
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 5,
                    RoomId = 5,
                    TypeOfLabel = TypeOfLabelEnum.Kitchen
                });

            modelBuilder.Entity<TransactionStatus>().HasData(
                new TransactionStatus
                {
                    TransactionStatusId = 1,
                    UserId = 7,
                    OrderId = 2,
                    CreateTime = new DateTime(2015, 02, 02),
                    AdminId = 3,
                    TotalAmount = 1700,
                    StatusType = StatusTypeEnum.TransferredToOwner
                },
                new TransactionStatus
                {
                    TransactionStatusId = 2,
                    UserId = 4,
                    OrderId = 1,
                    CreateTime = new DateTime(2020, 11, 29),
                    AdminId = 3,
                    TotalAmount = 1900,
                    StatusType = StatusTypeEnum.TransferredToOwner
                },
                new TransactionStatus
                {
                    TransactionStatusId = 3,
                    UserId = 2,
                    OrderId = 3,
                    CreateTime = new DateTime(2017, 12, 05),
                    AdminId = 2,
                    TotalAmount = 1400,
                    StatusType = StatusTypeEnum.ReturnedToGuest
                },
                new TransactionStatus
                {
                    TransactionStatusId = 4,
                    UserId = 1,
                    OrderId = 4,
                    CreateTime = new DateTime(2020, 08, 12),
                    AdminId = 1,
                    TotalAmount = 7100,
                    StatusType = StatusTypeEnum.Pending
                },
                new TransactionStatus
                {
                    TransactionStatusId = 5,
                    UserId = 5,
                    OrderId = 5,
                    CreateTime = new DateTime(2022, 03, 09),
                    AdminId = 2,
                    TotalAmount = 1100,
                    StatusType = StatusTypeEnum.Pending
                },
                new TransactionStatus
                {
                    TransactionStatusId = 6,
                    UserId = 5,
                    OrderId = 6,
                    CreateTime = new DateTime(2018, 04, 12),
                    AdminId = 2,
                    TotalAmount = 5200,
                    StatusType = StatusTypeEnum.Pending
                }
                //new TransactionStatus
                //{
                //    TransactionStatusId = 7,
                //    UserId = 4,
                //    OrderId = 5,
                //    CreateTime = new DateTime(2020, 05, 12),
                //    AdminId = 1,
                //    TotalAmount = 800,
                //    StatusType = StatusTypeEnum.Pending
                //}
                //new TransactionStatus
                //{
                //    TransactionStatusId = 8,
                //    UserId = 5,
                //    OrderId = 4,
                //    CreateTime = new DateTime(2019, 07, 12),
                //    AdminId = 1,
                //    TotalAmount = 840,
                //    StatusType = StatusTypeEnum.ReturnedToGuest
                //},
                //new TransactionStatus
                //{
                //    TransactionStatusId = 9,
                //    UserId = 6,
                //    OrderId = 3,
                //    CreateTime = new DateTime(2019, 04, 30),
                //    AdminId = 3,
                //    TotalAmount = 750,
                //    StatusType = StatusTypeEnum.Pending
                //},
                //new TransactionStatus
                //{
                //    TransactionStatusId = 10,
                //    UserId = 7,
                //    OrderId = 2,
                //    CreateTime = new DateTime(2018, 06, 11),
                //    AdminId = 2,
                //    TotalAmount = 8000,
                //    StatusType = StatusTypeEnum.Pending
                //},
                //new TransactionStatus
                //{
                //    TransactionStatusId = 11,
                //    UserId = 7,
                //    OrderId = 1,
                //    CreateTime = new DateTime(2020, 09, 12),
                //    AdminId = 1,
                //    TotalAmount = 930,
                //    StatusType = StatusTypeEnum.TransferredToOwner
                //}
                );
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
