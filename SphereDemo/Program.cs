using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Sphere> shapes = new List<Sphere>();
            shapes.Add(new Sphere(2));
            shapes.Add(new Cylinder(1.5, 2));
            shapes.Add(new Cone(.75, 1.5));
            shapes.Add(new Cube(1.2));
            //Sphere is parent of all classes so we could declare ea of em as a "Sphere":
            foreach (Sphere shape in shapes)
            {
                Console.WriteLine("{0:f2}", shape.Volume);
            }

            Console.WriteLine("\n If density is 10 then Mass of each of above is:\n");
            foreach (Sphere x in shapes)
            { Console.WriteLine(x.GetMass(10)); }

            

        }
    }
}
