using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ItensDeEntradaRepositorio : IEntradaRepositorio
    {
        private readonly Context _db;

        public ItensDeEntradaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Entrada entrada)
        {

            _db.Entrada.Add(entrada);
            _db.SaveChanges();
        }

        public List<Entrada> GetAll()
        {
            return _db.Entrada.ToList();
        }


    }
}
