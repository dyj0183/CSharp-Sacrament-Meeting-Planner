using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        // properties
        public int SacramentMeetingId { get; set; } // primary key

        [Display(Name = "Date")]
        [Required]
        public DateTime DateOfMeeting { get; set; }

        [Display(Name = "Conducting Leader")]
        [Required]
        public string ConductLeader { get; set; }

        [Display(Name = "Opening Hymn")]
        [Required]
        public string OpenHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        [Required]
        public string CloseHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpenPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosePrayer { get; set; }

        [Display(Name = "Musical Number")]
        public string MusicalNumber { get; set; } // it is optional

        // navigation properties
        public ICollection<Speaker> Speakers { get; set; } // each sacrament could link to zero or many speakers
    }
}
