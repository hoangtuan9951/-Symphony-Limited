﻿// <auto-generated />
using System;
using Epro3.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Epro3.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20240324110039_Epro3")]
    partial class Epro3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Epro3.Domain.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BackgroundImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("about", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("admin", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("class", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hotline")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("contact", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BackGroundImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("EndedDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("FeeChagreDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<decimal>("GradePass")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("course", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.CourseModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("courseModule", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.EntranceExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("entranceExam", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.EntranceExamStudentResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("EntranceExamId")
                        .HasColumnType("int");

                    b.Property<int>("EntrenceExamId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("EntranceExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("entranceExamStudentResult", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("fAQ", (string)null);
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RollNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Class", b =>
                {
                    b.HasOne("Epro3.Domain.Entities.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Epro3.Domain.Entities.CourseModule", b =>
                {
                    b.HasOne("Epro3.Domain.Entities.Course", "Course")
                        .WithMany("CourseModules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Epro3.Domain.Entities.EntranceExamStudentResult", b =>
                {
                    b.HasOne("Epro3.Domain.Entities.Course", "Course")
                        .WithMany("EntranceExamStudentResults")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Epro3.Domain.Entities.EntranceExam", "EntranceExam")
                        .WithMany()
                        .HasForeignKey("EntranceExamId");

                    b.HasOne("Epro3.Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("EntranceExam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Epro3.Domain.Entities.Course", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("CourseModules");

                    b.Navigation("EntranceExamStudentResults");
                });
#pragma warning restore 612, 618
        }
    }
}