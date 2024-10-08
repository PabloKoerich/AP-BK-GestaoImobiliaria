﻿
namespace GestaoImobiliaria.Web.Models;

public partial class FavoritoViewModel
{
    public int FavoritoId { get; set; }

    public int ClienteId { get; set; }

    public int ImovelId { get; set; }

    public DateOnly DataAdicionado { get; set; }

    public virtual ClienteViewModel Cliente { get; set; } = null!;

    public virtual ImoveisViewModel Imovel { get; set; } = null!;
}
