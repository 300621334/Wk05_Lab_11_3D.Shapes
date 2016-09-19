using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereDemo
{
    class Cone : Cylinder
    {
        //no additional prop defined. Just inherits some prop from parents.
        //"h" of cone was assigned to Height-of-parent"Cylinder". And fetched back to be used below.
        //cone vol = (pi * r^2 * H)/3
        public override double Volume { get { return (Math.PI*Math.Pow(Length, 2)*Height)/3; } } //this virtual will be overriden in child classes.
        //const rcvd 2 args & sends them to const-of-base
        public Cone(double l, double h) : base(l, h) { }
    }
}
