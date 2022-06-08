namespace MaoNaMassa1.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> CareerItems { get; set; }
        public int TotalCourses // => CareerItems.Count(); // Expression Body
        { 
            get { return CareerItems.Count(); } 
        }

        public Career(string title, string url) : base(title, url)
        {
            CareerItems = new List<CareerItem>();
        }

    }
}