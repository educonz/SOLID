using System;

namespace SOLID.Practices.ISP.Refatorado
{
    public class Dev : IDev
    {
        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("Codando e tomando café");
        }
    }
}
