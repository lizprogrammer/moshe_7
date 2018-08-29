using System;


namespace Section7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //IsSorted();
            CheckForDuplicates();

        }

        static void Yo()
        // Prints Yes
        {
            Console.WriteLine("Yes it's sorted");
        }
        
        static void No()
        // Prints no
        {
            Console.WriteLine("No it's not sorted");
        }
        
    /// Determines if string array is sorted from A -> Z
    public static bool IsSorted()
    {
        // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
        // or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not 
        // Consecutive".
            Console.Write("Please enter a few numbers separated by a hyphen: ");
            string MyString = Console.ReadLine();
            
            string[] Values = MyString.Split(',');
        
        for (int i = 1; i < Values.Length; i++)
        {
            if (Values[i - 1].CompareTo(Values[i]) > 0) // If previous is bigger, return false
            {
                No();
                return false;
            }
        }
        Yo();
        return true;
    }
    
    
        //     2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        // If the user simply presses Enter, without supplying an input, exit immediately; 
        // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the 
        // console.
        static int CheckForDuplicates()
        {
            Console.Write("Please enter a few numbers separated by a hyphen: ");
            string MyString = Console.ReadLine();
            
            string[] Values = MyString.Split('-');
            
            if(Values.Length <= 1)
            {
                Console.WriteLine("Try Again");
                CheckForDuplicates();
            }
            
            Array.Sort(Values);
            
            Console.Write(String.Format("{0} ", Values[0]));
            
            for (int i = 1; i < Values.Length; i++)
            {
                if (Values[i - 1].CompareTo(Values[i]) == 0) // If same, ignore
                {
                // do nothing
                 //Console.Write(String.Format("Same {0} ", Values[i]));
                }
                else
                {
                    Console.Write(String.Format("{0} ", Values[i]));
                }
            }
            Console.WriteLine();
            return 0;
        }
/*
Note: For all these exercises, ignore input validation unless otherwise specified. 
Assume the user provides input in the format that the program expects. 



2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; 
otherwise, check to see if there are duplicates. If so, display "Duplicate" on the 
console.

3- Write a program and ask the user to enter a time value in the 24-hour time format 
(e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, 
display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, 
consider it as invalid time. 

4- Write a program and ask the user to enter a few words separated by a space. Use 
the words to create a variable name with PascalCase. For example, if the user types: 
"number of students", display "NumberOfStudents". Make sure that the program is not 
dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should 
still display "NumberOfStudents".

5- Write a program and ask the user to enter an English word. Count the number of 
vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program 
should display 6 on the console.

*/
    }
}