namespace Pluralsight_Gighub.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notification
    {
        public int Id { get; private set; }

        public DateTime DateTime { get; private set; }

        public NotificationType Type { get; private set; }

        public DateTime? OriginalDateTime { get; set; }

        public string OriginalVenue { get; set; }

        [Required]
        public Gig Gig { get; private set; }

        protected Notification()
        {
        }

        public Notification(Gig gig, NotificationType type)
        {
            if (gig == null)
            {
                throw new ArgumentNullException();
            }

            this.Gig = gig;
            this.DateTime = DateTime.UtcNow;
            this.Type = type;
        }
    }
}