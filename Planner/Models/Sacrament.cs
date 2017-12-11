using System;
using System.ComponentModel.DataAnnotations;


namespace Planner.Models
{
    public class Sacrament
    {

        public int ID { get; set; }
        [Display(Name = "Sacrament Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SacramentDate { get; set; }
        public string Conducting { get; set; }
        public string OpeningHymn { get; set; }
        public string Invocation { get; set; }
        public string SacramentHymn { get; set; }
        public string FirstSpeaker { get; set; }
        public string SecondSpeaker { get; set; }
        public string RestHymn { get; set; }
        public string ThirdSpeaker { get; set; }
        public string ClosingHymn { get; set; }
        public string Convocation { get; set; }

    }
}
