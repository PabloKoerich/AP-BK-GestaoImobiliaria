using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoImobiliaria.Dominio.ModuloCorretor
{

    public class CorretorExistenteException : Exception
    {
        public CorretorExistenteException() : base("Corretor já Cadastrado!")
        {
        }
    }
}
