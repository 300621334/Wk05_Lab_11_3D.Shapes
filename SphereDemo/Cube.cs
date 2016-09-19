using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereDemo
{
    class Cube : Sphere
    {
        //volume overrides that of base/parent
        //lengthOfCube was passed to parent Sphere & then assigned to Length of Parent. Now below we fetch back same Length, which actually is same as lengthOfCube.
        //cube vol = r^3
        public override double Volume { get { return Math.Pow(Length, 3); } } //this virtual will be overriden in child classes.

        //constructor rcvd 1 arg & sends to base-constructor
        public Cube(double lengthOfCube) : base(lengthOfCube) { }
    }
    
    
}
