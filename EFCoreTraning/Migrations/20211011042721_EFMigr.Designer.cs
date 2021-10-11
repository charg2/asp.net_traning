﻿// <auto-generated />
using EFCoreTraning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreTraning.Migrations
{
    [DbContext(typeof(EFCoreDbContext))]
    [Migration("20211011042721_EFMigr")]
    partial class EFMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("EFCoreTraning.Models.Note", b =>
                {
                    b.Property<int>("NoteNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NoteContents")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NoteTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserNo")
                        .HasColumnType("int");

                    b.HasKey("NoteNo");

                    b.HasIndex("UserNo");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("EFCoreTraning.Models.User", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserNo");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCoreTraning.Models.Note", b =>
                {
                    b.HasOne("EFCoreTraning.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
