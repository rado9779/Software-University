using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandPostfix = "Command";

        public string Read(string args)
        {
            string[] tokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string commandName = tokens[0] + CommandPostfix;

            string[] elements = tokens.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();

            Type[] types = assembly.GetTypes();
            Type type = types.FirstOrDefault(t => t.Name == commandName);
            Object instance = Activator.CreateInstance(type);

            ICommand command = (ICommand)instance;
            return command.Execute(elements);

        }
    }
}
