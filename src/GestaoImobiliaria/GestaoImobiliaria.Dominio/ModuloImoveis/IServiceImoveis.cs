﻿
namespace GestaoImobiliaria.Dominio.ModuloImoveis
{
    public interface IServiceImoveis
    {
        void CriarImovel(Imoveis imoveis); 
        List<Imoveis> TragaTodosImoveis();

        void SalvarImovel(Imoveis imoveis);
        Imoveis TragaImoveisPorId(int id);

        void Remover(int id);
        object ImovelPorId (object ImovelId, int imovelId);
    }
}  // as outras funcionalidade, entram aqui certo? edição, vizualizar, 