namespace Guids
{
    public class ComparacaoString
    {
        public void Exemplo()
        {
            string text = "Testando";

            Console.Clear();
            // Retorna 0 se for igual e 1 se for diferente (Case sensitive)
            Console.WriteLine(text.CompareTo("Testando"));
            Console.WriteLine(text.CompareTo("testando"));


            text = "Este texto é um teste";
            // Retorna True se for igual e Fase se for diferente (Case sensitive)
            Console.WriteLine(text.Contains("teste"));
            Console.WriteLine(text.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.Contains("testando"));
        }
    }
}