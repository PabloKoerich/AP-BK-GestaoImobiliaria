using System;
using System.Collections.Generic;

namespace GestaoImobiliaria.Web.Models;

public partial class CorretoresViewModel
{
    public int CorretorId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Creci { get; set; } = null!;

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<ImoveisViewModel> ImoveisCorretorGestors { get; set; } = new List<ImoveisViewModel>();

    public virtual ICollection<ImoveisViewModel> ImoveisCorretorNegocios { get; set; } = new List<ImoveisViewModel>();

    public virtual ICollection<MensagensContato> MensagensContatos { get; set; } = new List<MensagensContato>();
}
