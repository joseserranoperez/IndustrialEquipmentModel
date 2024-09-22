﻿// <auto-generated />
using System;
using IndustrialEquipmentModel.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IndustrialEquipmentModel.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.27");

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Equipments.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModuleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkingPrinciple")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Equipment", (string)null);
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsExternal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UnitId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Modules", (string)null);
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartUp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Unities", (string)null);
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Equipments.Actuator", b =>
                {
                    b.HasBaseType("IndustrialEquipmentModel.Domain.Entities.Equipments.Equipment");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastMaintenance")
                        .HasColumnType("TEXT");

                    b.ToTable("Actuators", (string)null);
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Equipments.Sensor", b =>
                {
                    b.HasBaseType("IndustrialEquipmentModel.Domain.Entities.Equipments.Equipment");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastCalibration")
                        .HasColumnType("TEXT");

                    b.Property<int>("Variable")
                        .HasColumnType("INTEGER");

                    b.ToTable("Sensors", (string)null);
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Equipments.Equipment", b =>
                {
                    b.HasOne("IndustrialEquipmentModel.Domain.Entities.Module", "Module")
                        .WithMany("Equiments")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Module", b =>
                {
                    b.HasOne("IndustrialEquipmentModel.Domain.Entities.Unit", "Unit")
                        .WithMany("Modules")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Equipments.Actuator", b =>
                {
                    b.HasOne("IndustrialEquipmentModel.Domain.Entities.Equipments.Equipment", null)
                        .WithOne()
                        .HasForeignKey("IndustrialEquipmentModel.Domain.Entities.Equipments.Actuator", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Equipments.Sensor", b =>
                {
                    b.HasOne("IndustrialEquipmentModel.Domain.Entities.Equipments.Equipment", null)
                        .WithOne()
                        .HasForeignKey("IndustrialEquipmentModel.Domain.Entities.Equipments.Sensor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Module", b =>
                {
                    b.Navigation("Equiments");
                });

            modelBuilder.Entity("IndustrialEquipmentModel.Domain.Entities.Unit", b =>
                {
                    b.Navigation("Modules");
                });
#pragma warning restore 612, 618
        }
    }
}
