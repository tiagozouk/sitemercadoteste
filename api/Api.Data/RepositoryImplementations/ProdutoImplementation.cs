using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class ProdutoImplementation : BaseRepository<ProdutoEntity>, IProdutoRepository
    {
        private DbSet<ProdutoEntity> dataset;

        public ProdutoImplementation(MyContext context) : base(context)
        {
            dataset = context.Set<ProdutoEntity>();
        }

        public async Task<ProdutoEntity> FindByNome(string nome)
        {
            return await dataset.FirstOrDefaultAsync(x => x.Name.Equals(nome));
        }
    }
}