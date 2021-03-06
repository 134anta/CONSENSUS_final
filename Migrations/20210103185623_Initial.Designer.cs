﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Consensus.Contexts;

namespace WebAPI_Consensus.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210103185623_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebAPI_Consensus.Entities.ProduccionDiaria", b =>
                {
                    b.Property<int>("idProd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("circuloQty")
                        .HasColumnType("int");

                    b.Property<int>("cuadradoQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaProd")
                        .HasColumnType("datetime2");

                    b.Property<int>("produccionGenerada")
                        .HasColumnType("int");

                    b.Property<int>("rectanguloQty")
                        .HasColumnType("int");

                    b.Property<int>("trianguloQty")
                        .HasColumnType("int");

                    b.HasKey("idProd");

                    b.ToTable("ProduccionDiaria");
                });
#pragma warning restore 612, 618
        }
    }
}
