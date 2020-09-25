using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "How to Migrate Django DB", Line = "python manage.py migrate", Platform = "Linux" },
                new Command { Id = 1, HowTo = "Get Status Code of Website", Line = "Invoke-RestMethod: https://website.com", Platform = "Windows" },
                new Command { Id = 2, HowTo = "Create new Directory", Line = "mkdir {dirName}", Platform = "Unix" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "How to Migrate Django DB", Line = "python manage.py migrate", Platform = "Linux" };
        }
    }
}
