using Academia.Programador.Bk.Gestao.Imobiliaria.Web;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCliente
{
    public interface IServiceCliente
    {
        void CriarCliente(Cliente cliente);
    }
    public class ServiceCliente : IServiceCliente
    {
        private readonly IClienteRepositorio ClienteRepositorio;
        public ServiceCliente(IClienteRepositorio ClienteRepositorio)
        {
            ClienteRepositorio = clienteRepositorio;
        }
        public void CriarCliente(Cliente cliente)
        {
          ClienteRepositorio.CriarCliente(cliente);
        }
    }
}