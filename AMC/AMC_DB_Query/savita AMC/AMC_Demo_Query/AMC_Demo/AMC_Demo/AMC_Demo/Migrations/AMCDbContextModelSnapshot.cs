﻿// <auto-generated />
using AMC_Demo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AMC_Demo.Migrations
{
    [DbContext(typeof(AMCDbContext))]
    partial class AMCDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AMC_Demo.Models.DevOpsStatusTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Developement");

                    b.Property<bool>("Production");

                    b.Property<bool>("Staging");

                    b.Property<bool>("Testing");

                    b.Property<string>("UI");

                    b.HasKey("Id");

                    b.ToTable("devOpsStatusTables");
                });
#pragma warning restore 612, 618
        }
    }
}
