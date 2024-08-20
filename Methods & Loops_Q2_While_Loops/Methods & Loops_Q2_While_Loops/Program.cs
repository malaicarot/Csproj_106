////////////////While Loop////////////////
using System;
//Part 1
//Create a program that uses a while loop to print out the numbers 1 to 10 to the console.
//Hint: You can use a while loop to print out the numbers 1 to 10 to the console.
void printOutNumbers()
{
    int i = 1;

    while (i <= 10)
    {
        Console.WriteLine(i);
        i++;
    }
}
//printOutNumbers();

//Part 2
//Create a program that uses a while loop to print out the numbers 10 to 1 to the console.
//Hint: You can use a while loop to print out the numbers 10 to 1 to the console.
void printOutNumbers2()
{
    int i = 10;

    while (i > 0)
    {
        Console.WriteLine(i);
        i--;
    }
}
// printOutNumbers2();



//Part 3
//Create a program that uses a while loop to print out the even numbers from 1 to 10 to the console.
//Hint: You can use a while loop to print out the even numbers from 1 to 10 to the console.
void printOutEvenNumbers()
{
    int i = 1;

    while (i <= 10)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}
// printOutEvenNumbers();

//Part 4
//Create a program that uses a while loop to print out the odd numbers from 1 to 10 to the console.
//Hint: You can use a while loop to print out the odd numbers from 1 to 10 to the console.
void printOutOddNumbers()
{
    int i = 1;

    while (i <= 10)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}
// printOutOddNumbers();


//Part 5
//Write a C# Sharp program that takes a number as input and print its multiplication table.
//Hint: You can use a while loop to print out the multiplication table of a number.
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10
//5 * 3 = 15
//....
//5 * 10 = 50
void multipTableOfNumber()
{
    Console.Write("Enter the number: ");
    string input = Console.ReadLine();

    int number = int.Parse(input);
    int termNum = 0;

    while (termNum <= 10)
    {
        Console.WriteLine($"{number} x {termNum} = {number * termNum}");
        termNum++;
    }

}
// multipTableOfNumber();


//Part 6
//Write a C# Sharp program that takes a number as input and print its factorial.
//Hint: You can use a while loop to calculate the factorial of a number.
//Test Data:
//Enter the number: 5
//Expected Output:
//The factorial of 5 is: 120


int calculateFactorial(int number)
{

    if (number == 0 || number == 1)
    {
        return 1;
    }
    return number * calculateFactorial(number - 1);
}

void factorialNumber()
{
    Console.Write("Enter the number: ");
    string input = Console.ReadLine();

    int number = int.Parse(input);

    int result = calculateFactorial(number);

    Console.WriteLine($"The factorial of {number} is: {result}");
}

// factorialNumber();


//Part 7
//Write a C# Sharp program that takes a number as input and print the series 1+2+3+ ... +n = sum
//Hint: You can use a while loop to calculate the sum of a series.
//Test Data:
//Enter the number: 5
//Expected Output:
//1 + 2 + 3 + 4 + 5 = 15

void sumOfSeries()
{
    Console.Write("Enter the number: ");
    string input = Console.ReadLine();

    int number = int.Parse(input);

    int termNum = 1;

    int sum = 0;

    while (termNum <= number)
    {
        if (termNum == number)
        {
            Console.Write($"{termNum} = ");

        }
        else
        {
            Console.Write($"{termNum} + ");
        }
        sum += termNum;
        termNum++;
    }

    Console.Write(sum);
}
// sumOfSeries();

//Part 8
//Write a program in C# Sharp to display the multiplication table horizontally from 1 to n.
//Hint: You can use conseol.write to print out the multiplication table horizontally.
//Test Data:
//Input upto the table number starting from 1 : 8
//Expected Output:
//Multiplication table from 1 to 8
//1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
//...
//1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80

void multipTableHorizontally()
{
    Console.Write("Enter the number: ");
    string input = Console.ReadLine();

    int number = int.Parse(input);

    int termNum1 = 1;

    int termNum2 = 1;

    while (termNum2 < 11)
    {

        if (termNum1 > number)
        {
            termNum2++;
            termNum1 = 1;
            Console.WriteLine();
        }
        else
        {
            Console.Write($"{termNum1} x {termNum2} = {termNum1 * termNum2}, ");
            termNum1++;

        }

    }
}
// multipTableHorizontally();





//Part 9
//Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
//Hint: You can use a while loop to print out the pattern.
//Test Data:
//Input number of rows : 3
//Expected Output:
//1
//12
//123

void printOutRightAngleTriangle()
{
    Console.Write("Input number of rows: ");
    string input = Console.ReadLine();

    int rows = int.Parse(input);

    int part = 1;
    int quantity = 1;

    while (part <= rows)
    {
        while (quantity <= part)
        {
            Console.Write(quantity);
            quantity++;
        }
        Console.WriteLine();
        quantity = 1;
        part++;
    }
}
// printOutRightAngleTriangle();


//Part 10
//Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
//Hint: You can use a while loop to print out the pattern.
//Test Data:
//Input number of rows : 3
//Expected Output:
//*
//**
//***
void rightAngleTriangleWithStart()
{
    Console.Write("Input number of rows: ");
    string input = Console.ReadLine();

    int rows = int.Parse(input);

    int part = 1;
    int quantity = 1;
    char start = '*';

    while (part <= rows)
    {
        while (quantity <= part)
        {
            Console.Write(start);
            quantity++;
        }
        Console.WriteLine();
        quantity = 1;
        part++;
    }
}
// rightAngleTriangleWithStart();

//Part 11
//Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.
//Hint: You can use a while loop to print out the pattern.
//Test Data:
//Input number of rows : 5
//Expected Output:
//    1
//   2 3
//  4 5 6
// 7 8 9 10
//11 12 13 14 15

void printOutPyramid()
{

    Console.Write("Input number of rows: ");
    string input = Console.ReadLine();

    int rows = int.Parse(input);

    string pad = "";

    int padNum = rows - 1;

    int quantity = 1;

    int part = 1;

    int number = 1;

    while (part <= rows)
    {
        Console.Write(pad.PadLeft(padNum));

        while (quantity <= part)
        {
            Console.Write($"{number} ");
            quantity++;
            number++;
        }

        Console.WriteLine();
        part++;
        quantity = 1;
        padNum--;
    }
}

// printOutPyramid();

////////////////Do While Loop////////////////


//while loop: Condition is checked before the loop body runs.

//do-while loop: Loop body runs at least once before checking the condition.

//Example(Uncomment each loop type to see the difference) 


//While Loop//

// int x = 1;
// while (x < 1)
// {
//    Console.WriteLine(x);
//    x++;
// }



//Do While Loop//

// int x = 1;
// do
// {
//    Console.WriteLine(x);
//    x++;
// } while (x < 1);



