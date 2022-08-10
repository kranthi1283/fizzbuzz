namespace FizzBuzz
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            int i = 0;
            Console.WriteLine("Enter Upper Bound number");
            Int32.TryParse(Console.ReadLine(), out i);
            //c.Output(i);
            c.Output(int.MaxValue); // Leaving this to Max Value. We can uncomment line 11 and comment this line to check upper bound entry

        }
    }
}