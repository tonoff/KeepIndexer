﻿// <auto-generated />
using System;
using KeepIndexer.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KeepIndexer.Migrations
{
    [DbContext(typeof(KeepIndexerContext))]
    [Migration("20200827120107_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("KeepIndexer.Storage.Contract", b =>
                {
                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<ulong>("LastBlock");

                    b.Property<string>("Token");

                    b.HasKey("Address");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("KeepIndexer.Storage.Op", b =>
                {
                    b.Property<string>("Tx")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<ulong>("Block");

                    b.Property<string>("ContractAddress");

                    b.Property<string>("Sender");

                    b.Property<bool>("TDTUsed");

                    b.Property<string>("TDT_ID");

                    b.Property<DateTime>("Timestamp");

                    b.Property<int>("Type");

                    b.HasKey("Tx");

                    b.HasIndex("ContractAddress");

                    b.ToTable("Op");
                });

            modelBuilder.Entity("KeepIndexer.Storage.Op", b =>
                {
                    b.HasOne("KeepIndexer.Storage.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
