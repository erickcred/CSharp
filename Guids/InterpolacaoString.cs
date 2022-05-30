namespace Guids
{
    public class InterpolacaoString
    {
        public void Exemplo()
        {
            double preco = 12.40;
            string texto1 = "O preço do produto é " + preco;
            string text2 = String.Format("O preço do produto é {0}", preco);
            string texto3 = $"O preço do produto é {preco}";

            Console.Clear();
            Console.WriteLine(texto1);
            Console.WriteLine(texto3);
        }
    }
}