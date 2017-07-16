namespace SOLID.Practices.OCP.Refatorado
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return NumeroTransacao;
        }
    }
}
