namespace Pluralsight_Gighub.Controllers.Api
{
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Http;
    using Microsoft.AspNet.Identity;
    using Pluralsight_Gighub.Models;

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

            var gig = _context.Gigs
                .Include(g => g.Attendances.Select(a => a.Attendee))
                .Single(g => g.Id == id && g.ArtistId == usedId);

            if (gig.IsCanceled)
            {
                return NotFound();
            }

            gig.Cancel();

            _context.SaveChanges();

            return Ok();
        }
    }
}
