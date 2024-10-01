using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoImobiliaria.Dominio.ModuloImoveis
{
    public class ImoveisExistenteException : Exception
    {
        public ImoveisExistenteException() : base("Imóvel já Cadastrado!")
        {
        }
    }
}

    