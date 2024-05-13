﻿// <auto-generated />
using System;
using FourSix.Controllers.Gateways.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FourSix.Controllers.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240513230942_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FourSix.Domain.Entities.PagamentoAggregate.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoQR")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Desconto")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("StatusId")
                        .HasColumnType("smallint");

                    b.Property<decimal>("ValorPago")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPedido")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Pagamento", (string)null);
                });

            modelBuilder.Entity("FourSix.Domain.Entities.PagamentoAggregate.StatusPagamento", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("StatusPagamento", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (short)1,
                            Descricao = "Aguardando Pagamento"
                        },
                        new
                        {
                            Id = (short)2,
                            Descricao = "Pago"
                        },
                        new
                        {
                            Id = (short)3,
                            Descricao = "Cancelado"
                        },
                        new
                        {
                            Id = (short)4,
                            Descricao = "Negado"
                        });
                });

            modelBuilder.Entity("FourSix.Domain.Entities.PagamentoAggregate.Pagamento", b =>
                {
                    b.HasOne("FourSix.Domain.Entities.PagamentoAggregate.StatusPagamento", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
