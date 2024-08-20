//Use For Loops to solve the following problems.



//Part 1
//Write a program in C to display the first 10 natural numbers.
//Expected Output:
//1 2 3 4 5 6 7 8 9 10

void firstTenNaturalNumber()
{
    int mark = 10;
    for (int i = 1; i <= mark; i++)
    {
        Console.Write($"{i} ");
    }


}
// firstTenNaturalNumber();


//Part 2
//Write a program in C to display the cube of the number up to an integer.
//Expected Output:
//Input number of terms: 5
//Number is: 1 and cube of the 1 is: 1
//Number is: 2 and cube of the 2 is: 8
//Number is: 3 and cube of the 3 is: 27
//Number is: 4 and cube of the 4 is: 64
//Number is: 5 and cube of the 5 is: 125

void cubeOfNumber()
{
    int exponent = 3;

    Console.Write("Input number of terms: ");
    string input = Console.ReadLine();

    int firstNumbers = int.Parse(input);

    for (int i = 1; i <= firstNumbers; i++)
    {
        Console.WriteLine($"Number is: {i} and cube of the {i} is: {Math.Pow(i, exponent)}");
    }
}
// cubeOfNumber();



//Part 3
//Write a program in C to display the multiplication table of a given integer.
//Expected Output:
//Input the number (Table to be calculated): 15
//15 X 1 = 15
//...
//15 X 10 = 150

void multipTableOfNumber()
{

    Console.Write("Input the number (Table to be calculated): ");
    string input = Console.ReadLine();

    int number = int.Parse(input);

    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }
}
// multipTableOfNumber();


//Part 4
//Write a C# Sharp program to display an alphabet pattern like Y with an asterisk.
//Hint: Use nested loop
//Expected Output:
// *     *
//  *   *
//   * *
//    *
//    *
//    *
//    *

void alphabet()
{
    string asterisk = "*";
    string space = "";
    int spaceDistance = 6;
    int spaceDistance2 = 1;


    for (int i = 0; i < 7; i++)
    {
        if (i < 3)
        {
            for (int j = 0; j < 1; j++)
            {
                Console.Write($"{asterisk.PadLeft(spaceDistance2)}");
                
            }
            Console.WriteLine($"{asterisk.PadLeft(spaceDistance)}");
            spaceDistance2++;
            spaceDistance -= 2;
        }else{
            Console.WriteLine($"{asterisk.PadLeft(spaceDistance2)}");
        }
    }
}
// alphabet();

// Part 5: Character Health Regeneration
// Simulate the regeneration of a game character's health over 5 rounds. Display the character's health after each round, regenerating 10 health points per round.
// Expected Output:
// Round 1: Health 10
// Round 2: Health 20
// ...
// Round 5: Health 50

void healthRegeneration(){
    int healthPoint = 0;

    int healing = 10;

    for(int i = 1; i <= 5; i++){
        Console.WriteLine($"Round {i}: Health {healthPoint += healing}");
    }
}

//  healthRegeneration();


/////////// For Each Loop ///////////

//Use For Each Loops to solve the following problems.

//Part 6
// Create an list of names and iterate through each name and display the name.
//Expected Output:
//Name: John
//Name: James
//Name: Luke
//Name: Lila
string[] nameList = new string[] {"John", "James", "Luke", "Lila"};

void printOutListName(string[] nameList){

    foreach (string name in nameList)
    {
        Console.WriteLine($"Name: {name}");
    }
}
// printOutListName(nameList);


//Part 7
//Create a list of number , iterate through them and display the square of each number.
//Expected Output:
//Square of 2: 4
//Square of 3: 9
//Square of 4: 16
//Square of 5: 25

int[] numberList = {1, 2, 3, 6, 9, 11, 12};

void squareOfEachNumber(int[] numberList){

    foreach (int number in numberList)
    {
        Console.WriteLine($"Square of {number}: {number * number}");
    }
}
// squareOfEachNumber(numberList);


