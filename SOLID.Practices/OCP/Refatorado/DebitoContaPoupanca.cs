namespace SOLID.Practices.OCP.Refatorado
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return NumeroTransacao;
        }
    }
}
