using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.Produto;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Produto;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Models.Produto;
using Api.Domain.Models.User;
using AutoMapper;

namespace Api.Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private IRepository<ProdutoEntity> repository;
        private readonly IMapper mapper;
        public ProdutoService(IRepository<ProdutoEntity> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<bool> Exist(Guid id)
        {
            return await repository.ExistAsync(id);
        }

        public async Task<ProdutoDto> Get(Guid id)
        {
            var entity = await repository.SelectAsync(id);
            return mapper.Map<ProdutoDto>(entity);
        }

        public async Task<IEnumerable<ProdutoDto>> GetAll()
        {
            var entities = await repository.SelectAsync();
            return mapper.Map<IEnumerable<ProdutoDto>>(entities);
        }

        public async Task<ProdutoDto> Post(ProdutoDto user)
        {
            var model = mapper.Map<ProdutoModel>(user);
            var entity = mapper.Map<ProdutoEntity>(model);
            var result = await repository.InsertAsync(entity);
            return mapper.Map<ProdutoDto>(result);    
        }

        public async Task<ProdutoDtoUpdate> Put(ProdutoDtoUpdate user)
        {
            var model = mapper.Map<ProdutoModel>(user);
            var entity = mapper.Map<ProdutoEntity>(model);
            var result = await repository.UpdateAsync(entity);
            return mapper.Map<ProdutoDtoUpdate>(result);
        }
    }
}
