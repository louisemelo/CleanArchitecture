using Flunt.Notifications;

namespace CleanArchitecture.Domain.Entities
{
    public abstract class BaseEntity : Notifiable<Notification>
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }
    }
}
