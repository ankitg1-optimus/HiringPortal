﻿// <auto-generated />
using System;
using HiringPortal.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HiringPortal.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CandidateSkill", b =>
                {
                    b.Property<int>("CandidatesId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("CandidatesId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CandidateSkill");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Master.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Master.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeTypeId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.ApplicationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationStatus");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.EmployeeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.InterviewStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InterviewStatus");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.JobStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobStatus");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.RequisitionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequisitionStatus");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stage");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Interview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InterviewStatusId")
                        .HasColumnType("int");

                    b.Property<int>("JobApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Slot")
                        .HasColumnType("datetime2");

                    b.Property<int>("StageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InterviewStatusId");

                    b.HasIndex("JobApplicationId");

                    b.HasIndex("StageId");

                    b.ToTable("Interview");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("JobStatusId")
                        .HasColumnType("int");

                    b.Property<int>("RequisitionId")
                        .HasColumnType("int");

                    b.Property<int>("YOE")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("JobStatusId");

                    b.HasIndex("RequisitionId")
                        .IsUnique();

                    b.ToTable("Job");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.JobApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("ReferrerEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("JobId");

                    b.HasIndex("ReferrerEmployeeId");

                    b.HasIndex("StatusId");

                    b.ToTable("JobApplication");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Requisition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequisitionStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RequisitionStatusId");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("RoleId");

                    b.ToTable("Requisition");
                });

            modelBuilder.Entity("JobSkill", b =>
                {
                    b.Property<int>("JobsId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("JobsId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("JobSkill");
                });

            modelBuilder.Entity("CandidateSkill", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.Master.Candidate", null)
                        .WithMany()
                        .HasForeignKey("CandidatesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Master.Employee", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.Static.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.EmployeeType", "EmployeeType")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("EmployeeType");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Interview", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.Static.InterviewStatus", "InterviewStatus")
                        .WithMany("Interviews")
                        .HasForeignKey("InterviewStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.UseCase.JobApplication", "JobApplication")
                        .WithMany("Interviews")
                        .HasForeignKey("JobApplicationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.Stage", "Stage")
                        .WithMany("Interviews")
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("InterviewStatus");

                    b.Navigation("JobApplication");

                    b.Navigation("Stage");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Job", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.Master.Employee", "CreatedBy")
                        .WithMany("JobsCreated")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.EmployeeType", "EmployeeType")
                        .WithMany("Jobs")
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.JobStatus", "JobStatus")
                        .WithMany("Jobs")
                        .HasForeignKey("JobStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.UseCase.Requisition", "Requisition")
                        .WithOne("Job")
                        .HasForeignKey("HiringPortal.Domain.Entities.UseCase.Job", "RequisitionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("EmployeeType");

                    b.Navigation("JobStatus");

                    b.Navigation("Requisition");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.JobApplication", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.Master.Candidate", "Candidate")
                        .WithMany("JobApplications")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.UseCase.Job", "Job")
                        .WithMany("JobApplications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Master.Employee", "ReferrerEmployee")
                        .WithMany("Referrals")
                        .HasForeignKey("ReferrerEmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.ApplicationStatus", "Status")
                        .WithMany("JobApplications")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Job");

                    b.Navigation("ReferrerEmployee");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Requisition", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.Static.Department", "Department")
                        .WithMany("Requisitions")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Master.Employee", "Employee")
                        .WithMany("Requisitions")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("HiringPortal.Domain.Entities.Static.RequisitionStatus", "RequisitionStatus")
                        .WithMany("Requisitions")
                        .HasForeignKey("RequisitionStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Master.Employee", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId");

                    b.HasOne("HiringPortal.Domain.Entities.Static.Role", "Role")
                        .WithMany("Requistions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employee");

                    b.Navigation("RequisitionStatus");

                    b.Navigation("Reviewer");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("JobSkill", b =>
                {
                    b.HasOne("HiringPortal.Domain.Entities.UseCase.Job", null)
                        .WithMany()
                        .HasForeignKey("JobsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HiringPortal.Domain.Entities.Static.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Master.Candidate", b =>
                {
                    b.Navigation("JobApplications");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Master.Employee", b =>
                {
                    b.Navigation("JobsCreated");

                    b.Navigation("Referrals");

                    b.Navigation("Requisitions");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.ApplicationStatus", b =>
                {
                    b.Navigation("JobApplications");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Department", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Requisitions");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.EmployeeType", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.InterviewStatus", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.JobStatus", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.RequisitionStatus", b =>
                {
                    b.Navigation("Requisitions");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Role", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Requistions");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.Static.Stage", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Job", b =>
                {
                    b.Navigation("JobApplications");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.JobApplication", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("HiringPortal.Domain.Entities.UseCase.Requisition", b =>
                {
                    b.Navigation("Job")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}