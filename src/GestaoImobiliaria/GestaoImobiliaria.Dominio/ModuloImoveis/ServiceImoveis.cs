

namespace GestaoImobiliaria.Dominio.ModuloImoveis
{
    public class ServiceImoveis : IServiceImoveis
    {
        private readonly IServiceImoveis _imoveisRepositorio;

        public ServiceImoveis(IImoveisRepositorio imoveisRepositorio)
        {
            _imoveisRepositorio = (IServiceImoveis)imoveisRepositorio;
        }

        public void CriarImovel(Imoveis imoveis)
        {
            throw new NotImplementedException();
        } // ok

        public void Remover(int id) //ok
        {
            _imoveisRepositorio.Remover(id);
        }

        public void SalvarImovel(Imoveis imoveis) //ok
        {
            ValidarDuplicidade(imoveis);
            _imoveisRepositorio.SalvarImovel(imoveis);
        }

        public void ValidarDuplicidade(Imoveis imoveis) //ok
        {
            throw new NotImplementedException();
        }

        public object ImovelPorId(object ImovelId, int imovelId) // ok
        {
            return _imoveisRepositorio.TragaImoveisPorId;
        }
     
        public Imoveis TragaImoveisPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Imoveis> TragaTodosImoveis()
        {
            throw new NotImplementedException();
        }
    }
}