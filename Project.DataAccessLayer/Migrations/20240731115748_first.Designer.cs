﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DataAccessLayer.Concrete;

#nullable disable

namespace Project.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240731115748_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectAPI.EntityLayer.Entities.Sikayet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BakimImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BeyazMasaNo")
                        .HasColumnType("int");

                    b.Property<string>("BolgeSefligi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkIsmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SikayetImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SikayetNo")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Sikayets");
                });
#pragma warning restore 612, 618
        }
    }
}
