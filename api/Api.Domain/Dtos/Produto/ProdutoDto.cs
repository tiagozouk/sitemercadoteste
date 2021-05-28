using System;

namespace Api.Domain.Dtos.Produto
{
    public class ProdutoDto
    {
        public string Name { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string url_imagem { get; set; }
    }
}