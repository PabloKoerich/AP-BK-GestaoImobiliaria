
using System;
using System.Collections.Generic;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.Web;

public partial class Corretores
{
    public int CorretorId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Creci { get; set; } = null!;

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Imovel> ImoveisCorretorGestors { get; set; } = new List<Imovel>();

    public virtual ICollection<Imovel> ImoveisCorretorNegocios { get; set; } = new List<Imovel>();

    public virtual ICollection<MensagensContato> MensagensContatos { get; set; } = new List<MensagensContato>();
}