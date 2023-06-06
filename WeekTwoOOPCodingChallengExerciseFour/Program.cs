

// Exercise 4

// Write a program named Averages that includes a method that accepts any number of numeric parameters, displays them, and displays their average.
// Demonstrate that the program works correctly when passed one, two, or three numbers, or an array of numbers.

// Steps to write the program

// Tasks:

// Main() method:

// Declare and assign an array
// Call Average() to display elements and display average
// Call Average() when only one, two or three values passed
// Average() method:

// Parameter: one, two or three numbers or an array.  use parameter arrays Note: when you don’t know how many arguments of the same data type might be sent to a method  use params parameter
// Display elements of an array
// Calculate the total average
// Display the average.

class Averages
{
    static void Main()
    {
        // double[] array = new double[3];
        double[] array = { 12, 14, 17, 19, 33 };

        // call Average() method to dsiplay only one value
        Average(33);
        // call Average() method to dsiplay 2 values
        Average(12, 47.4);
        // call Average() method to dsiplay 3 values
        Average(41.5, 77.3, 500);
    }

    public static void Average(params double[] nums)
    {
        double total = 0;
        double avg = 0;

        // to calculate the sum of numbers and store it in the variable total 
        foreach(double num in nums)
        {
            Console.WriteLine(num);
            total += num;
        }
        // to calculate the average 
        avg = total / nums.Length;
        Console.WriteLine("The average of the numbers is: ({0})" ,avg);
    }
}