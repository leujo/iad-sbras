﻿// <auto-generated />
using System;
using Sbran.Domain.Data.Adapters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Sbran.Domain.Migrations.Domain
{
    [DbContext(typeof(DomainContext))]
    [Migration("20210109212117_Initial-Domain-New")]
    partial class InitialDomainNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Sbran.Domain.Entities.Alien", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("AlienUid");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("ContactUid");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("uuid")
                        .HasColumnName("OrganizationUid");

                    b.Property<Guid?>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("PassportUid");

                    b.Property<string>("Position")
                        .HasColumnType("text")
                        .HasColumnName("Position");

                    b.Property<Guid?>("StateRegistrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("StateRegistrationUid");

                    b.Property<string>("StayAddress")
                        .HasColumnType("text")
                        .HasColumnName("StayAddress");

                    b.Property<string>("WorkAddress")
                        .HasColumnType("text")
                        .HasColumnName("WorkAddress");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("text")
                        .HasColumnName("WorkPlace");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.HasIndex("OrganizationId")
                        .IsUnique();

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.HasIndex("StateRegistrationId")
                        .IsUnique();

                    b.ToTable("Aliens", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("HomePhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("HomePhoneNumber");

                    b.Property<string>("MobilePhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("MobilePhoneNumber");

                    b.Property<string>("Postcode")
                        .HasColumnType("text")
                        .HasColumnName("Postcode");

                    b.Property<string>("WorkPhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("WorkPhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Contacts", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("Content");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreatedDate");

                    b.Property<int>("DocumentType")
                        .HasColumnType("integer")
                        .HasColumnName("DocumentType");

                    b.Property<Guid>("InvitationId")
                        .HasColumnType("uuid")
                        .HasColumnName("InvitationUid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("InvitationId");

                    b.ToTable("Documents", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("AcademicDegree")
                        .HasColumnType("text")
                        .HasColumnName("AcademicDegree");

                    b.Property<string>("AcademicRank")
                        .HasColumnType("text")
                        .HasColumnName("AcademicRank");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("ContactUid");

                    b.Property<string>("Education")
                        .HasColumnType("text")
                        .HasColumnName("Education");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uuid")
                        .HasColumnName("ManagerUid");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("uuid")
                        .HasColumnName("OrganizationUid");

                    b.Property<Guid?>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("PassportUid");

                    b.Property<string>("Position")
                        .HasColumnType("text")
                        .HasColumnName("Position");

                    b.Property<Guid?>("StateRegistrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("StateRegistrationUid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserUid");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("text")
                        .HasColumnName("WorkPlace");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.HasIndex("ManagerId");

                    b.HasIndex("OrganizationId")
                        .IsUnique();

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.HasIndex("StateRegistrationId")
                        .IsUnique();

                    b.ToTable("Employees", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ForeignParticipant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<Guid?>("InvitationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("PassportUid");

                    b.HasKey("Id");

                    b.HasIndex("InvitationId");

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.ToTable("ForeignParticipants", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Invitation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<Guid>("AlienId")
                        .HasColumnType("uuid")
                        .HasColumnName("AlienUid");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedDate");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeUid");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("Status");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdateDate");

                    b.Property<Guid?>("VisitDetailId")
                        .HasColumnType("uuid")
                        .HasColumnName("VisitDetailUid");

                    b.HasKey("Id");

                    b.HasIndex("AlienId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("VisitDetailId")
                        .IsUnique();

                    b.ToTable("Invitations", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("LegalAddress")
                        .HasColumnType("text")
                        .HasColumnName("LegalAddress");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("ScientificActivity")
                        .HasColumnType("text")
                        .HasColumnName("ScientificActivity");

                    b.Property<string>("ShortName")
                        .HasColumnType("text")
                        .HasColumnName("ShortName");

                    b.Property<Guid?>("StateRegistrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("StateRegistrationUid");

                    b.HasKey("Id");

                    b.HasIndex("StateRegistrationId")
                        .IsUnique();

                    b.ToTable("Organizations", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Passport", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("BirthCountry")
                        .HasColumnType("text")
                        .HasColumnName("BirthCountry");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("BirthDate");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("text")
                        .HasColumnName("BirthPlace");

                    b.Property<string>("Citizenship")
                        .HasColumnType("text")
                        .HasColumnName("Citizenship");

                    b.Property<string>("DepartmentCode")
                        .HasColumnType("text")
                        .HasColumnName("DepartmentCode");

                    b.Property<int?>("Gender")
                        .HasColumnType("integer")
                        .HasColumnName("Gender");

                    b.Property<string>("IdentityDocument")
                        .HasColumnType("text")
                        .HasColumnName("IdentityDocument");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("IssueDate");

                    b.Property<string>("IssuePlace")
                        .HasColumnType("text")
                        .HasColumnName("IssuePlace");

                    b.Property<string>("NameEng")
                        .HasColumnType("text")
                        .HasColumnName("NameEng");

                    b.Property<string>("NameRus")
                        .HasColumnType("text")
                        .HasColumnName("NameRus");

                    b.Property<string>("PatronymicNameEng")
                        .HasColumnType("text")
                        .HasColumnName("PatronymicNameEng");

                    b.Property<string>("PatronymicNameRus")
                        .HasColumnType("text")
                        .HasColumnName("PatronymicNameRus");

                    b.Property<string>("Residence")
                        .HasColumnType("text")
                        .HasColumnName("Residence");

                    b.Property<string>("ResidenceCountry")
                        .HasColumnType("text")
                        .HasColumnName("ResidenceCountry");

                    b.Property<string>("ResidenceRegion")
                        .HasColumnType("text")
                        .HasColumnName("ResidenceRegion");

                    b.Property<string>("SurnameEng")
                        .HasColumnType("text")
                        .HasColumnName("SurnameEng");

                    b.Property<string>("SurnameRus")
                        .HasColumnType("text")
                        .HasColumnName("SurnameRus");

                    b.HasKey("Id");

                    b.ToTable("Passports", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.StateRegistration", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<string>("Inn")
                        .HasColumnType("text")
                        .HasColumnName("INN");

                    b.Property<string>("Ogrnip")
                        .HasColumnType("text")
                        .HasColumnName("OGRNIP");

                    b.HasKey("Id");

                    b.ToTable("StateRegistrations", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.VisitDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Uid");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("ArrivalDate");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasColumnName("Country");

                    b.Property<DateTime?>("DepartureDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("DepartureDate");

                    b.Property<string>("Goal")
                        .HasColumnType("text")
                        .HasColumnName("Goal");

                    b.Property<long?>("PeriodDays")
                        .HasColumnType("bigint")
                        .HasColumnName("PeriodDays");

                    b.Property<string>("VisaCity")
                        .HasColumnType("text")
                        .HasColumnName("VisaCity");

                    b.Property<string>("VisaCountry")
                        .HasColumnType("text")
                        .HasColumnName("VisaCountry");

                    b.Property<int?>("VisaMultiplicity")
                        .HasColumnType("integer")
                        .HasColumnName("VisaMultiplicity");

                    b.Property<string>("VisaType")
                        .HasColumnType("text")
                        .HasColumnName("VisaType");

                    b.Property<string>("VisitingPoints")
                        .HasColumnType("text")
                        .HasColumnName("VisitingPoints");

                    b.HasKey("Id");

                    b.ToTable("VisitDetails", "domain");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Alien", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Contact", "Contact")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "ContactId");

                    b.HasOne("Sbran.Domain.Entities.Organization", "Organization")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "OrganizationId");

                    b.HasOne("Sbran.Domain.Entities.Passport", "Passport")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "PassportId");

                    b.HasOne("Sbran.Domain.Entities.StateRegistration", "StateRegistration")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Alien", "StateRegistrationId");

                    b.Navigation("Contact");

                    b.Navigation("Organization");

                    b.Navigation("Passport");

                    b.Navigation("StateRegistration");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Document", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Invitation", "Invitation")
                        .WithMany()
                        .HasForeignKey("InvitationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invitation");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Contact", "Contact")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "ContactId");

                    b.HasOne("Sbran.Domain.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.HasOne("Sbran.Domain.Entities.Organization", "Organization")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "OrganizationId");

                    b.HasOne("Sbran.Domain.Entities.Passport", "Passport")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "PassportId");

                    b.HasOne("Sbran.Domain.Entities.StateRegistration", "StateRegistration")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Employee", "StateRegistrationId");

                    b.Navigation("Contact");

                    b.Navigation("Manager");

                    b.Navigation("Organization");

                    b.Navigation("Passport");

                    b.Navigation("StateRegistration");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.ForeignParticipant", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Invitation", null)
                        .WithMany("ForeignParticipants")
                        .HasForeignKey("InvitationId");

                    b.HasOne("Sbran.Domain.Entities.Passport", "Passport")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.ForeignParticipant", "PassportId");

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Invitation", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.Alien", "Alien")
                        .WithMany()
                        .HasForeignKey("AlienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.Employee", "Employee")
                        .WithMany("Invitations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sbran.Domain.Entities.VisitDetail", "VisitDetail")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Invitation", "VisitDetailId");

                    b.Navigation("Alien");

                    b.Navigation("Employee");

                    b.Navigation("VisitDetail");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Organization", b =>
                {
                    b.HasOne("Sbran.Domain.Entities.StateRegistration", "StateRegistration")
                        .WithOne()
                        .HasForeignKey("Sbran.Domain.Entities.Organization", "StateRegistrationId");

                    b.Navigation("StateRegistration");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Invitations");
                });

            modelBuilder.Entity("Sbran.Domain.Entities.Invitation", b =>
                {
                    b.Navigation("ForeignParticipants");
                });
#pragma warning restore 612, 618
        }
    }
}
