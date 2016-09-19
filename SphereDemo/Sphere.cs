using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereDemo
{
    public class Sphere
    {
        public double Length { get; private set; }
        //Apparently despite "get"-only prop,, I still don't need to create field. Works fine without field. But when use auto-prop then get/set both should be there.. 
        //public double volume; //virtual goes only e property for this field, not the field itself.
        //sphere vol = 4/3 (pi * r^3)
        public virtual double Volume { get { return (4*Math.PI*Math.Pow(Length, 3))/3; } } //this virtual will be overriden in child classes.
        public Sphere(double length)
        {
            Length = length;
        }

        //GetMass method will be inherited by all children. But each'd use their own "volume" aft overriding parent's.
        public double GetMass(double density)
        { return density * Volume; } //Capital "V" coz small "v" volume is NOT being assigned anything & is zero by default.

    }
}
