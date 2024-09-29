using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCorretor;
using Microsoft.EntityFrameworkCore;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.DAO.Repositorios.EF.Modulo_Corretor
{
    public class ImoveisRepositorio : IImoveisRepositorio
    {
        private readonly ImobiliariaDbContext _context;

        public ImoveisRepositorio(ImobiliariaDbContext context)
        {
            _context = context;
        }

        public void CriarImoveis(Imoveis imoveis) 
        {
            _context.Imoveis.Add(imoveis);
            _context.SaveChanges();
        }
