﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingList.Data;

#nullable disable

namespace ShoppingList.Data.Migrations
{
    [DbContext(typeof(ShoppingListDbContext))]
    partial class ShoppingListDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppingList.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Product Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Product name.");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasComment("Product entity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chees"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Milk"
                        });
                });

            modelBuilder.Entity("ShoppingList.Data.ProductNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Note Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Product note content");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasComment("Product Identifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductNotes");

                    b.HasComment("Product note entity");
                });

            modelBuilder.Entity("ShoppingList.Data.ProductNote", b =>
                {
                    b.HasOne("ShoppingList.Data.Product", "Product")
                        .WithMany("ProductNotes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoppingList.Data.Product", b =>
                {
                    b.Navigation("ProductNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
