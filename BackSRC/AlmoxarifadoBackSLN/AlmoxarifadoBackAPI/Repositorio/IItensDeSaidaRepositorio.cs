using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IItensDeSaidaRepositorio
    {
        void Add(ItensDeSaida ItensDeSaida);

        List<ItensDeSaida> GetAll();



    }
}