using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCorretor;
using GestaoImobiliaria.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoImobiliaria.Dominio.ModuloCorretor;

public class ServiceCorretor : IServiceCorretor
{
    private readonly IServiceCorretor _corretorRepositorio; 

    public ServiceCorretor(ICorretorRepositorio corretorRepositorio)
    {
        _corretorRepositorio = (IServiceCorretor?)corretorRepositorio;
    }


    public void CriarCorretor(Corretor corretor)
    {
        ValidacaoDuplicidade(corretor);
        _corretorRepositorio.CriarCorretor(corretor);
    }

    private void ValidacaoDuplicidade(Corretor corretor)
    {
        var exiteCorretorCpf = _corretorRepositorio.CorretorPorCpf(corretor.Cpf, corretor.CorretorId);

        if (exiteCorretorCpf is true)
        {
            throw new ClienteExistenteException();
        }

        var exiteCorretorEmail = _corretorRepositorio.CorretorPorEmail(corretor.Email, corretor.CorretorId);

        if (exiteCorretorEmail is true)
        {
            throw new ClienteExistenteException();
        }
    }

    public List<Corretor> TragaTodosCorretor()
    {
        return _corretorRepositorio.TragaTodosCorretores();
    }

    public void SalvarCorretor(Corretor corretor)
    {
        //Para validar duplicidade
        ValidacaoDuplicidade(corretor);
        _corretorRepositorio.SalvarCorretor(corretor);  
    }

    public Corretor TragaCorretorporId(int id)
    {
        return _corretorRepositorio.TragaCorretorPorId(id);
    }

    public void Remover(int id)
    {
        _corretorRepositorio.Remover(id);
    }

    public List<Corretor> TragaTodosCorretores()
    {
        throw new NotImplementedException();
    }

    public Corretor TragaCorretorPorId(int id)
    {
        throw new NotImplementedException();
    }

    public object CorretorPorCpf(object cpf, int corretorId)
    {
        throw new NotImplementedException();
    }

    public object CorretorPorEmail(object email, int corretorId)
    {
        throw new NotImplementedException();
    }
}

