using System;
using System.Linq;
using MaoNaMassa1.ContentContext;
using MaoNaMassa1.ContentContext.Enums;
using MaoNaMassa1.SubscriptionContext;

namespace MaoNaMassa1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "ecosistema-csharp"));
            articles.Add(new Article("Artigo sobre .NET", "iniciando-no-dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine($"{article.Id} \n{article.Title} - {article.Url}");
            //     Console.WriteLine();
            // }

            var courses = new List<Course>();
            Course course1 = new Course("Fundamentos OOP", "fundamentos-oop");
            Course course2 = new Course("Iniciando com C#", "fundamentos-csharp");
            Course course3 = new Course("ASP.DOTNET", "fundamentos-asp-dotnet");
            course1.Level = (EContentLevel)1;
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);

            var careers = new List<Career>();
            var career1 = new Career("Especialista .NET", "especialista-dotnet");
            var careerItems2 = new CareerItem(2, "Avançando para OOP", "", course1);
            var careerItems1 = new CareerItem(1, "Começe por aqui", "", null);
            var careerItems3 = new CareerItem(3, "Aprenda .NET", "", course3);
            career1.CareerItems.Add(careerItems2);
            career1.CareerItems.Add(careerItems1);
            career1.CareerItems.Add(careerItems3);
            careers.Add(career1);

            foreach (var career in careers)
            {
                Console.WriteLine($"{career.Title}");
                foreach (var item in career.CareerItems.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"Id: {item.Order} - Career: {item.Title} - Course Title: {item.Course?.Title} - Level: {item.Course?.Level}");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} -| {notification.Message}\n");
                    }
                }
            }

            var paypPalSubscription = new PayPalSubscription();
            Student student = new Student();
            student.CreateSubscription(paypPalSubscription);
            
            
        }
    }
}