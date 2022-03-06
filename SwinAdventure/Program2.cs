using System;
using System.Runtime.CompilerServices;
using SwinAdventure;



namespace SwinAdventure
{
    class Program
    {

        private string command;

        static void Main(string[] args)
        {
            //Get the player's name and description from the user, and use these details to create a
            //Player object.
            Console.WriteLine("Please name your player: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Please discribe your charector");
            string playerDescription = Console.ReadLine();
            
            Player player = new Player(playerName, playerDescription);

            //Create two items and add them to the the player's inventory

            Item money = new Item(new string[] { "money" }, "Cash", "A handfull of assorted dirty notes and coins.");
            Item blueprints = new Item(new string[] { "blueprints" }, "blueprints", "stolen bluprintss for a tritium deuterium fustion reactor. ");

            player.Inventory.PutItem(money);
            player.Inventory.PutItem(blueprints);

            //Create a bag and add it to the player's inventory

            Bag bag = new Bag(new string[] { "bag" }, "rucksack", "A hipster-esc styled blue backpack with brown heighlights.");
            player.Inventory.PutItem(bag);

            //Create another item and add it to the bag

            Item laptop = new Item(new string[] { "laptop" }, "laptop", "A suprisingly powerfull laptop. Odd, you have holes in your jeans and you're carying this?");
            bag.Inventory.PutItem(laptop);

            //addition of location 
            Locations location1 = new Locations(new string[] { "house" }, "house", "a spooky house");
            Locations location2 = new Locations(new string[] { "yahyahs" }, "yahyahs", "a fun nightclub");

            Path path1 = new Path(new string[] { "yahyahspath" }, "yahyahspath", "a path to yahyahs", location2);

            player.Location = location1;
            location1.Paths.Add(path1);

            location1.Inventory.PutItem(blueprints);

            //Loop reading commands from the user, and getting the look command to execute them.
            string command = "";
            CommandProcessor CommandProcessor = new CommandProcessor();

            while (command != "exit")
            {
                Console.WriteLine("Please enter your Command -->");
                command = Console.ReadLine();
                Console.WriteLine(CommandProcessor.Execute(player, command.Split(' ')));
            }
        }
    }
}
