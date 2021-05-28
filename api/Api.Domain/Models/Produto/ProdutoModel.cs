
using System;

namespace Api.Domain.Models.Produto
{
    public class ProdutoModel
    {
        private Guid _Id;
        public Guid Id
        {
            get { return _Id; }
            set { this._Id = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
                   
        private string _Preco;
        public string Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }
        
        private DateTime _CreateAt;
        public DateTime CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = value == null ? DateTime.UtcNow : value; }
        }
        
        private DateTime _UpdateAt;
        public DateTime UpdateAt
        {
            get { return _UpdateAt; }
            set { _UpdateAt = value; }
        }
        
        private string _Descricao;
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }


        private string _Url_imagem;
        public string url_imagem
        {
            get { return _Url_imagem; }
            set { _Url_imagem = value; }
        }


    }
}