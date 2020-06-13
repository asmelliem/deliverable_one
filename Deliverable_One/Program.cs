using System;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {                   

            Console.WriteLine("Which vacation type you with to go on: musical, tropical, or adventurous");
            string vacationType = Console.ReadLine().ToLower();
            string destination;

            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destination = "Beach Vacation in Mexico";
            }
            else
            {
                destination = "Whitewater Rafting the Grand Canyon";
            }

            Console.WriteLine("How many people will be in your group?");
            int groupSize = int.Parse(Console.ReadLine());
            string travelSuggestion;

            if (groupSize >= 6)
            {
                travelSuggestion = "Charter Flight";
            }
            else if (groupSize >= 3)
            {
                travelSuggestion = "Helicopter";
            }
            else
            {
                travelSuggestion = "First Class";
            }

            string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelSuggestion + " to " + destination;
            Console.WriteLine(result);           

        }
    }
}
