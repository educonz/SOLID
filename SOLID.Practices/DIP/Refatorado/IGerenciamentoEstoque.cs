namespace SOLID.Practices.DIP.Refatorado
{
    public interface IGerenciamentoEstoque
    {
        void BaixarEstoque(string codigoProduto, int quantidade);
    }
}