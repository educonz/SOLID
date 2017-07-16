namespace SOLID.Practices.SRP.Refatorado
{
    public interface IGerenciamentoEstoque
    {
        void BaixarEstoque(string codigoProduto, int quantidade);
    }
}