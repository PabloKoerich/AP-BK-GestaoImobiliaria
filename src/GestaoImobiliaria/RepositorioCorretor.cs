using Academia.Programador.Bk.Gestao.Imobiliaria.Dominio.ModuloCorretor;
using Microsoft.EntityFrameworkCore;

namespace Academia.Programador.Bk.Gestao.Imobiliaria.DAO.Repositorios.EF.Modulo_Corretor
{
    public class CorretorRepositorio : ICorretorRepositorio
    {
        private readonly ImobiliariaDbContext _context;

        public CorretorRepositorio(ImobiliariaDbContext context)
        {
            _context = context;
        }

        public void CriarCorretor(Corretor corretor)
        {
            _context.Corretores.Add(corretor);
            _context.SaveChanges();
        }
