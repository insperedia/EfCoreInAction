﻿// <auto-generated />
using DataLayer.EfCode;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DataLayer.Migrations
{
    [DbContext(typeof(EfCoreContext))]
    partial class EfCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.EfClasses.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("PublishedOn");

                    b.Property<string>("Publisher");

                    b.Property<bool>("SoftDeleted");

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DataLayer.EfClasses.BookAuthor", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("AuthorId");

                    b.Property<byte>("Order");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("DataLayer.EfClasses.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<decimal>("BookPrice");

                    b.Property<byte>("LineNum");

                    b.Property<short>("NumBooks");

                    b.Property<int>("OrderId");

                    b.HasKey("LineItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerName");

                    b.Property<DateTime>("DateOrderedUtc");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataLayer.EfClasses.PriceOffer", b =>
                {
                    b.Property<int>("PriceOfferId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<decimal>("NewPrice");

                    b.Property<string>("PromotionalText");

                    b.HasKey("PriceOfferId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("PriceOffers");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<string>("Comment");

                    b.Property<int>("NumStars");

                    b.Property<string>("VoterName");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("DataLayer.EfClasses.BookAuthor", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Author", "Author")
                        .WithMany("BooksLink")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLayer.EfClasses.Book", "Book")
                        .WithMany("AuthorsLink")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.EfClasses.LineItem", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Book", "ChosenBook")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataLayer.EfClasses.Order")
                        .WithMany("LineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.EfClasses.PriceOffer", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Book")
                        .WithOne("Promotion")
                        .HasForeignKey("DataLayer.EfClasses.PriceOffer", "BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.EfClasses.Review", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
