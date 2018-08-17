﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelagemInicial;

namespace ModelagemInicial.Migrations
{
    [DbContext(typeof(TMContext))]
    [Migration("20180816034215_ProdutosVenda")]
    partial class ProdutosVenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelagemInicial.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ModelagemInicial.Endereco", b =>
                {
                    b.Property<int>("PessoaId");

                    b.Property<string>("Bairro")
                        .HasMaxLength(50);

                    b.Property<string>("Cep");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<string>("Logradouro")
                        .HasMaxLength(50);

                    b.Property<int>("Numero");

                    b.Property<string>("Referencia")
                        .HasMaxLength(100);

                    b.HasKey("PessoaId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ModelagemInicial.FormaDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("FormasDePagamento");
                });

            modelBuilder.Entity("ModelagemInicial.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("ModelagemInicial.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfCnpj");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("InscricaoEstadual");

                    b.Property<string>("NomeFantasia")
                        .HasMaxLength(50);

                    b.Property<string>("NomeRazaoSocial")
                        .HasMaxLength(50);

                    b.Property<string>("Telefone");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ModelagemInicial.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estoque");

                    b.Property<int?>("MarcaId");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<double>("PrecoCompativel");

                    b.Property<double>("PrecoOriginal");

                    b.Property<double>("PrecoPeriferico");

                    b.Property<double>("PrecoRecarga");

                    b.Property<double>("PrecoReciclado");

                    b.Property<double>("PrecoTroca");

                    b.Property<int?>("SubcategoriaId");

                    b.Property<string>("TipoProduto")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("SubcategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ModelagemInicial.ProdutosDaVenda", b =>
                {
                    b.Property<int>("VendaId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("VendaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosDaVenda");
                });

            modelBuilder.Entity("ModelagemInicial.Subcategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Nome")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Subcategorias");
                });

            modelBuilder.Entity("ModelagemInicial.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImagemDePerfil");

                    b.Property<string>("Login")
                        .HasMaxLength(30);

                    b.Property<int?>("PessoaId");

                    b.Property<byte[]>("Senha");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ModelagemInicial.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<string>("DescricaoStatus");

                    b.Property<int?>("FormaDePagamentoId");

                    b.Property<string>("Observacao");

                    b.Property<int>("Parcelas");

                    b.Property<int?>("PessoaId");

                    b.Property<DateTime>("Previsao");

                    b.Property<int>("TipoPagamento");

                    b.Property<int>("TipoStatusVenda")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<double>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("FormaDePagamentoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("ModelagemInicial.Endereco", b =>
                {
                    b.HasOne("ModelagemInicial.Pessoa", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("ModelagemInicial.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelagemInicial.Produto", b =>
                {
                    b.HasOne("ModelagemInicial.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("ModelagemInicial.Subcategoria", "Subcategoria")
                        .WithMany()
                        .HasForeignKey("SubcategoriaId");
                });

            modelBuilder.Entity("ModelagemInicial.ProdutosDaVenda", b =>
                {
                    b.HasOne("ModelagemInicial.Produto", "Produto")
                        .WithMany("Vendas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ModelagemInicial.Venda", "Venda")
                        .WithMany("Produtos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelagemInicial.Subcategoria", b =>
                {
                    b.HasOne("ModelagemInicial.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("ModelagemInicial.Usuario", b =>
                {
                    b.HasOne("ModelagemInicial.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("ModelagemInicial.Venda", b =>
                {
                    b.HasOne("ModelagemInicial.FormaDePagamento", "FormaDePagamento")
                        .WithMany()
                        .HasForeignKey("FormaDePagamentoId");

                    b.HasOne("ModelagemInicial.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}