using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {

        public string Name { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string url_imagem { get; set; }

    }
}
