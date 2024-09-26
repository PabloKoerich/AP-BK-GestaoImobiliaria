namespace GestaoImobiliaria.Dominio.ModuloCliente
{
    public interface IServiceCliente
    {
        void CriarCliente(Cliente cliente);
        List<Cliente> TragaTodosClientes();
        void SalvarCliente(Cliente cliente);
        Cliente TragaClientePorId(int id);
        void Remover(int id);
    }
}