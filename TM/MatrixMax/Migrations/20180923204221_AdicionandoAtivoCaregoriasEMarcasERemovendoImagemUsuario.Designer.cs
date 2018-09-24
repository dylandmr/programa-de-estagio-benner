﻿// <auto-generated />
using System;
using MatrixMax.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MatrixMax.Migrations
{
    [DbContext(typeof(MatrixMaxContext))]
    [Migration("20180923204221_AdicionandoAtivoCaregoriasEMarcasERemovendoImagemUsuario")]
    partial class AdicionandoAtivoCaregoriasEMarcasERemovendoImagemUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MatrixMax.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("MatrixMax.Models.Endereco", b =>
                {
                    b.Property<int>("PessoaId");

                    b.Property<string>("Bairro")
                        .HasMaxLength(50);

                    b.Property<string>("Cep");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<string>("Logradouro")
                        .HasMaxLength(50);

                    b.Property<int?>("Numero");

                    b.Property<string>("Referencia")
                        .HasMaxLength(100);

                    b.HasKey("PessoaId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("MatrixMax.Models.FormaDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("FormasDePagamento");
                });

            modelBuilder.Entity("MatrixMax.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("MatrixMax.Models.Pessoa", b =>
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

            modelBuilder.Entity("MatrixMax.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<int>("Estoque");

                    b.Property<int?>("MarcaId");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<double?>("PrecoRecarga");

                    b.Property<double?>("PrecoTroca");

                    b.Property<double>("PrecoUnitario");

                    b.Property<int?>("SubcategoriaId");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("SubcategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("MatrixMax.Models.ProdutosDaVenda", b =>
                {
                    b.Property<int>("VendaId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("VendaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosDaVenda");
                });

            modelBuilder.Entity("MatrixMax.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

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

            modelBuilder.Entity("MatrixMax.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<int?>("DescontoPorcento");

                    b.Property<double>("DescontoValorFixo");

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

            modelBuilder.Entity("MatrixMax.Models.Categoria", b =>
                {
                    b.HasOne("MatrixMax.Models.Categoria", "CategoriaDaSubcategoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("MatrixMax.Models.Endereco", b =>
                {
                    b.HasOne("MatrixMax.Models.Pessoa", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("MatrixMax.Models.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MatrixMax.Models.Produto", b =>
                {
                    b.HasOne("MatrixMax.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("MatrixMax.Models.Categoria", "Subcategoria")
                        .WithMany()
                        .HasForeignKey("SubcategoriaId");
                });

            modelBuilder.Entity("MatrixMax.Models.ProdutosDaVenda", b =>
                {
                    b.HasOne("MatrixMax.Models.Produto", "Produto")
                        .WithMany("Vendas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MatrixMax.Models.Venda", "Venda")
                        .WithMany("Produtos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MatrixMax.Models.Usuario", b =>
                {
                    b.HasOne("MatrixMax.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("MatrixMax.Models.Venda", b =>
                {
                    b.HasOne("MatrixMax.Models.FormaDePagamento", "FormaDePagamento")
                        .WithMany()
                        .HasForeignKey("FormaDePagamentoId");

                    b.HasOne("MatrixMax.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}
