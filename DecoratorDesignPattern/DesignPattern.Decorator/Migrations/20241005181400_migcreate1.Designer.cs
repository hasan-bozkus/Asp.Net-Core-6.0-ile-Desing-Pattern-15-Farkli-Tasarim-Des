﻿// <auto-generated />
using DesignPattern.Decorator.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesignPattern.Decorator.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241005181400_migcreate1")]
    partial class migcreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DesignPattern.Decorator.DAL.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageReceiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
