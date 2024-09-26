namespace GestaoImobiliaria.Dominio.ModuloCliente;

public class ClienteExistenteException : Exception
{
    public ClienteExistenteException() : base("Cliente já cadastrado.")
    {
    }
}