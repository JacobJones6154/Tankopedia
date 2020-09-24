using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tankop.Models
{
    public class TankClassView
    {
        public List<Tanks> Tanks { get; set; }
        public SelectList Class { get; set; }
        public SelectList Tier { get; set; }
        public SelectList Country { get; set; }
        public string TankCountry { get; set; }
        public string TankClass { get; set; }
        public string TankTier { get; set; }
        public string SearchString { get; set; }
    }
}
