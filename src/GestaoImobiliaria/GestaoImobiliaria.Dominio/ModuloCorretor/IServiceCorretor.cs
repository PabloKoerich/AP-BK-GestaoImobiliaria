using GestaoImobiliaria.Dominio.ModuloCorretor;

namespace GestaoImobiliaria.Dominio.ModuloCorretor;

public interface IServiceCorretor
{
    void CriarCorretor(Corretor corretor);
    List<Corretor> TragaTodosCorretores();
    void SalvarCorretor(Corretor corretor);
    Corretor TragaCorretorPorId(int id);
    void Remover(int id);
    object CorretorPorCpf(object cpf, int corretorId);
    object CorretorPorEmail(object email, int corretorId);
}
