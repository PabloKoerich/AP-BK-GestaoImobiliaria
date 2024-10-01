﻿
namespace GestaoImobiliaria.Dominio.ModuloCliente;

public class ServiceCliente : IServiceCliente
{
    private readonly IClienteRepositorio _clienteRepositorio;

    public ServiceCliente(IClienteRepositorio clienteRepositorio)
    {
        _clienteRepositorio = clienteRepositorio;
    }

    public void CriarCliente(Cliente cliente)
    {
        //Para validar duplicidade
        ValidacaoDuplicidade(cliente);

        _clienteRepositorio.CriarCliente(cliente);
    }

    private void ValidacaoDuplicidade(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    private void ValidacaoDuplicacao(Cliente cliente)
    {
        var exiteClienteCpf = _clienteRepositorio.ClientePorCpf(cliente.Cpf, cliente.ClienteId);

        if (exiteClienteCpf is true)
        {
            throw new ClienteExistenteException();
        }

        var exiteClienteEmail = _clienteRepositorio.ClientePorEmail(cliente.Email, cliente.ClienteId);

        if (exiteClienteEmail is true)
        {
            throw new ClienteExistenteException();
        }
    }

    public List<Cliente> TragaTodosClientes()
    {
        return _clienteRepositorio.TragaTodosClientes();
    }

    public void SalvarCliente(Cliente cliente)
    {
        //Para validar duplicidade
        ValidacaoDuplicacao(cliente);

        _clienteRepositorio.SalvarCliente(cliente);
    }

    public Cliente TragaClientePorId(int id)
    {
        return _clienteRepositorio.TragaClientePorId(id);
    }

    public void Remover(int id)
    {
        _clienteRepositorio.Remover(id);
    }
}