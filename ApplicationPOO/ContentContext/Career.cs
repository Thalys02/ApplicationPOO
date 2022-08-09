namespace ApplicationPOO.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {

        }
        public int AmountCourses { get; set; }
        public IList<CarrerItem> Items { get; set; } = new List<CarrerItem>();
        public int TotalCourses { get => Items.Count; }
    }
}
