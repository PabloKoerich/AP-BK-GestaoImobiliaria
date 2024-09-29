
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace namespace GestaoImobiliaria.Dominio.ModuloImoveis
{
    public class ImoveisEntityConfiguration : IEntityTypeConfiguration<Imoveis>
    {
        public void Configure(EntityTypeBuilder<Imoveis> builder)
        {
            builder.ToTable("Imoveis");
            builder.HasKey(e => e.ImoveisId).HasName("PK__Imovel__4878C58FFBA660A3");

            builder.HasIndex(e => e.Endereco, "UQ__Imovel__C1F89731960F9C31").IsUnique();

            builder.HasIndex(e => e.Metragem, "UQ__Imovel__C1F89731960F9C31").IsUnique();

            builder.HasIndex(e => e.ValorParaVenda, "UQ__Imovel__C1F89731960F9C31").IsUnique();

            builder.HasIndex(e => e.ValorParaAluguel, "UQ__Imovel__C1F89731960F9C31").IsUnique();

            builder.HasIndex(e => e.Tipo, "UQ__Imovel__C46674094787D8EB").IsUnique();

            builder.Property(e => e.ImoveisId)
                .HasMaxLength(10)
                .HasColumnName("Código do Imóvel");
            
            builder.Property(e => e.Endereco)
                .HasMaxLength(30)
                .HasColumnName("Endereço do Imovél");

            builder.Property(e => e.Metragem)
                .HasMaxLength(10)
                .HasColumnName("Tamando Total do Imovél");

            builder.Property(e => e.PrecoParaVenda)
                .HasMaxLength(10)
                .HasColumnName("Preço para Venda do Imovél");

            builder.Property(e => e.PrecoParaLocacao)
                .HasMaxLength(10)
                .HasColumnName("Preço para Locação do Imovél");

            builder.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("Tipo do Imovél");
        }
    }
