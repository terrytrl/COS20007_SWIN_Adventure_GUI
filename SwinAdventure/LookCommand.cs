using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SwinAdventure;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        
        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            //if the first word is look the player will see the location.
            if (text.Length == 1)
            {
                return p.Location.FullDescription;
            }

            //The second word must be “at”, otherwise return “What do you want to look at?”
            if ((text.Length != 3 && text.Length != 5) || text[0] != "look")
            {
                return "I dont know how to look at that";
            }


            //The second word must be “at”, otherwise return “What do you want to look at?”
            if (text[0] != "look")
            {
                return "Error in look input";
            }
            //The second word must be “at”, otherwise return “What do you want to look at?”
            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            //if the string is 5 long look in bag. 
            if (text.Length == 3)
            {
                return LookAtIn(text[2], p);
            }

            else //(text.Length == 5)
            {
                //If there are 5 elements, then the 4th word must be “in”, 
                //otherwise return “What do you
                //want to look in?”
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }

                //The item id is the 3rd word

                IHaveInventory inv = FetchContiner(p, text[4]);
                if (inv == null)
                {
                    return "I can not find the " + text[4] + " to look in";
                }

                return LookAtIn(text[2], inv);

            }
            return "somthing went wrong";
        }
        //example of type casting / conversion. 
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

        private IHaveInventory FetchContiner(Player p, string containerId)
        {
            //container = obj as IHaveInventory;
            return p.Locate(containerId) as IHaveInventory;
        }
        
        private string LookAtIn(string thingID, IHaveInventory container)
        {

            GameObject obj = container.Locate(thingID) as GameObject;
            if (container.Locate(thingID) == null)
            {
                return "I can not find the " + thingID + "in the "  + container.Name;
            }
            else
            {
                return obj.FullDescription;
            }
        }
    }
}
