namespace Guids
{
    public class StartsWEndsW
    {
        public void Exemplo()
        {
            // StartsWith EndsWith Começa com e Termina com 
            string texto = "Este é um texto de teste";
            
            Console.Clear();
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase));

        }
    }
}