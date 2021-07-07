using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        // properties
        public int SpeakerId { get; set; } // primary key
        public int SacramentMeetingId  { get; set; } // foreign key

        [Display(Name = "Speaker")]
        [Required]
        public string SpeakerName { get; set; }

        [Display(Name = "Speaker Subject")]
        [Required]
        public string SpeakerSubject { get; set; }

        // navigation properties
        public SacramentMeeting SacramentMeeting { get; set; }
    }
}
