﻿// <auto-generated />
using ItechArtLabPetsitters.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ItechArtLabPetsitters.Infrastructure.Migrations
{
    [DbContext(typeof(PetsittersContext))]
    [Migration("20211102192429_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Client", b =>
                {
                    b.Property<long>("_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Order", b =>
                {
                    b.Property<long>("_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("_ClientID")
                        .HasColumnType("bigint");

                    b.Property<string>("_Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("_PetID")
                        .HasColumnType("bigint");

                    b.Property<long>("_PetsitterID")
                        .HasColumnType("bigint");

                    b.Property<long>("_ServiceID")
                        .HasColumnType("bigint");

                    b.HasKey("_ID");

                    b.HasIndex("_ClientID");

                    b.HasIndex("_PetID");

                    b.HasIndex("_PetsitterID");

                    b.HasIndex("_ServiceID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Pet", b =>
                {
                    b.Property<long>("_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("_Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_PetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_PetType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_ID");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Petsitter", b =>
                {
                    b.Property<long>("_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_ID");

                    b.ToTable("Petsitters");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Review", b =>
                {
                    b.Property<long>("_ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("_ClientID")
                        .HasColumnType("bigint");

                    b.Property<string>("_Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("_Mark")
                        .HasColumnType("tinyint");

                    b.Property<long>("_PetsitterID")
                        .HasColumnType("bigint");

                    b.HasKey("_ReviewID");

                    b.HasIndex("_ClientID");

                    b.HasIndex("_PetsitterID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Service", b =>
                {
                    b.Property<long>("_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("_ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_ID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Order", b =>
                {
                    b.HasOne("ItechArtLabPetsitters.Core.Entities.Client", "_Client")
                        .WithMany("_Orders")
                        .HasForeignKey("_ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Core.Entities.Pet", "_Pet")
                        .WithMany("_Orders")
                        .HasForeignKey("_PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Core.Entities.Petsitter", "_Petsitter")
                        .WithMany("_Orders")
                        .HasForeignKey("_PetsitterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Core.Entities.Service", "_Service")
                        .WithMany("_Orders")
                        .HasForeignKey("_ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Client");

                    b.Navigation("_Pet");

                    b.Navigation("_Petsitter");

                    b.Navigation("_Service");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Review", b =>
                {
                    b.HasOne("ItechArtLabPetsitters.Core.Entities.Client", "_Client")
                        .WithMany("_Reviews")
                        .HasForeignKey("_ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Core.Entities.Petsitter", "_Petsitter")
                        .WithMany("_Reviews")
                        .HasForeignKey("_PetsitterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Client");

                    b.Navigation("_Petsitter");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Client", b =>
                {
                    b.Navigation("_Orders");

                    b.Navigation("_Reviews");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Pet", b =>
                {
                    b.Navigation("_Orders");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Petsitter", b =>
                {
                    b.Navigation("_Orders");

                    b.Navigation("_Reviews");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Core.Entities.Service", b =>
                {
                    b.Navigation("_Orders");
                });
#pragma warning restore 612, 618
        }
    }
}