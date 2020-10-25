﻿// <auto-generated />
using System;
using BlazorApp2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201021012904_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("BlazorApp2.Data.Detalle", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Recursonombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TareaidTarea")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("Fecha");

                    b.HasIndex("Recursonombre");

                    b.HasIndex("TareaidTarea");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("BlazorApp2.Data.Recurso", b =>
                {
                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("nombre");

                    b.HasIndex("usuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("BlazorApp2.Data.Tarea", b =>
                {
                    b.Property<int>("idTarea")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estimacion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Responsablenombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("idTarea");

                    b.HasIndex("Responsablenombre");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("BlazorApp2.Data.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("usuarioid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BlazorApp2.Data.Detalle", b =>
                {
                    b.HasOne("BlazorApp2.Data.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("Recursonombre");

                    b.HasOne("BlazorApp2.Data.Tarea", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaidTarea");
                });

            modelBuilder.Entity("BlazorApp2.Data.Recurso", b =>
                {
                    b.HasOne("BlazorApp2.Data.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId");
                });

            modelBuilder.Entity("BlazorApp2.Data.Tarea", b =>
                {
                    b.HasOne("BlazorApp2.Data.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("Responsablenombre");
                });
#pragma warning restore 612, 618
        }
    }
}