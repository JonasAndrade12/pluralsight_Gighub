﻿namespace Pluralsight_Gighub.Controllers
{
    using Microsoft.AspNet.Identity;
    using Pluralsight_Gighub.Dto;
    using Pluralsight_Gighub.Models;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();

            if (_context.Attendances.Any(x => x.GigId == dto.GigId && x.AttendeeId == userId))
            {
                return BadRequest("The attendance already exist.");
            }

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
