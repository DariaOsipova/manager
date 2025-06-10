using Manager.ValueObjects;
using Manager.Domain.Enums;
using Manager.ValueObjects.Base;
using Manager.Domain.Entities.Base;
using Manager.Domain.Entities;
using Manager.Domain.Exceptions;

namespace Manager.Domain.ValueObjects
{
    public class Feedback : Entity<Guid>
    {
        public Guid DealId { get; private set; }
        public Comment Comment { get; private set; }
        public Rating Rating { get; private set; }
        public Deal Deal { get; private set; }


        public Feedback(Guid dealId, string comment, Rating rating)
            : base(Guid.NewGuid())
        {
            DealId = dealId;
            Comment = new Comment(comment);
            Rating = rating;
        }

        protected Feedback() : base(Guid.NewGuid()) { }
    }

}

