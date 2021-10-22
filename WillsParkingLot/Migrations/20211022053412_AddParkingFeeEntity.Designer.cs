﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WillsParkingLot.DbContexts;

namespace WillsParkingLot.Migrations
{
    [DbContext(typeof(WillsParkingLotContext))]
    [Migration("20211022053412_AddParkingFeeEntity")]
    partial class AddParkingFeeEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WillsParkingLot.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WillsParkingLot.Models.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayId");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            DayId = 1,
                            DayName = "Monday"
                        },
                        new
                        {
                            DayId = 2,
                            DayName = "Tuesday"
                        },
                        new
                        {
                            DayId = 3,
                            DayName = "Wednesday"
                        },
                        new
                        {
                            DayId = 4,
                            DayName = "Thursday"
                        },
                        new
                        {
                            DayId = 5,
                            DayName = "Friday"
                        },
                        new
                        {
                            DayId = 6,
                            DayName = "Saturday"
                        },
                        new
                        {
                            DayId = 7,
                            DayName = "Sunday"
                        });
                });

            modelBuilder.Entity("WillsParkingLot.Models.Parking", b =>
                {
                    b.Property<int>("ParkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArriveTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LeaveTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ParkingId");

                    b.HasIndex("CarId");

                    b.ToTable("Parkings");
                });

            modelBuilder.Entity("WillsParkingLot.Models.ParkingFee", b =>
                {
                    b.Property<int>("ParkingFeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParkingId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalParkingFeeCollected")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ParkingFeeId");

                    b.HasIndex("ParkingId");

                    b.ToTable("ParkingFees");
                });

            modelBuilder.Entity("WillsParkingLot.Models.RateYearDay", b =>
                {
                    b.Property<int>("RateYearDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<decimal?>("IncrementPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("YearId")
                        .HasColumnType("int");

                    b.HasKey("RateYearDayId");

                    b.HasIndex("DayId");

                    b.HasIndex("YearId");

                    b.ToTable("RateYearsDays");

                    b.HasData(
                        new
                        {
                            RateYearDayId = 1,
                            CarType = 0,
                            DayId = 1,
                            Rate = 20m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 945, DateTimeKind.Local).AddTicks(59),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 2,
                            CarType = 0,
                            DayId = 2,
                            Rate = 20m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3824),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 3,
                            CarType = 0,
                            DayId = 3,
                            Rate = 20m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3870),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 4,
                            CarType = 0,
                            DayId = 4,
                            Rate = 20m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3876),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 5,
                            CarType = 0,
                            DayId = 5,
                            Rate = 20m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(3880),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 6,
                            CarType = 0,
                            DayId = 6,
                            IncrementPercent = 15m,
                            Rate = 20m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4371),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 7,
                            CarType = 0,
                            DayId = 7,
                            Rate = 0m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4387),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 8,
                            CarType = 1,
                            DayId = 1,
                            Rate = 22m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4391),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 9,
                            CarType = 1,
                            DayId = 2,
                            Rate = 22m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4395),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 10,
                            CarType = 1,
                            DayId = 3,
                            Rate = 22m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4399),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 11,
                            CarType = 1,
                            DayId = 4,
                            Rate = 22m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4402),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 12,
                            CarType = 1,
                            DayId = 5,
                            Rate = 22m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4406),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 13,
                            CarType = 1,
                            DayId = 6,
                            IncrementPercent = 15m,
                            Rate = 22m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4423),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 14,
                            CarType = 1,
                            DayId = 7,
                            Rate = 0m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4427),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 15,
                            CarType = 2,
                            DayId = 1,
                            Rate = 25m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4431),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 16,
                            CarType = 2,
                            DayId = 2,
                            Rate = 25m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4435),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 17,
                            CarType = 2,
                            DayId = 3,
                            Rate = 25m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4438),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 18,
                            CarType = 2,
                            DayId = 4,
                            Rate = 25m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4442),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 19,
                            CarType = 2,
                            DayId = 5,
                            Rate = 25m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4446),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 20,
                            CarType = 2,
                            DayId = 6,
                            IncrementPercent = 15m,
                            Rate = 25m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4450),
                            YearId = 1
                        },
                        new
                        {
                            RateYearDayId = 21,
                            CarType = 2,
                            DayId = 7,
                            Rate = 0m,
                            RegistrationDate = new DateTime(2021, 10, 22, 0, 34, 11, 947, DateTimeKind.Local).AddTicks(4454),
                            YearId = 1
                        });
                });

            modelBuilder.Entity("WillsParkingLot.Models.Year", b =>
                {
                    b.Property<int>("YearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("YearNumber")
                        .HasColumnType("int");

                    b.HasKey("YearId");

                    b.ToTable("Years");

                    b.HasData(
                        new
                        {
                            YearId = 1,
                            YearNumber = 2021
                        },
                        new
                        {
                            YearId = 2,
                            YearNumber = 2022
                        });
                });

            modelBuilder.Entity("WillsParkingLot.Models.Parking", b =>
                {
                    b.HasOne("WillsParkingLot.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("WillsParkingLot.Models.ParkingFee", b =>
                {
                    b.HasOne("WillsParkingLot.Models.Parking", "Parking")
                        .WithMany()
                        .HasForeignKey("ParkingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parking");
                });

            modelBuilder.Entity("WillsParkingLot.Models.RateYearDay", b =>
                {
                    b.HasOne("WillsParkingLot.Models.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WillsParkingLot.Models.Year", "Year")
                        .WithMany()
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Year");
                });
#pragma warning restore 612, 618
        }
    }
}
