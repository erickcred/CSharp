namespace Generics
{
    public class DataContext<T> // DataContext<T, U, V>
    // Restrissão de tipos
    where T : Person
    // where U : Payment
    // where V : Subscription
    {
        public void Save(T entity)
        {
            
        }

        // public void Save(U entity) {}
        // public void Save(V entity) {}    
    }
}