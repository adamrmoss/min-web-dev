﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinWebDev.Data;

#nullable disable

namespace MinWebDev.Data.Migrations
{
    [DbContext(typeof(MinWebDevDbContext))]
    partial class MinWebDevDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MinWebDev.Data.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tagline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("MinWebDev.Data.EmploymentTerm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Employer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmploymentTerms");
                });

            modelBuilder.Entity("MinWebDev.Data.EmploymentTermBulletPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BulletPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmploymentTermId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("EmploymentTermBulletPoints");
                });

            modelBuilder.Entity("MinWebDev.Data.EmploymentTermSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmploymentTermId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmploymentTermSkills");
                });

            modelBuilder.Entity("MinWebDev.Data.SchoolAttendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GraduationYear")
                        .HasColumnType("int");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SchoolAttendances");
                });

            modelBuilder.Entity("MinWebDev.Data.SkillExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SkillExperiences");
                });
#pragma warning restore 612, 618
        }
    }
}
