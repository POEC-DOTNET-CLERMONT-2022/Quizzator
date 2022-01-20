﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quizzator.Persistance;

#nullable disable

namespace Quizzator.Persistance.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20220120094715_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Quizzator.Entity.LinksEntity", b =>
                {
                    b.Property<Guid>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Element")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Links")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("_Id")
                        .HasName("PrimaryKey_LinksId");

                    b.HasIndex("Links");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("Quizzator.Entity.QuestionEntity", b =>
                {
                    b.Property<Guid>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Question")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Texte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_Id")
                        .HasName("PrimaryKey_QuestionId");

                    b.HasIndex("Question");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Quizzator.Entity.ReponseEntity", b =>
                {
                    b.Property<Guid>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Reponse")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("_Explication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Texte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("_isTroll")
                        .HasColumnType("bit");

                    b.HasKey("_Id")
                        .HasName("PrimaryKey_ReponseId");

                    b.HasIndex("Reponse");

                    b.ToTable("Reponses");
                });

            modelBuilder.Entity("Quizzator.Entity.ThemeExEntity", b =>
                {
                    b.Property<Guid>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_Id")
                        .HasName("PrimaryKey_ThemeId");

                    b.ToTable("ThemeEx");
                });

            modelBuilder.Entity("Quizzator.Entity.LinksEntity", b =>
                {
                    b.HasOne("Quizzator.Entity.ReponseEntity", "Reponse")
                        .WithMany("_Lien")
                        .HasForeignKey("Links")
                        .HasConstraintName("Link_In_Response");

                    b.Navigation("Reponse");
                });

            modelBuilder.Entity("Quizzator.Entity.QuestionEntity", b =>
                {
                    b.HasOne("Quizzator.Entity.ThemeExEntity", "ThemeEx")
                        .WithMany("_Questions")
                        .HasForeignKey("Question")
                        .HasConstraintName("Question_In_Theme");

                    b.Navigation("ThemeEx");
                });

            modelBuilder.Entity("Quizzator.Entity.ReponseEntity", b =>
                {
                    b.HasOne("Quizzator.Entity.QuestionEntity", "Question")
                        .WithMany("_ReponseList")
                        .HasForeignKey("Reponse")
                        .HasConstraintName("Reponses_In_Question");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Quizzator.Entity.QuestionEntity", b =>
                {
                    b.Navigation("_ReponseList");
                });

            modelBuilder.Entity("Quizzator.Entity.ReponseEntity", b =>
                {
                    b.Navigation("_Lien");
                });

            modelBuilder.Entity("Quizzator.Entity.ThemeExEntity", b =>
                {
                    b.Navigation("_Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
