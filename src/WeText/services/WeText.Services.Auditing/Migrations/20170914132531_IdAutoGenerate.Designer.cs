﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WeText.Services.Auditing;

namespace WeText.Services.Auditing.Migrations
{
    [DbContext(typeof(AuditingDataContext))]
    [Migration("20170914132531_IdAutoGenerate")]
    partial class IdAutoGenerate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("WeText.Services.Auditing.Models.EventItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("EventId");

                    b.Property<string>("Intent")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<bool>("IsIntegration");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .IsUnicode(true);

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("EventItems");
                });
#pragma warning restore 612, 618
        }
    }
}