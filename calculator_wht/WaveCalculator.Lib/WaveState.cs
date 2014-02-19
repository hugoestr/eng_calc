using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveCalculator.Lib
{
    public class WaveState
    {
         public double k {get; set;}
         public double omega {get; set;}
         public double T {get; set;}
         public double c {get; set;}
         public double cg {get; set;}

         public double E {get; set;}
         public double Hs {get; set;}
         public double P {get; set;}
         public double u {get; set;}

         public string state { get; set; }
    
    }
}
