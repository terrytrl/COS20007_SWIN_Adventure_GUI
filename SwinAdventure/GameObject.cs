using System;
using System.Collections.Generic;
using SwinAdventure;



namespace SwinAdventure
{
    public class GameObject : IdentifiableObject
    {
        private string _description;
        private readonly string _name;

        public GameObject(string[] Id, string Name, string Desc) : base (Id)
        {
            _name = Name;
            _description = Desc;
        }

        public string Name
        {
            get
            { return _name; }
        }

        public string ShortDescription
        {
            get { return _name + " "  + "(" + FirstId + ")"; }
        }

        public virtual string FullDescription
        {
            get { return _description; }
        }

        public void newGameObject(string[] ids, string name, string desc)
        {

        }
    }

}
