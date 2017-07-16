using System.Linq;

namespace SOLID.Practices.DIP.Refatorado
{
    public class GerenciamentoEstoque
    {
        private readonly Repository _repository;

        public GerenciamentoEstoque()
        {
            _repository = new Repository();
        }

        public void BaixarEstoque(string codigoProduto, int quantidade)
        {
            var estoque = _repository.Query<Estoque>().FirstOrDefault(x => x.CodigoProduto.Equals(codigoProduto));
            estoque.Quantidade -= quantidade;
            _repository.Save(estoque);
        }
    }
}
