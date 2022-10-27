using GearGames.Core.Interfaces;

namespace GearGames.Core.Services
{
    public class Notificator : INotificator
    {
        private List<string> Notifications { get; set; } = new();

        public List<string> GetNotifications() => Notifications;

        public void Handle(string notification) => Notifications.Add(notification);

        public bool HasNotifications() => Notifications.Any();
    }
}
