using System;
using System.Collections.Generic;

namespace SmsSender.Application.Depricated
{
    public class CommandFactory
    {
        public readonly IDictionary<string, Action> Commands;

        public CommandFactory(IDictionary<string, Action> commands)
        {
            this.Commands = commands;
        }

        public void RegisterCommand(string commandName, Action action)
        {
            Commands.Add(commandName, action);
        }
        public Action GetCommand(string commandName)
        {
            return Commands[commandName];
        }
        public void Execute(string commandName)
        {
            GetCommand(commandName)();
        }
    }
}
