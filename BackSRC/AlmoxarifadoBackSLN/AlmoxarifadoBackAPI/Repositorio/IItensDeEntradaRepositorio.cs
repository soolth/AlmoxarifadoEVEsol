using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IItensDeEntradaRepositorio
    {
        void Add(ItensDeEntrada ItensDeEntrada);

        List<ItensDeEntrada> GetAll();


    }
}
