namespace Assignment_3._1._3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lets count the number of spaces in a string. \nType in a string:");
            string input = Console.ReadLine();

            int count = 0;

            foreach (char space in input) //identifies 'space' in string 'input'
            {
                if (space == ' ')
                {
                    count++; //adds all 'space' in the string
                }
            }
            Console.WriteLine($"Number of spaces in the string is: {count}");  

        }

    }
}
