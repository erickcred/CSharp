using MaoNaMassa1.ContentContext.Enums;
using MaoNaMassa1.SharedContext;

namespace MaoNaMassa1.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationMinutes { get; set; }
        public EContentLevel Level { get; set; }


    }
}