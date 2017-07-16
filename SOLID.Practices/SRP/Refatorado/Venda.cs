using SOLID.Practices.DIP.Refatorado;
using System.Collections.Generic;

namespace SOLID.Practices.SRP.Refatorado
{
    public class Venda
    {
        private readonly IRepository _repository;
        private readonly IList<Produto> _produtos;
        private readonly IValidacaoProduto _validacaoProduto;
        private readonly IGerenciamentoEstoque _gerenciamentoEstoque;

        public Venda(IRepository repository, 
            IValidacaoProduto validacaoProduto,
            IGerenciamentoEstoque gerenciamentoEstoque)
        {
            _repository = repository;
            _validacaoProduto = validacaoProduto;
            _gerenciamentoEstoque = gerenciamentoEstoque;
            _produtos = new List<Produto>();
        }

        public string AdicionarProduto(string codigoProduto, int quantidade)
        {
            var resultadoValidacaoProduto = _validacaoProduto.ValidarCodigoProduto(codigoProduto);
            if (!string.IsNullOrEmpty(resultadoValidacaoProduto))
                return resultadoValidacaoProduto;

            var resultadoValidacaoProdutoExiste = _validacaoProduto.ValidarProdutoExiste(codigoProduto);
            if (!string.IsNullOrEmpty(resultadoValidacaoProdutoExiste.Item1))
                return resultadoValidacaoProdutoExiste.Item1;

            _gerenciamentoEstoque.BaixarEstoque(codigoProduto, quantidade);

            _produtos.Add(resultadoValidacaoProdutoExiste.Item2);

            return $"Produto adicionado {codigoProduto}";
        }

        public decimal CalcularTotal()
        {
            // implementações
            return default(decimal);
        }
    }
}
