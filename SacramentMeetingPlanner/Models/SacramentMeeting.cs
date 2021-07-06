using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        // properties
        public int SacramentMeetingId { get; set; } // primary key
        public DateTime DateOfMeeting { get; set; }
        public string ConductLeader { get; set; }
        public string OpenHymn { get; set; }
        public string CloseHymn { get; set; }
        public string SacramentHymn { get; set; }
        public string OpenPrayer { get; set; }
        public string ClosePrayer { get; set; }
        public string MusicalNumber { get; set; } // optional
    }
}
