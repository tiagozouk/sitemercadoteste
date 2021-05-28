using System;
using System.Net;
using System.Threading.Tasks;
using Api.Application.Controllers.Base;
using Api.Application.Controllers.Extensions;
using Api.Application.ViewModels.Response;
using Api.Domain.Dtos;
using Api.Domain.Dtos.Produto;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Produto;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    public class ProdutosController : BaseController
    {
        private IProdutoService service;
        public ProdutosController(IProdutoService service)
        {
            this.service = service;
        }

        
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await service.GetAll());
            }
            catch (ArgumentException e)
            {                
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var result = await service.Get(id);
                if(result == null) {
                    return NotFound(false.AsNotFoundResponse("Produto não encontrado."));
                }
                return Ok(result);
            }
            catch (ArgumentException e)
            {                
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProdutoDto prod)
        {
            try
            {
                
                if (await service.Post(prod) == null) {
                    return BadRequest();                    
                }
                return Ok(true.AsSuccessResponse("Produto registrado com sucesso."));
            }
            catch (ArgumentException e)
            {                
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        
        
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProdutoDtoUpdate prod)
        {
            try
            {

                if (!await service.Exist(prod.Id))
                {
                    return NotFound(false.AsNotFoundResponse("Produto não encontrado."));
                }

                if ( await service.Put(prod) == null) {
                    return BadRequest();                   
                }
                return Ok(true.AsSuccessResponse("Produto alterado com sucesso."));
            }
            catch (ArgumentException e)
            {                
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if(!await service.Exist(id)) {
                    return NotFound(false.AsNotFoundResponse("Produto não encontrado."));
                }
                if(await service.Delete(id)) {
                    return Ok(true.AsSuccessResponse("Produto deletado com sucesso.")); 
                }    
                return BadRequest();                
            }
            catch (ArgumentException e)
            {                
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
