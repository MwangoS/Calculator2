﻿using System;
using Operations;
using Sum;
using Divide1;
using Subtract;
using Square;


namespace Basic_Calculator1
{
   
    public class Calculator : IAdd, IDivide, ISubtract, ISquare
    {
        // Creating objects of Geeks1 and Geeks2 class 
        private readonly Adding add = new Adding();
        private readonly Div divide = new Div();
OperationsTests

        private readonly Squares squared = new Squares();
        private readonly Subtraction Subtract = new Subtraction();
 master
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;

        }

        public dynamic Subtracts(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }

        public dynamic Square(dynamic a)
        {
            result = Square(a);
            return result;
        }

    }
}