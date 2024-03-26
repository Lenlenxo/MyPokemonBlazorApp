﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPokemonBlazorApp.Context;

#nullable disable

namespace MyPokemonBlazorApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("MyPokemonBlazorApp.Model.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Attack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Generation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HP")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Legendary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("MyPokemonBlazorApp.Model.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanionId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("MyPokemonBlazorApp.Model.Trainer", b =>
                {
                    b.HasOne("MyPokemonBlazorApp.Model.Pokemon", "Companion")
                        .WithMany("Trainers")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");
                });

            modelBuilder.Entity("MyPokemonBlazorApp.Model.Pokemon", b =>
                {
                    b.Navigation("Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}
