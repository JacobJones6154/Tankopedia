﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tankop.Data;

namespace Tankop.Migrations
{
    [DbContext(typeof(TankopContext))]
    [Migration("20200921203611_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tankop.Models.Tanks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Accuracy")
                        .HasColumnType("real");

                    b.Property<float>("AimTime")
                        .HasColumnType("real");

                    b.Property<int>("AvgDamage")
                        .HasColumnType("int");

                    b.Property<int>("AvgPenetration")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Dpm")
                        .HasColumnType("real");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<string>("HullArmor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ROF")
                        .HasColumnType("real");

                    b.Property<string>("TankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.Property<string>("TurretArmor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tanks");
                });
#pragma warning restore 612, 618
        }
    }
}
