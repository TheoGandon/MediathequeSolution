﻿// <auto-generated />
using Mediatheque.Core.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mediatheque.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240416143924_EmprunteurNuabl")]
    partial class EmprunteurNuabl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("JeuxDeSociete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AgeMaximum")
                        .HasColumnType("integer");

                    b.Property<int>("AgeMinimum")
                        .HasColumnType("integer");

                    b.Property<string>("Editeur")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Emprunteur")
                        .HasColumnType("text");

                    b.Property<string>("TitreDeLObjet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeJeux")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Jeux");
                });

            modelBuilder.Entity("Mediatheque.Core.Model.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Emprunteur")
                        .HasColumnType("text");

                    b.Property<string>("Groupe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TitreDeLObjet")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CDs");
                });
#pragma warning restore 612, 618
        }
    }
}
