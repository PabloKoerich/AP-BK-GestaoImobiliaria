using System;
using System.Collections.Generic;

namespace GestaoImobiliaria.Web.Models;

public partial class Favorito
{
    public int FavoritoId { get; set; }

    public int ClienteId { get; set; }

    public int ImovelId { get; set; }

    public DateOnly DataAdicionado { get; set; }

    public virtual ClienteViewModel Cliente { get; set; } = null!;

    public virtual Imoveis Imovel { get; set; } = null!;
}
