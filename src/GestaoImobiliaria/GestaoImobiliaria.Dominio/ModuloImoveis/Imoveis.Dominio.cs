using Academia.Programador.Bk.Gestao.Imobiliaria;
using Academia.Programador.Bk.Gestao.Imobiliaria.Web;
using GestaoImobiliaria.Dominio.DominioModels;

namespace GestaoImobiliaria.Dominio.ModuloImoveis
{
    public partial class Imoveis
    {
        private ICollection<Imoveis> imoveis = new List<Imoveis>();

        public int ImovelId { get; set; }

        public string Endereco { get; set; } = null!;

        public int Tipo { get; set; }

        public decimal Area { get; set; }

        public decimal ValorParaLocacao { get; set; }

        public decimal ValorParaVenda { get; set; }

        public string Descricao { get; set; }

        public bool Disponivel { get; set; }

        public virtual ICollection<Favorito> Favoritos { get; set; } = new List<Favorito>();

        public virtual ICollection<Imovel> Imovel { get; set; } = new List<Imovel>();

        public virtual ICollection<MensagensContato> MensagensContatos { get; set; } = new List<MensagensContato>();

        public class Dominio
        {
        }
    }
}