// ---------------------------------------------------------------------
// Question: Finding the First Element Meeting a Condition in an Array
// Write a C# program to find and display the first element greater than 50 in an integer array.
// Hint: Use the Array.Find() method with a condition-checking function (Predicate) to find the first element greater than 50 in the array.
// Define a condition-checking function that returns true if the element is greater than 50.



int[] numbers = {1, 10, 21, 32, 45, 60, 100};

int firstGreater(int[] _numbers){
    return Array.Find(_numbers, number => number > 50);

}
bool foundIt(){
    if(firstGreater(numbers) == 0){
        return false;
    }
    return true;
}
// Console.WriteLine(foundIt());

// ---------------------------------------------------------------------
// Question: Find the First Element Greater Than 10
// Write a C# program that finds the first element greater than 10 in an integer array and displays it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first element greater than 10.
// Define a condition-checking function that returns true if the element is greater than 10.
int firstGreaterTen(int[] _numbers){
    return Array.Find(_numbers, checkCondition);

}
bool checkCondition(int number){
    return number > 10;

}
// Console.WriteLine(firstGreaterTen(numbers));

//---------------------------------------------------------------------
// Question: Find the First Negative Number
// Write a C# program to find the first negative number in an array of integers and display it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first negative number.
// Define a condition-checking function that returns true if the element is negative.

int[] numbersHaveNegative = {3, 5, 1, -21, -2, 24, 100};

int firstNegative(int[] _numbers){
    return Array.Find(_numbers, number => number < 0);

}

Console.WriteLine(firstNegative(numbersHaveNegative));
