using MachinePark.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachinePark.Pages
{
    public partial class MachineDetails
    {
        [Parameter]
        public Guid MachineId { get; set; }

        public Machine Machine { get; set; } = new Machine();

        public IEnumerable<Machine> Machines { get; set; }

        private void InitializeMachines()
        {
            Machines = new List<Machine>()
            {
                new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
                new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Just Here", "Not Going" }, Status = 0, Name = "New Shiny" }

            };
        }


        protected override Task OnInitializedAsync()
        {
            InitializeMachines();
            Machine = Machines.FirstOrDefault(m => m.MachineId == MachineId);
            return base.OnInitializedAsync();
        }
    }
}
