﻿// <auto-generated />
using System;
using IMDB_clone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IMDB_clone.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211127162408_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CrewMovie", b =>
                {
                    b.Property<int>("MovieActorsCrewID")
                        .HasColumnType("int");

                    b.Property<int>("MovieActorsId")
                        .HasColumnType("int");

                    b.HasKey("MovieActorsCrewID", "MovieActorsId");

                    b.HasIndex("MovieActorsId");

                    b.ToTable("CrewMovie");
                });

            modelBuilder.Entity("IMDB_clone.Entities.Crew", b =>
                {
                    b.Property<int>("CrewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CrewAge")
                        .HasColumnType("int");

                    b.Property<string>("CrewBio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrewName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrewSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("crewType")
                        .HasColumnType("int");

                    b.HasKey("CrewID");

                    b.ToTable("Crew");
                });

            modelBuilder.Entity("IMDB_clone.Entities.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("IMDB_clone.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("IMDB_clone.Entities.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ReviewPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("LocationMovie", b =>
                {
                    b.Property<int>("MovieLocationsId")
                        .HasColumnType("int");

                    b.Property<int>("MovieLocationsLocationID")
                        .HasColumnType("int");

                    b.HasKey("MovieLocationsId", "MovieLocationsLocationID");

                    b.HasIndex("MovieLocationsLocationID");

                    b.ToTable("LocationMovie");
                });

            modelBuilder.Entity("MovieReview", b =>
                {
                    b.Property<int>("MovieReviewsId")
                        .HasColumnType("int");

                    b.Property<int>("MovieReviewsReviewID")
                        .HasColumnType("int");

                    b.HasKey("MovieReviewsId", "MovieReviewsReviewID");

                    b.HasIndex("MovieReviewsReviewID");

                    b.ToTable("MovieReview");
                });

            modelBuilder.Entity("CrewMovie", b =>
                {
                    b.HasOne("IMDB_clone.Entities.Crew", null)
                        .WithMany()
                        .HasForeignKey("MovieActorsCrewID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMDB_clone.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocationMovie", b =>
                {
                    b.HasOne("IMDB_clone.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieLocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMDB_clone.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("MovieLocationsLocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieReview", b =>
                {
                    b.HasOne("IMDB_clone.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieReviewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMDB_clone.Entities.Review", null)
                        .WithMany()
                        .HasForeignKey("MovieReviewsReviewID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
