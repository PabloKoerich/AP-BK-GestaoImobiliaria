using System;
using System.Collections.Generic;

namespace GestaoImobiliaria.Web.Models;

public partial class MensagensContato
{
    public int MensagemId { get; set; }

    public int ImovelId { get; set; }

    public int ClienteId { get; set; }

    public int CorretorId { get; set; }

    public string Mensagem { get; set; } = null!;

    public DateTime DataEnvio { get; set; }

    public virtual ClienteViewModel Cliente { get; set; } = null!;

    public virtual CorretoresViewModel Corretor { get; set; } = null!;

    public virtual ImoveisViewModel Imovel { get; set; } = null!;
}
