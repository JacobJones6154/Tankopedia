using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tankop.Models
{
    public class Tanks
    { 

        public int Id { get; set; }
        public string Country { get; set; }
        public string Class { get; set; }
        public int Tier { get; set; } 
        public string TankName { get; set; }
        public int HitPoints { get; set; }
        public float ROF { get; set; }
        public float AimTime { get; set; }
        public float Accuracy { get; set; }
        public int AvgPenetration { get; set; }
        public int AvgDamage { get; set; }
        public float Dpm { get; set; }
        public string HullArmor { get; set; }
        public string TurretArmor { get; set; }
        public string ImgSrc { get; set; }


    }
}
