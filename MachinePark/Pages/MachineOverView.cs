using Blazor.FlexGrid.DataAdapters;
using MachinePark.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachinePark.Pages
{
    // Razor and C# partials code combines. Instead of writing in one file with @ for everything
    public partial class MachineOverView
    {
        public IEnumerable<Machine> Machines { get; set; }

        private void InitializeMachines()
        {
            Machines = new List<Machine>()
            {
                new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
                new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Just Here", "Not Going" }, Status = 0, Name = "New Shiny" }

            };
        }


        protected override Task OnInitializedAsync()
        {
            //InitializeMachines();
            var machines = new List<Machine>()
            {
                new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
                new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Just Here", "Not Going" }, Status = 0, Name = "New Shiny" }

            };
            return base.OnInitializedAsync();
        }

        //Flex Grid Serverside Nugget.
        //public CollectionTableDataAdapter<Machine> Machines { get; set; }

        //protected override Task OnInitializedAsync()
        //{

        //    var machines = new List<Machine>()
        //    {
        //        new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
        //        new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Just Here", "Not Going" }, Status = 0, Name = "New Shiny" }

        //    };
        //    Machines = new CollectionTableDataAdapter<Machine>(machines);
        //    return base.OnInitializedAsync();
        //}


    }
}
