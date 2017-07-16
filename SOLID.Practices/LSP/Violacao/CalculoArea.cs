namespace SOLID.Practices.LSP.Violacao
{
    public class CalculoArea
    {
        private void ObterAreaRetangulo(Retangulo retangulo)
        {
            var visorCalculoArea = $"{retangulo.Altura} * {retangulo.Largura}"; // 5 * 5 = 25 ??

            var calculoArea = retangulo.Area;
        }

        public void Calcular()
        {
            var quadrado = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quadrado);
        }
    }
}
