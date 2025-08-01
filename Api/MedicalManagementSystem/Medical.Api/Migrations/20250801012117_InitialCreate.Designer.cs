﻿// <auto-generated />
using System;
using Medical.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Medical.Api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20250801012117_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Medical.Domain.Entities.Appointment", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientID");

                    b.HasIndex("DoctorID");

                    b.ToTable("appointments", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DoctorID");

                    b.ToTable("doctors", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.DoctorSpecialty", b =>
                {
                    b.Property<int>("DoctorSpecialtyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorSpecialtyID"));

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("SpecialtyID")
                        .HasColumnType("int");

                    b.HasKey("DoctorSpecialtyID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("SpecialtyID");

                    b.ToTable("doctorspecialty", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NotificationID");

                    b.ToTable("notifications", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"));

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("PatientID");

                    b.ToTable("patients", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Receipt", b =>
                {
                    b.Property<int>("ReceiptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ReceiptID");

                    b.ToTable("receipts", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleID");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Specialty", b =>
                {
                    b.Property<int>("SpecialtyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialtyID"));

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SpecialtyID");

                    b.ToTable("spacilaties", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("UserID");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Medical.Domain.Entities.Appointment", b =>
                {
                    b.HasOne("Medical.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medical.Domain.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Medical.Domain.Entities.DoctorSpecialty", b =>
                {
                    b.HasOne("Medical.Domain.Entities.Doctor", "Doctor")
                        .WithMany("DoctorSpecialties")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medical.Domain.Entities.Specialty", "Specialty")
                        .WithMany("DoctorSpecialties")
                        .HasForeignKey("SpecialtyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Notification", b =>
                {
                    b.HasOne("Medical.Domain.Entities.Appointment", "Appointment")
                        .WithOne("Notification")
                        .HasForeignKey("Medical.Domain.Entities.Notification", "NotificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Receipt", b =>
                {
                    b.HasOne("Medical.Domain.Entities.Appointment", "Appointment")
                        .WithOne("Receipt")
                        .HasForeignKey("Medical.Domain.Entities.Receipt", "ReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Role", b =>
                {
                    b.HasOne("Medical.Domain.Entities.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Appointment", b =>
                {
                    b.Navigation("Notification");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("DoctorSpecialties");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Medical.Domain.Entities.Specialty", b =>
                {
                    b.Navigation("DoctorSpecialties");
                });

            modelBuilder.Entity("Medical.Domain.Entities.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
