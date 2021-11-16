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
    [Migration("20211115200847_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Client", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientID")
                        .HasColumnType("bigint");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PetID")
                        .HasColumnType("bigint");

                    b.Property<long>("PetsitterID")
                        .HasColumnType("bigint");

                    b.Property<long>("ServiceID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("PetID");

                    b.HasIndex("PetsitterID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Pet", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Petsitter", b =>
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

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Review", b =>
                {
                    b.Property<long>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientID")
                        .HasColumnType("bigint");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Mark")
                        .HasColumnType("tinyint");

                    b.Property<long>("PetsitterID")
                        .HasColumnType("bigint");

                    b.HasKey("ReviewID");

                    b.HasIndex("ClientID");

                    b.HasIndex("PetsitterID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Service", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Order", b =>
                {
                    b.HasOne("ItechArtLabPetsitters.Repository.Entities.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Repository.Entities.Pet", "Pet")
                        .WithMany("Orders")
                        .HasForeignKey("PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Repository.Entities.Petsitter", "Petsitter")
                        .WithMany("Orders")
                        .HasForeignKey("PetsitterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Repository.Entities.Service", "Service")
                        .WithMany("Orders")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Pet");

                    b.Navigation("Petsitter");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Review", b =>
                {
                    b.HasOne("ItechArtLabPetsitters.Repository.Entities.Client", "Client")
                        .WithMany("Reviews")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItechArtLabPetsitters.Repository.Entities.Petsitter", "Petsitter")
                        .WithMany("Reviews")
                        .HasForeignKey("PetsitterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Petsitter");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Client", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Pet", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Petsitter", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ItechArtLabPetsitters.Repository.Entities.Service", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}