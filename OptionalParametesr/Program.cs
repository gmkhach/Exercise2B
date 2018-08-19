//  3. Using your own words in a comment at the top of your .cs file, describe "syntactic sugar".
//  The term "sntactic sugar" refers to the creative design of the language's syntax to make itself an easier read for the human eye.
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametesr
{
    class Program
    {
        static void Main(string[] args)
        {
            nightSky();
        }

        //  1. Write a method that takes two optional parameters.
        static void nightSky(string celestialObject = "Earth", string objectType = "planet")
        {
            Console.WriteLine($"The {celestialObject} is a {objectType}!");
        }

        //  2. Manually write out the method you created in #1, this time using overloaded functions rather than optional parameters.
        static void night_Sky(string celestialObject, string objectType)
        {
            Console.WriteLine($"The {celestialObject} is a {objectType}!");
        }

        static void night_Sky(string celestialObject)
        {
            night_Sky(celestialObject, "planet");
        }

        static void night_Sky()
        {
            night_Sky("Earth");
            night_Sky("Earth", "planet");
        }

    }
}
