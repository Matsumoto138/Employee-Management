﻿// <auto-generated />
using EmployeeHomework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeHomework.Migrations
{
    [DbContext(typeof(EmployeeHomeworkDbContext))]
    partial class EmployeeHomeworkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeHomework.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeHomework.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("EmployeeID1")
                        .HasColumnType("int");

                    b.Property<int>("OrderDate")
                        .HasColumnType("int");

                    b.Property<int>("ShipCountry")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("EmployeeID1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EmployeeHomework.Models.Order", b =>
                {
                    b.HasOne("EmployeeHomework.Models.Employee", "EmployeeID")
                        .WithMany()
                        .HasForeignKey("EmployeeID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeID");
                });
#pragma warning restore 612, 618
        }
    }
}