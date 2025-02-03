using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IProdutoRepositorio
    {
        void Add(Produto categoria);

        List<Produto> GetAll();
    }
}
