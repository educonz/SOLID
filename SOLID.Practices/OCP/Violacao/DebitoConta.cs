namespace SOLID.Practices.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.ContaCorrente)
            {
                // debita 
            }
            else if (tipoConta == TipoConta.ContaPoupanca)
            {
                // valida aniversário
                // debita
            }
        }
    }
}
