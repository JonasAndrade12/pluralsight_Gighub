namespace Pluralsight_Gighub.Controllers.Api
{
    using Microsoft.AspNet.Identity;
    using Pluralsight_Gighub.Models;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    public class GigsController : ApiController
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var usedId = User.Identity.GetUserId();

            var gig = _context.Gigs.Single(g => g.Id == id && g.ArtistId == usedId);

            if (gig.IsCanceled)
            {
                return NotFound();
            }

            gig.IsCanceled = true;

            var notification = new Notification
            {
                DateTime = DateTime.Now,
                Gig = gig,
                Type = NotificationType.GigCanceled
            };

            var attendees = _context.Attendances
                .Where(a => a.GigId == gig.Id)
                .Select(a => a.Attendee)
                .ToList();

            foreach (var attendee in attendees)
            {
                attendee.Notify(notification);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
