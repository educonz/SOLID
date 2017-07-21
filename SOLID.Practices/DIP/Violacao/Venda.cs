using SOLID.Practices.DIP.Refatorado;
using System.Collections.Generic;

namespace SOLID.Practices.DIP.Violacao
{
    public class Venda
    {
        private readonly Repository _repository;
        private readonly IList<Produto> _produtos;
        private readonly ValidacaoProduto _validacaoProduto;
        private readonly GerenciamentoEstoque _gerenciamentoEstoque;

        public Venda()
        {
            _repository = new Repository();
            _produtos = new List<Produto>();
            _validacaoProduto = new ValidacaoProduto();
            _gerenciamentoEstoque = new GerenciamentoEstoque();
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
