using System;
using System.Collections.Generic;
using SwinAdventure;

namespace SwinAdventure
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;

        public Bag(String[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(String ids)
        {
            if (AreYou(ids))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(ids);
            }
        }

        public override string FullDescription
        {
            get{ return "in the " + FirstId + " you can see " + ShortDescription + "."; }
        }

        public Inventory Inventory
        {
            get { return _inventory; } 
        }
    }
}
