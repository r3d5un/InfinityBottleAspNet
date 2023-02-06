﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BrandId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("BrandId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Name");

                    b.ToTable("brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            CompanyId = 1,
                            Name = "Laphroaig"
                        },
                        new
                        {
                            BrandId = 2,
                            CompanyId = 3,
                            Name = "Ardmore"
                        },
                        new
                        {
                            BrandId = 3,
                            CompanyId = 3,
                            Name = "Auchentoshan"
                        },
                        new
                        {
                            BrandId = 4,
                            CompanyId = 3,
                            Name = "Bowmore"
                        },
                        new
                        {
                            BrandId = 5,
                            CompanyId = 3,
                            Name = "Glen Garioch"
                        },
                        new
                        {
                            BrandId = 6,
                            CompanyId = 3,
                            Name = "McClelland"
                        },
                        new
                        {
                            BrandId = 7,
                            CompanyId = 3,
                            Name = "Connemara"
                        },
                        new
                        {
                            BrandId = 8,
                            CompanyId = 2,
                            Name = "Balcones"
                        },
                        new
                        {
                            BrandId = 9,
                            CompanyId = 3,
                            Name = "Ardbeg"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("region");

                    b.Property<string>("SubCategory")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sub_category");

                    b.HasKey("CategoryId");

                    b.HasIndex("Name");

                    b.HasIndex("Region");

                    b.HasIndex("SubCategory");

                    b.ToTable("category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Scotch",
                            Region = "Islay",
                            SubCategory = "Islay Single Malt"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Scotch",
                            Region = "Highland",
                            SubCategory = "Highland Single Malt"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Scotch",
                            Region = "Lowland",
                            SubCategory = "Lowland Single Malt"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Scotch",
                            Region = "Strathspey",
                            SubCategory = "Speyside Single Malt"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Bourbon",
                            Region = "America",
                            SubCategory = "Kentucky Straight Bourbon Whiskey"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Rye",
                            Region = "America",
                            SubCategory = "Kentucky Straight Rye Whiskey"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Irish",
                            Region = "Ireland",
                            SubCategory = "Irish Single Malt"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("city");

                    b.Property<string>("CountryId")
                        .HasColumnType("varchar(2)")
                        .HasColumnName("country");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("state");

                    b.HasKey("CompanyId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name");

                    b.ToTable("company");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            Address = "222 W Merchandise Mart Plz Ste 1600",
                            City = "Chicago",
                            CountryId = "US",
                            Name = "Beam Suntory",
                            PostalCode = "60654",
                            State = "Illinois"
                        },
                        new
                        {
                            CompanyId = 2,
                            Address = "225 S 11th St, Waco",
                            City = "Waco, Texas",
                            CountryId = "US",
                            Name = "Balcones Distilling",
                            PostalCode = "76701",
                            State = "Texas"
                        },
                        new
                        {
                            CompanyId = 3,
                            Address = "22 Avenue Montaigne",
                            City = "Paris",
                            CountryId = "FR",
                            Name = "LVMH",
                            PostalCode = "75008"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Country", b =>
                {
                    b.Property<string>("CountryId")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("CountryId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name");

                    b.ToTable("country");

                    b.HasData(
                        new
                        {
                            CountryId = "US",
                            Name = "United States"
                        },
                        new
                        {
                            CountryId = "GB",
                            Name = "United Kingdom"
                        },
                        new
                        {
                            CountryId = "FR",
                            Name = "France"
                        },
                        new
                        {
                            CountryId = "JP",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = "CA",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryId = "IE",
                            Name = "Ireland"
                        },
                        new
                        {
                            CountryId = "TW",
                            Name = "Taiwan"
                        },
                        new
                        {
                            CountryId = "NO",
                            Name = "Norway"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer")
                        .HasColumnName("amount");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int>("InfinityBottleId")
                        .HasColumnType("integer")
                        .HasColumnName("infinity_bottle_id");

                    b.Property<int>("WhiskyId")
                        .HasColumnType("integer")
                        .HasColumnName("whisky_id");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.ToTable("history");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 4,
                            Date = new DateOnly(2023, 1, 1),
                            InfinityBottleId = 1,
                            WhiskyId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 4,
                            Date = new DateOnly(2023, 1, 2),
                            InfinityBottleId = 1,
                            WhiskyId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 4,
                            Date = new DateOnly(2023, 1, 3),
                            InfinityBottleId = 1,
                            WhiskyId = 3
                        });
                });

            modelBuilder.Entity("DataAccess.Models.InfinityBottle", b =>
                {
                    b.Property<int>("InfinityBottleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InfinityBottleId"));

                    b.Property<string>("BottleName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bottle_name");

                    b.Property<int>("BottleSize")
                        .HasColumnType("integer")
                        .HasColumnName("bottle_size");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<int?>("NumberOfBottles")
                        .IsRequired()
                        .HasColumnType("integer")
                        .HasColumnName("number_of_bottles");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("InfinityBottleId");

                    b.HasIndex("BottleName");

                    b.ToTable("infinity_bottle");

                    b.HasData(
                        new
                        {
                            InfinityBottleId = 1,
                            BottleName = "Sample Infinity Bottle",
                            BottleSize = 70,
                            NumberOfBottles = 1,
                            StartDate = new DateOnly(2023, 1, 1)
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Whisky", b =>
                {
                    b.Property<int>("WhiskyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WhiskyId"));

                    b.Property<int>("ABV")
                        .HasColumnType("integer")
                        .HasColumnName("abv");

                    b.Property<int?>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<int>("BrandId")
                        .HasColumnType("integer")
                        .HasColumnName("brand_id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<double?>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.HasKey("WhiskyId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name");

                    b.ToTable("whiskies");

                    b.HasData(
                        new
                        {
                            WhiskyId = 1,
                            ABV = 40,
                            Age = 10,
                            BrandId = 1,
                            CategoryId = 1,
                            Name = "Laphroaig 10 Year Old"
                        },
                        new
                        {
                            WhiskyId = 2,
                            ABV = 46,
                            Age = 10,
                            BrandId = 9,
                            CategoryId = 1,
                            Name = "Ardbeg 10 Year Old"
                        },
                        new
                        {
                            WhiskyId = 3,
                            ABV = 40,
                            Age = 12,
                            BrandId = 7,
                            CategoryId = 8,
                            Name = "Connemara Peated Single Malt"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Brand", b =>
                {
                    b.HasOne("DataAccess.Models.Company", null)
                        .WithMany("Brands")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Company", b =>
                {
                    b.HasOne("DataAccess.Models.Country", null)
                        .WithMany("Companies")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("DataAccess.Models.Whisky", b =>
                {
                    b.HasOne("DataAccess.Models.Brand", null)
                        .WithMany("Whiskies")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Category", null)
                        .WithMany("Whiskies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Brand", b =>
                {
                    b.Navigation("Whiskies");
                });

            modelBuilder.Entity("DataAccess.Models.Category", b =>
                {
                    b.Navigation("Whiskies");
                });

            modelBuilder.Entity("DataAccess.Models.Company", b =>
                {
                    b.Navigation("Brands");
                });

            modelBuilder.Entity("DataAccess.Models.Country", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
