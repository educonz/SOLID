using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Practices.SRP.Refatorado
{
    public class ValidacaoProduto
    {
        public string ValidarCodigoProduto(string codigoProduto)
        {
            if (codigoProduto.Length == 6)
            {
                return "Produto inválido";
            }

            return string.Empty;
        }

        public Tuple<string, Produto> ValidarProdutoExiste(string codigoProduto)
        {
            var produto = new Repository().Query<Produto>().FirstOrDefault(x => x.CodigoProduto.Equals(codigoProduto));

            var mensagemRetorno = (produto == null)
                ? "Produto não encontrado" 
                : string.Empty;

            return new Tuple<string, Produto>(mensagemRetorno, produto);
        }
    }
}
