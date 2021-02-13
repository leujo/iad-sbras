﻿// <auto-generated />
using System;
using Sbran.Domain.Data.Adapters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Sbran.Domain.Migrations.System
{
    [DbContext(typeof(SystemContext))]
    [Migration("20210109212412_Initial-Domain-New")]
    partial class InitialDomainNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Sbran.Domain.Entities.System.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea")
                        .HasColumnName("Avatar");

                    b.Property<string>("WebPages")
                        .HasColumnType("text")
                        .HasColumnName("WebPages");

                    b.HasKey("Id");

                    b.ToTable("Profiles", "system");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.System.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("Account")
                        .HasColumnType("text")
                        .HasColumnName("Account");

                    b.Property<string>("Password")
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid")
                        .HasColumnName("ProfileUid");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.ToTable("Users", "system");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.System.User", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.System.Profile", "Profile")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.System.User", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
