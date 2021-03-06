﻿// <auto-generated />
using API_Employment_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Employment_Project.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20210203215836_Database_obj")]
    partial class Database_obj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("API_Employment_Project.Model.Employment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address_of_employer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Job_salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Job_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employment");
                });
#pragma warning restore 612, 618
        }
    }
}
