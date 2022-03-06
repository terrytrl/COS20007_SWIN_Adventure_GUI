using System;
using System.Collections.Generic;
using System.Text;
using SwinAdventure;

namespace SwinAdventure
{
    public class TakeCommand : Command
    {
        Item _item;
        IHaveInventory _inventory;
        public TakeCommand() : base(new string[] { "take" })
        { }

        public override string Execute(Player player, string[] text)
        {
            if (text[0] != "take")
            {
                return "Sorry, I do not know how to do that";
            }

            //Take Item
            if (text.Length == 2)
            {
                _item = player.Location.Inventory.Take(text[1]);
                return "you picked up " + _item.Name + " from the " + player.Location.Name;
            }

            //TODO: Take Item from somewhere
            else if (text.Length == 4)
            {
                _inventory = FetchInvertory(player, text[3]);
                if (_item != null)
                {
                    player.Inventory.PutItem(_item);
                    return "You picked up the " + _item.Name;
                }
                else
                {
                    return "I can not find the " + text[1] + " in the " + text[3];
                }
            }
            else
            {
                return "Sorry, I do not know how to do that";
            }
        }

        private IHaveInventory FetchInvertory(Player player, string fetchID)
        {
            return player.Inventory.Fetch(fetchID) as IHaveInventory;
        }
    }
}
