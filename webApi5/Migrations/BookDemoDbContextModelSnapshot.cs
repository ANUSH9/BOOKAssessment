﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webApi5;

#nullable disable

namespace webApi5.Migrations
{
    [DbContext(typeof(BookDemoDbContext))]
    partial class BookDemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("webApi5.Model.books", b =>
                {
                    b.Property<int>("bookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookID"), 1L, 1);

                    b.Property<float>("BookCost")
                        .HasColumnType("real");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zoner")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("Varchar(15)");

                    b.HasKey("bookID");

                    b.ToTable("BookDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
