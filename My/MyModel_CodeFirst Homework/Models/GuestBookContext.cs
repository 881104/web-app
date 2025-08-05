using Microsoft.EntityFrameworkCore;

namespace MyModel_CodeFirst_Homework.Models
{
    public class GuestBookContext : DbContext
    {
        public GuestBookContext(DbContextOptions<GuestBookContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<ReBook> ReBook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookID).HasName("PK_BookID"); //指定名字(自己取)

                entity.Property(e => e.BookID)//設定屬性
                .HasMaxLength(36)  //BookID長度為36
                .IsUnicode(false); //不使用Unicode編碼 

                entity.Property(e => e.Title)
               .HasMaxLength(30);

                entity.Property(e => e.Author)
               .HasMaxLength(20);

                entity.Property(e => e.Photo)
               .HasMaxLength(40);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime"); // 設定為datetime型別
            });

            modelBuilder.Entity<ReBook>(entity =>
            {
                entity.HasKey(e => e.ReBookID); //設定主鍵
                entity.Property(e => e.ReBookID).HasMaxLength(36)  //長度為36
                .IsUnicode(false);  //ReBookID預設值為GUID

                entity.Property(e => e.Author)
                .HasMaxLength(20);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime"); // 設定為datetime型別

            });
        }
    }
}

        

