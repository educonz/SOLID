using System;

namespace SOLID.Practices.ISP.Refatorado
{
    public class ProductOwner : IProductOwner
    {
        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando o backlog com base nas necessidades do negócio");
        }
    }
}
