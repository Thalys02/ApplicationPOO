namespace ApplicationPOO.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; } = new List<Notification>();

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsValid => Notifications.Any();
    }
}
