using System;
using System.Collections.Generic;
using System.Text;
using SwinAdventure;


namespace SwinAdventure
{
    public class PlayerCommand
    {

        private List<Command> _commands;

        public PlayerCommand()
        {
            _commands = new List<Command>();
            _commands.Add(new LookCommand());
        }

        public string Run(Player p, string[] text)
        {
            foreach (Command c in _commands)
            {
                if (c.AreYou(text[0]))
                {
                    return c.Execute(p, text);    
                }
            }
            return "I do not understand";
        }




    }
}
