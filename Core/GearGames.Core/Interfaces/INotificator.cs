namespace GearGames.Core.Interfaces
{
    public interface INotificator
    {
        List<string> GetNotifications();
        bool HasNotifications();
        void Handle(string notification);
    }
}
