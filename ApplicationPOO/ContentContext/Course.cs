namespace ApplicationPOO.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) 
            : base(title, url)
        {

        }
        public string? Tag { get; set; }
        public IList<Module> Modules { get; set; } = new List<Module>();
    }
}
