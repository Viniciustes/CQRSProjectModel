﻿// <auto-generated />
using System;
using CQRSProjectModel.Infrastructure.Data.SQLServer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Migrations
{
    [DbContext(typeof(CQRSProjectModelSQLServerContext))]
    [Migration("20190507023705_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CQRSProjectModel.Domain.Entities.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("Date");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}