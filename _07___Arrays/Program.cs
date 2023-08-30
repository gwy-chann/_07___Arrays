namespace _07___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize array grades 

            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 30;
            grades[3] = 50;
            grades[4] = 60;
            Console.WriteLine("Grade at index 0 : {0}.", grades[0]); 

            string input = Console.ReadLine();
            // assigning value to array index 0 
            grades[0] = int.Parse(input);
            Console.WriteLine("Grade at index 0 : {0}.", grades[0]);

            // another way of initializing
            int[] gradeOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //third way of initializing an array 
            int[] gradeOfMathStudentsB = new int[] { 20, 13, 12, 13, 15, 3, 6 };

            Console.WriteLine("Length of gradesOfMathStudentsA {0}.", gradeOfMathStudentsA.Length);

            Console.ReadKey();
        }
    }
}