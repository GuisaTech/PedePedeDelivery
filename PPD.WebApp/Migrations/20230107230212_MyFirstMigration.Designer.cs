﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPD.Infrastructure.Data;

#nullable disable

namespace PPD.WebApp.Migrations
{
    [DbContext(typeof(PedePedeContext))]
    [Migration("20230107230212_MyFirstMigration")]
    partial class MyFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.ChavePix", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<bool>("SouTitular")
                        .HasColumnType("bit");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("Titular")
                        .HasColumnType("int");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ChavesPix", (string)null);
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.ContaBancaria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CodigoBanco")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Conta")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CpfTitular")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("DigitoAgencia")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DigitoConta")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<bool>("SouTitular")
                        .HasColumnType("bit");

                    b.Property<int>("Titular")
                        .HasColumnType("int");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ContasBancarias", (string)null);
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ApelidoUrl")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("InformacaoEndereco")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Empresas", (string)null);
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("InformacaoEndereco")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.RedeSocial", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeFacebook")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeInstagram")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeYoutube")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<int>("Titular")
                        .HasColumnType("int");

                    b.Property<string>("UrlFacebook")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrlInstagram")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrlSite")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrlYoutube")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("RedesSociais", (string)null);
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Autorizado")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Removido")
                        .HasColumnType("bit");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Cpf" }, "UQ_Usuario_Cpf")
                        .IsUnique();

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.ChavePix", b =>
                {
                    b.HasOne("PPD.WebApp.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("ChavesPix")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.ContaBancaria", b =>
                {
                    b.HasOne("PPD.WebApp.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("ContasBancarias")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.Empresa", b =>
                {
                    b.HasOne("PPD.WebApp.Domain.Entidades.Usuario", "Usuario")
                        .WithOne("Empresa")
                        .HasForeignKey("PPD.WebApp.Domain.Entidades.Empresa", "UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.Endereco", b =>
                {
                    b.HasOne("PPD.WebApp.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Enderecos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.RedeSocial", b =>
                {
                    b.HasOne("PPD.WebApp.Domain.Entidades.Usuario", "Usuario")
                        .WithOne("RedeSocial")
                        .HasForeignKey("PPD.WebApp.Domain.Entidades.RedeSocial", "UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PPD.WebApp.Domain.Entidades.Usuario", b =>
                {
                    b.Navigation("ChavesPix");

                    b.Navigation("ContasBancarias");

                    b.Navigation("Empresa")
                        .IsRequired();

                    b.Navigation("Enderecos");

                    b.Navigation("RedeSocial")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
