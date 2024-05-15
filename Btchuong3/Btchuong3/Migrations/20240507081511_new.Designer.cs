﻿// <auto-generated />
using System;
using Btchuong3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Btchuong3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240507081511_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Btchuong3.Model.Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "J.K. Rowling"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Fujiko Fujio"
                        });
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Book_Author", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("Id", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("PublisherID")
                        .HasColumnType("int");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverUrl = "https://images.example.com/BookHarry-Potter.jpg",
                            DateAdded = new DateTime(2024, 5, 7, 15, 15, 9, 295, DateTimeKind.Local).AddTicks(9971),
                            DateRead = new DateTime(2024, 5, 7, 15, 15, 9, 295, DateTimeKind.Local).AddTicks(9952),
                            Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry.",
                            Genre = "dung",
                            IsRead = true,
                            PublisherID = 1,
                            Rate = 5,
                            Title = "Harry Potter and the Chamber of Secrets"
                        },
                        new
                        {
                            Id = 2,
                            CoverUrl = "https://images.example.com/BookDoraemon.jpg",
                            DateAdded = new DateTime(2024, 5, 7, 15, 15, 9, 295, DateTimeKind.Local).AddTicks(9990),
                            DateRead = new DateTime(2024, 5, 7, 15, 15, 9, 295, DateTimeKind.Local).AddTicks(9987),
                            Description = "Doraemon phieu luu cung nhung nguoi ban",
                            Genre = "dung",
                            IsRead = true,
                            PublisherID = 2,
                            Rate = 5,
                            Title = "Doraemon"
                        });
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Publishers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bloomsbury Publishing"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kim dong"
                        });
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Book_Author", b =>
                {
                    b.HasOne("Btchuong3.Model.Domain.Author", "Author")
                        .WithMany("Book_Authors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Btchuong3.Model.Domain.Books", "Book")
                        .WithMany("Book_Authors")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Books", b =>
                {
                    b.HasOne("Btchuong3.Model.Domain.Publishers", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Author", b =>
                {
                    b.Navigation("Book_Authors");
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Books", b =>
                {
                    b.Navigation("Book_Authors");
                });

            modelBuilder.Entity("Btchuong3.Model.Domain.Publishers", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
