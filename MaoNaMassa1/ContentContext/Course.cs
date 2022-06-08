using System.Collections.Generic;
using MaoNaMassa1.ContentContext.Enums;

namespace MaoNaMassa1.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; } // cod
        public IList<Module> Modules { get; set; }
        public int DurationMinutes { get; set; }
        public EContentLevel Level { get; set; }
        

        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
    }

}