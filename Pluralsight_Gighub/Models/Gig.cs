using System;

namespace Pluralsight_Gighub.Models
{
    public partial class Gig
    {
        public int MyProperIDty { get; set; }
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        public string Venue { get; set; }
    }
}