using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using template.Models;

namespace template.Data;

public partial class AaContext : DbContext
{
    public AaContext()
    {
    }

    public AaContext(DbContextOptions<AaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Disease> Diseases { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<Nurse> Nurses { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Prescription> Prescriptions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Initial Catalog=aa;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__appointm__FD01B5036689ACAB");

            entity.ToTable("appointment");

            entity.Property(e => e.AppointmentId)
                .ValueGeneratedNever()
                .HasColumnName("Appointment_ID");
            entity.Property(e => e.AdmitDate)
                .HasColumnType("date")
                .HasColumnName("Admit_date");
            entity.Property(e => e.AppointmentStatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("appointment_status");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.DischargeDate)
                .HasColumnType("date")
                .HasColumnName("Discharge_date");
            entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NurseId).HasColumnName("Nurse_ID");
            entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            entity.Property(e => e.WardId).HasColumnName("Ward_ID");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__appointme__Docto__4BAC3F29");

            entity.HasOne(d => d.Nurse).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__appointme__Nurse__4CA06362");

            entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__appointme__Patie__4AB81AF0");

            entity.HasOne(d => d.Ward).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK__appointme__Ward___4D94879B");
        });

        modelBuilder.Entity<Disease>(entity =>
        {
            entity.HasKey(e => e.DiseaseId).HasName("PK__disease__6384843E59990100");

            entity.ToTable("disease");

            entity.Property(e => e.DiseaseId)
                .ValueGeneratedNever()
                .HasColumnName("Disease_ID");
            entity.Property(e => e.DiseaseName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Disease_name");
            entity.Property(e => e.DiseaseType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('Chronic')")
                .HasColumnName("Disease_type");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__doctor__E59B530F6FBA36FE");

            entity.ToTable("doctor");

            entity.Property(e => e.DoctorId)
                .ValueGeneratedNever()
                .HasColumnName("Doctor_ID");
            entity.Property(e => e.ContactInformation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Contact_Information");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Schedule_Time");
            entity.Property(e => e.Specialty)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasKey(e => e.MedicalRecordId).HasName("PK__medical___F2C1FA5CEA4E7E6A");

            entity.ToTable("medical_record");

            entity.Property(e => e.MedicalRecordId)
                .ValueGeneratedNever()
                .HasColumnName("Medical_Record_ID");
            entity.Property(e => e.Allergy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('None')");
            entity.Property(e => e.DoctoId).HasColumnName("Docto_ID");
            entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            entity.Property(e => e.PrescriptionId).HasColumnName("Prescription_ID");
            entity.Property(e => e.Procedur)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Treatment)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.DiagnosisNavigation).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.Diagnosis)
                .HasConstraintName("FK__medical_r__Diagn__5165187F");

            entity.HasOne(d => d.Docto).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.DoctoId)
                .HasConstraintName("FK__medical_r__Docto__4F7CD00D");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__medical_r__Patie__4E88ABD4");

            entity.HasOne(d => d.Prescription).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.PrescriptionId)
                .HasConstraintName("FK__medical_r__Presc__5070F446");
        });

        modelBuilder.Entity<Nurse>(entity =>
        {
            entity.HasKey(e => e.NurseId).HasName("PK__nurse__F4B2A268729AC6EF");

            entity.ToTable("nurse");

            entity.Property(e => e.NurseId)
                .ValueGeneratedNever()
                .HasColumnName("Nurse_ID");
            entity.Property(e => e.ContactInformation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Contact_Information");
            entity.Property(e => e.EmailId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__patient__C1A88B59BD521AE3");

            entity.ToTable("patient");

            entity.Property(e => e.PatientId)
                .ValueGeneratedNever()
                .HasColumnName("Patient_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceInfo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Insurance_Info");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
        });

        modelBuilder.Entity<Prescription>(entity =>
        {
            entity.HasKey(e => e.PrescriptionId).HasName("PK__prescrip__E82EBD58C992434F");

            entity.ToTable("prescription");

            entity.Property(e => e.PrescriptionId)
                .ValueGeneratedNever()
                .HasColumnName("Prescription_ID");
            entity.Property(e => e.Dosage)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ingredient)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Instructions).HasColumnType("text");
            entity.Property(e => e.MedicationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Medication_Name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.HasIndex(e => e.Name, "idx_username");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.WardId).HasName("PK__ward__370C723FE32A8058");

            entity.ToTable("ward");

            entity.Property(e => e.WardId)
                .ValueGeneratedNever()
                .HasColumnName("Ward_ID");
            entity.Property(e => e.AvailableEquipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Available_Equipment");
            entity.Property(e => e.BedCount).HasColumnName("Bed_Count");
            entity.Property(e => e.WardDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Ward_Description");
            entity.Property(e => e.WardName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ward_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
