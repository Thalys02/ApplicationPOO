namespace ApplicationPOO.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url)
            : base(title, url)
        {

        }
        public override string ToString()
        {
            return $"Article: {Id}\n \t  {Title}\n \t  {Url}\n\n";
        }
    }
}
 