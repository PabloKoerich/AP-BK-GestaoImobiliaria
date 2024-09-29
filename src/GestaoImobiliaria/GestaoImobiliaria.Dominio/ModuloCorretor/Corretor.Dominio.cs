using Academia.Programador.Bk.Gestao.Imobiliaria;
using Academia.Programador.Bk.Gestao.Imobiliaria.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoImobiliaria.Dominio.ModuloCorretor
{
    public class Corretor
    {
        public int CorretorId { get; set; }

        public string CorretorName { get; set; }
        
        public string CorretorCPF { get; set; } = null!;
        
        public string CorretorCreci { get; set; } = null!;
        
        public string CorretorTelefone { get; set; }
        
        public string CorretorEmail { get; set; }

        public virtual ICollection<Imovel> ImoveisCorretorGestor { get; set; } = new List<Imovel>();

        public virtual ICollection<Imovel> ImoveisCorretorNegocio { get; set; } = new List<Imovel>();

        public virtual ICollection<MensagensContato> MensagensContatos { get; set; } = new List<MensagensContato>();
        public object Cpf { get; internal set; }
        public object Email { get; internal set; }
    }
}
