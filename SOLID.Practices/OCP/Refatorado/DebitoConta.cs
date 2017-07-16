namespace SOLID.Practices.OCP.Refatorado
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);
    }
}
