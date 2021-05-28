using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.Produto;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Produto {
    public interface IProdutoService {
        Task<ProdutoDto> Get (Guid id);
        Task<bool> Exist (Guid id);
        Task<IEnumerable<ProdutoDto>> GetAll ();
        Task<ProdutoDto> Post (ProdutoDto user);
        Task<ProdutoDtoUpdate> Put (ProdutoDtoUpdate user);
        Task<bool> Delete (Guid id);
    }
}