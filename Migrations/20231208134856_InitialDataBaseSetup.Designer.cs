﻿// <auto-generated />
using System;
using EsportsTour.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EsportsTour.Migrations
{
    [DbContext(typeof(EsportsDbContext))]
    [Migration("20231208134856_InitialDataBaseSetup")]
    partial class InitialDataBaseSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("IdentityUserLogin<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("IdentityUserToken<string>");
                });

            modelBuilder.Entity("Projet.Net.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomEquipe")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id")
                        .HasName("PK__Equipes__DC0A3743F019E1C7");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("Projet.Net.Models.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateNaissance")
                        .HasColumnType("date");

                    b.Property<int?>("EquipeId")
                        .HasColumnType("int");

                    b.Property<string>("Pseudonyme")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id")
                        .HasName("PK__Joueurs__D6CEE2407FCE1182");

                    b.HasIndex("EquipeId");

                    b.ToTable("Joueurs");
                });

            modelBuilder.Entity("Projet.Net.Models.Resultat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateMatch")
                        .HasColumnType("date");

                    b.Property<int?>("EquipeGagnanteId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipePerdanteId")
                        .HasColumnType("int");

                    b.Property<int?>("ScoreGagnant")
                        .HasColumnType("int");

                    b.Property<int?>("ScorePerdant")
                        .HasColumnType("int");

                    b.Property<int?>("TournoiId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Resultat__20BF3E6BBAD92AB0");

                    b.HasIndex("EquipeGagnanteId");

                    b.HasIndex("EquipePerdanteId");

                    b.HasIndex("TournoiId");

                    b.ToTable("Resultats");
                });

            modelBuilder.Entity("Projet.Net.Models.Tournoi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("date");

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Jeu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("jeu");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id")
                        .HasName("PK__Tournois__6536E3D9E8BDE8DD");

                    b.ToTable("Tournois");
                });

            modelBuilder.Entity("Projet.Net.Models.Joueur", b =>
                {
                    b.HasOne("Projet.Net.Models.Equipe", "Equipe")
                        .WithMany("Joueurs")
                        .HasForeignKey("EquipeId")
                        .HasConstraintName("FK__Joueurs__EquipeI__3B75D760");

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("Projet.Net.Models.Resultat", b =>
                {
                    b.HasOne("Projet.Net.Models.Equipe", "EquipeGagnante")
                        .WithMany("ResultatEquipeGagnantes")
                        .HasForeignKey("EquipeGagnanteId")
                        .HasConstraintName("FK__Resultats__Equip__3F466844");

                    b.HasOne("Projet.Net.Models.Equipe", "EquipePerdante")
                        .WithMany("ResultatEquipePerdantes")
                        .HasForeignKey("EquipePerdanteId")
                        .HasConstraintName("FK__Resultats__Equip__403A8C7D");

                    b.HasOne("Projet.Net.Models.Tournoi", "Tournoi")
                        .WithMany("Resultats")
                        .HasForeignKey("TournoiId")
                        .HasConstraintName("FK__Resultats__Tourn__3E52440B");

                    b.Navigation("EquipeGagnante");

                    b.Navigation("EquipePerdante");

                    b.Navigation("Tournoi");
                });

            modelBuilder.Entity("Projet.Net.Models.Equipe", b =>
                {
                    b.Navigation("Joueurs");

                    b.Navigation("ResultatEquipeGagnantes");

                    b.Navigation("ResultatEquipePerdantes");
                });

            modelBuilder.Entity("Projet.Net.Models.Tournoi", b =>
                {
                    b.Navigation("Resultats");
                });
#pragma warning restore 612, 618
        }
    }
}
