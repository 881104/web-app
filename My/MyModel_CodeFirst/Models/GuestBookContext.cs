using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyModel_CodeFirst.Models
{
    //1.2.2 撰寫GuestBookContext類別的內容
    //(1)須繼承DbContext類別
    public class GuestBookContext : DbContext
    {
        //(2)撰寫依賴注入用的建構子
        public GuestBookContext(DbContextOptions<GuestBookContext> options)
            : base(options)
        {
        }

        //(3)描述資料庫裡面的資料表
        public virtual DbSet<Book> Book { get; set; } //Book資料表
        public virtual DbSet<ReBook> ReBook { get; set; } //ReBook資料表

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1.2.6

            // 可在此處進行模型配置，例如設定主鍵、索引等
            //modelBuilder.Entity<Book>(E)
            //    .HasKey(b => b.BookID);
            modelBuilder.Entity<ReBook>()
                .HasKey(r => r.ReBookID);
            // 設定Book與ReBook之間的一對多關聯
            modelBuilder.Entity<Book>()
                .HasMany(b => b.ReBooks)
                .WithOne(r => r.Book)
                .HasForeignKey(r => r.BookID);
        }
    }
}
