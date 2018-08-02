﻿// <auto-generated />
using CoreEditor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoreEditor.Migrations
{
    [DbContext(typeof(CoreEditorContext))]
    [Migration("20180802154238_AddAdvTypeModel")]
    partial class AddAdvTypeModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("CoreEditor.Models.AdvType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeName")
                        .IsRequired();

                    b.Property<string>("TypePrice");

                    b.Property<string>("TypeSize");

                    b.HasKey("ID");

                    b.ToTable("AdvTypes");
                });

            modelBuilder.Entity("CoreEditor.Models.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialName")
                        .IsRequired();

                    b.Property<string>("MaterialPrice");

                    b.Property<string>("MaterialSize");

                    b.HasKey("ID");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("CoreEditor.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<string>("FilePath");

                    b.Property<int?>("MaterialId");

                    b.Property<int>("Status");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserOrganization")
                        .IsRequired();

                    b.Property<string>("UserPhone")
                        .IsRequired();

                    b.Property<string>("UserSurname")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("MaterialId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CoreEditor.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoreEditor.Models.Order", b =>
                {
                    b.HasOne("CoreEditor.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId");
                });
#pragma warning restore 612, 618
        }
    }
}
