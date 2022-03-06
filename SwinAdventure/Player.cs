using System;
using System.Collections.Generic;
using SwinAdventure;

namespace SwinAdventure
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        private Locations _location;

        public Locations Location { get { return _location; } set { _location = value; } }
        public Inventory Inventory { get { return _inventory; } set { _inventory = value; } }

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            Location = new Locations(new string[] { "location" }, "location", "Somewhere");
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }

        public override string FullDescription
        {
            get
            {
                return "You are " + Name + ", " + ShortDescription + "\nYou are carrying\n" + _inventory.ItemList;
            }
        }

        public string MoveLocation(string id)
        {
            if (Location.Paths != null)
            {
                foreach (Path p in _location.Paths)
                {
                    if (p.AreYou(id))
                    {
                        p.PlayerMove(this);
                        return "You have moved to " + this.Location.FirstId;
                    }
                }
            }
            return "I can not move there";
        }
    }
}
