using System;
using System.Collections.Generic;
using System.Text;
using SwinAdventure;

namespace SwinAdventure
{
    public class Locations : GameObject , IHaveInventory
    {

        //Can contain items.
        private Inventory _inventory;
        private List<Path> _paths;
        public List<Path> Paths { get { return _paths; } set { _paths = value; } }


        /// <summary>
        /// Will need to be identifiable and have a name, and description.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public Locations(string[] ids, string name, string description) : base(ids, name, description)
        {
            _inventory = new Inventory();
            _paths = new List<Path>();
        }

        public GameObject Locate(string ids)
        {
            if (AreYou(ids))
            {
                return this;
            }
            else {
                return _inventory.Fetch(ids);
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }
        public override string FullDescription
        {
            get { return base.FullDescription + " in the room you can see: " + _inventory.ItemList; }
        }

        //TODO: DO we need this? 

        public Path GetPath(string ids)
        {
            foreach (Path p in _paths)
            {
                if (p.AreYou(ids))
                {
                    return p;
                }
            }
            return null;
        }
    }
}
 