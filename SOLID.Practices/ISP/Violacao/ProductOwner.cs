using System;

namespace SOLID.Practices.ISP.Violacao
{
    public class ProductOwner : IMembroDeTimeScrum
    {
        public void BlindarTime()
        {
            throw new NotImplementedException();
        }

        public void ImplementarFuncionalidades()
        {
            throw new NotImplementedException();
        }

        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando o backlog com base nas necessidades do negócio");
        }
    }
}
