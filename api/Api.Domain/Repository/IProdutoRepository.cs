using Api.Domain.Interfaces;
using Api.Domain.Entities;
using System.Threading.Tasks;

namespace Api.Domain.Repository
{
    public interface IProdutoRepository : IRepository<ProdutoEntity>
    {
         Task<ProdutoEntity> FindByNome(string nome);
    }
}