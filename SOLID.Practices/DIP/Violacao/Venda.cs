using System.Collections.Generic;
using System.Linq;

namespace SOLID.Practices.DIP.Violacao
{
    public class Repository
    {
        public IQueryable<T> Query<T>() { return default(IQueryable<T>); }
        public T Save<T>(T entity) { return default(T); }
    }

    public class Produto
    {
        public string CodigoProduto { get; set; }
        public decimal ValorUnitario { get; set; }
    }

    public class Estoque
    {
        public string CodigoProduto { get; set; }
        public decimal Quantidade { get; set; }
    }

    public class Venda
    {
        private readonly Repository _repository;
        private readonly IList<Produto> _produtos;

        public Venda()
        {
            _repository = new Repository();
            _produtos = new List<Produto>();
        }

        public string AdicionarProduto(string codigoProduto, int quantidade)
        {
            if (codigoProduto.Length == 6)
            {
                return "Produto inválido";
            }

            var produto = _repository.Query<Produto>().FirstOrDefault(x => x.CodigoProduto.Equals(codigoProduto));

            if (produto == null)
            {
                return "Produto não encontrado";
            }

            var estoque = _repository.Query<Estoque>().FirstOrDefault(x => x.CodigoProduto.Equals(codigoProduto));
            estoque.Quantidade -= quantidade;
            _repository.Save(estoque);

            _produtos.Add(produto);

            return $"Produto adicionado {codigoProduto}";
        }

        public decimal CalcularTotal()
        {
            // implementações
            return default(decimal);
        }

        public void GerarPlanilhaExcel()
        {
            // implementações
        }
    }
}
