// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIWithDocker.Data;

namespace WebAPIWithDocker.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20220318171531_initialmodel")]
    partial class initialmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPIWithDocker.Data.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Weathers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 3, 19, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(5643),
                            Summary = "Chilly",
                            TemperatureC = 50
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 3, 20, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6565),
                            Summary = "Sweltering",
                            TemperatureC = 39
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 3, 21, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6574),
                            Summary = "Warm",
                            TemperatureC = 34
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 3, 22, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6575),
                            Summary = "Scorching",
                            TemperatureC = 51
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 3, 23, 11, 41, 16, 543, DateTimeKind.Local).AddTicks(6576),
                            Summary = "Balmy",
                            TemperatureC = 11
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
