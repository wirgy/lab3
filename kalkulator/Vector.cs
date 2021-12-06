using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
   public class Vector
    {

        private double x;
        private double y;
        private double z;

        public Vector(double value, double value2, double value3)
        {
            x = value;
            y = value2;
            z = value3;
        }

        public string Verbose()
        {
            return String.Format("{0}, {1}, {2}", x, y, z);
        }

        public string Verbose2()
        {
            return String.Format("{0}", x);
        }
        public static Vector operator +(Vector instance1, Vector instance2)
        {
            return new Vector(instance1.x + instance2.x, instance1.y + instance2.y, instance1.z + instance2.z);
        }
        public static Vector operator -(Vector instance1, Vector instance2)
        {
            return new Vector(instance1.x - instance2.x, instance1.y - instance2.y, instance1.z - instance2.z);
        }
        public static Vector operator %(Vector instance1, Vector instance2)
        {
            return new Vector(instance1.x * instance2.x + instance1.y * instance2.y + instance1.z * instance2.z, 0, 0);
        }
       public static Vector operator /(Vector instance1, Vector instance2)
       {
            Vector newVect = new Vector(Math.Sqrt(Math.Pow(instance1.x, 2) + Math.Pow(instance1.y, 2)) + Math.Pow(instance1.z, 2), 0, 0);
            return newVect;
       }
        public static Vector operator *(Vector instance1, Vector instance2)
        {
            return new Vector(instance1.y * instance2.z - instance1.z * instance2.y, -(instance1.x * instance2.z - instance1.z * instance2.x), instance1.x * instance2.y - instance1.y * instance2.x);
        }
    }
}

