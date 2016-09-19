using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereDemo
{
    //since the constructor for Sohere is NOT a default one & needs a param, so we have to explicitly call sphere's constructor from child class. Otherwise red line under "Cylinder"
    class Cylinder : Sphere
    {
        public double Height { get; private set; }
        //cylinder vol = pi * r^2 * H
        public override double Volume { get { return Math.PI*Math.Pow(Length, 2)*Height; } } //this virtual will be overriden in child classes.
        //constructor rcd 2 args & called base-constructor e one of those. While used 2nd to assign the prop.
        public Cylinder(double len, double height) : base(len)
        {
            Height = height;
        }
    }
}
