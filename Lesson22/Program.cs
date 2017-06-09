﻿using System;


namespace LoopsMethodsExceptionsArraysClasses
{
    // Add a static method named MultiplytTwoNumbers that takes two int
    // parameters named x and y, and returns the int result that is the
    // product of the two parameters.

    class Program
    {
        
     static void MultiplyNumbers(int x, int y, out int? result)
        {
            result = x * y;
        }

        // Add an instance method named AddTwoNumbers that takes two int
        // parameters named x and y, and returns the int result that is
        // the sum of the two parameters.

        int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        // Add a static method named DoubleIt that returns void, and it
        // takes one parameter named x of type int that will be returned
        // as an out parameter. The outgoing value of the parameter is double
        // the input value of the parameter.

        static void DoubleIt(out int x)
        {
            x = 1;
            var y = x * 2;
            x = y;

        }

        // Add an instance method named LoopOverParams that returns void, and
        // takes a single parameter that is an array of int type elements
        // declared using the params keyword. The LoopOverParams method uses a
        // foreach loop to iterate over the collection of values it receives
        // and it displays the list of elements in the parameter.


        // Add a static method named DivideIntegers that takes two int
        // parameters named dividend and divisor. It returns the result
        // of dividing the dividend parameter by the divisor parameter.


       
       
            // Call the static method named MultiplytTwoNumbers
            // passing in the two int values of 3 and 4. Then
            // assign the result to a local variable named product and
            // display the resulting value of product in console output.

            static void Main()
            {
                int a = 3;
                int b = 4;


                Program mm = new Program();
                int product = Program.MultiplyNumbers(a, b);
                Console.WriteLine(product);
            }

        // Create an instance of the Program class named program.
        // Then call the instance method named AddTwoNumbers
        // passing in the values of 3 and 4. Then assign
        // the result to a local variable named sum and
        // display the value of sum in console output


        // Declare an int variable named x and initialize it
        // with the literal value of 42. Call the static method
        // named DoubleIt passing in the x variable as the
        // parameter. Then display the resulting value of x in
        // console output.

        int x = 42;

        static DoubleIt() {

            Console.WriteLine(x); }

            // Call the LoopOverParams instance method, passing in
            // three parameters with the values of 1, 2, and 3.


            // Call the method named DivideIntegers with the first
            // parameter set to 1, and second parameter set to 0.
            // Assign the result to an int variable named quotient.
            // Apply the try and catch keywords to properly handle
            // the resulting divide by zero exception. In the
            // exception handler, display the exception message
            // in the console output.


            // Declare a two-dimensional array named multiplicationTable
            // that contains 4 elements by 4 elements. Initialize it in
            // a nested loop to contain elements that equal to the value
            // that is the product of the two index values for
            // each element. In a second nested loop, display the values
            // in the console output, with column elements seperated with
            // commas, and row elements seperated with carriage returns.


        }
    }




