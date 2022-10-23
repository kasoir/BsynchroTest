﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test1.Data;

namespace Test1.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test1.Models.User", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<double>("balance")
                        .HasColumnType("float");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("transactions")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
