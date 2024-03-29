﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeStore.Data.EFCore;

#nullable disable

namespace ShoeStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240112152745_first migration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ShoeStore.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("ShoeStore.Models.CollectionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CollectionTypes");
                });

            modelBuilder.Entity("ShoeStore.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("ShoeStore.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("ShoeStore.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("ShoeStore.Models.Shoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollectionTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeasonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShoeTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CollectionTypeId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModelId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("ShoeTypeId");

                    b.HasIndex("SizeId");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("ShoeStore.Models.ShoeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShoeTypes");
                });

            modelBuilder.Entity("ShoeStore.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Number")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("ShoeStore.Models.Model", b =>
                {
                    b.HasOne("ShoeStore.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("ShoeStore.Models.Shoe", b =>
                {
                    b.HasOne("ShoeStore.Models.CollectionType", "CollectionType")
                        .WithMany("Shoes")
                        .HasForeignKey("CollectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeStore.Models.Color", "Color")
                        .WithMany("Shoes")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeStore.Models.Model", "Model")
                        .WithMany("Shoes")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeStore.Models.Season", "Season")
                        .WithMany("Shoes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeStore.Models.ShoeType", "ShoeType")
                        .WithMany("Shoes")
                        .HasForeignKey("ShoeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeStore.Models.Size", "Size")
                        .WithMany("Shoes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CollectionType");

                    b.Navigation("Color");

                    b.Navigation("Model");

                    b.Navigation("Season");

                    b.Navigation("ShoeType");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("ShoeStore.Models.CollectionType", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("ShoeStore.Models.Color", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("ShoeStore.Models.Model", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("ShoeStore.Models.Season", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("ShoeStore.Models.ShoeType", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("ShoeStore.Models.Size", b =>
                {
                    b.Navigation("Shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
