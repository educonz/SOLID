using SOLID.Practices.DIP.Refatorado;
using System;

namespace SOLID.Practices.DIP.Refatorado
{
    public interface IValidacaoProduto
    {
        string ValidarCodigoProduto(string codigoProduto);
        Tuple<string, Produto> ValidarProdutoExiste(string codigoProduto);
    }
}