// See https://aka.ms/new-console-template for more information
using ApplicationPOO.ContentContext;
using ApplicationPOO.SubscriptionContext;

var articles = new List<Article>();

articles.Add(new Article("Article about POO", "orientation-objects"));
articles.Add(new Article("Article about C#", "csharp-is-better"));
articles.Add(new Article("Article about .NET", "dotnet-is-nice"));

foreach (var article in articles)
{
    Console.WriteLine(article.ToString());
}

var courses = new List<Course>();

var coursePOO = new Course("Fundamentals POO", "fundamentals-POO");
var courseCsharp = new Course("Fundamentals C#", "fundamentals-csharp");
var courseAspNet = new Course("Fundamentals .NET", "fundamentals-aspnet");

courses.Add(coursePOO);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotNet = new Career("Specialist .Net", "specialist-dotnet");
var careerItem = new CarrerItem(1, "Beginer for here", "", null);
var careerItem3 = new CarrerItem(3, "Learning POO", "", coursePOO);
var careerItem2 = new CarrerItem(2, "Learning C#", "", courseCsharp);

careerDotNet.Items.Add(careerItem);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);

careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(o => o.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.CreateSubscription(payPalSubscription);