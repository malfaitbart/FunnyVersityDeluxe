﻿// <auto-generated />
using System;
using FunnyVersityDeluxe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FunnyVersityDeluxe.Migrations
{
    [DbContext(typeof(FunnyVersityDeluxeContext))]
    [Migration("20181019080629_Number02")]
    partial class Number02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FVD.Domain.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Name");

                    b.Property<int?>("ProfessorID");

                    b.Property<double>("StudyPoints");

                    b.HasKey("ID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("FVD.Domain.Professor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("FVD.Domain.Course", b =>
                {
                    b.HasOne("FVD.Domain.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorID");
                });
#pragma warning restore 612, 618
        }
    }
}
