﻿// <auto-generated />
using System;
using DemoEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoEF.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoEF.Models.Equipement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Equipement", (string)null);
                });

            modelBuilder.Entity("DemoEF.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Job", (string)null);
                });

            modelBuilder.Entity("DemoEF.Models.Personnage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Alive")
                        .HasColumnType("bit")
                        .HasColumnName("Vivant");

                    b.Property<DateTime>("DateDeCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PvMax")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Personnage", (string)null);
                });

            modelBuilder.Entity("EquipementPersonnage", b =>
                {
                    b.Property<int>("EquipementsId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnagesId")
                        .HasColumnType("int");

                    b.HasKey("EquipementsId", "PersonnagesId");

                    b.HasIndex("PersonnagesId");

                    b.ToTable("EquipementPersonnage", (string)null);
                });

            modelBuilder.Entity("DemoEF.Models.Personnage", b =>
                {
                    b.HasOne("DemoEF.Models.Job", "Job")
                        .WithMany("Personnages")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("EquipementPersonnage", b =>
                {
                    b.HasOne("DemoEF.Models.Equipement", null)
                        .WithMany()
                        .HasForeignKey("EquipementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoEF.Models.Personnage", null)
                        .WithMany()
                        .HasForeignKey("PersonnagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoEF.Models.Job", b =>
                {
                    b.Navigation("Personnages");
                });
#pragma warning restore 612, 618
        }
    }
}
