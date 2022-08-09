using ApplicationPOO.NotificationContext;
using ApplicationPOO.SharedContext;

namespace ApplicationPOO.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(a => !a.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "The student has a subscription active"));
                return;
            }

            Subscriptions.Add(subscription);
        }

    }
}
