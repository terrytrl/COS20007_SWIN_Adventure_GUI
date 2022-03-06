using System;
using System.Collections.Generic;
using System.Text;
using SwinAdventure;

namespace SwinAdventure
{
    public class Path : GameObject
    {
        private Locations _locations;

        public Path(string[] ids, string name, string desc, Locations Locations) : base(ids, name, desc)
        {
            _locations = Locations;
        }

        public void PlayerMove(Player p)
        {
            p.Location = _locations;
        }

        public override string FullDescription
        {
            get 
            { 
                return "You head " + FirstId + ". " + base.FullDescription + ". You arrive in a " + _locations.Name; 
            }
        }
    }
}
