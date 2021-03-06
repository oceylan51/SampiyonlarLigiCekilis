// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampiyonlarLigiApp.Data.Concrete;

namespace SampiyonlarLigiApp.Data.Migrations
{
    [DbContext(typeof(SampiyonlarLigiAppDbContext))]
    [Migration("20220608111028_mg1")]
    partial class mg1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Group1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TemaCountry")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Group1");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Group2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TemaCountry")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Group2");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Group3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TemaCountry")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Group3");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Group4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TemaCountry")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Group4");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group1");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group2");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group3");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group4");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group5", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group5");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group6", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group6");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group7", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group7");
                });

            modelBuilder.Entity("SampiyonlarLigiApp.Entity.Last32Group8", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalDifference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamGoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamGoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("last32Group8");
                });
#pragma warning restore 612, 618
        }
    }
}
