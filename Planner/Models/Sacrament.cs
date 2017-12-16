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
        public string Hymns { get; set; }
        public string Prayer { get; set; }
        public string Speakers { get; set; }
        public string Subject { get; set; }

    }

}
