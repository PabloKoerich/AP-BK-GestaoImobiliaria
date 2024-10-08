﻿using System;
using System.Collections.Generic;

namespace GestaoImobiliaria.Web.Models;

public partial class ImoveisViewModel
{
    public int ImovelId { get; set; }

    public string Endereco { get; set; } = null!;

    public int Tipo { get; set; }

    public decimal Area { get; set; }

    public decimal Valor { get; set; }

    public string? Descricao { get; set; }

    public int Negocio { get; set; }

    public int? CorretorNegocioId { get; set; }

    public int CorretorGestorId { get; set; }

    public int ClienteDonoId { get; set; }

    public bool Disponivel { get; set; }

    public string? Fotos { get; set; }

    public virtual ClienteViewModel ClienteDono { get; set; } = null!;

    public virtual CorretoresViewModel CorretorGestor { get; set; } = null!;

    public virtual CorretoresViewModel? CorretorNegocio { get; set; }

    public virtual ICollection<FavoritoViewModel> Favoritos { get; set; } = new List<FavoritoViewModel>();

    public virtual ICollection<MensagensContato> MensagensContatos { get; set; } = new List<MensagensContato>();
}
