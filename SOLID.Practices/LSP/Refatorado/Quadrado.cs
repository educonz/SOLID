using System;

namespace SOLID.Practices.LSP.Refatorado
{
    public class Quadrado : Paralelograma
    {
        public Quadrado(int altura, int largura) 
            : base(altura, largura)
        {
            if (altura != largura)
                throw new Exception("Os lados precisam ser iguais");
        }
    }
}
