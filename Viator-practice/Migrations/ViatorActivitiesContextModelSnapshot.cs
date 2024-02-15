﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Viator_practice;

#nullable disable

namespace Viator_practice.Migrations
{
    [DbContext(typeof(ViatorActivitiesContext))]
    partial class ViatorActivitiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<string>("productCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("destinationId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("pricing")
                        .HasColumnType("real");

                    b.Property<string>("productUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("rating")
                        .HasColumnType("real");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productCode");

                    b.HasIndex("destinationId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Viator_practice.Models.Destination", b =>
                {
                    b.Property<int>("destinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("destinationId"));

                    b.Property<string>("defaultCurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationUrlName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("iataCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("latitude")
                        .HasColumnType("real");

                    b.Property<float>("longitude")
                        .HasColumnType("real");

                    b.Property<string>("lookupId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parentId")
                        .HasColumnType("int");

                    b.Property<bool>("selectable")
                        .HasColumnType("bit");

                    b.Property<int>("sortOrder")
                        .HasColumnType("int");

                    b.Property<string>("timeZone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("destinationId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("Viator_practice.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("destinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });
#pragma warning restore 612, 618
        }
    }
}