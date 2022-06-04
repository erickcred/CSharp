namespace Guids
{
    public class Indice
    {
        public void Exemplo()
        {
            string texto = "Este texto é um teste";

            Console.Clear();
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}