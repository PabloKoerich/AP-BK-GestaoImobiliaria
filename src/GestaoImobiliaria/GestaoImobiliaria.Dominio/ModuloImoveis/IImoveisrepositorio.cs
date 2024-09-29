using Academia.Programador.Bk.Gestao.Imobiliaria;
using GestaoImobiliaria.Dominio.ModuloCliente;

namespace GestaoImobiliaria.Dominio.ModuloImoveis
{
    public interface IImoveisRepositorio 
    {
        void CriarImoveis(Imovel imovel);
        List<Imovel> TragaTodosImoveis();

        void SalvarImovel(Imovel imovel);
        Imovel TragaimovelPorId(int id);
        void Remover(int id);
        bool ImovelPorid(string imovelId, int ImovelId);
    }
}
