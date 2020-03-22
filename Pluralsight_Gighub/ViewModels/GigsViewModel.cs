namespace Pluralsight_Gighub.ViewModels
{
    using Pluralsight_Gighub.Models;
    using System.Collections.Generic;

    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }

        public bool ShowActions { get; set; }
    }
}