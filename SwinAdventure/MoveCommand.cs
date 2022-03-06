using System;
using System.Collections.Generic;
using System.Text;

namespace SwinAdventure
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base (new string[] {"move"})
        {
           // "move", "go", "head", "leave"
        }

        public override string Execute(Player p, string[] text)
        {
            //Is the text valid in length?
            //TODO: null or text.length == 0 ?
            if (text.Length > 2 || text.Length == null)
            {
                return "Sorry, I don't know how to move like that.";
            }

            //Does the command start with move?
            if (text[0] != "move" )
            {
                return "Error in move Command";
            }

            Locations currentLocation = p.Location;
            
            Path followPath = currentLocation.GetPath(text[1]);

            //If no path exists then this is not a valid direction.
            if (followPath == null)
            {
                return "That is not a valid path";
            }
            else
            {
                //If the path exists move the player location. 
                followPath.PlayerMove(p);
                return followPath.FullDescription;
            }
        }
    }
}


