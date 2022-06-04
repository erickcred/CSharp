namespace Guids
{
    public class Guids
    {
        public void Exemplo()
        {
            // Guid -> Global Unic Identifier
            var id = Guid.NewGuid();
            string guid = id.ToString();

            Console.WriteLine(id);

            Console.WriteLine(guid);
        }
    }
}