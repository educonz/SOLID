using System;

namespace SOLID.Practices.ISP.Violacao
{
    public class Dev : IMembroDeTimeScrum
    {
        public void BlindarTime()
        {
            throw new NotImplementedException();
        }

        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("Codando e tomando café");
        }

        public void PriorizarBacklog()
        {
            throw new NotImplementedException();
        }
    }
}
