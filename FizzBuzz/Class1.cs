using System.Text;

namespace FizzBuzz
{
    public class Class1
    {
        // Using the dictionary to store the combinations we are entering
        public Dictionary<int, string> keyValue = new Dictionary<int, string>();

       
        /// <summary>
        /// Output Method
        /// <paramref name="upperBound"/>
        /// </summary>
        /// <param name="upperBound"></param>
        public void Output(int upperBound)  // This method outputs the whole string based on the combinations and Maximum Upper Bound value
        {

            UserInput();
            
            for (int i = 0; i < upperBound; i++)
            {
                string output = string.Empty;
                foreach (var comb in keyValue)
                {
                    if (i % comb.Key ==0)
                        output += comb.Value;
                }
                if(output == null)
                {
                    output = i.ToString();
                }
                Console.WriteLine (output);
            }
        }

        
        /// <summary>
        /// User Input Method
        /// </summary>
        public void UserInput() //This method takes input from user for all the combinations. "Exit" when done.
        {
            Console.WriteLine("Please enter integer and string combinations with a space. Enter Exit when done");
            string line;
            do
            {
                line = Console.ReadLine();
                string[] parts = line.Split(' ');
                Int32.TryParse(parts[0], out int number);
                if (parts.Length == 2 && number != 0)
                    keyValue.Add(number, parts[1]);

            } while (line != null && !line.ToLower().Equals("exit"));
        }
    }
}