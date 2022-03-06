using System;
using System.Collections.Generic;
using SwinAdventure;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public List<string> Identifiers
        {
            get {
                return _identifiers;
            }

            set {
                _identifiers = value;
            } 
        }

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public IdentifiableObject()
        { 
            
        }

        /// <summary>
        /// pass and store string into our private list. 
        /// </summary>
        /// <param name="input"></param>
        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            
            foreach (string s in idents)
            {
                _identifiers.Add(s.ToLower());
            }
        }

        /// <summary>
        /// Check if string is already in our list. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        /// <summary>
        /// return first id in _identifiers.
        /// </summary>
        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0) {

                    return "";
                
            }
            return _identifiers [0]; 
            }
                
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
