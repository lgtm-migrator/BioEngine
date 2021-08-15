﻿// <auto-generated />
using System;
using BioEngine.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BioEngine.Admin.Migrations
{
    [DbContext(typeof(BioDbContext))]
    [Migration("20210815092734_AddIsMainToSites")]
    partial class AddIsMainToSites
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.7.21378.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Blocks")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("jsonb")
                        .HasColumnName("Blocks")
                        .HasDefaultValueSql("'[]'");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DatePublished")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Blocks")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("jsonb")
                        .HasColumnName("Blocks")
                        .HasDefaultValueSql("'[]'");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DatePublished")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Blocks")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("jsonb")
                        .HasColumnName("Blocks")
                        .HasDefaultValueSql("'[]'");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("DatePublished")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sections");

                    b.HasDiscriminator<int>("Type");
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsMain")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PageSite", b =>
                {
                    b.Property<Guid>("PagesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SitesId")
                        .HasColumnType("uuid");

                    b.HasKey("PagesId", "SitesId");

                    b.HasIndex("SitesId");

                    b.ToTable("PageSites", (string)null);
                });

            modelBuilder.Entity("PostSection", b =>
                {
                    b.Property<Guid>("PostsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SectionsId")
                        .HasColumnType("uuid");

                    b.HasKey("PostsId", "SectionsId");

                    b.HasIndex("SectionsId");

                    b.ToTable("PostSections", (string)null);
                });

            modelBuilder.Entity("PostSite", b =>
                {
                    b.Property<Guid>("PostsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SitesId")
                        .HasColumnType("uuid");

                    b.HasKey("PostsId", "SitesId");

                    b.HasIndex("SitesId");

                    b.ToTable("PostSites", (string)null);
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<Guid>("PostsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uuid");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTags", (string)null);
                });

            modelBuilder.Entity("SectionSite", b =>
                {
                    b.Property<Guid>("SectionsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SitesId")
                        .HasColumnType("uuid");

                    b.HasKey("SectionsId", "SitesId");

                    b.HasIndex("SitesId");

                    b.ToTable("SectionSites", (string)null);
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Developer", b =>
                {
                    b.HasBaseType("BioEngine.Core.Data.Entities.Section");

                    b.Property<string>("Data")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("jsonb")
                        .HasColumnName("Data");

                    b.ToTable("Sections");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Game", b =>
                {
                    b.HasBaseType("BioEngine.Core.Data.Entities.Section");

                    b.Property<string>("Data")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("jsonb")
                        .HasColumnName("Data");

                    b.ToTable("Sections");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("BioEngine.Core.Data.Entities.Topic", b =>
                {
                    b.HasBaseType("BioEngine.Core.Data.Entities.Section");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("Data");

                    b.ToTable("Sections");

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("PageSite", b =>
                {
                    b.HasOne("BioEngine.Core.Data.Entities.Page", null)
                        .WithMany()
                        .HasForeignKey("PagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioEngine.Core.Data.Entities.Site", null)
                        .WithMany()
                        .HasForeignKey("SitesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostSection", b =>
                {
                    b.HasOne("BioEngine.Core.Data.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioEngine.Core.Data.Entities.Section", null)
                        .WithMany()
                        .HasForeignKey("SectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostSite", b =>
                {
                    b.HasOne("BioEngine.Core.Data.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioEngine.Core.Data.Entities.Site", null)
                        .WithMany()
                        .HasForeignKey("SitesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("BioEngine.Core.Data.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioEngine.Core.Data.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SectionSite", b =>
                {
                    b.HasOne("BioEngine.Core.Data.Entities.Section", null)
                        .WithMany()
                        .HasForeignKey("SectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BioEngine.Core.Data.Entities.Site", null)
                        .WithMany()
                        .HasForeignKey("SitesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
