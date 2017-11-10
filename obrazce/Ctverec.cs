using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Ctverec : Obrazec
    {
        double strana;
        public Ctverec(double strana)
        {
            this.strana = strana;
        }
        public override double VypoctiObsah()
        {
            return (strana * strana);
        }
    }
}
