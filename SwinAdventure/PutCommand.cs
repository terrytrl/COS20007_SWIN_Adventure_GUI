using System;
using System.Collections.Generic;
using System.Text;
using SwinAdventure;

namespace SwinAdventure
{
    public class PutCommand : Command
    {

        IHaveInventory _inventory;
        Item _item;
        public PutCommand() : base(new string[] { "put", "drop"})
        {

        }

        public override string Execute(Player player, string[] text)
        {
            if (text.Length == 2)
            {
                
                _item = player.Inventory.Take(text[1]);

                if (_item != null)
                {
                    //TODO: player or Inventoryu? 
                    player.Inventory.PutItem(_item);

                    return "You have put the" + _item.Name + " in the " + _inventory.Name;

                }
                else { return "I can not find the " + text[1]; }

            }
            //TODO Put item in bag. 
            //put item in bag
            else if (text.Length == 4)
            {
                _item = player.Inventory.Take(text[1]);
                _inventory = FetchInvertory(player, text[3]);
                if (_item != null)
                {
                    player.Inventory.PutItem(_item);
                    return "You put the " + _item.Name + "in the " + _inventory.Name;

                }
                else {
                    return "I can not find the " + text[1];
                }
            }
            else
            {
                return "I do not know how to do that.";
            }
        }

        private IHaveInventory FetchInvertory(Player player, string fetchID)
        {
            return player.Inventory.Fetch(fetchID) as IHaveInventory;
        }
    }
}