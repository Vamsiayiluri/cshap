namespace ConsoleApp
{
    /// <summary>
    /// This class will takes input and displays the output
    /// </summary>
    public class InputOutput
    {
        /// <summary>
        /// this ReadInput method will take input from the user
        /// </summary>
        /// <returns></returns>
        public string ReadInput()
        {
            return Console.ReadLine();
        }
        /// <summary>
        /// This Display method will display output to the user
        /// </summary>
        /// <param name="output"></param>
        public void Display(string output)
        {
            Console.WriteLine(output);
        }
    }
}
