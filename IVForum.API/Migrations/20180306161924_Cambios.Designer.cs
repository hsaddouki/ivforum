﻿// <auto-generated />
using IVForum.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace IVForum.API.Migrations
{
    [DbContext(typeof(DbHandler))]
    [Migration("20180306161924_Cambios")]
    partial class Cambios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IVForum.API.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ImgUri");

                    b.Property<string>("Name");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("Bills");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Bill");
                });

            modelBuilder.Entity("IVForum.API.Models.Forum", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Background");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Icon");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Views");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Forums");
                });

            modelBuilder.Entity("IVForum.API.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Background");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<Guid?>("ForumId");

                    b.Property<string>("Icon");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("RepositoryUrl");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TotalMoney");

                    b.Property<int>("Views");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("IVForum.API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("FacebookUrl");

                    b.Property<string>("IdentityId");

                    b.Property<string>("RepositoryUrl");

                    b.Property<string>("TwitterUrl");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId");

                    b.ToTable("DbUsers");
                });

            modelBuilder.Entity("IVForum.API.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("IVForum.API.Models.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ForumId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IVForum.API.Models.BillOption", b =>
                {
                    b.HasBaseType("IVForum.API.Models.Bill");

                    b.Property<Guid>("WalletId");

                    b.HasIndex("WalletId");

                    b.ToTable("BillOption");

                    b.HasDiscriminator().HasValue("BillOption");
                });

            modelBuilder.Entity("IVForum.API.Models.Transaction", b =>
                {
                    b.HasBaseType("IVForum.API.Models.Bill");

                    b.Property<Guid>("ForumId");

                    b.HasIndex("ForumId");

                    b.ToTable("Transaction");

                    b.HasDiscriminator().HasValue("Transaction");
                });

            modelBuilder.Entity("IVForum.API.Models.Vote", b =>
                {
                    b.HasBaseType("IVForum.API.Models.Bill");

                    b.Property<Guid>("ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Vote");

                    b.HasDiscriminator().HasValue("Vote");
                });

            modelBuilder.Entity("IVForum.API.Models.Forum", b =>
                {
                    b.HasOne("IVForum.API.Models.User", "Owner")
                        .WithMany("Forums")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IVForum.API.Models.Project", b =>
                {
                    b.HasOne("IVForum.API.Models.Forum", "Forum")
                        .WithMany("Projects")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IVForum.API.Models.User", "Owner")
                        .WithMany("Projects")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IVForum.API.Models.User", b =>
                {
                    b.HasOne("IVForum.API.Models.UserModel", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("IVForum.API.Models.Wallet", b =>
                {
                    b.HasOne("IVForum.API.Models.Forum", "Forum")
                        .WithMany("Wallets")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IVForum.API.Models.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IVForum.API.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IVForum.API.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IVForum.API.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IVForum.API.Models.UserModel")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IVForum.API.Models.BillOption", b =>
                {
                    b.HasOne("IVForum.API.Models.Wallet", "Wallet")
                        .WithMany("Bills")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IVForum.API.Models.Transaction", b =>
                {
                    b.HasOne("IVForum.API.Models.Forum", "Forum")
                        .WithMany("Transactions")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IVForum.API.Models.Vote", b =>
                {
                    b.HasOne("IVForum.API.Models.Project", "Project")
                        .WithMany("Votes")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
