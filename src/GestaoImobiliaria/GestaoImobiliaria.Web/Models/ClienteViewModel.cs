using System;
using System.Collections.Generic;

namespace GestaoImobiliaria.Web.Models;

public partial class ClienteViewModel
{
    public int ClienteId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<FavoritoViewModel> Favoritos { get; set; } = new List<FavoritoViewModel>();

    public virtual ICollection<ImoveisViewModel> Imoveis { get; set; } = new List<ImoveisViewModel>();

    public virtual ICollection<MensagensContato> MensagensContatos { get; set; } = new List<MensagensContato>();
}
