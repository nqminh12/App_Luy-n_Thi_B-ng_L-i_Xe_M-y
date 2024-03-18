using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class Winapp_Final_ProjectContext : DbContext
    {
        public Winapp_Final_ProjectContext()
        {
        }

        public Winapp_Final_ProjectContext(DbContextOptions<Winapp_Final_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<History> Histories { get; set; } = null!;
        public virtual DbSet<HistoryDetail> HistoryDetails { get; set; } = null!;
        public virtual DbSet<License> Licenses { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;
        public virtual DbSet<Topic> Topics { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;database=Winapp_Final_Project;uid=sa;pwd=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.AnswerId).HasColumnName("Answer_Id");

                entity.Property(e => e.AnswerDescription).HasColumnName("Answer_Description");

                entity.Property(e => e.AnswerImage).HasColumnName("Answer_Image");

                entity.Property(e => e.AnswerType).HasColumnName("Answer_Type");

                entity.Property(e => e.QuestionId).HasColumnName("Question_Id");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Answer__Question__440B1D61");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.Property(e => e.HistoryId).HasColumnName("History_Id");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("History_Date");

                entity.Property(e => e.HistoryTime).HasColumnName("History_Time");

                entity.Property(e => e.LicenseId).HasColumnName("License_Id");

                entity.Property(e => e.SetId).HasColumnName("Set_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.License)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.LicenseId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_History_License");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_History_Set");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__History__User_Id__46E78A0C");
            });

            modelBuilder.Entity<HistoryDetail>(entity =>
            {
                entity.ToTable("History_Detail");

                entity.Property(e => e.HistoryDetailId).HasColumnName("History_Detail_Id");

                entity.Property(e => e.AnswerId).HasColumnName("Answer_Id");

                entity.Property(e => e.HistoryId).HasColumnName("History_Id");

                entity.Property(e => e.QuestionId).HasColumnName("Question_Id");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.HistoryDetails)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK__History_D__Answe__4BAC3F29");

                entity.HasOne(d => d.History)
                    .WithMany(p => p.HistoryDetails)
                    .HasForeignKey(d => d.HistoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__History_D__Histo__49C3F6B7");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.HistoryDetails)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__History_D__Quest__4AB81AF0");
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.ToTable("License");

                entity.Property(e => e.LicenseId).HasColumnName("License_Id");

                entity.Property(e => e.LicenseName)
                    .HasMaxLength(50)
                    .HasColumnName("License_Name");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.QuestionId).HasColumnName("Question_Id");

                entity.Property(e => e.LicenseId).HasColumnName("License_Id");

                entity.Property(e => e.QuestionDescription).HasColumnName("Question_Description");

                entity.Property(e => e.QuestionExplain).HasColumnName("Question_Explain");

                entity.Property(e => e.QuestionImage).HasColumnName("Question_Image");

                entity.Property(e => e.SetId).HasColumnName("Set_Id");

                entity.Property(e => e.TopicId).HasColumnName("Topic_Id");

                entity.HasOne(d => d.License)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.LicenseId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Question__Licens__3F466844");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Question__Set_Id__412EB0B6");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Question__Topic___403A8C7D");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set");

                entity.Property(e => e.SetId).HasColumnName("Set_Id");

                entity.Property(e => e.SetName)
                    .HasMaxLength(50)
                    .HasColumnName("Set_Name");

                entity.Property(e => e.SetNumber).HasColumnName("Set_Number");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.TopicId).HasColumnName("Topic_Id");

                entity.Property(e => e.TopicName)
                    .HasMaxLength(50)
                    .HasColumnName("Topic_Name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phonenumber).HasMaxLength(50);

                entity.Property(e => e.UserRole).HasColumnName("User_Role");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
