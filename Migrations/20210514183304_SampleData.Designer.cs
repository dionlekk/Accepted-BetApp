﻿// <auto-generated />
using BetApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BetApp.Migrations
{
    [DbContext(typeof(MatchInfoContext))]
    [Migration("20210514183304_SampleData")]
    partial class SampleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BetApp.Entities.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("MatchDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            MatchId = 1,
                            Description = "OSFP-PAO",
                            MatchDate = "19/03/2021",
                            MatchTime = "15:00",
                            Sport = "1",
                            TeamA = "OSFP",
                            TeamB = "PAO"
                        },
                        new
                        {
                            MatchId = 2,
                            Description = "AEK-PAOK",
                            MatchDate = "20/03/2021",
                            MatchTime = "17:00",
                            Sport = "2",
                            TeamA = "AEK",
                            TeamB = "PAOK"
                        },
                        new
                        {
                            MatchId = 3,
                            Description = "ARIS-PAOK",
                            MatchDate = "21/03/2021",
                            MatchTime = "21:00",
                            Sport = "1",
                            TeamA = "ARIS",
                            TeamB = "PAOK"
                        });
                });

            modelBuilder.Entity("BetApp.Entities.MatchOdds", b =>
                {
                    b.Property<int>("MatchOddId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<double>("Odd")
                        .HasColumnType("float");

                    b.Property<string>("Specifier")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("MatchOddId");

                    b.HasIndex("MatchId");

                    b.ToTable("MatchOdds");

                    b.HasData(
                        new
                        {
                            MatchOddId = 1,
                            MatchId = 1,
                            Odd = 2.0,
                            Specifier = "X"
                        },
                        new
                        {
                            MatchOddId = 2,
                            MatchId = 2,
                            Odd = 2.0,
                            Specifier = "1"
                        },
                        new
                        {
                            MatchOddId = 3,
                            MatchId = 3,
                            Odd = 2.0,
                            Specifier = "X"
                        });
                });

            modelBuilder.Entity("BetApp.Entities.MatchOdds", b =>
                {
                    b.HasOne("BetApp.Entities.Match", "Match")
                        .WithMany("MatchOdds")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("BetApp.Entities.Match", b =>
                {
                    b.Navigation("MatchOdds");
                });
#pragma warning restore 612, 618
        }
    }
}