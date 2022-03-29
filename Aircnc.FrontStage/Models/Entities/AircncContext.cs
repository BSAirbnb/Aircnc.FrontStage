using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
                new UserVerification { UserVerificationId = 1,DocumentType =1 ,Status =1,ApplyTime = DateTime.Now, CertificationTime= DateTime.Now,AdminId = 1},
                new UserVerification { UserVerificationId = 2, DocumentType = 1, Status = 1, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 2 },
                new UserVerification { UserVerificationId = 3, DocumentType = 1, Status = 1, ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 1 }
           );
            modelBuilder.Entity<BankVerification>().HasData(
                new BankVerification { BankVerificationId = 1, Status = 1, BankAccount = "80222222222220",ApplyTime=DateTime.Now,CertificationTime=DateTime.Now,AdminId=1,BankbookImg= "https://picsum.photos/seed/picsum/200/300" },
                new BankVerification { BankVerificationId = 2, Status = 1, BankAccount = "80222222222221", ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 1, BankbookImg = "https://picsum.photos/seed/picsum/200/300" },
                new BankVerification { BankVerificationId = 3, Status = 1, BankAccount = "80222222222222", ApplyTime = DateTime.Now, CertificationTime = DateTime.Now, AdminId = 2, BankbookImg = "https://picsum.photos/seed/picsum/200/300" }
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
                    IsDelete = false
                }

            );
            modelBuilder.Entity<Message>().HasData(
                new Message { MessageId = 1, SenderId = 1, RecipientId = 2, Text = "HI", SendTime = DateTime.Now },
                new Message { MessageId = 2, SenderId = 1, RecipientId = 2, Text = "HI", SendTime = DateTime.Now },
                new Message { MessageId = 3, SenderId = 1, RecipientId = 2, Text = "HI", SendTime = DateTime.Now }
            );
            modelBuilder.Entity<Room>().HasData(
                new Room() { RoomId = 1, UserId = 1, HouseType = 1, RoomType = 1, Street = "石潭路88號", District = "內湖區", City = "台北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "星雲小屋", UnitPrice = 2310, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 2, UserId = 2, HouseType = 2, RoomType = 2, Street = "南京東路3段25號9樓", District = "松山區", City = "台北市", Country = "台灣", Pax = 3, BedCount = 2, RoomCount = 1, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "小葉-懶人-溫馨寬敞的樓中樓套房,青山綠樹景色,適合宅度假", UnitPrice = 710, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 3, UserId = 3, HouseType = 3, RoomType = 3, Street = "東新街116-3號", District = "南港區", City = "台北市", Country = "台灣", Pax = 2, BedCount = 1, RoomCount = 1, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "景觀雙人房A25，免費早餐、交通方便、溫馨舒適", UnitPrice = 500, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 4, UserId = 4, HouseType = 4, RoomType = 3, Street = "敦化南路二段201號", District = "大安區", City = "台北市", Country = "台灣", Pax = 5, BedCount = 5, RoomCount = 1, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "303魚池白宮", UnitPrice = 1110, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 5, UserId = 1, HouseType = 1, RoomType = 2, Street = "林森南路17號", District = "中正區", City = "台北市", Country = "台灣", Pax = 4, BedCount = 2, RoomCount = 2, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "捷運站步行3分鐘 近夜市與101 Near MRT & Taipei 101", UnitPrice = 990, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 6, UserId = 2, HouseType = 5, RoomType = 1, Street = "福德路57巷2號1樓", District = "士林區", City = "台北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "1 min walk to YounChun MRT, center of Taipei city", UnitPrice = 3210, CreateTime = new DateTime(2011, 6, 10), LastChangeTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 7, UserId = 6, HouseType = 2, RoomType = 2, Street = "中正路570號", District = "永和區", City = "新北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "榮星花園旁靜巷溫馨小宅～適合親子同遊！", UnitPrice = 1495, CreateTime = new DateTime(2011, 6, 10), Status = 2 },
                new Room() { RoomId = 8, UserId = 5, HouseType = 3, RoomType = 3, Street = "大仁街44號", District = "三重區", City = "新北市", Country = "台灣", Pax = 6, BedCount = 3, RoomCount = 3, BathroomCount = 2, RoomDescription = "優質房源", RoomName = "[K] 38 ✦ 大雙人房 含獨立衛浴 沙發", UnitPrice = 865, CreateTime = new DateTime(2011, 6, 10), Status = 2 }
                );
            modelBuilder.Entity<WishList>().HasData(
                new WishList { WishListId = 1, UserId = 1, RoomId = 1, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 2, UserId = 2, RoomId = 2, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 3, UserId = 3, RoomId = 3, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 4, UserId = 4, RoomId = 4, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 5, UserId = 5, RoomId = 5, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 6, UserId = 6, RoomId = 6, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 7, UserId = 6, RoomId = 3, CreateTime = new DateTime(2013, 7, 18) },

                new WishList { WishListId = 8, UserId = 5, RoomId = 2, CreateTime = new DateTime(2013, 7, 18) });

            //    new WishList { WishListId = 9, UserId = 4, RoomId = 6, CreateTime = new DateTime(12 - 31 - 2011) },

            //    new WishList { WishListId = 10, UserId = 3, RoomId = 7, CreateTime = new DateTime(12 - 31 - 2011) },

            //    new WishList { WishListId = 11, UserId = 2, RoomId = 8, CreateTime = new DateTime(12 - 31 - 2011) }
            //);


            modelBuilder.Entity<Comment>().HasData(
                new Comment { CommentId = 1, UserId = 1, RoomId = 3, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 2, UserId = 3, RoomId = 2, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 3, UserId = 3, RoomId = 3, CommentContent = "環境整潔，還不錯", Stars = 2, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 4, UserId = 5, RoomId = 4, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 5, UserId = 6, RoomId = 5, CommentContent = "環境整潔，還不錯", Stars = 5, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 6, UserId = 7, RoomId = 2, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 7, UserId = 1, RoomId = 6, CommentContent = "環境整潔，還不錯", Stars = 4, CreateTime = new DateTime(2013, 7, 18) },


                new Comment { CommentId = 8, UserId = 5, RoomId = 1, CommentContent = "環境整潔，還不錯", Stars = 3, CreateTime = new DateTime(2013, 7, 18) });

            //        new Comment { CommentId = 9, UserId = 2, RoomId = 7, Comment = "環境整潔，還不錯", Stars = 5, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 10, UserId = 6, RoomId = 4, Comment = "環境整潔，還不錯", Stars = 5, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 11, UserId = 4, RoomId = 7, Comment = "環境整潔，還不錯", Stars = 3, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 12, UserId = 5, RoomId = 8, Comment = "環境整潔，還不錯", Stars = 3, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 13, UserId = 2, RoomId = 4, Comment = "環境整潔，還不錯", Stars = 4, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 14, UserId = 1, RoomId = 5, Comment = "環境整潔，還不錯", Stars = 5, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 15, UserId = 1, RoomId = 2, Comment = "環境整潔，還不錯", Stars = 3, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 16, UserId = 2, RoomId = 8, Comment = "環境整潔，還不錯", Stars = 4, CreateTime = "2020-04-52" }

            //        new Comment { CommentId = 17, UserId = 6, RoomId = 1, Comment = "環境整潔，還不錯", Stars = 4, CreateTime = "2020-04-52" }
            //    );

            modelBuilder.Entity<Order>().HasData(
                new Order { 
                    OrderId = 1,
                    BookingDateTime = new DateTime (2022,07,01),
                    UserId = 1,
                    RoomId = 1,
                    RoomName = "高級馬桶",
                    CkeckIn = new DateTime(2022, 07, 11),
                    CkeckOut = new DateTime(2022, 07, 12),
                    PaymentType = 1,
                    Status = 1,
                    BedCount = 1,
                    RoomCount = 1,
                    GuestCount = 2,
                    OriginalPrice = 2000,
                    City = "台中市",
                    District = "沙鹿區",
                    Street = "沙鹿路87樓"

                },
                 new Order
                 {
                     OrderId = 2,
                     BookingDateTime = new DateTime(2022, 07, 01),
                     UserId = 1,
                     RoomId = 1,
                     CkeckIn = new DateTime(2022, 07, 11),
                     CkeckOut = new DateTime(2022, 07, 12),
                     PaymentType = 1,
                     Status = 1,
                     BedCount = 2,
                     RoomCount = 1,
                     GuestCount = 4,
                     OriginalPrice = 6000,
                     City = "花蓮市",
                     District = "吉安鄉",
                     Street = "曾記麻糬路3號",
                     RoomName = "麻糬吃到飽飯店"
                 },
                  new Order
                  {
                      OrderId = 3,
                      BookingDateTime = new DateTime(2022, 07, 01),
                      UserId = 1,
                      RoomId = 1,
                      CkeckIn = new DateTime(2022, 07, 11),
                      CkeckOut = new DateTime(2022, 07, 12),
                      PaymentType = 1,
                      Status = 1,
                      BedCount = 1,
                      RoomCount = 1,
                      GuestCount = 2,
                      OriginalPrice = 2000,
                      City = "台北市",
                      District = "信義區",
                      Street = "市府路一號",
                      RoomName = "台北市政府柯文哲辦公室"
                  },
                   new Order
                   {
                       OrderId = 4,
                       BookingDateTime = new DateTime(2022, 07, 01),
                       UserId = 1,
                       RoomId = 1,
                       CkeckIn = new DateTime(2022, 07, 11),
                       CkeckOut = new DateTime(2022, 07, 12),
                       PaymentType = 1,
                       Status = 1,
                       BedCount = 1,
                       RoomCount = 1,
                       GuestCount = 1,
                       OriginalPrice = 1000,
                       City = "台南市",
                       District = "中西區",
                       Street = "國華街",
                       RoomName = "堯平布朗尼吃到飽飯店"

                   },
                    new Order
                    {
                        OrderId = 5,
                        BookingDateTime = new DateTime(2022, 07, 01),
                        UserId = 1,
                        RoomId = 1,
                        CkeckIn = new DateTime(2022, 07, 11),
                        CkeckOut = new DateTime(2022, 07, 12),
                        PaymentType = 1,
                        Status = 1,
                        BedCount = 1,
                        RoomCount = 1,
                        GuestCount = 2,
                        OriginalPrice = 1500,
                        City = "新竹市",
                        District = "東區",
                        Street = "新竹科學園區路78號",
                        RoomName = "高階工程師聚集旅社"

                    }
                );

            modelBuilder.Entity<RoomCalendar>().HasData(
                new RoomCalendar 
                { RoomCalendarId = 1,
                  RoomId = 1,
                  Date = new DateTime(2022, 01, 12),
                  LastChangeTime = new DateTime(2022, 03, 02),
                  RoomCalendarStatus = 1,
                  UnitPrice = 2000,
                  Note = "價格異動"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 2,
                    RoomId = 2,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 02),
                    RoomCalendarStatus = 1,
                    UnitPrice = 3000,
                    Note = "價格異動"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 3,
                    RoomId = 1,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 02),
                    RoomCalendarStatus = 1,
                    UnitPrice = 2000,
                    Note = "今天不租"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 4,
                    RoomId = 1,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 02),
                    RoomCalendarStatus = 1,
                    UnitPrice = 2000,
                    Note = "開啟租房"
                },
                new RoomCalendar
                {
                    RoomCalendarId = 5,
                    RoomId = 1,
                    Date = new DateTime(2022, 01, 12),
                    LastChangeTime = new DateTime(2022, 03, 02),
                    RoomCalendarStatus = 1,
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
                    TypeOfLabel = 1
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 2,
                    RoomId = 1,
                    TypeOfLabel = 2
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 3,
                    RoomId = 3,
                    TypeOfLabel = 3
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 4,
                    RoomId = 4,
                    TypeOfLabel = 2
                },
                new RoomServiceLabel
                {
                    RoomServiceLabelId = 5,
                    RoomId = 5,
                    TypeOfLabel = 2
                });

            modelBuilder.Entity<TransactionStatus>().HasData(
                new TransactionStatus
                {
                    TransactionStatusId = 1,
                    UserId = 1,
                    OrderId = 2,
                    CreateTime = new DateTime(2022, 03, 02),
                    AdminId = 1,
                    TotalAmount = 1700,
                    StatusType = 1
                },
                new TransactionStatus
                {
                    TransactionStatusId = 2,
                    UserId = 1,
                    OrderId = 2,
                    CreateTime = new DateTime(2022, 03, 29),
                    AdminId = 1,
                    TotalAmount = 1900,
                    StatusType = 1
                },
                new TransactionStatus
                {
                    TransactionStatusId = 3,
                    UserId = 2,
                    OrderId = 4,
                    CreateTime = new DateTime(2022, 03, 05),
                    AdminId = 1,
                    TotalAmount = 1400,
                    StatusType = 2
                },
                new TransactionStatus
                {
                    TransactionStatusId = 4,
                    UserId = 1,
                    OrderId = 2,
                    CreateTime = new DateTime(2022, 04, 12),
                    AdminId = 1,
                    TotalAmount = 3500,
                    StatusType = 2
                },
                new TransactionStatus
                {
                    TransactionStatusId = 5,
                    UserId = 1,
                    OrderId = 2,
                    CreateTime = new DateTime(2022, 03, 09),
                    AdminId = 1,
                    TotalAmount = 1100,
                    StatusType = 3
                });
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
