using System;

namespace SOLID.Practices.ISP.Violacao
{
    public class ScrumMaster : IMembroDeTimeScrum
    {
        public void BlindarTime()
        {
            Console.WriteLine("Devs working! You shall not pass!!");
        }

        public void ImplementarFuncionalidades()
        {
            throw new NotImplementedException();
        }

        public void PriorizarBacklog()
        {
            throw new NotImplementedException();
        }
    }
}
