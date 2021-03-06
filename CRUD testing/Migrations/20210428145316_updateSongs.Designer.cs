// <auto-generated />
using System;
using CRUD_testing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_testing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210428145316_updateSongs")]
    partial class updateSongs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD_testing.Models.Songs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("songAlbum")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("songArtist")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("songName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
