﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SwinAdventure
{
    public class CommandProcessor
    {
        private List<Command> _commands;

        public CommandProcessor()
        {
            _commands = new List<Command>();
            _commands.Add(new LookCommand());
            _commands.Add(new MoveCommand());
            _commands.Add(new PutCommand());
            _commands.Add(new TakeCommand());
        }

        public string Execute(Player player, string[] text)
        {
            foreach (Command c in _commands)
            {
                if (c.AreYou(text[0]))
                {
                    return c.Execute(player, text);
                }
            }
            return "This is not a valid command.";
        }
    }
}
