// See https://aka.ms/new-console-template for more information

namespace Console_App_W01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displaying a greeting first to remind me "WriteLine" exists
            Console.WriteLine("Hello!");

            // 2. Get user's name and location
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();

            // 3. Display both variables with proper labels
            Console.WriteLine($"Your name is {firstName}, and you are from {location}");

            // 4. Output current date, but not the time.
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is " + today.ToString("D"));

            // 5. Output number of days until Christmas, using today's year
            string nextChristmas = "12/25/" + today.Year;
            DateTime Christmas = DateTime.Parse(nextChristmas);

            // This method will cause issues on the last week of December, could account for this with an if statement
            Console.WriteLine("We have " + (Christmas - today).Days + " days until Christmas!");

            // 6. Imported Rob Miles window frame code, start with initializing variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            // Let the user know what we're doing
            Console.WriteLine("\nNow let's build some windows!");

            // Get width input as a double
            Console.Write("Enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            // Get height input as a double
            Console.Write("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //calculate the necessary material lengths
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
           
            // Inform the user of the proper dimensions
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // 7. Pause before automatically terminating
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}