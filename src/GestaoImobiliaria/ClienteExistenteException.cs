namespace Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCliente;

public class ClienteExistenteException : Exception
{
    public ClienteExistenteException() : base("Cliente já cadastrado.")
    {
    }
}