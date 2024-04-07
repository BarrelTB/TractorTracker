﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TractorTracker.Core;

#nullable disable

namespace TractorTracker.Core.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    partial class CoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EquipmentWorker", b =>
                {
                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersId")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId", "WorkersId");

                    b.HasIndex("WorkersId");

                    b.ToTable("EquipmentWorker");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Chassis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastCleaningAndLubricationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RustRating")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId")
                        .IsUnique();

                    b.ToTable("Chassis");

                    b.HasDiscriminator().HasValue("Chassis");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Fuel")
                        .HasColumnType("int");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastFilterChange")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastOilChange")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfCylinders")
                        .HasColumnType("int");

                    b.Property<string>("OilType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("size")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId")
                        .IsUnique();

                    b.ToTable("Engine");

                    b.HasDiscriminator().HasValue("Engine");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Equipment");

                    b.HasDiscriminator().HasValue("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FieldIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("LatLocation")
                        .HasColumnType("float");

                    b.Property<double>("LongLocation")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChassisId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentBaseId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<int>("RimId")
                        .HasColumnType("int");

                    b.Property<int>("TireId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<int>("WheelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChassisId");

                    b.HasIndex("EngineId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("PartId");

                    b.HasIndex("RimId");

                    b.HasIndex("TireId");

                    b.HasIndex("TransmissionId");

                    b.HasIndex("WheelId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Part");

                    b.HasDiscriminator().HasValue("Part");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Rim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RustRating")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("WheelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WheelId");

                    b.ToTable("Rim");

                    b.HasDiscriminator().HasValue("Rim");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Tire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Psi")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreadPattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WearRating")
                        .HasColumnType("int");

                    b.Property<int>("WheelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WheelId");

                    b.ToTable("Tire");

                    b.HasDiscriminator().HasValue("Tire");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastFilterChange")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastFluidChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId")
                        .IsUnique();

                    b.ToTable("Transmission");

                    b.HasDiscriminator().HasValue("Transmission");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZoneInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Wheel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrakeRating")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChassisId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastBrakeChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChassisId");

                    b.ToTable("Wheel");

                    b.HasDiscriminator().HasValue("Wheel");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthsOfService")
                        .HasColumnType("int");

                    b.Property<int>("YearsOfService")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("EquipmentWorker", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Equipment", null)
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Chassis", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Equipment", "Equipment")
                        .WithOne("Chassis")
                        .HasForeignKey("TractorTracker.Core.Models.Chassis", "EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Engine", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Equipment", "Equipment")
                        .WithOne("Engine")
                        .HasForeignKey("TractorTracker.Core.Models.Engine", "EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Equipment", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Location", "Location")
                        .WithMany("Equipment")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.User", "User")
                        .WithMany("Equipment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Note", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Chassis", "Chassis")
                        .WithMany("Notes")
                        .HasForeignKey("ChassisId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Engine", "Engine")
                        .WithMany("Notes")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Equipment", "Equipment")
                        .WithMany("Notes")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Part", "Part")
                        .WithMany("Notes")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Rim", "Rim")
                        .WithMany("Notes")
                        .HasForeignKey("RimId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Tire", "Tire")
                        .WithMany("Notes")
                        .HasForeignKey("TireId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Transmission", "Transmission")
                        .WithMany("Notes")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TractorTracker.Core.Models.Wheel", "Wheel")
                        .WithMany("Notes")
                        .HasForeignKey("WheelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Chassis");

                    b.Navigation("Engine");

                    b.Navigation("Equipment");

                    b.Navigation("Part");

                    b.Navigation("Rim");

                    b.Navigation("Tire");

                    b.Navigation("Transmission");

                    b.Navigation("Wheel");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Part", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Equipment", "Equipment")
                        .WithMany("Parts")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Rim", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Wheel", "Wheel")
                        .WithMany("Rims")
                        .HasForeignKey("WheelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Wheel");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Tire", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Wheel", "Wheel")
                        .WithMany("Tires")
                        .HasForeignKey("WheelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Wheel");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Transmission", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Equipment", "Equipment")
                        .WithOne("Transmission")
                        .HasForeignKey("TractorTracker.Core.Models.Transmission", "EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Wheel", b =>
                {
                    b.HasOne("TractorTracker.Core.Models.Chassis", "Chassis")
                        .WithMany("Wheels")
                        .HasForeignKey("ChassisId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Chassis");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Chassis", b =>
                {
                    b.Navigation("Notes");

                    b.Navigation("Wheels");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Engine", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Equipment", b =>
                {
                    b.Navigation("Chassis");

                    b.Navigation("Engine");

                    b.Navigation("Notes");

                    b.Navigation("Parts");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Location", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Part", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Rim", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Tire", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Transmission", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.User", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TractorTracker.Core.Models.Wheel", b =>
                {
                    b.Navigation("Notes");

                    b.Navigation("Rims");

                    b.Navigation("Tires");
                });
#pragma warning restore 612, 618
        }
    }
}
