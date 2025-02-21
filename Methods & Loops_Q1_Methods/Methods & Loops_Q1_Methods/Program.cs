﻿using System;
//---------------------------------------------------------------------
// Part 1: Displaying a Welcome Message
// Create a user-defined function to display a welcome message.
// Hint: Define a function named DisplayWelcomeMessage() that prints the welcome message to the console.
//---------------------------------------------------------------------
// Part 2: Personalized Welcome Message
// Create a user-defined function with parameters to personalize a welcome message.
// Hint: Define a function named PersonalizedWelcomeMessage() that takes a name as a parameter and prints a personalized welcome message to the console.

//---------------------------------------------------------------------
// Part 3: Calculating the Sum of Two Numbers
// Create a user-defined function to calculate the sum of two numbers.
// Hint: Define a function named CalculateSum() that takes two parameters, adds them, and returns the result.


//---------------------------------------------------------------------
// Part 4: Counting Spaces in a String
// Create a user-defined function to count the number of spaces in a string.
// Hint: Define a function named CountSpaces() that takes a string as a parameter, counts the number of spaces, and returns the count.



class program
{

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello My World!");
    }

    static void PersonalizedWelcomeMessage(string yourName, string address)
    {
        Console.WriteLine($"Hello {yourName}. Hope to see you at {address}!");
    }

    static double CalculateSum(double num1, double num2)
    {
        return num1 + num2;
    }


    static int CountSpaces(string strNeedToCount){

        int countSpaces = 0;

        foreach (char item in strNeedToCount)
        {
            if(item == ' '){
                countSpaces++;
            }
        }
        return countSpaces;
}

    static double CalculateArraySum(double[] arrNum){

        double sum = 0;

        foreach (double num in arrNum)
        {
            sum += num;
          
        }
        return sum;
}

   static void SwapNumbers(int num1, int num2){

        int virNum;

        Console.WriteLine($"Before: num 1: {num1} / num 2: {num2}");

        virNum = num1;
        num1 = num2;
        num2 = virNum;
        Console.WriteLine($"After: num 1: {num1} / num 2: {num2}");
}


   static double CalculateExponent(double baseNum, double exponentNum){
    

    return Math.Pow(baseNum, exponentNum);

}
static int DisplayFibonacciSequence(int numOfTerms){

    if(numOfTerms == 0 || numOfTerms == 1){
        return 1;
    }

    return DisplayFibonacciSequence(numOfTerms - 2) + DisplayFibonacciSequence(numOfTerms - 1);

}

static bool CheckPrimeNumber(int number){

    if(number < 2){
        Console.WriteLine($"{number} isn't prime number!");
        return false;
    }

    for(int i = 2; i <= Math.Sqrt(number); i++){
        if(number % i == 0){
            Console.WriteLine($"{number} isn't prime number!");

            return false;
        }
    }

        Console.WriteLine($"{number} is prime number!");

    return true;

}


static int CalculateDigitSum(int number){
    int result = 0;

    while(number > 0){
        result += number % 10;
        number /= 10;
    }

    return result;
}


static void DisplayInfo(string name, int age){
    Console.WriteLine($"Name: {name} - Age: {age}");

}


static double GetSquareRoot(double number, out double result){
    result = Math.Sqrt(number);

   return  result;
}


static void GreetUser(string name, string greetingMessage = "Hello"){
    Console.WriteLine($"{greetingMessage} {name}!");
}
    static void Main()
    {
        //------1-------//
        // DisplayWelcomeMessage();
        //------2-------//
        // PersonalizedWelcomeMessage("PAK", "GV");
        //------3-------//
        // Console.WriteLine(CalculateSum(4.5, 3.5));
        //------4-------//
        // string myString = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        // Console.WriteLine(CountSpaces(myString));
        //------5-------//
        // double[] arr = {1, 3.4, 5.5, 3};
        // Console.WriteLine(CalculateArraySum(arr));
        //------6-------//
        // SwapNumbers(1, 2);
        //------7-------//
        // double num1= 2;
        // double num2 = 3;
        // Console.WriteLine(CalculateExponent(num1, num2));
        //------8-------//
        // Console.WriteLine(DisplayFibonacciSequence(5));
        //------9-------//
        // CheckPrimeNumber(3);
        //------10-------//
        // Console.WriteLine(CalculateDigitSum(78574));
        //------11-------//
        // DisplayInfo(name: "John", age: 30);
        //------12-------//
        // double num = 6;
        // double result = 0;
        // Console.WriteLine(result);
        // Console.WriteLine(GetSquareRoot(num, out result));
        // Console.WriteLine(result);
        //------13-------//
        GreetUser(name: "PAK");

    
    }

}

//---------------------------------------------------------------------
// Part 5: Calculating the Sum of Elements in an Array
// Create a user-defined function to calculate the sum of elements in an array.
// Hint: Define a function named CalculateArraySum() that takes an array as a parameter, calculates the sum of its elements, and returns the sum.

//---------------------------------------------------------------------
// Part 6: Swapping Two Integer Numbers
// Create a user-defined function to swap two integer numbers.
// Hint: Define a function named SwapNumbers() that takes two integer parameters, swaps their values, and prints the updated values to the console.

//---------------------------------------------------------------------
// Part 7: Calculating Exponentiation
// Create a user-defined function to calculate the result of raising an integer number to another.
// Hint: Define a function named CalculateExponent() that takes two integer parameters (base and exponent), calculates the result, and prints it to the console.


//---------------------------------------------------------------------
// Part 8: Displaying the Fibonacci Sequence
// Create a user-defined function to display the Fibonacci sequence up to a specified number of terms.
// Hint: Define a function named DisplayFibonacciSequence() that takes an integer parameter (number of terms), calculates and prints the Fibonacci sequence to the console.

//---------------------------------------------------------------------
// Part 9: Checking Prime Numbers
// Create a user-defined function to check whether a number is prime or not.
// Hint: Define a function named CheckPrimeNumber() that takes an integer parameter, checks if it's prime, and prints the result to the console.

//---------------------------------------------------------------------
// Part 10: Calculating the Sum of Individual Digits
// Create a user-defined function to calculate the sum of individual digits of a given number.
// Hint: Define a function named CalculateDigitSum() that takes an integer parameter, calculates the sum of its digits, and prints the result to the console.

//---------------------------------------------------------------------
// Part 11: Testing Named Parameters in C#
// Write a C# program that defines a method called "DisplayInfo" that takes two parameters: "name" and "age".
// Use named parameters to call the "DisplayInfo" method with the parameter values "name"="John" and "age"=30.
// Hint: Define the method "DisplayInfo" with parameters "name" and "age", then call it using named parameters.

//---------------------------------------------------------------------
// Part 12: Testing Out Parameters in C#
// Write a C# program that defines a method called "GetSquareRoot" that calculates the square root of a number.
// Use an out parameter to return the square root of a given number.
// Hint: Define the method "GetSquareRoot" with an out parameter to store the result.

//---------------------------------------------------------------------
// Part 13: Testing Default or Optional Parameters in C#
// Write a C# program that defines a method called "GreetUser" with two parameters: "name" and "greetingMessage".
// Set the default value of "greetingMessage" to "Hello".
// Call the "GreetUser" method with only the "name" parameter provided.
// Hint: Define the method "GreetUser" with a default value for one of its parameters.

