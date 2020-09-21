using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Tankop.Models
{
    public class TankCountryView
    {
        public List<Tanks> Tanks { get; set; }
        public SelectList Country { get; set; }
        public string TankCountry { get; set; }
        public string SearchString { get; set; }
    }
}
