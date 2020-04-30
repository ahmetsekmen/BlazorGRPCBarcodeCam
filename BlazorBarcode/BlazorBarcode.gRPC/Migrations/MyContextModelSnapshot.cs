﻿// <auto-generated />
using BlazorBarcode.gRPC.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorBarcode.gRPC.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BlazorBarcode.gRPC.Domain.BarcodeProduct", b =>
                {
                    b.Property<string>("BarcodeNo")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.HasKey("BarcodeNo");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
