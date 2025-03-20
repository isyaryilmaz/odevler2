using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Matematik
    {

        //Toplama işlemi için overload
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }


        public double Topla(double a, double b)
        {
            return a + b;
        }
        public double Topla(double a, double b, double c)
        {
            return a + b + c;
        }

        //Çarpma işlemi için overload
        public int Carp(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Carp(double a, double b)
        {
            return a * b;
        }



        public double Carp(double a, double b, double c)
        {
            return a * b * c;
        }




    }
}
