﻿// <auto-generated />
using Cars_And_Parts_Site_First_Performance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cars_And_Parts_Site_First_Performance.Migrations
{
    [DbContext(typeof(Cars_And_Parts_Site_First_PerformanceContext))]
    [Migration("20190114021243_Cars_And_AutoParts_Shop_Web_Site")]
    partial class Cars_And_AutoParts_Shop_Web_Site
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cars_And_Parts_Site_First_Performance.Models.DepartmentModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("DepartmentModel");
                });
#pragma warning restore 612, 618
        }
    }
}