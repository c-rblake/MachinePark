using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinePark.Shared
{
    public class State
    {
        public List<Machine> Machines { get; set; } = new List<Machine>()

            {
                new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
                new Machine { MachineId = Guid.NewGuid(), Log = new List<string>() { "Up", "Trecking" }, Status = Shared.Status.Online, Name = "New Sparky" },
                new Machine { MachineId = Guid.NewGuid(), Log = new List<string>() { "Crash", "Not Going" }, Status = Shared.Status.Offline, Name = "Old Shiny" },
                new Machine { MachineId = Guid.NewGuid(), Log = new List<string>() { "Crash", "Not Going" }, Status = Shared.Status.Offline, Name = "New Shiny" },

            };

    }
}

