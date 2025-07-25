﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyModel_CodeFirst.Models;

#nullable disable

namespace MyModel_CodeFirst.Migrations
{
    [DbContext(typeof(GuestBookContext))]
    partial class GuestBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyModel_CodeFirst.Models.Book", b =>
                {
                    b.Property<string>("BookID")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("BookID")
                        .HasName("PK_BookID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("MyModel_CodeFirst.Models.Login", b =>
                {
                    b.Property<string>("Account")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Account");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("MyModel_CodeFirst.Models.ReBook", b =>
                {
                    b.Property<string>("ReBookID")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BookID")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReBookID");

                    b.HasIndex("BookID");

                    b.ToTable("ReBook");
                });

            modelBuilder.Entity("MyModel_CodeFirst.Models.ReBook", b =>
                {
                    b.HasOne("MyModel_CodeFirst.Models.Book", "Book")
                        .WithMany("ReBooks")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MyModel_CodeFirst.Models.Book", b =>
                {
                    b.Navigation("ReBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
