﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalAPIen.NET;

#nullable disable

namespace MinimalAPIen.NET.Migrations
{
    [DbContext(typeof(TasksContext))]
    partial class TasksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MinimalAPIen.NET.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73bd"),
                            Description = "Work related tasks",
                            Name = "Category 1",
                            Weight = 1
                        },
                        new
                        {
                            CategoryId = new Guid("b11dc8d6-437d-41d0-829b-523b5d1e7302"),
                            Description = "Work related tasks",
                            Name = "Categoryt 2",
                            Weight = 50
                        });
                });

            modelBuilder.Entity("MinimalAPIen.NET.Models.Task", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<int>("TaskPriority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Task", (string)null);

                    b.HasData(
                        new
                        {
                            TaskId = new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"),
                            CategoryId = new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73bd"),
                            CreationDate = new DateTime(2024, 11, 22, 21, 21, 48, 419, DateTimeKind.Unspecified),
                            Description = "Create a new project in Visual Studio",
                            IsComplete = false,
                            TaskPriority = 2,
                            Title = "Create a new project"
                        },
                        new
                        {
                            TaskId = new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"),
                            CategoryId = new Guid("b11dc8d6-437d-41d0-829b-523b5d1e7302"),
                            CreationDate = new DateTime(2024, 11, 22, 21, 21, 48, 419, DateTimeKind.Unspecified),
                            Description = "Whatch Netflix",
                            IsComplete = false,
                            TaskPriority = 0,
                            Title = "Create a new project2"
                        });
                });

            modelBuilder.Entity("MinimalAPIen.NET.Models.Task", b =>
                {
                    b.HasOne("MinimalAPIen.NET.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MinimalAPIen.NET.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
