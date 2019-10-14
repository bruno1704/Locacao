﻿// <auto-generated />
using System;
using Locacao.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locacao.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191013020826_ordem_colunas")]
    partial class ordem_colunas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Locacao.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataEntrega")
                        .IsRequired();

                    b.Property<DateTime>("DataRetirada");

                    b.Property<int>("ReservaId");

                    b.Property<int?>("StatusId");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("ReservaId");

                    b.HasIndex("StatusId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Locacao.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataReserva");

                    b.Property<int?>("StatusPedidoId");

                    b.Property<int?>("VeiculoId");

                    b.Property<int?>("usuarioId");

                    b.HasKey("Id");

                    b.HasIndex("StatusPedidoId");

                    b.HasIndex("VeiculoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Locacao.Models.StatusPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("StatusPedido");
                });

            modelBuilder.Entity("Locacao.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Administrador");

                    b.Property<string>("Email");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Locacao.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completo");

                    b.Property<string>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<decimal>("ValorDiaria");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Locacao.Models.Pedido", b =>
                {
                    b.HasOne("Locacao.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Locacao.Models.StatusPedido", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("Locacao.Models.Reserva", b =>
                {
                    b.HasOne("Locacao.Models.StatusPedido", "StatusPedido")
                        .WithMany()
                        .HasForeignKey("StatusPedidoId");

                    b.HasOne("Locacao.Models.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.HasOne("Locacao.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
