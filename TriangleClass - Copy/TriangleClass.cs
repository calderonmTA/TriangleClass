using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NmSpcTriangle
{
//Author: ******  YOUR NAME HERE
//Purpose:  This class contains the definiton of a TriangleClass. It contains three private data members and 
// 8 public methods. The data members are: sideA, sideB and sideC which contain the lengths of the sides.
// A summary of the methods appears below:
// 
// Assumptions: Data supplied for the length of sides will always be that of a valid triangle.
//              Data supplied for the length of the sides in the non-default constructor will be in the rder
//                  sideA is the shortest side, sideB is the midddlest side, sideC will be the longest side.
//          
// Exception Handling: None
//
// Summary of Methods:
//  TriangleClass() default constructor : instantiates an equilateral triangle of sides 1,1,1.
//  TriangleClass(sA, sB, sC) : instantiates a triangle with the three values supplied by the client)
//  void SetSides(sA, sB, sC) : changes the sides of the traingle to a new set of sides
//  void GetSides(out sA, out sB, out sC) : returns the sides of the triangle
//  float Perimeter() : calculates the perimeter of the triangle
//  float Area() : calculates the Area of a triangle 
//  bool IsTriangle: determines whether the pdm's of class represent a valid triangle
//  bool  IsRight : determines whether the pdm;s of the class representa a valid right triangle
//  string ToString(); returns a string representation of the PDM's of the class
//  public void Zero() : test method to zero the class  
//  public static TriangleClass operator +(t1,t2) : returns the sum of two triangles

    public class TriangleClass
    {
        //private data members
        private float sideA;                //shortest side(unless eq/isos)
        private float sideB;                //middle side(unless eq/isos)
        private float sideC;                //longest side


        //public methods

        //constructor
        //Pre: Object has been instantiated
        //Post: Class has been initialized to a 3,4,5 right triangle
        //Purpose: initialized a class object
        public TriangleClass()
        {
            sideA = 3.0f;
            sideB = 4.0f;
            sideC = 5.0f;
        }

        //Pre: fltA, B and C contain lengths of sides of a valid triangle
        //Post: PDM'S of class have been set to  incoming parameters
        //Purpose: To initialize a Triangle with values of fltA, fltB and fltC
        public TriangleClass(float sA, float sB, float sC)
        {
            sideA = sA;
            sideB = sB;
            sideC = sC;
        }


        //Pre: sA, sB and sC contain lengths of sides of a valid triangle
        //Post: PDM'S of class have been set to incoming parameters
        //Purpose: To reset a Triangle sides with values of sA, sB and sC
        public void ResetSides(float sA, float sB, float sC)
        {
            sideA = sA;
            sideB = sB;
            sideC = sC;
        }


        //Pre: none
        //Post: PDM'S of class have been set to incoming parameters
        //Purpose: To set a Triangle sides with values of sA, sB and sC
        public void SetSides(float sA, float sB, float sC)
        {
            sideA = sA;
            sideB = sB;
            sideC = sC;
        }


        //Pre: The triangle has been instantiated
        //Post: The lengths of the sides of the triangle are passed back to the caller.
        //Purpose: Allows the client to get all three sides simultaneously
        public void GetSides(out float sA, out float sB, out float sC)
        {
            sA = sideA;
            sB = sideB;
            sC = sideC;
        }


        //Pre: Object has been instantiated
        //Post: Perimeter of triangle has been calculated and returned
        //Purpose: Calculate the perimeter of the triangle
        public float Perimeter()
        {
            return (sideA + sideB + sideC);
        }


        //Pre:Object has been instantiated
        //Post: Area of triangle has been calculated and returned
        //Purpose: Calculate the area of the triangle using Heron's formula
        public float Area()
        {
            // Heron's formula
            double s = (sideA + sideB + sideC) / 2.0f;
            double side1 = (s - (double)sideA);
            double side2 = (s - (double)sideB);
            double side3 = (s - (double)sideC);
            return (float)(Math.Sqrt(s * side1 * side2 * side3));
        }


        //Pre:Object has been instantiated
        //Post: A boolean value signifying if the three sides make up a valid triangle has been returned
        //Purpose: Determines whether the PDM's are sides of a valid triangle
        public bool isTriangle()
        {
            return ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA));
        }

        //Pre:Object has been instantiated
        //Post: A boolean value signifying if the three sides make up a valid right triangle has been returned
        //Purpose: Determines whether the PDM's are sides of a valid right triangle
        public bool isRight()
        {
            return (sideC * sideC == (sideA * sideA) + (sideB * sideB));
        }


        //Pre:Object has been instantiated
        //Post: The PDM's of the object have been reset to zero
        //Purpose: Resets a triangle
        public void Zero()
        {
            sideA = 0.0f;
            sideB = 0.0f;
            sideC = 0.0f;
        }

        //Pre:Object has been instantiated
        //Post: A string representing the contents of the PDM's has been returned
        //Purpose: returns a string delineating the contents of the class PDM's
        public override string ToString()
        {
            return ((sideA.ToString()) + " " + sideB.ToString() + " " + sideC.ToString()); 
        }

        /*
         * Purpose: Provides the union of two TriangleClass objects.
         * 
         * Pre: Two instantiated TriangleClass objects must be passed to the 
         * method.
         * 
         * Post: A new TriangleClass object that contains the sum of the 
         * corresponding sides of two triangles is returned.
        */
        public static TriangleClass operator+(TriangleClass leftHand, TriangleClass rightHand) 
        {
            TriangleClass newTri = new TriangleClass();
            newTri.sideA = leftHand.sideA + rightHand.sideA;
            newTri.sideB = leftHand.sideB + rightHand.sideB;
            newTri.sideC = leftHand.sideC + rightHand.sideC;

            return newTri;
        }



    }// end TriangleClass

}// end namespace