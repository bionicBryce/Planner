using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Planner.Models
{
    public class SacramentSpeakerViewModel
    {
        public List<Sacrament> sacraments;
        public SelectList firstspeaker;
        public string sacramentSpeaker { get; set; }
    }
}
