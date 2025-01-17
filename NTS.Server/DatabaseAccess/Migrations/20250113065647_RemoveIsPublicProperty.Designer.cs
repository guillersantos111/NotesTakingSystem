﻿// <auto-generated />
using System;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NTS.Server.Data;

#nullable disable

namespace NTS.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250113065647_RemoveIsPublicProperty")]
    partial class RemoveIsPublicProperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NTS.Server.Domain.Entities.ApplicationUsers", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("FullName");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("RecoveryEmail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("RecoveryEmail");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("ApplicationUsers", (string)null);
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.FavoriteNotes", b =>
                {
                    b.Property<Guid>("FavoriteNoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NoteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FavoriteNoteId");

                    b.HasIndex("NoteId")
                        .HasDatabaseName("IX_FavoriteNotes_NoteId");

                    b.HasIndex("UserId")
                        .HasDatabaseName("IX_FavoriteNotes_UserId");

                    b.ToTable("FavoriteNotes", (string)null);
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.ImportantNotes", b =>
                {
                    b.Property<Guid>("ImportantNoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NoteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ImportantNoteId");

                    b.HasIndex("NoteId")
                        .HasDatabaseName("IX_FavoriteNotes_NoteId");

                    b.HasIndex("UserId")
                        .HasDatabaseName("IX_FavoriteNotes_UserId");

                    b.ToTable("ImportantNotes", (string)null);
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.Notes", b =>
                {
                    b.Property<Guid>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Content");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("FavoriteNote")
                        .HasColumnType("bit");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Priority");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Title");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.HasKey("NoteId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes", (string)null);
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.SharedNotes", b =>
                {
                    b.Property<Guid>("SharedNoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NoteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SharedNoteId");

                    b.HasIndex("NoteId")
                        .HasDatabaseName("IX_FavoriteNotes_NoteId");

                    b.HasIndex("UserId")
                        .HasDatabaseName("IX_FavoriteNotes_UserId");

                    b.ToTable("SharedNotes", (string)null);
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.StarredNotes", b =>
                {
                    b.Property<Guid>("StarredNotesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NoteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StarredNotesId");

                    b.HasIndex("NoteId")
                        .HasDatabaseName("IX_FavoriteNotes_NoteId");

                    b.HasIndex("UserId")
                        .HasDatabaseName("IX_FavoriteNotes_UserId");

                    b.ToTable("StarredNotes", (string)null);
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.FavoriteNotes", b =>
                {
                    b.HasOne("NTS.Server.Domain.Entities.Notes", "Note")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NTS.Server.Domain.Entities.ApplicationUsers", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Note");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.ImportantNotes", b =>
                {
                    b.HasOne("NTS.Server.Domain.Entities.Notes", "Notes")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NTS.Server.Domain.Entities.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notes");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.Notes", b =>
                {
                    b.HasOne("NTS.Server.Domain.Entities.ApplicationUsers", "Users")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.SharedNotes", b =>
                {
                    b.HasOne("NTS.Server.Domain.Entities.Notes", "Notes")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NTS.Server.Domain.Entities.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notes");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.StarredNotes", b =>
                {
                    b.HasOne("NTS.Server.Domain.Entities.Notes", "Notes")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NTS.Server.Domain.Entities.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Notes");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NTS.Server.Domain.Entities.ApplicationUsers", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
