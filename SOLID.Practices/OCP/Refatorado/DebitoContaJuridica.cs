using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Practices.OCP.Refatorado
{
    public class DebitoContaJuridica : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            throw new NotImplementedException();
        }
    }
}
