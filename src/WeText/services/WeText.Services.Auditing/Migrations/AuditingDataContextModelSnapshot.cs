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
    partial class AuditingDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("WeText.Services.Auditing.Models.Authentication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true);

                    b.Property<string>("FailReason")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .IsUnicode(true);

                    b.Property<bool>("Succeeded");

                    b.Property<DateTime>("TimeOfAuthentication");

                    b.HasKey("Id");

                    b.ToTable("Authentications");
                });
#pragma warning restore 612, 618
        }
    }
}
