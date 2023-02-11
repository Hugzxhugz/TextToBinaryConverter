using System.Threading.Channels;

namespace TextToBinaryConverter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Text - Binary Converter");
            Console.Write("Please enter text to convert: ");
            string input = Console.ReadLine();
            
            string output = TextToBinary(input);
            Console.WriteLine("Binary conversion for text is:");
            Console.WriteLine(output);
            Console.ReadLine();

        }

        static string TextToBinary(string input)
        {
            string output = "";
            
            foreach (char c in input.ToArray())
            {
                output += Convert.ToString(c, 2).PadLeft(8, '0') + " ";
            }
            return output;
        }
    }
}

