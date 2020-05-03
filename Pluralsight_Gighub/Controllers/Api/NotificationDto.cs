namespace Pluralsight_Gighub.Controllers.Api
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Pluralsight_Gighub.Models;

    public class NotificationDto
    {
        public DateTime DateTime { get; set; }

        public NotificationType Type { get; set; }

        public DateTime? OriginalDateTime { get; set; }

        public string OriginalVenue { get; set; }

        public GigDto Gig { get; set; }
    }
}