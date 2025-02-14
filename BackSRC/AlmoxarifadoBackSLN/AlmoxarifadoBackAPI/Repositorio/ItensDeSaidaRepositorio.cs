using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ItensDeSaidaRepositorio : IItensDeSaidaRepositorio
    {
        private readonly Context _db;

        public ItensDeSaidaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(ItensDeSaidaRepositorio ItensSaidaRepositorio)
        {

            _db.Produto.Add(ItensDeSaidaRepositorio);
            _db.SaveChanges();
        }

        public List<ItensDeSaidaRepositorio> GetAll()
        {
            return _db.ItensDeSaidaRepositorio.ToList();
        }
    }
}

