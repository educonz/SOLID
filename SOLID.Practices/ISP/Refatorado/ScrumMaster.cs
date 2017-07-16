using System;

namespace SOLID.Practices.ISP.Refatorado
{
    public class ScrumMaster : IScrumMaster
    {
        public void BlindarTime()
        {
            Console.WriteLine("Devs working! You shall not pass!!");
        }
    }
}
