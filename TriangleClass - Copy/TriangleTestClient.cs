//Author: YOUR NAME HERE
//Date: 
//Purpose: This program is a test client designed to test the Triangle Class
//Input: None
//Processing: Each method of the class is tested for functionality
//Output: All output resulting from the various test statements is printed to the screen. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NmSpcTriangle; 

namespace DistanceTestClient
{
    class TriangleTestClient
    {
        static void Main(string[] args)
        {

            //Declare Triangle class objects for testing
            TriangleClass myTri = new TriangleClass();
            Console.WriteLine(myTri);
            //Test Perimeter Method
            Console.WriteLine(myTri.Perimeter().ToString());


            //Test Area Method
            Console.WriteLine(myTri.Area().ToString());

            //Test IsTriangle
            if (myTri.isTriangle())
            {
                Console.WriteLine("IT IS a triangle");
            }
            else
            {
                Console.WriteLine("NOT a triangle");
            }

            // Test isRight
            if (myTri.isRight())
            {
                Console.WriteLine("IT IS a right triangle");
            }
            else
            {
                Console.WriteLine("NOT a right triangle");
            }

            //Test GetSides / SetSides
            TriangleClass yourTri = new TriangleClass(10, 20, 30);
            Console.WriteLine(yourTri.ToString());
            float side1, side2, side3;
            myTri.GetSides(out side1, out side2, out side3);
            yourTri.SetSides(side1, side2, side3);
            Console.WriteLine(yourTri.ToString());

           
            // ourTri is assigned yourTri.. You may think two objects are created, but outTri is a just an alias 
            //for yourTri.. They reference the same object... 
            TriangleClass ourTri = new TriangleClass(50, 100, 150);
            Console.WriteLine(ourTri.ToString());
            ourTri = yourTri;
            Console.WriteLine(ourTri.ToString());

            TriangleClass addTri = new TriangleClass(50, 50, 50);
            Console.WriteLine(addTri.ToString());

            // Test operator + 
            addTri = addTri + ourTri;

            Console.WriteLine(addTri.ToString());
            //Therefore after I zero yourTri.. ourTri is also zeroed .. If they were two different objects 
            //OurTri would not have been zeroed.
            Console.ReadLine(); // acts like system("pause");
        }   
    }
}
