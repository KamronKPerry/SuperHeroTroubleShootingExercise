using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperHeroInc.DATA//.Metadata placing in same namespace as partial classes
{
    [MetadataType(typeof(AlignmentMetadata))]
    public partial class Alignment { }
    public class AlignmentMetadata
    {
        [Required(ErrorMessage = "*Required to create a new Alignment")]
        [Display(Name = "Alignment Name")]
        [StringLength(50, ErrorMessage = "*Max Length 50")]
        public string AlignName { get; set; }
        [Display(Name = "Alignment Description")]
        [DisplayFormat(NullDisplayText = "No Description Provided")]
        [UIHint("MultilineText")]
        public string AlignDesc { get; set; }
    }
    [MetadataType(typeof(CharacterMetadata))]
    public partial class Character { }
    public class CharacterMetadata
    {
        [Required(ErrorMessage = "*Required")]
        [StringLength(50, ErrorMessage = "*Max Length 50")]
        [Display(Name = "Hero Name")]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "*Max Length 50")]
        [DisplayFormat(NullDisplayText = "No Description Provided")]
        [Display(Name = "Hero Alias")]
        public string Alias { get; set; }
    }
    [MetadataType(typeof(EventMetadata))]
    public partial class Event { }
    public class EventMetadata
    {
        [Required(ErrorMessage = "* Required to create an Event")]
        [StringLength(50, ErrorMessage = "*Max Length 50")]
        [Display(Name = "Event Title")]
        public string EventName { get; set; }
        [DisplayFormat(NullDisplayText = "No Description Provided")]
        [Display(Name = "Event Description")]
        [UIHint("MultilineText")]
        public string Description { get; set; }
        [Display(Name = "Instructor ID")]
        [Required(ErrorMessage = "Required to create an event")]
        public int Instructor { get; set; }
        //[Range(DateTime.Now, DateTime.Now.AddDays(60)] //Max DateTime allowed??? TASK: Date Time Range restriction? 
        [Display(Name = "Event Date")]
        [Required(ErrorMessage = "*Required to create an event")]
        public System.DateTime EventDate { get; set; }
        [Display(Name = "Is the event weekly?")]
        public bool isRecurring { get; set; }
        [Required(ErrorMessage = "* Required to create an event")]
        public string Location { get; set; }
    }
    [MetadataType(typeof(StatusMetadata))]
    public partial class Status { }
    public class StatusMetadata
    {
        [Required(ErrorMessage = "*Required")]
        [StringLength(50, ErrorMessage = "*Max Length 50")]
        [Display(Name = "Status Name")]
        public string StatusName { get; set; }
        [Display(Name = "Status Description")]
        [UIHint("MultilineText")]
        public string StatusDesc { get; set; }
    }

}

